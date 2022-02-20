using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duck_Hunt
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Black, 2);
        Point mouse_location = new Point();

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            this.MouseMove += Form1_MouseMove;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawEllipse(pen,
          mouse_location.X - 10, mouse_location.Y - 10, 20, 20);
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_location.X = e.Location.X;
            mouse_location.Y = e.Location.Y;

            this.Invalidate();

        }
    }
}
