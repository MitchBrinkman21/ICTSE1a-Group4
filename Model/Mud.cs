using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    

    class Mud : Obstacle
    {

        public int slow { get { return slow; } set { slow = 10; } }

        public Mud(int x, int y)
            : base(x, y)
        {
            
            width = 40;
            length = 40;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.mud, width, length);
        }
    }
}
