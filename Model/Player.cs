using System;
using System.Collections.Generic;
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
        public int width;
        public int length;
        public string image;

        public Player()
        {
            this.x = 1;
            this.y = 1;
            this.speed = 10;
            this.width = 10;
            this.length = 10;
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
