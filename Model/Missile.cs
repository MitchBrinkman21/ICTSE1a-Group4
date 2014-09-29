using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarGame.Model
{
    public class Missile : Obstacle
    {
        private int speed {get; set;}


        public Missile(int x, int y)
            : base(x, y)
        {
            speed = 10;
            width = 10;
            length = 10;
            image = new Bitmap(WarGame.Properties.Resources.missile);
            rect = new Rectangle(x, y, width, length);
        }

        /* Computes the distance to the player and either moves towards
         * it or the missile explodes
         */
        public void FindPlayer(int px, int py)
        {
            // pythagoras for distance from player
            float tx = px - x;
            float ty = py - y;
            float distance = (float) Math.Sqrt(tx * tx + ty * ty);

            if (distance > speed)
            {
                // move towards the player
                x = (int)(x + speed * tx / distance);
                y = (int)(y + speed * ty / distance);
            }
            else
            {
                // already there
                x = px;
                y = py;
                ShowExplosion();
            }
        

        }
        
        /* Changes current image to the explosion image
         */
        public void ShowExplosion()
        {
            image = new Bitmap(WarGame.Properties.Resources.explosion);
        }
    }
}
