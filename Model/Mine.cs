using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Mine : Obstacle
    {
        public int proximity;



        public Mine(int x, int y)
            : base(y, x)
        {
            image = Properties.Settings.Default.ImageTransparent;
            width = 10;
            length = 10;
            rect = new Rectangle(x, y, width, length);
        }

        public void ShowObject()
        {
            image = Properties.Settings.Default.ImageMine;
        }

        public void ShowExplosion()
        {
            image = Properties.Settings.Default.ImageExplosion;
        }
    }
}
