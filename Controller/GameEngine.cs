﻿using System;
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
        
        public Stopwatch stopwatch = new Stopwatch();

        public delegate void FormMainEvents();
        public FormMainEvents formMainEvents;

        private static GameEngine gameEngine;
        public Level level;

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

        public void ResetGame(bool refresh)
        {
            formGameField.stopWatch.Reset();
            stopwatch.Reset();            
            level.player = new Player();
            level.ResetLevel();
            formGameField.DrawHealthKits();            
            resetMovement();
            if (refresh)
            {
                formGameField.Invalidate();
            }
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
                XmlParser xmlParser = new XmlParser(true);
                xmlParser.ParseMap(doc, ref progressBarDialog);
            }
            
            formImportLevel.Dispose();

        }

        public void OpenHelp()
        {
            FormHelp h = new FormHelp();
            h.Show();
        }

        public void OpenIntro() 
        {
            FormIntro i = new FormIntro();
            i.Show();
        }

        public void OpenHighscores()
        {
            FormHighScores hs = new FormHighScores();
            hs.ShowDialog();
        }

        // game loop
        public void GameLoopThreadFunction()
        {
            try
            {                
                if(FormGameField.gameState == true)
                {
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();                        
                    }
                    if (!formGameField.stopWatch.IsRunning)
                    {
                        formGameField.stopWatch.Start();
                    }
                    move();
                    LaunchMissiles();
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

            if (player.lives <= 0)
            {
                GameOver();                
            }
            else
            {
                // check if any of the missile is hitting an object
                foreach (Obstacle obstacle in gameEngine.level.obstacleList)
                {
                    foreach (Obstacle o in gameEngine.level.obstacleList)
                    {
                        if (o.ToString().Equals("WarGame.Model.Missilelauncher"))
                        {
                            Missilelauncher missilelauncher = o as Missilelauncher;
                            Missile tempMissile = null;
                            foreach (Missile missile in missilelauncher.missiles)
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
                                                case "WarGame.Model.Missilelauncher":
                                                    Console.WriteLine("Missile flies over launcher ...");
                                                    break;
                                                default:
                                                    Console.WriteLine("missile hit object");
                                                    //playerRect.Location = new Point((int)player.x, (int)player.y); // Location after hit...
                                                    missile.ShowExplosion();
                                                    missile.exploded = true;
                                                    missile.rect.Location = new Point(-missile.width, -missile.length);
                                                    break;
                                            }
                                        }
                                        else if (missile.rect.IntersectsWith(player.rect))
                                        {
                                            missile.ShowExplosion();
                                            missile.exploded = true;
                                            missile.rect = new Rectangle(-10, -10, 1, 1);
                                            player.DecreaseLive();
                                            formGameField.DrawHealthKits();
                                        }

                                    }
                                    else
                                    {
                                        if ((int)missile.explosiontimer.Elapsed.Seconds > 1)
                                        {
                                            tempMissile = missile;
                                        }
                                    }
                                }
                            }
                            if (tempMissile != null)
                            {
                                missilelauncher.RemoveMissile(tempMissile);
                                tempMissile = null;
                            }
                        }
                    }

                    // check if player is hitting any object
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
                                mine.rect.Location = new Point(-mine.width, -mine.length);
                                player.DecreaseLive();
                                formGameField.DrawHealthKits();
                                break;
                            case "WarGame.Model.Mud":
                                Console.WriteLine("Player walks in mud");
                                checkmud = true;
                                break;
                            default:
                                break;
                        }
                    }
                    // check if mine should become vissible
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
                if (tempObstacle != null)
                {
                    level.obstacleList.Remove(tempObstacle);
                    tempObstacle = null;
                }
                mud = checkmud;
            }
        }

        public void LaunchMissiles()
        {
            foreach (Obstacle obstacle in gameEngine.level.obstacleList)
            {                
                if (obstacle.ToString().Equals("WarGame.Model.Missilelauncher"))
                {
                    Missilelauncher missilelauncher = obstacle as Missilelauncher;
                    if (!missilelauncher.launchtimer.IsRunning)
                    {
                        missilelauncher.launchtimer.Start();
                    }
                    if (missilelauncher.launchtimer.ElapsedMilliseconds > missilelauncher.launchinterval)
                    {
                        missilelauncher.LaunchMissile();
                        missilelauncher.launchtimer.Restart();
                    }
                    foreach (Missile missile in missilelauncher.missiles)
                    {
                        missile.FindPlayer((int)gameEngine.level.player.x, (int)gameEngine.level.player.y);
                    }
                }
            }
        }

        public void GameOver()
        {
            FormGameField.gameState = false;
            FormGameOver formGameOver = new FormGameOver();
            DialogResult dr = formGameOver.ShowDialog();
            if (dr == DialogResult.Abort)
            {
                formGameField.Close();

                if (DevMode)
                    formDevMode.Close();

                ResetGame(false);
            }
            else if (dr == DialogResult.Retry)
            {
                FormGameField.gameState = true;
                ResetGame(true);
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
            if (formEndGame.ShowDialog() == DialogResult.OK || formEndGame.close == true)
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
                    xml.ChangeFile(namePlayer, formEndGame.time);
                }
                else
                {
                    xml.CreateFile(namePlayer, formEndGame.time);
                }
                    formGameField.Close();

                    if (DevMode)
                        formDevMode.Close();

                    resetMovement();
            }
            ResetGame(false);
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

            // calculate desired position if player is moving
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
                // calculate if desired position for x and y are possible
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
                                    case "WarGame.Model.Missilelauncher":
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
                                    case "WarGame.Model.Missilelauncher":
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

        // calculate rotation for player image
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

        public void resetMovement()
        {
            up = false;
            down = false;
            left = false;
            right = false;
            mud = false;
            angle = 90;
        }
    }
}
