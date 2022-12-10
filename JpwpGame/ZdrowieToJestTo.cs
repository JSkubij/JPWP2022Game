using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpwpGame
{
    public partial class ZdrowieToJestTo : Form
    {
        bool ruchPrawo, ruchLewo, ruchGora, ruchDol;

        int[] Wartosci_jedzenia_zdrowie = { -4, -2, -1, 0, 3, 5 };
        int[] Wartosci_jedzenia_samopoczucie = { -2, -6, 1, 0, 3, 5 };
        int[] Wartosci_jedzenia_kondycja = { -6, -4, 2, 0, 3, 5 };

        static string[] Sciezki_do_wyborow_1 = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy", "*.png");
        List<string> obrazy = Sciezki_do_wyborow_1.ToList();

        int speed = 12, zdrowie=50, samopoczucie=50, kondycja=50, Losowa1, Losowa2, Losowa3, Liczba_dni=0, Liczba_los=0;
        Random rnd = new Random();

        string[] informacje_o_produkltach;

        /// <summary>
        /// Zmienne pomocniczne
        /// </summary>

        int rekord_wysoko_zdrowie, rekord_wysoko_samopoczucie, rekord_wysoko_kondycja, rekord_nisko_zdrowie, rekord_nisko_samopoczucie, rekord_nisko_kondycja;

        public ZdrowieToJestTo()
        {
            InitializeComponent();
        }
        

        private void postac_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void ruchTimer(object sender, EventArgs e)
        {
            if (ruchLewo == true && postac.Left>0)
            {
                postac.Left -= speed;
            }
            if (ruchPrawo == true && postac.Left<761)
            {
                postac.Left += speed;
            }
            if (ruchGora == true && postac.Top >0)
            {
                postac.Top -= speed;
            }
            if (ruchDol == true && postac.Top <542)
            {
                postac.Top += speed;
            }

            zdrowiestatus.Text = "Zdrowie: " + zdrowie.ToString();
            samopoczuciestatus.Text ="Samopoczucie: " + samopoczucie.ToString();
            kondycjastatus.Text = "Kondycja: " + kondycja.ToString();
            liczbadni.Text = "Dzień " + Liczba_dni;


            ///Dodatek
            /*
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "food1")
                {
                    if (postac.Bounds.IntersectsWith(x.Bounds))
                    {
                        Jedzenie1.Image = Image.FromFile(@"c:\icons8-blueberry-94.png");
                    }
                    else
                    {
                        Jedzenie1.Image = Image.FromFile(@"c:\icons8-cherry-94.png");
                    }
                }
            }
            */
        }
        public void losowanie(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3)
            {
                Liczba_los++;
                Losowa1 = rnd.Next(0, 5);
                Losowa2 = rnd.Next(0, 5);
                Losowa3 = rnd.Next(0, 5);
                if (e.KeyCode == Keys.NumPad1)
                {
                    zdrowie -= Wartosci_jedzenia_zdrowie[Losowa1];
                    samopoczucie -= Wartosci_jedzenia_samopoczucie[Losowa1];
                    kondycja -= Wartosci_jedzenia_kondycja[Losowa1];
                }
                if (e.KeyCode == Keys.NumPad2)
                {
                    zdrowie -= Wartosci_jedzenia_zdrowie[Losowa2];
                    samopoczucie -= Wartosci_jedzenia_samopoczucie[Losowa2];
                    kondycja -= Wartosci_jedzenia_kondycja[Losowa3];
                }
                if (e.KeyCode == Keys.NumPad3)
                {
                    zdrowie -= Wartosci_jedzenia_zdrowie[Losowa3];
                    samopoczucie -= Wartosci_jedzenia_samopoczucie[Losowa3];
                    kondycja -= Wartosci_jedzenia_kondycja[Losowa3];
                }
                Jedzenie1.ImageLocation = Sciezki_do_wyborow_1[Losowa1];
                Jedzenie2.ImageLocation = Sciezki_do_wyborow_1[Losowa2];
                Jedzenie3.ImageLocation = Sciezki_do_wyborow_1[Losowa3];
                if (Liczba_los == 3)
                {
                    Liczba_los = 0;
                    Liczba_dni++;
                }
            }
        }

        public void Licznik()
        {

        }

        public void reset()
        {

        }

        public void koniec_gry()
        {

        }

        public void zapis_do_plliku()
        {

        }

        public void alert()
        {

        }

        private void dol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Left)
            {
                ruchLewo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                ruchPrawo = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                ruchDol = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                ruchGora = true;
            }
            losowanie(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gora(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                ruchLewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                ruchPrawo = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                ruchDol = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                ruchGora = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
