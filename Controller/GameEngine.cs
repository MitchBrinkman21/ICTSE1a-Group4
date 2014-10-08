using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        bool isLaunched = false;
        Stopwatch stopwatch = new Stopwatch();

        public delegate void FormMainEvents();
        public FormMainEvents formMainEvents;

        private static GameEngine gameEngine;
        public Level level;

        public Missile missile;
        public Missile missile2;

        private double gameTime; // The time you spend in the game
        private String namePlayer;

        public bool LevelImported = false;
        FormGameField formGameField;
        FormDevMode formDevMode;

        private bool up, down, left, right, mud;
        public float angle { get; set; }

        public bool DevMode;

        public static string levelName;      

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
            up = false;
            down = false;
            left = false;
            right = false;
            mud = false;
            angle = 90;

            level = new Level();
            level.player = new Player();
            
        }


        public void StartGame()
        {
            if (level.player == null)
            {
                level.player = new Player();
            }
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
                    move();
                    if (isLaunched == false)
                    {
                        LaunchMissile();
                    }
                    if (missile == null)
                    {
                        isLaunched = false;
                    }

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
            Obstacle tempObstacle = null;

            if (player.lives == 0)
            {
                LevelImported = false;
                GameOver();
                
            }
            else
            {
                foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                {
                    if (missile != null)
                    {
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
                                        missile.exploded = true;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if ((int)missile.explosiontimer.Elapsed.Seconds > 1)
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
                            case "WarGame.Model.Mine":
                                Console.WriteLine("Player hit mine");
                                Mine mine = obstacle as Mine;
                                mine.ShowExplosion();
                                mine.rect = new Rectangle(-10, -10, 1, 1);
                                player.DecreaseLive();
                                formGameField.DrawHealthKits();
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

                    if (obstacle.ToString().Equals("WarGame.Model.Mine"))
                    {
                        Mine mine = obstacle as Mine;
                        if (Math.Sqrt(Math.Pow(Math.Abs(mine.x - (player.x + (player.width / 2))), 2) + Math.Pow(Math.Abs(mine.y - (player.y + (player.width / 2))), 2)) < mine.proximity * mine.width)
                        {
                            mine.visible = true;
                        }
                        if ((int)mine.explosiontimer.Elapsed.Seconds > 1)
                        {
                            tempObstacle = mine;
                        }
                    }
                }
                if (missile != null)
                {
                    if (missile.rect.IntersectsWith(player.rect))
                    {
                        missile.ShowExplosion();
                        missile.exploded = true;
                        missile.rect = new Rectangle(-10, -10, 1, 1);
                        player.DecreaseLive();
                        formGameField.DrawHealthKits();
                    }
                }
                if (tempObstacle != null)
                {
                    level.obstacleList.Remove(tempObstacle);
                    tempObstacle = null;
                }
                mud = checkmud;
            }
        }

        public void GameOver()
        {
            FormGameField.gameState = false;
            FormGameOver formGameOver = new FormGameOver();
            if (formGameOver.ShowDialog() == DialogResult.Abort)
            {
                formGameField.Close();
            }

            LevelImported = false;
            gameEngine.level.player = null;
            gameEngine.level.obstacleList = null;
            missile = null;
        }
        public void LaunchMissile()
        {   
            if (missile == null)
            {
                if (stopwatch.IsRunning == false)
                {
                    stopwatch.Start();
                }
                if (stopwatch.ElapsedMilliseconds >= 3000) //3 sec
                {
                    missile = new Missile(level.missilelauncher.x, level.missilelauncher.y); // Launch from the center of the map...
                    stopwatch.Restart();
                    isLaunched = true;
                }
            }
        }

        public void EndGame()
        {
            // Stop GameLoopThreadFunction and stopWatch
            FormGameField.gameState = false;
            formGameField.stopWatch.Stop();

            // Put stopWatch time into int variable gameTime
            gameTime = formGameField.stopWatch.Elapsed.TotalMilliseconds;

            // Open FormEndGame and check result this form
            FormEndGame formEndGame = new FormEndGame(gameTime);
            if (formEndGame.ShowDialog() == DialogResult.OK)
            {
                // Initialize namePlayer with result of FormEndGame
                namePlayer = formEndGame.namePlayer;
                if (namePlayer.Equals(""))
                {
                    namePlayer = "Anonymous";
                }

                // Create XmlBuilder and put name of file in a string variable
                XmlBuilder xml = new XmlBuilder();
                string filename = @"c:\WarGame\stats\Statistics.xml";
                
                // If file already exists, change that file with the new Highscore
                if(File.Exists(filename))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filename);
                    xml.ChangeFile(namePlayer, gameTime);
                }
                else
                {
                    xml.CreateFile(namePlayer, gameTime);
                }
                    formGameField.Close();
            }
            LevelImported = false;
            gameEngine.level.player = null;
            gameEngine.level.obstacleList = null;
            missile = null;
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
                int ysteps = 0;
                bool yintersect = false;
                while ((xsteps < speed && !xintersect) || (ysteps < speed && !yintersect))
                {
                    if (xsteps < speed && !xintersect)
                    {
                        gameEngine.level.player.rect.Location = new Point((int)(gameEngine.level.player.x + ((x - gameEngine.level.player.x) / speed * (xsteps + 1))), (int)(gameEngine.level.player.y + ((y - gameEngine.level.player.y) / speed * (ysteps))));
                        foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                        {
                            if (obstacle.rect.IntersectsWith(gameEngine.level.player.rect))
                            {
                                switch (obstacle.ToString())
                                {
                                    case "WarGame.Model.Tree":
                                    case "WarGame.Model.Sandbag":
                                        xintersect = true;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        if (!xintersect)
                        {
                            xsteps++;
                        }
                    }

                    if (ysteps < speed && !yintersect)
                    {
                        gameEngine.level.player.rect.Location = new Point((int)(gameEngine.level.player.x + ((x - gameEngine.level.player.x) / speed * (xsteps))), (int)(gameEngine.level.player.y + ((y - gameEngine.level.player.y) / speed * (ysteps + 1))));
                        foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                        {
                            if (obstacle.rect.IntersectsWith(gameEngine.level.player.rect))
                            {
                                switch (obstacle.ToString())
                                {
                                    case "WarGame.Model.Tree":
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
