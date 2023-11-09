using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Timers;

namespace test1
{

    public partial class lv1 : Form
    {   // https://stackoverflow.com/questions/47980316/move-a-control-smoothly-using-keydown-event
        // Y: 182 - gorna linia, Y: 366 - dolna linia
        int x = 20;
        int y = 235;
        private void Ustaw()
        {
            System.Timers.Timer licznik = new System.Timers.Timer(1000);
            licznik.Elapsed += sprawdz;
            licznik.AutoReset = true;
            licznik.Enabled = true;
        }
        
        public lv1()
        {
            InitializeComponent();
            level1.Width = 850;
            level1.Height = 550;
            ruch.Location = new Point(20, 235);
        }

        private void sprawdz(object sender, ElapsedEventArgs e)
        {
            //l2.Text = "test";
            if(ruch.Right == 182 /*|| ruch.Right + 75 == 366*/)
            {
                l2.Text = "Przegrales!";
                x = 20;
                y = 235;
                ruch.Location = new Point(x, y);
            }
        }

        private void level1_Click(object sender, EventArgs e)
        {

        }

        private void lv1_Load(object sender, EventArgs e)
        {
            Ustaw();

        }

        private void level1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Black, 2);
            Pen pen2 = new Pen(Brushes.Gray, 2);
            SolidBrush Gray = new SolidBrush(Color.Gray);
            int height = level1.Height / 3;
            Rectangle rect = new Rectangle(0, height, level1.Width, height);
            e.Graphics.FillRectangle(Gray, rect);
            e.Graphics.DrawRectangle(pen2, rect);
            e.Graphics.DrawLine(pen, 0, height, level1.Width, height);
            e.Graphics.DrawLine(pen, 0, height*2, level1.Width, height*2);

        }

        private void ruch_Click(object sender, EventArgs e)
        {

        }

        private void lv1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void lv1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                x += 10;
                y -= 10;
                ruch.Location = new Point(x, y);
                l1.Text += "test";
            }
        }

        private void level1_MouseMove(object sender, MouseEventArgs e)
        {
            l1.Text = "X: " + e.X + "  Y: " + e.Y;
        }
    }
}
