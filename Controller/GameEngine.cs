using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Model;
using WarGame.View;

namespace WarGame.Controller
{
    public class GameEngine
    {
        private static GameEngine gameEngine;
        public Level level = new Level();

        public static GameEngine Instance()
        {
            if (gameEngine == null)
                gameEngine = new GameEngine();
            //Hallo hallo bassie
            return gameEngine;
        }
        
    }
}
