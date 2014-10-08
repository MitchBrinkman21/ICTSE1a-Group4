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
            
            width = 100;
            length = 100;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.mud, width, length);
        }

        public Mud(Mud m)
            : base(m.x, m.y)
        {
            width = m.width;
            length = m.length;
            rect = m.rect;
            image = m.image;
        }
    }
}
