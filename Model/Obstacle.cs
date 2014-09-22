using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public abstract class Obstacle
    {
        public double x;
        public double y;
        public double width;
        public double lenght;

        public Obstacle(double x, double y) 
        {
            this.x = x;
            this.y = y;
            this.width = 10;
            this.lenght = 10;
        }
    }
}
