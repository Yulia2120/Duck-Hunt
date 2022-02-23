using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
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

        string[] textR = { "Wow!", "Killed!", "Whoo!", "Killed!" };
        Font font = new Font("Arial", 14);
        SolidBrush exbrush = new SolidBrush(Color.Red);
        int speed = 5;
        int kill, missed, coin;
      
     


        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Properties.Resources.cursor);
            Cursor crs = new Cursor(bmp.GetHicon());
            this.Cursor = crs;
            g = CreateGraphics();

            MouseMove += Form1_MouseMove;
            l_over.Visible = false;
          

        }
  
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_location.X = e.Location.X;
            mouse_location.Y = e.Location.Y;
            this.Invalidate();

        }
        //private void Form1_Paint(object sender, PaintEventArgs e)
        //{
        //    //Target target1 = new Target(200, 200, 20, 20, Color.Black);
        //    //target1.Draw(e.Graphics);

        //    g.DrawEllipse(pen,
        //    mouse_location.X - 10, mouse_location.Y - 10, 20, 20);
        //}
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, textR.Length);
            g.DrawString(textR[index], font, exbrush, mouse_location.X-50, mouse_location.Y-50);
            Sound();
            missed++;
            l_missed.Text = "Missed: " + missed;
        }
     
        private void Birds()
        {
            if(p_1.Left < 0)
            {
                p_1.Left = ClientSize.Width;
                p_1.Image = Properties.Resources.bird_1;
              
            }
            if (p_2.Left < 0)
            {
                p_2.Left = ClientSize.Width;
                p_2.Image = Properties.Resources.bird_2;
               
            }
            if (p_3.Left < 0)
            {
                p_3.Left = ClientSize.Width;
                p_3.Image = Properties.Resources.bird_3;
             
            }
            p_1.Left -= speed;
            p_2.Left -= speed;
            p_3.Left -= speed;
          
          //if (p_1.Bounds.IntersectsWith(g.VisibleClipBounds))
          //  {

          //  }
        }

        private void Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Desktop\Git\Duck Hunt\Resources\Sound_1.wav");
            sound.Play();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Birds();
            GameResult();
        }
        private void p_1_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            coin = kill * 3;
            l_coin.Text = "Coin: " + coin;
            p_1.Image = Properties.Resources.kill;
            Sound();
        }

        private void p_2_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            coin = kill * 3;
            l_coin.Text = "Coin: " + coin;
            p_2.Image = Properties.Resources.kill;
            Sound();
        }

        private void p_3_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            coin = kill * 3;
            l_coin.Text = "Coin: " + coin;
            p_3.Image = Properties.Resources.kill;
            Sound();
        }
        private void GameResult()
        {
            if(l_missed.Text == "Missed: 5")
            {
                l_over.Visible = true;
                timer1.Stop();
                l_missed.Visible = false;
                l_kill.Visible = false;
            }
            if(l_kill.Text == "Killed: 50")
            {
                l_over.Text = "Level Up...";
                l_over.Visible = true;
                timer1.Stop();
            }
        }

        //if (pictureBox1.Bounds.IntersectsWith(item.Bounds))
    }
}
