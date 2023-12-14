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
    public partial class lv2 : Form
    {
        int x = 710; // pozycja oryginalna "pojazdu"
        int y = 370;
        bool shown = false; // czy komunikat po przejechaniu linii mety został pokazany
        public lv2()
        {
            InitializeComponent();
            okno_glowne.Width = 820; // poniższe przypisania służa do tego samego, co robiły w poziomie 1
            okno_glowne.Height = 500;
            MaximizeBox = false;
            MinimizeBox = false;
            samochod.Location = new Point(x, y);
        }
        private void lv2_Load(object sender, EventArgs e) { Ustaw(); } // funkcja włanczająca licznik
        private void Ustaw() // funkcja ustawiająca licznik
        {
            System.Timers.Timer licznik = new System.Timers.Timer(1); // moze 10
            licznik.Elapsed += sprawdz;
            licznik.AutoReset = true;
            licznik.Enabled = true;
        }
        private void sprawdz(object sender, EventArgs e) // funkcja sprawdzająca, czy gracz przekroczył specyficzne
        { // części okna - w takim przypadku wykonuje adekwatne działanie
            int width = okno_glowne.Width / 5;
            int height = okno_glowne.Height / 3;
            if(x < width*4 && y+samochod.Height > height*2 || x+samochod.Width > width && y < height) // "pojazd" poza drogą
            {
                kraksa();
            }
            if(x < 0 || x+samochod.Width > okno_glowne.Width || y+samochod.Height > okno_glowne.Height)
            {
                kraksa();
            }
            if(x > 0 && x < width && y <= 55) // "pojazd" przejechał metę
            {
                PokazMessage();
            }
           
        }

        private void PokazMessage() // tak samo jak w poprzednim poziomie, jeśli gracz przejechał linię mety, wyświetlany
        { // jest komunikat i jest on przenoszony do okna startowego aplikacji
            if (!shown)
            {
                shown = true;
                MessageBox.Show("Udało ci się wygrać!");
                Application.Restart();
            }
        }
        
        private void kraksa() // funkcja obsługująca wyjazd gracza poza drogę
        { // zostaje on przeniesiony do pozycji startowej i wyświetlany jest komunikat
            x = 710;
            y = 370;
            MessageBox.Show("Wyjechałeś poza drogę!");
        }
        private void okno_glowne_Paint(object sender, PaintEventArgs e) // funkcja rysująca poziom - funkcjonuje
        { // identycznie do tej z poziomu 1
            Graphics gdi = e.Graphics;
            int width = okno_glowne.Width / 5;
            int height = okno_glowne.Height / 3;
            Pen pen = new Pen(Brushes.Black, 2);
            Pen pen2 = new Pen(Brushes.Gray, 2);
            Pen white2 = new Pen(Color.WhiteSmoke);
            SolidBrush Gray = new SolidBrush(Color.Gray);
            SolidBrush Black = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.WhiteSmoke);
            SolidBrush trawa = new SolidBrush(Color.YellowGreen);
            Rectangle droga1 = new Rectangle(width * 4, height, width, height * 2);
            Rectangle droga2 = new Rectangle(0, height, okno_glowne.Width, height);
            Rectangle droga3 = new Rectangle(0, 0, width, height);
            Rectangle koniecB = new Rectangle(0, 25, width, 30);
            Rectangle koniecC = new Rectangle(0, 55, width, 30);
           
            gdi.FillRectangle(Gray, droga1);
            gdi.FillRectangle(Gray, droga2);
            gdi.FillRectangle(Gray, droga3);
            gdi.FillRectangle(white, koniecB);
            gdi.FillRectangle(Black, koniecC);
            gdi.FillRectangle(trawa, width, 0, width * 4, height);
            gdi.FillRectangle(trawa, 0, height * 2, width * 4, height);
            gdi.DrawLine(pen, width * 4, okno_glowne.Height, width * 4, height * 2);
            gdi.DrawLine(pen, 0, height * 2, width * 4, height * 2);
            gdi.DrawLine(pen, width, 0, width, height);
            gdi.DrawLine(pen, width, height, okno_glowne.Width, height);

        }

        private void lv2_KeyDown(object sender, KeyEventArgs e) // funkcja obsługująca poruszanie sie "pojazdu"
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

        private void okno_glowne_Click(object sender, EventArgs e){} // funkcje do testowania funkcjonalności
        private void samochod_Click(object sender, EventArgs e){}
        private void lv2_MouseMove(object sender, MouseEventArgs e){}
        private void okno_glowne_MouseMove(object sender, MouseEventArgs e){}
    }
}
