using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Missilelauncher : Obstacle
    {
        public int launchinterval;
        public Stopwatch launchtimer { get; set; }
        public List<Missile> missiles { get; set; }
        public Missilelauncher(int x, int y)
            : base(x, y)
        {
            width = 40;
            length = 40;
            launchinterval = 3000;
            missiles = new List<Missile>();
            rect = new Rectangle(x, y, width, length);
            image = new Bitmap(WarGame.Properties.Resources.missilelauncher, width, length);
        }

        public Missilelauncher(Missilelauncher ml) : base (ml.x, ml.y)         
        {
            width = ml.width;
            length = ml.length;
            rect = ml.rect;
            image = ml.image;
            missiles = new List<Missile>();
            launchtimer = new Stopwatch();
            launchinterval = ml.launchinterval;
        }

        public void LaunchMissile() 
        {
            missiles.Add(new Missile(x, y));
        }

        public void RemoveMissile(Missile missile)
        {
            missiles.Remove(missile);
        }
    }
}
