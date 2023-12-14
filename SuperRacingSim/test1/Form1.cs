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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Location = new Point(this.Width / 4, this.Height / 8);
            start.Location = new Point(this.Width / 3, this.Height / 4 + 20); // ustawienie elementow w oknie
            exit.Location = new Point(this.Width / 3 + 15, this.Height / 2 + 30);
        }
        private void start_Click(object sender, EventArgs e)
        {
            poziomy lvSelector = new poziomy(); // przekierowanie do okna z listą poziomów
            lvSelector.Show(this);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close(); // zamyka aplikację
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) {/*if (e.KeyCode == Keys.A){start.Text += "test";}*/}
        private void Form1_Load(object sender, EventArgs e) { } // funkcje do testowania sposobu działania aplikacji
    }
}
