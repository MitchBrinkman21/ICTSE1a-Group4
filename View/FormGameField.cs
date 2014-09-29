using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGame.Controller;
using WarGame.Model;
using WarGame.Properties;

namespace WarGame.View
{
    public partial class FormGameField : Form
    {
        GameEngine gameEngine;
        public Boolean gameOver;
        Graphics Visual;
        Stopwatch stopWatch = new Stopwatch();
        Player player = new Player();
       
        public FormGameField()
            
        {
            InitializeComponent();
            Color color = System.Drawing.ColorTranslator.FromHtml("#66000000");
            panel1.BackColor = color;
            gameEngine = GameEngine.Instance();
            stopWatch.Start();
            

            
            if (gameEngine.level.obstacleList != null)
            {
                foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                {
                    //switch (obstacle.ToString())
                    //{
                    //    case "WarGame.Model.Tree":
                    //        //Bitmap Tree = new Bitmap(obstacle.image);
                    //        //add.rectangleList();
                    //        break;
                    //    case "WarGame.Model.Mine":
                    //        MessageBox.Show("Mine");
                    //        break;
                    //    case "WarGame.Model.Missile":
                    //        MessageBox.Show("Missile");
                    //        break;
                    //    case "WarGame.Model.Mud":
                    //        MessageBox.Show("Mud");
                    //        break;
                    //    case "WarGame.Model.Finish":
                    //        MessageBox.Show("Finish");
                    //        break;
                    //    case "WarGame.Model.Sandbag":
                    //        MessageBox.Show("Sandbag");
                    //        break;
                    //}
                }
            }
        }


        private void start_Click(object sender, EventArgs e)
        {
                Bitmap pauseImage = new Bitmap(WarGame.Properties.Resources.pause1);
                Bitmap playImage = new Bitmap(WarGame.Properties.Resources.start1);
          
            
            if (pauzeButton.Tag == "pauze" )
            {
                pauzeButton.Image = playImage;
                pauzeButton.Tag = "play";
                stopWatch.Stop();
                
            }
            else if (pauzeButton.Tag == "play")
            {
                pauzeButton.Image = pauseImage;
                pauzeButton.Tag = "pauze";
                stopWatch.Start();
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            Bitmap playImage = new Bitmap(WarGame.Properties.Resources.start1);
            stopWatch.Stop();
            pauzeButton.Image = playImage;
            DialogResult result = MessageBox.Show("Are you sure you want to stop the game?", "WarGame", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        this.Close();
                        break;
                    }
                case DialogResult.No:
                    {  
                        break;       
                    }
            }
            Bitmap pauseImage = new Bitmap(WarGame.Properties.Resources.pause1);
            pauzeButton.Image = pauseImage;
            pauzeButton.Tag = "pauze";
            stopWatch.Start();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            stopWatch = Stopwatch.StartNew();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = stopWatch.Elapsed.Minutes.ToString() + ":" + stopWatch.Elapsed.Seconds.ToString();
        }

        public void draw_healthkits()
        {
            Bitmap healthKit_on = new Bitmap(WarGame.Properties.Resources.first_aid_kit);
            Bitmap healthKit_off = new Bitmap(WarGame.Properties.Resources.first_aid_kit_blacked_out);
            if (player.lives == 3)
            {
                pictureBox1.Image = healthKit_on;
                pictureBox2.Image = healthKit_on;
                pictureBox3.Image = healthKit_on;
            }
            else if (player.lives == 2)
            {
                pictureBox1.Image = healthKit_on;
                pictureBox2.Image = healthKit_on;
                pictureBox3.Image = healthKit_off;
            }
            else if (player.lives == 1)
            {
                pictureBox1.Image = healthKit_on;
                pictureBox2.Image = healthKit_off;
                pictureBox3.Image = healthKit_off;
            }
            if (player.lives == 0)
            {
                pictureBox1.Image = healthKit_off;
                pictureBox2.Image = healthKit_off;
                pictureBox3.Image = healthKit_off;
            }
        }
    }
}
