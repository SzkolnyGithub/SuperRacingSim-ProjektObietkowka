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
        bool shown = false;
        private void Ustaw()
        {
            System.Timers.Timer licznik = new System.Timers.Timer(1); // moze 10
            licznik.Elapsed += sprawdz;
            licznik.AutoReset = true;
            licznik.Enabled = true;
        }
        private void lv1_Load(object sender, EventArgs e)
        {
            Ustaw();
        }
        public lv1()
        {
            InitializeComponent();
            level1.Width = 850;
            level1.Height = 550;
            MaximizeBox = false;
            MinimizeBox = false;
            ruch.Location = new Point(20, 235);
        }
        private void sprawdz(object sender, ElapsedEventArgs e)
        {
            if (y <= 182 || y+ruch.Height >= 366 || x < 0)
            {
                x = 20;
                y = 235;
                MessageBox.Show("Wyjechałeś poza drogę!");
            }
            if(x+ruch.Width >= 760)
            {
                x = 750;
                y = 235;
                PokazMessage();
            }
        }
        private void PokazMessage()
        {
            if(!shown)
            {
                shown = true;
                MessageBox.Show("Udało ci się wygrać!");
                Application.Restart();
            }
        }
        private void level1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Black, 2);
            Pen pen2 = new Pen(Brushes.Gray, 2);
            Pen white2 = new Pen(Color.WhiteSmoke);
            SolidBrush Gray = new SolidBrush(Color.Gray);
            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.WhiteSmoke);
            SolidBrush trawa = new SolidBrush(Color.YellowGreen);
            int height = level1.Height / 3;
            Rectangle rect = new Rectangle(0, height, level1.Width, height);
            Rectangle meta = new Rectangle(730, height, 30, height);
            Rectangle meta2 = new Rectangle(760, height, 30, height);
            Rectangle trawa1 = new Rectangle(0, 0, level1.Width, height);
            Rectangle trawa2 = new Rectangle(0, height * 2, level1.Width, level1.Height);
            e.Graphics.FillRectangle(Gray, rect);
            e.Graphics.DrawRectangle(pen2, rect);
            e.Graphics.FillRectangle(Black, meta);
            e.Graphics.DrawRectangle(pen, meta);
            e.Graphics.FillRectangle(white, meta2);
            e.Graphics.DrawRectangle(white2, meta2);
            e.Graphics.FillRectangle(trawa, trawa1);
            e.Graphics.FillRectangle(trawa, trawa2);
            e.Graphics.DrawLine(pen, 0, height, level1.Width, height);
            e.Graphics.DrawLine(pen, 0, height*2, level1.Width, height*2);
        }
        private void lv1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                x -= 5;
                ruch.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.D)
            {
                x += 5;
                ruch.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.W)
            {
                y -= 5;
                ruch.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.S)
            {
                y += 5;
                ruch.Location = new Point(x, y);
            }
        }
        private void level1_MouseMove(object sender, MouseEventArgs e){}
        private void level1_Click(object sender, EventArgs e){}
        private void ruch_Click(object sender, EventArgs e){}
        private void lv1_MouseMove(object sender, MouseEventArgs e){}
    }
}
