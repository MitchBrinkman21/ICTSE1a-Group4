using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WarGame.Model
{
    public class Missile : Obstacle
    {
        public int speed {get; set;}
        Bitmap baseimage;
        public Boolean exploded { get; set; }
        public Stopwatch explosiontimer;
        public double scale { get; set; }

        public Missile(int x, int y)
            : base(x, y)
        {
            speed = 3;
            width = 30;
            length = 30;
            scale = 250;
            exploded = false;
            explosiontimer = new Stopwatch();
            image = new Bitmap(WarGame.Properties.Resources.missile, width, length);
            baseimage = new Bitmap(WarGame.Properties.Resources.missile, width, length);
            rect = new Rectangle(x, y, width, length);
        }

        /* Computes the distance to the player and either moves towards
         * it or the missile explodes
         */
        public void FindPlayer(int px, int py)
        {
            
            if (!exploded)
            {

                // pythagoras for distance from player
                float tx = px - x;
                float ty = py - y;
                float angle = (float)(Math.Atan2(ty, tx) * 180.0 / Math.PI) + 90;
                float distance = (float)Math.Sqrt(tx * tx + ty * ty);

                // rotate image with given angle
                image = Rotate(baseimage, angle);

                // move towards the player
                x = (int)(x + speed * tx / distance);
                y = (int)(y + speed * ty / distance);
                rect.Location = new Point(x, y);
            }
            
         
       }

        public static Bitmap Rotate(Bitmap img, float angle)
        {
            Bitmap rotated = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(rotated);
            gfx.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            gfx.RotateTransform(angle);
            gfx.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            gfx.DrawImage(img, new Point(0, 0));
            return rotated;
        }

        
        /* Changes current image to the explosion image
         */
        public void ShowExplosion()
        {
            explosiontimer.Start();
            image = new Bitmap(WarGame.Properties.Resources.explosion, (int)(width * (1 + (scale / 100))), (int)(length * (1 + (scale / 100))));
        }


    }
}
