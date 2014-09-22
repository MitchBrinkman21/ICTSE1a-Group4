using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    

    class Mud : Obstacle
    {
        private int slow = 13;

        public Mud(int x, int y)
            : base(x, y)
        { 
        }
    }
}
