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
    }
}
