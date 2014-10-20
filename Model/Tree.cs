using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Tree : Obstacle
    {

        public Tree(int x, int y)
            : base(x, y)
        {
            
            width = 50;
            length = 50;
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.tree, width, length);
        }

        public Tree(Tree t)
            : base(t.x, t.y)
        {
            width = t.width;
            length = t.length;
            rect = t.rect;
            image = t.image;
        }
    }
}
