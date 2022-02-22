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

        string[] textR = { "100", "200", "500", "1000","700", "800" };
        Font font = new Font("Arial", 14);
        SolidBrush exbrush = new SolidBrush(Color.Red);
        int speed = 5;
        int kill;
      
     


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
            Sound();
        }
     
        private void Birds()
        {
            if(p_1.Left < 0)
            {
                p_1.Left = ClientSize.Width;
                p_1.Image = Properties.Resources.bird_1;
                Sound();
            }
            if (p_2.Left < 0)
            {
                p_2.Left = ClientSize.Width;
                p_2.Image = Properties.Resources.bird_2;
                Sound();
            }
            if (p_3.Left < 0)
            {
                p_3.Left = ClientSize.Width;
                p_3.Image = Properties.Resources.bird_3;
                Sound();
            }
            p_1.Left -= speed;
            p_2.Left -= speed;
            p_3.Left -= speed;
        }

       private void Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Desktop\Git\Duck Hunt\Resources\Sound_1.wav");
            sound.Play();
        }

        private void p_1_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            p_1.Image = Properties.Resources.kill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Birds();
        }

        private void p_2_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            p_2.Image = Properties.Resources.kill;
        }

        private void p_3_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            p_3.Image = Properties.Resources.kill;
        }

        //if (pictureBox1.Bounds.IntersectsWith(item.Bounds))
    }
}
