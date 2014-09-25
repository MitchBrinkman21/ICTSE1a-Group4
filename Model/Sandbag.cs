using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Sandbag : Obstacle
    {

        public Sandbag(int x, int y)
            : base(x, y)
        {
            
            width = 10;
            length = 10;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(Properties.Settings.Default.ImageSandbag);
        }
    }
}
