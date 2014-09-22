using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Missile : Obstacle
    {
        private int speed {get; set;}

        public Missile(int x, int y)
            : base(x, y)
        {
            speed = 10;
        }

        public void FindPlayer(int px, int py)
        {
            float tx = px - x;
            float ty = py - y;
            float distance = (float) Math.Sqrt(tx * tx + ty * ty);
            if (distance > speed)
            {
                // move towards the goal
                x = (int)(x + speed * tx / distance);
                y = (int)(y + speed * ty / distance);
            }
            else
            {
                // already there
                x = px;
                y = py;
            }
        

        }
    }
}
