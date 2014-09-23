using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public abstract class Obstacle
    {
        public int x;
        public int y;
        public int width;
        public int lenght;
        public String image;

        public Obstacle(int x, int y, int width, int length) 
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.lenght = length;
        }
    }
}
