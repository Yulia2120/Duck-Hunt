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
using System.IO;

namespace Duck_Hunt
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen = new Pen(Color.Black, 2);
        Point mouse_location = new Point();
        // Gifduck = new Image.FromFile("GjA.gif");
        string[] textR = { "100", "200", "500", "1000","700", "800" };
        Font font = new Font("Arial", 14);
        SolidBrush exbrush = new SolidBrush(Color.Red);
       // RectangleF rect = new RectangleF();
        //Duck duck = new Duck(200, 200);
        int speed = 12;
       



        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
         
            MouseMove += Form1_MouseMove;
            MouseDown += Form1_MouseDown;
           

        }
  
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_location.X = e.Location.X;
            mouse_location.Y = e.Location.Y;
            this.Invalidate();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Target target1 = new Target(200, 200, 20, 20, Color.Black);
            //target1.Draw(e.Graphics);

            g.DrawEllipse(pen,
            mouse_location.X - 10, mouse_location.Y - 10, 20, 20);
        }

       

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, textR.Length);
             g.DrawString(textR[index], font, exbrush, mouse_location.X-50, mouse_location.Y-50);
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var k = pictureBox1.Location.X;
            k += speed;
            if (k < 0 || k + 300 > 750)
            {
                speed = -speed;
            }
          
        }


    }
}
