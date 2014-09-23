using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Mine : Obstacle
    {
        int proximity;

        public Mine(int x, int y, int width, int length)
            : base(y, x, width, length)
        {
            image = "../Resources/transparent.png";
        }

        public void ShowObject()
        {
            image = "../Resources/mine.png";
        }

        public void ShowExplosion()
        {
            image = "../Resources/explosion.png";
        }
    }
}
