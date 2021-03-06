﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Sandbag : Obstacle
    {

        public Sandbag(int x, int y)
            : base(x, y)
        {
            
            width = 35;
            length = 25;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.sandbag, width, length);
        }

        public Sandbag(Sandbag sb)
            : base(sb.x, sb.y)
        {
            width = sb.width;
            length = sb.length;
            rect = sb.rect;
            image = sb.image;
        }
    }
}
