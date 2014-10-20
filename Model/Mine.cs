using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Mine : Obstacle
    {
        public int proximity;        
        public bool visible { get; set; }
        public Stopwatch explosiontimer;
        public double scale { get; set; }
        public Mine(int x, int y)
            : base(x, y)
        {
            width = 25;
            length = 25;
            proximity = 3;
            scale = 200;
            visible = false;
            explosiontimer = new Stopwatch();
            image = new Bitmap(WarGame.Properties.Resources.mine, width, length);
            rect = new Rectangle(x, y, width, length);            
        }

        public void ShowObject()
        {
            image = new Bitmap(WarGame.Properties.Resources.mine, width, length);
        }

        public void ShowExplosion()
        {
            explosiontimer.Start();
            image = new Bitmap(WarGame.Properties.Resources.explosion, (int)(width * (1 + (scale / 100))), (int)(length * (1 + (scale / 100))));
        }

        public Mine(Mine m)
            : base(m.x, m.y)
        {
            width = m.width;
            length = m.length;
            proximity = m.proximity;
            visible = false;
            explosiontimer = new Stopwatch();
            image = m.image;
            rect = m.rect;
            scale = m.scale;
        }
    }
}
