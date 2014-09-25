using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WarGame.Model
{
    public abstract class Obstacle
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int length { get; set; }
        public Bitmap image { get; set; }
        public Rectangle rect;

        public Obstacle(int x, int y) 
        {
            this.x = x;
            this.y = y;
           
        }
    }
}
