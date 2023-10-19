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

    public partial class lv1 : Form
    {   // https://stackoverflow.com/questions/47980316/move-a-control-smoothly-using-keydown-event
        private int x, y;
        public lv1()
        {
            InitializeComponent();
        }

        private void level1_Click(object sender, EventArgs e)
        {

        }

        private void lv1_Load(object sender, EventArgs e)
        {
            

        }

        private void level1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Black, 2);
            Pen pen2 = new Pen(Brushes.Gray, 2);
            SolidBrush Gray = new SolidBrush(Color.Gray);
            int height = level1.Height / 3;
            Rectangle rect = new Rectangle(0, 150, 800, 150);
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
            
            if(e.KeyCode == Keys.Up)
            {
                y += 10;
                x += 10;
                ruch.Location = new Point(x, y);
            }
        }
    }
}
