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
    public partial class poziomy : Form
    {
        public poziomy()
        {
            InitializeComponent();
        }

        private void lv1_Click(object sender, EventArgs e)
        {
            lv1 level1 = new lv1();
            level1.Show(this);
        }

        private void level2_Click(object sender, EventArgs e)
        {
            lv2 level2 = new lv2();
            level2.Show(this);
        }

        private void level3_Click(object sender, EventArgs e)
        {
            /*lv3 level3 = new lv3();
            level3.Show(this);*/
        }
    }
}
