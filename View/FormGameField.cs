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
        Pen p = new Pen(System.Drawing.Color.Red, 3);
       
        public FormGameField()
            
        {
            InitializeComponent();
            Color color = System.Drawing.ColorTranslator.FromHtml("#66000000");
            panelMenu.BackColor = color;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = new Size(1366, 768);
            this.MinimumSize = new Size(1366, 768);
            gameEngine = GameEngine.Instance();
            stopWatch.Start();
        }


        private void buttonStartPause_Click(object sender, EventArgs e)
        {
                Bitmap imagePause = new Bitmap(WarGame.Properties.Resources.pause1);
                Bitmap imagePlay = new Bitmap(WarGame.Properties.Resources.start1);
            if (buttonStartPause.Tag == "pause" )
            {
                buttonStartPause.Image = imagePlay;
                buttonStartPause.Tag = "play";
                stopWatch.Stop();
                
            }
            else if (buttonStartPause.Tag == "play")
            {
                buttonStartPause.Image = imagePause;
                buttonStartPause.Tag = "pause";
                stopWatch.Start();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        } 
        private void buttonStop_Click(object sender, EventArgs e)
        {
            Bitmap imagePlay = new Bitmap(WarGame.Properties.Resources.start1);
            stopWatch.Stop();
            buttonStartPause.Image = imagePlay;
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
            Bitmap imagePause = new Bitmap(WarGame.Properties.Resources.pause1);
            buttonStartPause.Image = imagePause;
            buttonStartPause.Tag = "pause";
            stopWatch.Start();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            stopWatch = Stopwatch.StartNew();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = stopWatch.Elapsed.Minutes.ToString() + ":" + stopWatch.Elapsed.Seconds.ToString();
        }

        public void DrawHealthKits()
        {
            Bitmap imageHealthKitON = new Bitmap(WarGame.Properties.Resources.first_aid_kit);
            Bitmap imageHealthKitOFF = new Bitmap(WarGame.Properties.Resources.first_aid_kit_blacked_out);
          
            if (gameEngine.level.player.lives == 2)
            {
                imageHealthKit3.Image = imageHealthKitOFF;
            }
            else if (gameEngine.level.player.lives == 1)
            {
     
                imageHealthKit2.Image = imageHealthKitOFF;
                imageHealthKit3.Image = imageHealthKitOFF;
            }
            else if (gameEngine.level.player.lives == 0)
            {
                imageHealthKit1.Image = imageHealthKitOFF;
                imageHealthKit2.Image = imageHealthKitOFF;
                imageHealthKit3.Image = imageHealthKitOFF;
            }
        }

        private void FormGameField_Paint(object sender, PaintEventArgs e)
        {
            if (gameEngine.level.obstacleList != null)
            {
                foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                {
                    e.Graphics.DrawImage(obstacle.image, obstacle.x, obstacle.y);
                    e.Graphics.DrawRectangle(Pens.Transparent, obstacle.rect);
                }
            }
            e.Graphics.DrawRectangle(p, gameEngine.level.player.rect);
        }

        private void FormGameField_KeyDown(object sender, KeyEventArgs e)
        {
            gameEngine.PressKey(e);
        }

        private void FormGameField_KeyUp(object sender, KeyEventArgs e)
        {
            gameEngine.ReleaseKey(e);
        }
    }
}
