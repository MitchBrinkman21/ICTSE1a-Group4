using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WarGame.Model
{
    public class Missile : Obstacle
    {
        public int speed {get; set;}


        public Missile(int x, int y)
            : base(x, y)
        {
            speed = 10;
            width = 10;
            length = 10;
            image = new Bitmap(WarGame.Properties.Resources.missile, width, length);
            rect = new Rectangle(x, y, width, length);
        }

        /* Computes the distance to the player and either moves towards
         * it or the missile explodes
         */
        public void FindPlayer(int px, int py)
        {
            // pythagoras for distance from player
            float tx = px - x;
            float ty = py - y;
            float angle = (float) (Math.Atan2(ty, tx) * 180.0 / Math.PI);
            float distance = (float) Math.Sqrt(tx * tx + ty * ty);

            // rotate image with given angle
            image = RotateImg(image, angle, Color.Transparent);

            // move towards the player
            x = (int)(x + speed * tx / distance);
            y = (int)(y + speed * ty / distance);
         
       }
       
        public static Bitmap RotateImg(Bitmap bmp, float angle, Color bkColor)
        {
            int w = bmp.Width;
            int h = bmp.Height;
            PixelFormat pf = default(PixelFormat);
            if (bkColor == Color.Transparent)
            {
                pf = PixelFormat.Format32bppArgb;
            }
            else
            {
                pf = bmp.PixelFormat;
            }

            Bitmap tempImg = new Bitmap(w, h, pf);
            Graphics g = Graphics.FromImage(tempImg);
            g.Clear(bkColor);
            g.DrawImageUnscaled(bmp, 1, 1);
            g.Dispose();

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, w, h));
            Matrix mtrx = new Matrix();

            //Using System.Drawing.Drawing2D.Matrix class 
            mtrx.Rotate(angle);
            RectangleF rct = path.GetBounds(mtrx);
            Bitmap newImg = new Bitmap(Convert.ToInt32(rct.Width), Convert.ToInt32(rct.Height), pf);
            g = Graphics.FromImage(newImg);
            g.Clear(bkColor);
            g.TranslateTransform(-rct.X, -rct.Y);
            g.RotateTransform(angle);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.DrawImageUnscaled(tempImg, 0, 0);
            g.Dispose();
            tempImg.Dispose();
            return newImg;
        }
        
        /* Changes current image to the explosion image
         */
        public void ShowExplosion()
        {
            image = new Bitmap(WarGame.Properties.Resources.explosion, 20, 20);
        }


    }
}
