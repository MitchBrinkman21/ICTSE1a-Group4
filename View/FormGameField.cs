using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGame.Controller;
using WarGame.Model;

namespace WarGame.View
{
    public partial class FormGameField : Form
    {
        GameEngine gameEngine;
        public Boolean gameOver;
        Graphics Visual;
        Stopwatch stopWatch = new Stopwatch();
        int x = 20, y = 20;
        public FormGameField()
            
        {
            InitializeComponent();
            Color color = System.Drawing.ColorTranslator.FromHtml("#66000000");
            panel1.BackColor = color;
            gameEngine = GameEngine.Instance();
            stopWatch.Start();
            timer1.Start();

            
            if (gameEngine.level.obstacleList != null)
            {
                foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                {
                    switch (obstacle.ToString())
                    {
                        case "WarGame.Model.Tree":
                            //Bitmap Tree = new Bitmap(obstacle.image);
                            //add.rectangleList();
                            break;
                        case "WarGame.Model.Mine":
                            MessageBox.Show("Mine");
                            break;
                        case "WarGame.Model.Missile":
                            MessageBox.Show("Missile");
                            break;
                        case "WarGame.Model.Mud":
                            MessageBox.Show("Mud");
                            break;
                        case "WarGame.Model.Finish":
                            MessageBox.Show("Finish");
                            break;
                        case "WarGame.Model.Sandbag":
                            MessageBox.Show("Sandbag");
                            break;
                    }
                }
            }
        }


        private void start_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            stopWatch = Stopwatch.StartNew();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = stopWatch.Elapsed.Minutes.ToString() + ":" + stopWatch.Elapsed.Seconds.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }

    }
}
