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
        private double scaler = 0.2;

        public Player()
        {
            this.lives = 3;
            this.x = 100;
            this.y = 100;
            this.speed = 6;
            this.width = 40;
            this.height = 40;
            this.rect = new Rectangle((int)(x + ((scaler / 2) * width)), (int)(y + ((scaler / 2) * height)), (int)(width * (1 - scaler)), (int)(height * (1 - scaler)));
            image = new Bitmap(WarGame.Properties.Resources.player, width, height);
        }

        public void MovePlayer(double x, double y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            rect.Location = new Point((int)(this.x + ((scaler / 2) * width)), (int)(this.y + ((scaler / 2) * height)));
        }

        public void DecreaseLive()
        {
            this.lives--;
        } 


    }

    
}
