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
    {
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
            Rectangle rect = new Rectangle(0, height, level1.Width, height * 2);
            e.Graphics.DrawLine(pen, 0, height, level1.Width, height);
            e.Graphics.DrawLine(pen, 0, height*2, level1.Width, height*2);
            e.Graphics.DrawRectangle(pen2, rect);
        }
    }
}
