using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Duck_Hunt
{
    class Target
    {
        float x, y, w, h;
        Pen pen;
        //Point mouse_location;


        public Target(float x, float y, float w, float h, Color color)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            pen = new Pen(color, 2);
           
        }
       
       
        public void Draw(Graphics g)
        {
            PointF p1 = new PointF(x + w / 2, y - h/2);
            PointF p2 = new PointF(x + w / 2, y + h/4);

            PointF p3 = new PointF(x - w/2, y + h/2);
            PointF p4 = new PointF(x + w/4, y + h/2);

            PointF p5 = new PointF(x + w / 2, y + h -5);
            PointF p6 = new PointF(x + w / 2, y + h + h/2);

            PointF p7 = new PointF(x + w /2 + w/4, y + h/2);
            PointF p8 = new PointF(x + w + w/2, y + h/2);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);
            g.DrawLine(pen, p5, p6);
            g.DrawLine(pen, p7, p8);
            g.DrawEllipse(pen, x, y, w, h);
            

        }
      
    }
}
   //Target target1 = new Target(200, 200, 20, 20, Color.Black);
            //target1.Draw(e.Graphics);