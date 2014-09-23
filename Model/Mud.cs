using System;
using System.Collections.Generic;
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
            width = 10;
            length = 10;
            image = Properties.Settings.Default.ImageMud;
        }
    }
}
