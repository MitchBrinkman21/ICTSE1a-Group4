using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WarGame.Model;
using WarGame.View;


namespace WarGame.Controller
{
    public class GameEngine
    {
        public delegate void FormMainEvents();
        public FormMainEvents formMainEvents;

        private static GameEngine gameEngine;
        public Level level = new Level();

        public Missile missile;
        public Missile missile2;

        private int missileCounter = 0;

        private double gameTime; // The time you spend in the game
        private String namePlayer;

        public bool LevelImported = false;
        FormGameField formGameField;
        FormDevMode formDevMode;

        private bool up, down, left, right, mud;
        public float angle { get; set; }

        public bool DevMode;

        Obstacle tempObstacle = null;
        int settime = -1;
        int settime2 = -1;
      

       

        public static GameEngine Instance()
        {
            if (gameEngine == null)
                gameEngine = new GameEngine();
           
            return gameEngine;
        }

        public GameEngine()
        {
            formMainEvents += StartGame;
            formMainEvents += ImportLevel;
            SoundPlayer sound = new SoundPlayer(WarGame.Properties.Resources.Music);
            sound.PlayLooping();
            up = false;
            down = false;
            left = false;
            right = false;
            mud = false;
            angle = 90;

        }

        public void StartGame()
        {

            formGameField = new FormGameField();
            formGameField.Show();

            if (DevMode)
            {
                formDevMode = new FormDevMode();
                formDevMode.Show();
            }

            FormGameField.gameState = true;
        }

        public void ImportLevel()
        {
            XmlDocument doc = null;

            FormImportLevel formImportLevel = new FormImportLevel();
            if (formImportLevel.ShowDialog() == DialogResult.OK)
            {
                doc = formImportLevel.doc;
            }

            if(doc != null)
            {
                ProgressBarDialog progressBarDialog = new ProgressBarDialog();
                XmlParser xmlParser = new XmlParser();
                xmlParser.ParseMap(doc, ref progressBarDialog);
            }
            
            formImportLevel.Dispose();

        }

        public void OpenHelp()
        {
            FormHelp h = new FormHelp();
            h.Show();
        }
        public void OpenHighscores()
        {
            FormHighScores hs = new FormHighScores();
            hs.ShowDialog();
        }

