using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Duck_Hunt
{
   public class Duck
    {
        public int x;
        public int y;
        public int size;
        public Image duckImg;
        private Duck duck;

        public Duck(int x, int y)
        {
            duckImg = new Bitmap(@"D:\Desktop\Git\Duck Hunt\Resources\5.gif");
            this.x = x;
            this.y = y;
            size = 50;
        }
        public void Init()
        {
            duck = new Duck(200, 200);
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(duck.duckImg, duck.x, duck.y, duck.size, duck.size);
        }
    }
}
