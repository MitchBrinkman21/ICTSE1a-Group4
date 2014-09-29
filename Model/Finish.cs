﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Finish : Obstacle
    {
      
        public Finish(int x, int y)
            : base(x, y)
        {
            width = 10;
            length = 10;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.player, width, length);

        }
    }
}
