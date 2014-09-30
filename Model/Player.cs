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

        public Player()
        {
            this.lives = 3;
            this.x = 100;
            this.y = 100;
            this.speed = 10;
            this.width = 10;
            this.height = 10;
            this.rect = new Rectangle((int)x, (int)y, width, height);
            image = new Bitmap(WarGame.Properties.Resources.player);
        }

        public void MovePlayer(double x, double y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            rect.Location = new Point((int)this.x, (int)this.y);
        }

        public void DecreaseLive()
        {
            this.lives--;
        } 


    }

    
}
