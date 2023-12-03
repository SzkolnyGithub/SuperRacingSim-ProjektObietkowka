using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class lv3 : Form
    {
        int x = 20;
        int y = 400;
        bool shown = false;

        public lv3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            okno_glowne.Width = 820;
            okno_glowne.Height = 500;
            samochod.BringToFront();
           
        }
        private void Ustaw()
        {
            System.Timers.Timer licznik = new System.Timers.Timer(1); // moze 10
            licznik.Elapsed += sprawdz;
            licznik.AutoReset = true;
            licznik.Enabled = true;
        }

        private void sprawdz(object sender, EventArgs e)
        {
            if(x+25 >= 730 && y > 0 && y < 100)
            {
                PokazMessage();
            }
            if(x< 655 && y < 365 && y > 280)
            {
                kraksa();
            }
            if(x+50 > 165 && y+50 > 100 && y < 185)
            {
                kraksa();
            }
            if(x < 0 || x+50 > 820)
            {
                kraksa();
            }
            if (y < 0 || y + 50 > 460)
            {
                kraksa();
            }
        }

        private void PokazMessage()
        {
            if (!shown)
            {
                shown = true;
                MessageBox.Show("Udało ci się wygrać!");
                Application.Restart();
            }
        }

        private void kraksa()
        {
            x = 12;
            y = 399;
            MessageBox.Show("Wyjechałeś poza drogę!");
        }

        private void okno_glowne_Paint_1(object sender, PaintEventArgs e)
        {

            Graphics gdi = e.Graphics;
            int width = okno_glowne.Width / 5;
            int height = okno_glowne.Height / 5;
            int width2 = okno_glowne.Width;
            int height2 = okno_glowne.Height;
            Pen pen = new Pen(Brushes.Black, 2);
            Pen pen2 = new Pen(Brushes.Gray, 2);
            Pen white2 = new Pen(Color.WhiteSmoke);
            SolidBrush Gray = new SolidBrush(Color.Gray);
            SolidBrush Blue = new SolidBrush(Color.Blue);
            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.WhiteSmoke);
            SolidBrush trawa = new SolidBrush(Color.YellowGreen);
            Rectangle droga1 = new Rectangle(0, height*4-35, width2, height);
            Rectangle droga2 = new Rectangle(width*4, height*3-15, width, height);
            Rectangle droga3 = new Rectangle(0, height*2-15, width2, height);
            Rectangle droga4 = new Rectangle(0, height, width, height);
            Rectangle droga5 = new Rectangle(0, 0, width2, height);
            Rectangle koniecB = new Rectangle(width*4+75, 0, 50, 100);
            Rectangle koniecC = new Rectangle(width * 4 +25, 0, 50, 100);
            gdi.FillRectangle(Gray, droga1);
            gdi.FillRectangle(Gray, droga2);
            gdi.FillRectangle(Gray, droga3);
            gdi.FillRectangle(Gray, droga4);
            gdi.FillRectangle(Gray, droga5);
            gdi.FillRectangle(white, koniecB);
            gdi.FillRectangle(Black, koniecC);
            gdi.FillRectangle(trawa, 0, height * 3 - 15, width * 4, height - 20);
            gdi.FillRectangle(trawa, width, height, width * 4, height - 15);
            gdi.DrawLine(pen, 0, height * 4 - 35, width * 4, height * 4 - 35);
            gdi.DrawLine(pen, 0, height * 3 - 15, width * 4, height * 3 - 15);
            gdi.DrawLine(pen, width * 4, height * 4 - 35, width * 4, height * 3 - 15);
            gdi.DrawLine(pen, width, height, okno_glowne.Width, height);
            gdi.DrawLine(pen, width, height * 2 - 15, okno_glowne.Width, height * 2 - 15);
            gdi.DrawLine(pen, width, height, width, height * 2 - 15);
        }
      
        private void lv3_Load(object sender, EventArgs e) { Ustaw(); }

        private void lv3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                x -= 5;
                samochod.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.D)
            {
                x += 5;
                samochod.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.W)
            {
                y -= 5;
                samochod.Location = new Point(x, y);
            }
            if (e.KeyCode == Keys.S)
            {
                y += 5;
                samochod.Location = new Point(x, y);
            }
        }

        private void samochod_Click(object sender, EventArgs e){}
        private void lv3_Paint(object sender, PaintEventArgs e){}
        private void lv3_MouseMove(object sender, MouseEventArgs e){}
        private void okno_glowne_MouseMove(object sender, MouseEventArgs e){}
        private void okno_glowne_Click(object sender, EventArgs e){}
    }
}
