using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private int missileCounter;

        private int gameTime; // The time you spend in the game
        private String namePlayer;

        public bool LevelImported = false;
        FormGameField formGameField;

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
        }

        public void StartGame()
        {
            formGameField = new FormGameField();
            formGameField.Show();

            //Thread thread = new Thread(new ThreadStart(GameLoopThreadFunction));
            //thread.Start();
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

        public void GameLoopThreadFunction()
        {
            try
            {
                while (true)
                {
                    

                    Thread.Sleep(39);
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
            int playerX = player.x;
            int playerY = player.y;

            foreach(Obstacle obstacle in gameEngine.level.obstacleList)
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
                            playerRect.Location = new Point(player.x, player.y); // Location after hit...
                            missile.ShowExplosion();
                            missileCounter--;

                            if (player.lives == 0)
                                EndGame();
                            else
                                player.DecreaseLive();
                            break;
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
                            Console.WriteLine("Player hit tree...");
                            break;
                        case "WarGame.Model.Finish":
                            Console.WriteLine("Player at finish...");
                            EndGame();
                            break;
                        case "WarGame.Model.Missile":
                            Console.WriteLine("Player hit missile");
                            playerRect.Location = new Point(player.x, player.y); // Location after hit...
                            missile.ShowExplosion();
                            missileCounter--;

                            if (player.lives == 0)
                                EndGame();
                            else
                            {
                                player.DecreaseLive();
                                formGameField.DrawHealthKits();
                            }
                                
                            break;
                        case "WarGame.Model.Mine":
                            Console.WriteLine("Player hit missile");
                            playerRect.Location = new Point(player.x, player.y);

                            Mine mine = obstacle as Mine;
                            mine.ShowExplosion();

                            if (player.lives == 0)
                            {
                                EndGame();
                            }                          
                            else
                            {
                                player.DecreaseLive();
                                formGameField.DrawHealthKits();
                            }
                                
                            break;

                            gameEngine.level.obstacleList.Remove(obstacle);
                        default:
                            break;
                    }
                }
            }
        }

        public void LaunchMissile()
        {
            Missile missile = new Missile(10, 10); // Launch from the center of the map...
            missileCounter++;
        }

        public void EndGame()
        {
            FormEndGame formEndGame = new FormEndGame(gameTime);
            if (formEndGame.ShowDialog() == DialogResult.OK)
            {
                namePlayer = formEndGame.namePlayer;
                if (namePlayer.Equals(""))
                {
                    namePlayer = "Anonymous";
                }
            }
             
            // ToDo: Create class XmlBuilder. Build a xml file and store on disk.
        }
    }
}
