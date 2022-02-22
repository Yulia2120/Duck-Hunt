
using System.Windows.Forms;

namespace Duck_Hunt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private MouseEventHandler MouseEvent;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_kill = new System.Windows.Forms.Label();
            this.p_cloud = new System.Windows.Forms.PictureBox();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_kill
            // 
            this.l_kill.AutoSize = true;
            this.l_kill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_kill.Location = new System.Drawing.Point(267, 19);
            this.l_kill.Name = "l_kill";
            this.l_kill.Size = new System.Drawing.Size(68, 18);
            this.l_kill.TabIndex = 4;
            this.l_kill.Text = "Killed: 0";
            // 
            // p_cloud
            // 
            this.p_cloud.BackColor = System.Drawing.Color.Transparent;
            this.p_cloud.Image = global::Duck_Hunt.Properties.Resources.cloud;
            this.p_cloud.Location = new System.Drawing.Point(-3, 237);
            this.p_cloud.Name = "p_cloud";
            this.p_cloud.Size = new System.Drawing.Size(637, 417);
            this.p_cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p_cloud.TabIndex = 3;
            this.p_cloud.TabStop = false;
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Transparent;
            this.p_3.Image = global::Duck_Hunt.Properties.Resources.bird_3;
            this.p_3.Location = new System.Drawing.Point(222, 159);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(114, 72);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_3.TabIndex = 2;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.p_3_Click);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.Transparent;
            this.p_2.Image = global::Duck_Hunt.Properties.Resources.bird_2;
            this.p_2.Location = new System.Drawing.Point(431, 82);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(111, 78);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_2.TabIndex = 1;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.p_2_Click);
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.Transparent;
            this.p_1.Image = ((System.Drawing.Image)(resources.GetObject("p_1.Image")));
            this.p_1.Location = new System.Drawing.Point(53, 49);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(117, 90);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_1.TabIndex = 0;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.p_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(633, 475);
            this.Controls.Add(this.l_kill);
            this.Controls.Add(this.p_cloud);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duck Hunt";
           // this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.p_cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Timer timer1;
        private PictureBox p_1;
        private PictureBox p_2;
        private PictureBox p_3;
        private PictureBox p_cloud;
        private Label l_kill;
    }
}

