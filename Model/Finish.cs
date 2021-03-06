﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Finish : Obstacle
    {
      
        public Finish(int x, int y)
            : base(x, y)
        {
            width = 40;
            length = 35;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.finish, width, length);
        }

        public Finish(Finish f)
            : base(f.x, f.y)
        {
            width = f.width;
            length = f.length;
            rect = f.rect;
            image = f.image;

        }
    }
}
