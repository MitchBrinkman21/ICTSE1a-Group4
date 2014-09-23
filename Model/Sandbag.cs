using System;
using System.Collections.Generic;
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
            image = Properties.Settings.Default.ImageSandbag;
        }
    }
}
