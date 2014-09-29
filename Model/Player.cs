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
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public Bitmap image { get; set; }
        public Rectangle rect { get; set; }

        public Player()
        {
            this.lives = 3;
            this.x = 1;
            this.y = 1;
            this.speed = 10;
            this.width = 10;
            this.length = 10;
            this.rect = new Rectangle(10, 10, 10, 10);
            image = new Bitmap("..\\Resources\\player.png");
        }

        public void MovePlayer(int x, int y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
        }

        public void DecreaseLive()
        {
            this.lives--;
        } 


    }

    
}