        public void GameLoopThreadFunction()
        {
            try
            {
                if(FormGameField.gameState == true)
                {
                    HitDetect();

                    move();

                    LaunchMissile();
                    if (missile != null)
                    {
                        missile.FindPlayer((int)level.player.x, (int)level.player.y);
                    }
                    HitDetect();
   
                    formGameField.Invalidate();          
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in execute thread.");
            }

        }
        
        public void HitDetect()
        {
            Player player = level.player;
            Rectangle playerRect = player.rect;
            int playerX = (int)player.x;
            int playerY = (int)player.y;
            bool checkmud = false;
            

            foreach(Obstacle obstacle in gameEngine.level.obstacleList)
            {
                if(missile != null) {
                    if (!missile.exploded)
                    {
                        if (missile.rect.IntersectsWith(obstacle.rect))
                        {
                            switch (obstacle.ToString())
                            {
                                case "WarGame.Model.Mine":
                                    Console.WriteLine("Missile flies over mine...");
                                    break;
                                case "WarGame.Model.Finish":
                                    Console.WriteLine("Missile flies over finish...");
                                    break;
                                case "WarGame.Model.Mud":
                                    Console.WriteLine("Missile flies over mud ...");
                                    break;
                                default:
                                    Console.WriteLine("missile hit object");
                                    //playerRect.Location = new Point((int)player.x, (int)player.y); // Location after hit...
                                    missile.ShowExplosion();
                                    settime2 = (int)formGameField.stopWatch.Elapsed.TotalSeconds + 1;
                                    missile.exploded = true;


                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (settime2 == (int)formGameField.stopWatch.Elapsed.TotalSeconds)
                           
                            missile = null;
                    }
                }
                
                if (obstacle.rect.IntersectsWith(playerRect))
                {
                    switch (obstacle.ToString())
                    {
                        case "WarGame.Model.Tree":
                            Console.WriteLine("Player hit tree...");                        
                            break;
                        case "WarGame.Model.Sandbag":
                            Console.WriteLine("Player hit sandbag...");
                            break;
                        case "WarGame.Model.Finish":
                            Console.WriteLine("Player at finish...");
                            EndGame();
                            break;
                        case "WarGame.Model.Missile":
                            Console.WriteLine("Player hit missile");
                            playerRect.Location = new Point((int)player.x, (int)player.y); // Location after hit...
                            missile.ShowExplosion();
                            missileCounter--;

                            if (player.lives == 0)
                                GameOver();
                            else
                            {
                                player.DecreaseLive();
                                formGameField.DrawHealthKits();
                            }
                                
                            break;
                        case "WarGame.Model.Mine":
                            Console.WriteLine("Player hit mine");
                            

                            Mine mine = obstacle as Mine;
                            tempObstacle = mine;
                            mine.ShowExplosion();
                            settime = (int) formGameField.stopWatch.Elapsed.TotalSeconds+1;
                            mine.rect = new Rectangle(-10, -10, 1, 1);

                            player.DecreaseLive();
                            formGameField.DrawHealthKits();

                            if (player.lives == 0)
                            {
                                GameOver();
                            }
                            //player.MovePlayer((int)player.x - 20, (int)player.y - 20, player.speed);
                             
                            break;     
                        case "WarGame.Model.Mud":
                            Console.WriteLine("Player walks in mud");
                            checkmud = true;
                            break;

                        default:
                            break;
                    }
                }
            }
            if (tempObstacle != null && settime == (int)formGameField.stopWatch.Elapsed.TotalSeconds)
            {
                level.obstacleList.Remove(tempObstacle);
                tempObstacle = null;
            }
            mud = checkmud;
        }

        public void GameOver()
        {
            FormGameField.gameState = false;
            FormGameOver formGameOver = new FormGameOver();
            if (formGameOver.ShowDialog() == DialogResult.Abort)
            {
                formGameField.Close();
            }
        }
        public void LaunchMissile()
        {
                if (missile == null)
                {
                    missile = new Missile(683, 384); // Launch from the center of the map...
                }
        }

        public void EndGame()
        {
            FormGameField.gameState = false;
            formGameField.stopWatch.Stop();
            gameTime = formGameField.stopWatch.Elapsed.TotalMilliseconds;
            FormEndGame formEndGame = new FormEndGame(gameTime);
            if (formEndGame.ShowDialog() == DialogResult.OK)
            {
                namePlayer = formEndGame.namePlayer;
                if (namePlayer.Equals(""))
                {
                    namePlayer = "Anonymous";
                }

                XmlBuilder xml = new XmlBuilder();
                string filename = @"c:\WarGame\stats\Statistics.xml";
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(filename);
                    xml.ChangeFile(namePlayer, gameTime);
                }
                catch (FileNotFoundException)
                {
                    xml.CreateFile(namePlayer, gameTime);
                }
                finally 
                {
                    formGameField.Close();
                }
            }
            // ToDo: Create class XmlBuilder. Build a xml file and store on disk.
        }

        public void PressKey(KeyEventArgs kea)
        {
            switch (kea.KeyData)
            {
                case Keys.Up:
                    up = true;
                    break;
                case Keys.Down:
                    down = true;
                    break;
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Right:
                    right = true;
                    break;

            }
        }

        public void ReleaseKey(KeyEventArgs kea)
        {
            switch (kea.KeyData)
            {
                case Keys.Up:
                    up = false;
                    break;
                case Keys.Down:
                    down = false;
                    break;
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Right:
                    right = false;
                    break;
            }
        }

        public void move()
        {
            double x = gameEngine.level.player.x;
            double y = gameEngine.level.player.y;
            int speed = gameEngine.level.player.speed;
            int formwidth = formGameField.Width;
            int formheight = formGameField.Height;
            int width = gameEngine.level.player.width;
            int height = gameEngine.level.player.height;
            if (up || down || left || right)
            {
                if (up)
                {
                    if (left ^ right)
                    {
                        y -= speed * (1 / Math.Sqrt(2));
                    }
                    else
                    {
                        y -= speed;
                    }
                }
                if (down)
                {

                    if (left ^ right)
                    {
                        y += speed * (1 / Math.Sqrt(2));
                    }
                    else
                    {
                        y += speed;
                    }
                }
                if (left)
                {
                    if (up ^ down)
                    {
                        x -= speed * (1 / Math.Sqrt(2));
                    }
                    else
                    {
                        x -= speed;
                    }
                }
                if (right)
                {
                    if (up ^ down)
                    {
                        x += speed * (1 / Math.Sqrt(2));
                    }
                    else
                    {
                        x += speed;
                    }
                }
                if (x + width > formwidth)
                {
                    x = formwidth - width;
                }
                if (x < 0)
                {
                    x = 0;
                }
                if (y > formheight - height)
                {
                    y = formheight - height;
                }
                if (y < 0)
                {
                    y = 0;
                }

                int xsteps = 0;
                bool xintersect = false;
                while (xsteps < speed && !xintersect) {
                    gameEngine.level.player.rect.Location = new Point((int)(gameEngine.level.player.x + ((x - gameEngine.level.player.x) / speed * (xsteps + 1))), (int)gameEngine.level.player.y);
                    foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                    {
                        if (obstacle.rect.IntersectsWith(gameEngine.level.player.rect))
                        {
                            switch (obstacle.ToString())
                            {
                                case "WarGame.Model.Tree":
                                    xintersect = true;
                                    break;
                                case "WarGame.Model.Sandbag":
                                    xintersect = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    if (!xintersect) { 
                        xsteps++;
                    }
                }

                int ysteps = 0;
                bool yintersect = false;
                while (ysteps < speed && !yintersect)
                {
                    gameEngine.level.player.rect.Location = new Point((int)(gameEngine.level.player.x), (int)(gameEngine.level.player.y + ((y - gameEngine.level.player.y) / speed * (ysteps + 1))));
                    foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                    {
                        if (obstacle.rect.IntersectsWith(gameEngine.level.player.rect))
                        {
                            switch (obstacle.ToString())
                            {
                                case "WarGame.Model.Tree":
                                    yintersect = true;
                                    break;
                                case "WarGame.Model.Sandbag":
                                    yintersect = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    if (!yintersect)
                    {
                        ysteps++;
                    }
                }

                x -= (x - gameEngine.level.player.x) / speed * (speed - xsteps);
                y -= (y - gameEngine.level.player.y) / speed * (speed - ysteps);

                gameEngine.level.player.MovePlayer(x, y, mud);
                DetermineAngle();

            }
        }

        public void DetermineAngle()
        {
            if (up)
            {
                angle = 360;
            }
            if (down)
            {
                angle = 180;
            }
            if (left)
            {
                angle = 270;
            }
            if (right)
            {
                angle = 90;
            }
            if (up && left)
            {
                angle = 315;
                if (right)
                {
                    angle = 360;
                }
                if (down)
                {
                    angle = 270;
                }
            }
            if (up && right)
            {
                angle = 45;
                if (left)
                {
                    angle = 360;
                }
                if (down)
                {
                    angle = 90;
                }
            }
            if (down && left)
            {
                angle = 225;
                if (up)
                {
                    angle = 270;
                }
                if (right)
                {
                    angle = 180;
                }
            }
            if (down && right)
            {
                angle = 135;
                if (up)
                {
                    angle = 90;
                }
                if (left)
                {
                    angle = 180;
                }
            }
            
        }
    }
}
