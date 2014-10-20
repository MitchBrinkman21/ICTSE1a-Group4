using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Player
    {
        public int lives { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public int speed { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Bitmap image { get; set; }
        public Rectangle rect;
        private int runspeed, mudspeed;
        public double scale { get; set; }
        public Player()
        {
            this.lives = 3;
            this.x = 100;
            this.y = 100;
            this.runspeed = 5;
            this.mudspeed = 1;
            this.speed = runspeed;
            this.width = 25;
            this.height = 25;
            this.scale = 30;
            this.rect = new Rectangle((int)x, (int)y, width, height);
            image = new Bitmap(WarGame.Properties.Resources.player, (int)(width * (1 + (scale / 100))), (int)(height * (1 + (scale / 100))));
        }

        public void MovePlayer(double x, double y, bool mud)
        {
            this.x = x;
            this.y = y;
            if (mud)
            {
                speed = mudspeed;
            }
            else
            {
                speed = runspeed;
            }
            rect.Location = new Point((int)(this.x), (int)(this.y));
        }

        public void DecreaseLive()
        {
            this.lives--;
        } 
    }
}
