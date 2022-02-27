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
using System.Drawing.Imaging;

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
        int speed = 6;
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
            l_shop.Visible = false;
            b_Buy.Visible = false;
          

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
            MakeScreenshot();
        }
        private void p_1_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            coin = kill * 3;
            l_coin.Text = "Coin: " + coin;
            if(l_coin.Text == "Coin: 51" )
            {
                l_shop.Visible = true;
                b_Buy.Visible = true;
            }
           
            p_1.Image = Properties.Resources.kill;
            Sound();
        }

        private void p_2_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            coin = kill * 3;
            l_coin.Text = "Coin: " + coin;
            if (l_coin.Text == "Coin: 51")
            {
                l_shop.Visible = true;
                b_Buy.Visible = true;
            }
            p_2.Image = Properties.Resources.kill;
            Sound();
        }

        private void p_3_Click(object sender, EventArgs e)
        {
            kill++;
            l_kill.Text = "Killed: " + kill;
            coin = kill * 3;
            l_coin.Text = "Coin: " + coin;
            if (l_coin.Text == "Coin: 51")
            {
                l_shop.Visible = true;
                b_Buy.Visible = true;
            }
          
            p_3.Image = Properties.Resources.kill;
            Sound();
        }
        private void b_Buy_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Properties.Resources.cursor2a);
            Cursor crs = new Cursor(bmp.GetHicon());
            this.Cursor = crs;
            l_coin.Text = "Coin: " + (coin - 30);
            l_shop.Visible = false;
            b_Buy.Visible = false;

        }
        private void GameResult()
        {
            if(l_missed.Text == "Missed: 5")
            {
                l_over.Visible = true;
                timer1.Stop();
            }
            if(l_kill.Text == "Killed: 50")
            {
                l_over.Text = "Level Up...";
                l_over.Visible = true;
                timer1.Stop();
            }
        }

        private void MakeScreenshot()
        {
            Rectangle bounds = new Rectangle(Location.X, Location.Y, ClientSize.Width, ClientSize.Height); 
            using (var bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (var g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Location, Point.Empty, bounds.Size);
                }
                bitmap.Save("GameOver.jpg", ImageFormat.Jpeg);
            }
        }
        //if (pictureBox1.Bounds.IntersectsWith(item.Bounds))
    }
}
