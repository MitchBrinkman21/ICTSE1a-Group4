using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            FormGameField formGameField = new FormGameField();
            formGameField.Show();
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
        
        public void HitDetect()
        {
            int playerX = gameEngine.level.player.x;
            int playerY = gameEngine.level.player.y;

            foreach(Object obstacle in gameEngine.level.obstacleList)
            {

            }
        }
    }
}
