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
        public Rectangle rectShow;  //use rectShow to check if the mine should show itself, use rect to check if the mine should explode
        public bool visible { get; set; }
        public Mine(int x, int y)
            : base(x, y)
        {
            width = 25;
            length = 25;
            proximity = 3;
            visible = false;
            image = new Bitmap(WarGame.Properties.Resources.mine, width, length);
            rect = new Rectangle(x, y, width, length);
            rectShow = new Rectangle(x, y, width * 2, length * 2);
        }

        public void ShowObject()
        {
            image = new Bitmap(WarGame.Properties.Resources.mine, width, length);
        }

        public void ShowExplosion()
        {
            image = new Bitmap(WarGame.Properties.Resources.explosion, width*2, length*2);
        }
    }
}
