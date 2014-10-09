using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        public Stopwatch stopWatch = new Stopwatch();
        Pen p = new Pen(System.Drawing.Color.Blue, 1);
        public static Boolean gameState;
       
        public FormGameField()
            
        {
            InitializeComponent();
            Color color = System.Drawing.ColorTranslator.FromHtml("#66000000");
            panelMenu.BackColor = color;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(1366, 768);
            this.MinimumSize = new Size(1366, 768);
            buttonStop.Location = new Point(1268, 0);
            buttonStartPause.Location = new Point(1229, 0);
            buttonReset.Location = new Point(1307, 0);
            label1.Location = new Point(672, 4);
            this.StartPosition = FormStartPosition.CenterScreen;
            gameEngine = GameEngine.Instance();
            stopWatch.Start();
        }


        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            Bitmap imagePause = new Bitmap(WarGame.Properties.Resources.pause1);
            Bitmap imagePlay = new Bitmap(WarGame.Properties.Resources.start1);
            if (buttonStartPause.Tag.ToString().Equals("pause") )
            {
                buttonStartPause.Image = imagePlay;
                buttonStartPause.Tag = "play";
                stopWatch.Stop();
                gameState = false;
                
            }
            else if (buttonStartPause.Tag == "play")
            {
                buttonStartPause.Image = imagePause;
                buttonStartPause.Tag = "pause";
                stopWatch.Start();
                gameState = true;
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
            gameState = false;
            buttonStartPause.Image = imagePlay;
            DialogResult result = MessageBox.Show("Are you sure you want to stop the game?", "WarGame", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        gameEngine.ResetGame(false);
                        this.Close();
                        break;
                    }
                case DialogResult.No:
                    {
                        gameState = true;
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
            gameEngine.ResetGame(true);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = stopWatch.Elapsed.Minutes.ToString() + ":" + stopWatch.Elapsed.Seconds.ToString("D2");
        }

        public void DrawHealthKits()
        {
            Bitmap imageHealthKitON = new Bitmap(WarGame.Properties.Resources.first_aid_kit);
            Bitmap imageHealthKitOFF = new Bitmap(WarGame.Properties.Resources.first_aid_kit_blacked_out);
            if (gameEngine.level.player.lives == 3)
            {
                imageHealthKit1.Image = imageHealthKitON;
                imageHealthKit2.Image = imageHealthKitON;
                imageHealthKit3.Image = imageHealthKitON;
            }
            else if (gameEngine.level.player.lives == 2)
            {
                imageHealthKit1.Image = imageHealthKitON;
                imageHealthKit2.Image = imageHealthKitON;
                imageHealthKit3.Image = imageHealthKitOFF;
            }
            else if (gameEngine.level.player.lives == 1)
            {
                imageHealthKit1.Image = imageHealthKitON;
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
                List<Mine> mines = new List<Mine>();
                List<Tree> trees = new List<Tree>();
                List<Sandbag> sandbags = new List<Sandbag>();
                List<Mud> muds = new List<Mud>();
                List<Missilelauncher> missilelaunchers = new List<Missilelauncher>();
                Finish finish = new Finish(0, 0);
                foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                {
                    switch (obstacle.ToString())
                    {
                        case "WarGame.Model.Mine":
                            mines.Add(obstacle as Mine);
                            break;
                        case "WarGame.Model.Tree":
                            trees.Add(obstacle as Tree);
                            break;
                        case "WarGame.Model.Sandbag":
                            sandbags.Add(obstacle as Sandbag);
                            break;
                        case "WarGame.Model.Mud":
                            muds.Add(obstacle as Mud);
                            break;
                        case "WarGame.Model.MissileLauncher":
                            missilelaunchers.Add(obstacle as Missilelauncher);
                            break;
                        case "WarGame.Model.Finish":
                            finish = obstacle as Finish;
                            break;
                    }
                }

                foreach (Mud mud in muds)
                {
                    e.Graphics.DrawImage(mud.image, mud.x, mud.y);
                }
                foreach (Sandbag sandbag in sandbags)
                {
                    e.Graphics.DrawImage(sandbag.image, sandbag.x, sandbag.y);
                }
                foreach (Tree tree in trees)
                {
                    e.Graphics.DrawImage(tree.image, tree.x, tree.y);
                }
                foreach (Missilelauncher missilelauncher in missilelaunchers)
                {
                    e.Graphics.DrawImage(missilelauncher.image, missilelauncher.x, missilelauncher.y);
                }
                foreach (Mine mine in mines)
                {
                    if (mine.visible == true)
                    {
                        e.Graphics.DrawImage(mine.image, mine.x, mine.y);
                        //e.Graphics.DrawRectangle(Pens.Red, obstacle.rect);
                    }
                }
                e.Graphics.DrawImage(finish.image, finish.x, finish.y);
                
            }
            
            //e.Graphics.DrawRectangle(p, gameEngine.level.player.rect);            
            e.Graphics.DrawImage(Rotate(gameEngine.level.player.image, gameEngine.angle), (int)gameEngine.level.player.x, (int)gameEngine.level.player.y);
            

            
            if (gameEngine.missile != null)
            {
                //e.Graphics.DrawRectangle(p, gameEngine.missile.rect);
                e.Graphics.DrawImage(gameEngine.missile.image, gameEngine.missile.x, gameEngine.missile.y);
            }


        }

        public static Bitmap Rotate(Bitmap img, float angle)
        {
            Bitmap rotated = new Bitmap(img.Width, img.Height);            
            Graphics gfx = Graphics.FromImage(rotated);
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            gfx.RotateTransform(angle);
            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            gfx.DrawImage(img, new Point(0, 0));
            return rotated;
        }

        private void FormGameField_KeyDown(object sender, KeyEventArgs e)
        {
            gameEngine.PressKey(e);
            if (e.KeyCode ==  Keys.R)
            {
                gameEngine.ResetGame(true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                gameState = false;
                gameEngine.ResetGame(false);
            }
            if (e.KeyCode == Keys.P)
            {
                if (gameState == false)
                {
                    Bitmap imagePause = new Bitmap(WarGame.Properties.Resources.pause1);
                    stopWatch.Start();

                    buttonStartPause.Image = imagePause;
                    gameState = true;
                }
                else if (gameState == true)
                {
                    Bitmap imagePlay = new Bitmap(WarGame.Properties.Resources.start1);
                    stopWatch.Stop();

                    buttonStartPause.Image = imagePlay;
                    gameState = false;
                }
            }
            
            if (gameState == false) { 
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    Bitmap imagePause = new Bitmap(WarGame.Properties.Resources.pause1);
                    buttonStartPause.Image = imagePause;
                    gameState = true;
                }
            }
        }

        private void FormGameField_KeyUp(object sender, KeyEventArgs e)
        {
            gameEngine.ReleaseKey(e);
        }
    }
}
