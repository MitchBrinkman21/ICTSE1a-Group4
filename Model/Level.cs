using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Level
    {
        public List<Obstacle> obstacleList = new List<Obstacle>();
        public Player player = new Player();
        private static Level level;
        public static Level Instance()
        {
            if (level == null)
                level = new Level();

            return level;
        }

	{
		 
	}
    }
}
