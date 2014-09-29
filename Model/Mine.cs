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

        public Mine(int x, int y)
            : base(y, x)
        {
            image = new Bitmap(WarGame.Properties.Resources.mine);
            rect = new Rectangle(x, y, 10, 10);
            rectShow = new Rectangle(x, y, 20, 20);
        }

        public void ShowObject()
        {
            image = new Bitmap(WarGame.Properties.Resources.mine);
        }

        public void ShowExplosion()
        {
            image = new Bitmap(WarGame.Properties.Resources.explosion);
        }
    }
}
