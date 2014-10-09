using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Level
    {
        public List<Obstacle> obstacleList;
        public List<Obstacle> parsedList;
        public Player player;

        public void ResetLevel()
        {
            obstacleList = new List<Obstacle>();
            foreach (Obstacle obstacle in parsedList)
            {
                switch (obstacle.ToString())
                {
                    case "WarGame.Model.Mine":
                        obstacleList.Add(new Mine(obstacle as Mine));
                        break;
                    case "WarGame.Model.Mud":
                        obstacleList.Add(new Mud(obstacle as Mud));
                        break;
                    case "WarGame.Model.Missilelauncher":
                        obstacleList.Add(new Missilelauncher(obstacle as Missilelauncher));
                        break;
                    case "WarGame.Model.Tree":
                        obstacleList.Add(new Tree(obstacle as Tree));
                        break;
                    case "WarGame.Model.Sandbag":
                        obstacleList.Add(new Sandbag(obstacle as Sandbag));
                        break;
                    case "WarGame.Model.Finish":
                        obstacleList.Add(new Finish(obstacle as Finish));
                        break;
                }
            }
        }

    }
}
