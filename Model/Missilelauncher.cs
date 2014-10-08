using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Missilelauncher : Obstacle
    {
        public Missilelauncher(int x, int y)
            : base(x, y)
        {
            width = 40;
            length = 40;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.missilelauncher, width, length);
        }

        public Missilelauncher(Missilelauncher ml) : base (ml.x, ml.y)         
        {
            width = ml.width;
            length = ml.length;
            rect = ml.rect;
            image = ml.image;
        }
    }
}
