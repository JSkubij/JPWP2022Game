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
        /// <summary>
        /// Zmienna ruchu
        /// </summary>
        bool ruchPrawo, ruchLewo, ruchGora, ruchDol;

        /// <summary>
        /// Lista tablic wartosci dla danej grupy produktow i danej statystyki
        /// </summary>
        /// Owoce
        int ile_Owoce=6;
        int[] Wartosci_jedzenia_zdrowie_Owoce = {1,1,1,1,1,1};
        int[] Wartosci_jedzenia_samopoczucie_Owoce = { 1, 1, 1, 1, 1, 1 };
        int[] Wartosci_jedzenia_kondycja_Owoce = { 1, 1, 1, 1, 1, 1 };
        string[] Opisy_Owoce = {"Jabłko","Morela","Awokado","Banan","Pomarańcza","Ananas"};
        /// Desery
        int ile_Desery=6;
        int[] Wartosci_jedzenia_zdrowie_Desery = {2,2,2,2,2,2};
        int[] Wartosci_jedzenia_samopoczucie_Desery = { 2, 2, 2, 2, 2, 2 };
        int[] Wartosci_jedzenia_kondycja_Desery = { 2, 2, 2, 2, 2, 2 };
        string[] Opisy_Desery = {"Deser lodowy","Ciasto z owocami", "Sernik","Sernik z owocami","Pucharek lodowy","Galaretka owocowa"};
        /// Slodycze
        int ile_Slodycze=9;
        int[] Wartosci_jedzenia_zdrowie_Slodycze = {3,3,3,3,3,3,3,3,3};
        int[] Wartosci_jedzenia_samopoczucie_Slodycze = { 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        int[] Wartosci_jedzenia_kondycja_Slodycze = { 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        string[] Opisy_Slodycze = {"Cukierek", "Wata cukrowa", "Ciastka z czekoladą", "Biała czekolada", "Czekolada", "Donat", "Rogalik", "Kanapka z kremem czekoladowym","Lód" };
        /// Napoje
        int ile_Napoje=5;
        int[] Wartosci_jedzenia_zdrowie_Napoje = {4,4,4,4,4};
        int[] Wartosci_jedzenia_samopoczucie_Napoje = { 4, 4, 4, 4, 4 };
        int[] Wartosci_jedzenia_kondycja_Napoje = { 4, 4, 4, 4, 4 };
        string[] Opisy_Napoje = {"Mleko kokosowe", "Cola","Mleko owsiane","Mleko","Zielona herbata"};
        /// Fastfood
        int ile_Fastfood=6;
        int[] Wartosci_jedzenia_zdrowie_Fastfood = {5,5,5,5,5,5};
        int[] Wartosci_jedzenia_samopoczucie_Fastfood = { 5, 5, 5, 5, 5, 5 };
        int[] Wartosci_jedzenia_kondycja_Fastfood = { 5, 5, 5, 5, 5, 5 };
        string[] Opisy_Fastfood = {"Frytki z głebokiego oleju", "Burger", "Hot-dog","Pałeczki kurczaka","Pizza","Popcorn"};
        /// Dania
        int ile_Dania=9;
        int[] Wartosci_jedzenia_zdrowie_Dania = {6,6,6,6,6,6,6,6,6,6,6};
        int[] Wartosci_jedzenia_samopoczucie_Dania = { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
        int[] Wartosci_jedzenia_kondycja_Dania = { 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6 };
        string[] Opisy_Dania = {"Burito", "Płatki owsiane","Pierogi z mięsem","Jajko sadzone", "Sałatka","Sushi","Lazania","Makaron","Naleśniki z owocami"};
        /// Śnadania/Kolecje/SK
        int ile_SK=7;
        int[] Wartosci_jedzenia_zdrowie_Sk = {7,7,7,7,7,7,7};
        int[] Wartosci_jedzenia_samopoczucie_Sk = { 7, 7, 7, 7, 7, 7, 7 };
        int[] Wartosci_jedzenia_kondycja_Sk = { 7, 7, 7, 7, 7, 7, 7 };
        string[] Opisy_Sk = {"Tost z jajkiem", "Sałatka", "Jajko sadzone","Jogurt","Naleśniki z owocami","Płatki owsiane","Kanapka z kremem czekoladowym"};


        /// <summary>
        /// Postac statystyki
        /// </summary>
        int speed = 12, zdrowie = 50, samopoczucie = 50, kondycja = 50;

        /// <summary>
        /// Zmienne do losowan
        /// </summary>
        int Losowa1, Losowa2, Losowa3, Liczba_dni = 0, Liczba_los = 1, warunek_los = 0;
        bool czywybdan = true;
        Random rnd = new Random();

        static string[] Sciezki_do_wyborow_Ile = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Ile", "*.png");
        List<string> obrazy = Sciezki_do_wyborow_Ile.ToList();

        static string[] Sciezki_do_wyborow_Dania = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Dania", "*.png");
        List<string> obrazy1 = Sciezki_do_wyborow_Dania.ToList();

        static string[] Sciezki_do_wyborow_Desery = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Desery", "*.png");
        List<string> obrazy2 = Sciezki_do_wyborow_Desery.ToList();

        static string[] Sciezki_do_wyborow_Fast = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Fast", "*.png");
        List<string> obrazy3 = Sciezki_do_wyborow_Fast.ToList();

        static string[] Sciezki_do_wyborow_Napoj = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Napoj", "*.png");
        List<string> obrazy4 = Sciezki_do_wyborow_Napoj.ToList();

        static string[] Sciezki_do_wyborow_Owoc = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Owoc", "*.png");
        List<string> obrazy5 = Sciezki_do_wyborow_Owoc.ToList();

        static string[] Sciezki_do_wyborow_Sk = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Sk", "*.png");
        List<string> obrazy6 = Sciezki_do_wyborow_Sk.ToList();

        static string[] Sciezki_do_wyborow_Slodycze = Directory.GetFiles(@"C:\Users\jakub\OneDrive\Pulpit\Studia\SEM 5\JPWP\JpwpGame\Obrazy\Slodycze", "*.png");
        List<string> obrazy7 = Sciezki_do_wyborow_Slodycze.ToList();

        string test = "";

        public ZdrowieToJestTo(string textToPass)
        {
            InitializeComponent();
            test = textToPass;
            if (test == "Przeslij")
            {
                StreamReader sr = new StreamReader("C:\\Users\\jakub\\OneDrive\\Pulpit\\Studia\\SEM 5\\JPWP\\JpwpGame\\zapis.txt");
                zdrowie = Int32.Parse(sr.ReadLine());
                samopoczucie = Int32.Parse(sr.ReadLine());
                kondycja = Int32.Parse(sr.ReadLine());
                Liczba_dni = Int32.Parse(sr.ReadLine());
                sr.Close();
            }
        }
        

        private void postac_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\jakub\\OneDrive\\Pulpit\\Studia\\SEM 5\\JPWP\\JpwpGame\\zapis.txt");
            sw.WriteLine(zdrowie);
            sw.WriteLine(samopoczucie);
            sw.WriteLine(kondycja);
            sw.WriteLine(Liczba_dni);
            sw.Close();
            Menu f3 = new Menu();
            this.Hide();
            f3.ShowDialog();
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
        }
        public void los3dania()
        {
            if (warunek_los == 3)
            {
                switch (Liczba_los)
                {
                    case 1:
                        ///Sniadanie
                        Losowa1 = rnd.Next(0, 5); ///Desery
                        Losowa2 = rnd.Next(0, 6); ///SK
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Desery[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Sk[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Desery[Losowa1];
                        Opis2.Text = Opisy_Sk[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 2:
                        ///Obiad
                        Losowa1 = rnd.Next(0, 8); ///Dania
                        Losowa2 = rnd.Next(0, 5); ///Fast
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Dania[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Fast[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Dania[Losowa1];
                        Opis2.Text = Opisy_Fastfood[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 3:
                        ///Kolacja
                        Losowa1 = rnd.Next(0, 8); ///Słodycze
                        Losowa2 = rnd.Next(0, 4); ///Napój
                        Losowa3 = rnd.Next(0, 6); ///SK
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Napoj[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Sk[Losowa3];
                        Opis1.Text = Opisy_Slodycze[Losowa1];
                        Opis2.Text = Opisy_Napoje[Losowa2];
                        Opis3.Text = Opisy_Sk[Losowa3];
                        break;
                }
            }
        }
        public void los4dania()
        {
            if (warunek_los == 4)
            {
                switch (Liczba_los)
                {
                    case 1:
                        ///Sniadanie
                        Losowa1 = rnd.Next(0, 5); ///Desery
                        Losowa2 = rnd.Next(0, 6); ///SK
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Desery[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Sk[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Desery[Losowa1];
                        Opis2.Text = Opisy_Sk[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 2:
                        ///2 Sniadanie
                        Losowa1 = rnd.Next(0, 5); ///Owoc
                        Losowa2 = rnd.Next(0, 5); ///Fast
                        Losowa3 = rnd.Next(0, 5); ///Desery
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Owoc[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Fast[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Desery[Losowa3];
                        Opis1.Text = Opisy_Owoce[Losowa1];
                        Opis2.Text = Opisy_Fastfood[Losowa2];
                        Opis3.Text = Opisy_Desery[Losowa3];
                        break;
                    case 3:
                        ///Obiad
                        Losowa1 = rnd.Next(0, 8); ///Dania
                        Losowa2 = rnd.Next(0, 5); ///Fast
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Dania[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Fast[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Dania[Losowa1];
                        Opis2.Text = Opisy_Fastfood[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 4:
                        ///Kolacja
                        Losowa1 = rnd.Next(0, 8); ///Słodycze
                        Losowa2 = rnd.Next(0, 4); ///Napój
                        Losowa3 = rnd.Next(0, 6); ///SK
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Napoj[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Sk[Losowa3];
                        Opis1.Text = Opisy_Slodycze[Losowa1];
                        Opis2.Text = Opisy_Napoje[Losowa2];
                        Opis3.Text = Opisy_Sk[Losowa3];
                        break;
                }
            }
        }
        public void los5dania()
        {
            if (warunek_los == 5)
            {
                switch (Liczba_los)
                {
                    case 1:
                        ///Sniadanie
                        Losowa1 = rnd.Next(0, 5); ///Desery
                        Losowa2 = rnd.Next(0, 6); ///SK
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Desery[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Sk[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Desery[Losowa1];
                        Opis2.Text = Opisy_Sk[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 2:
                        ///2 Sniadanie
                        Losowa1 = rnd.Next(0, 5); ///Owoc
                        Losowa2 = rnd.Next(0, 5); ///Fast
                        Losowa3 = rnd.Next(0, 6); ///Desery
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Owoc[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Fast[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Desery[Losowa3];
                        Opis1.Text = Opisy_Owoce[Losowa1];
                        Opis2.Text = Opisy_Fastfood[Losowa2];
                        Opis3.Text = Opisy_Desery[Losowa3];
                        break;
                    case 3:
                        ///Obiad
                        Losowa1 = rnd.Next(0, 8); ///Dania
                        Losowa2 = rnd.Next(0, 5); ///Fast
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Dania[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Fast[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Dania[Losowa1];
                        Opis2.Text = Opisy_Fastfood[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 4:
                        ///Podwieczorek
                        Losowa1 = rnd.Next(0, 6); ///SK
                        Losowa2 = rnd.Next(0, 5); ///Desery
                        Losowa3 = rnd.Next(0, 8); ///Słodycze
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Sk[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Desery[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa3];
                        Opis1.Text = Opisy_Sk[Losowa1];
                        Opis2.Text = Opisy_Desery[Losowa2];
                        Opis3.Text = Opisy_Slodycze[Losowa3];
                        break;
                    case 5:
                        ///Kolacja
                        Losowa1 = rnd.Next(0, 8); ///Słodycze
                        Losowa2 = rnd.Next(0, 4); ///Napój
                        Losowa3 = rnd.Next(0, 6); ///SK
                        Jedzenie1.ImageLocation = Sciezki_do_wyborow_Slodycze[Losowa1];
                        Jedzenie2.ImageLocation = Sciezki_do_wyborow_Napoj[Losowa2];
                        Jedzenie3.ImageLocation = Sciezki_do_wyborow_Sk[Losowa3];
                        Opis1.Text = Opisy_Slodycze[Losowa1];
                        Opis2.Text = Opisy_Napoje[Losowa2];
                        Opis3.Text = Opisy_Sk[Losowa3];
                        break;
                }
            }
        }
        public void odlos5dania(int klawisz)
        {
            switch (Liczba_los)
            {
                case 1:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Desery[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Desery[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Desery[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 2:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Desery[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Desery[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Desery[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 3:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Dania[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Dania[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Dania[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Fastfood[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Fastfood[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Fastfood[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 4:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Desery[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Desery[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Desery[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 5:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Napoje[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Napoje[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Napoje[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa3];
                    }
                    break;
            }
        }
        public void odlos4dania(int klawisz) {
            switch (Liczba_los) {
                case 1:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Desery[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Desery[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Desery[Losowa1];
                    }else if (klawisz == 2){
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 2:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Desery[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Desery[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Desery[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 3:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Dania[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Dania[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Dania[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Fastfood[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Fastfood[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Fastfood[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 4:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Napoje[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Napoje[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Napoje[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa3];
                    }
                    break;
            }
        }
        public void odlos3dania(int klawisz)
        {
            switch (Liczba_los)
            {
                case 1:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Desery[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Desery[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Desery[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 2:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Dania[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Dania[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Dania[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Fastfood[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Fastfood[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Fastfood[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa3];
                    }
                    break;
                case 3:
                    if (klawisz == 1)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Slodycze[Losowa1];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Slodycze[Losowa1];
                        kondycja += Wartosci_jedzenia_kondycja_Slodycze[Losowa1];
                    }
                    else if (klawisz == 2)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Napoje[Losowa2];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Napoje[Losowa2];
                        kondycja += Wartosci_jedzenia_kondycja_Napoje[Losowa2];
                    }
                    else if (klawisz == 3)
                    {
                        zdrowie += Wartosci_jedzenia_zdrowie_Sk[Losowa3];
                        samopoczucie += Wartosci_jedzenia_samopoczucie_Sk[Losowa3];
                        kondycja += Wartosci_jedzenia_kondycja_Sk[Losowa3];
                    }
                    break;
            }
        }
        public void resetopisow() {
            Opis1.Text = "Opis 1 pola";
            Opis2.Text = "Opis 2 pola";
            Opis3.Text = "Opis 3 pola";
        }
        public void koniecgry()
        {
            if (zdrowie <= 20 || samopoczucie <= 20 || kondycja <= 20)
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\jakub\\OneDrive\\Pulpit\\Studia\\SEM 5\\JPWP\\JpwpGame\\dane.txt");
                sw.WriteLine("Przegrana! :<");
                sw.WriteLine("Udało ci się przeżyć: ");
                sw.WriteLine(Liczba_dni + " dni");
                sw.Close();
                Koncowy f4 = new Koncowy();
                this.Hide();
                f4.ShowDialog();
            }
            else if (zdrowie >= 100 && samopoczucie >= 100 && kondycja >= 100) {
                StreamWriter sw = new StreamWriter("C:\\Users\\jakub\\OneDrive\\Pulpit\\Studia\\SEM 5\\JPWP\\JpwpGame\\dane.txt");
                sw.WriteLine("Udało ci się, gratulacje!");
                sw.WriteLine("Udało ci się przeżyć: ");
                sw.WriteLine(Liczba_dni+" dni");
                sw.Close();
                Koncowy f4 = new Koncowy();
                this.Hide();
                f4.ShowDialog();
            }

        }
        public void losowanie(KeyEventArgs e)
        {
        powtorz:
            if (czywybdan == true)
            {
                Jedzenie1.ImageLocation = Sciezki_do_wyborow_Ile[0];
                Jedzenie2.ImageLocation = Sciezki_do_wyborow_Ile[1];
                Jedzenie3.ImageLocation = Sciezki_do_wyborow_Ile[2];
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "wyb1")
                {
                    if (postac.Bounds.IntersectsWith(x.Bounds) && e.KeyCode == Keys.NumPad1)
                    {
                        if (czywybdan == true)
                        {
                            warunek_los = 3;
                            los3dania();
                            czywybdan = false;
                        }
                        else
                        {
                            if (warunek_los == 3) odlos3dania(1);
                            else if (warunek_los == 4) odlos4dania(1);
                            else if (warunek_los == 5) odlos5dania(1);

                            if (Liczba_los == warunek_los)
                            {
                                koniecgry();
                                Liczba_los = 0;
                                warunek_los = 0;
                                Liczba_dni++;
                                czywybdan = true;
                                postac.Location = new Point(259,515);
                                resetopisow();
                                goto powtorz;
                            }
                            Liczba_los++;
                            if (warunek_los == 3) los3dania();
                            else if (warunek_los == 4) los4dania();
                            else if (warunek_los == 5) los5dania();
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "wyb2")
                {
                    if (postac.Bounds.IntersectsWith(x.Bounds) && e.KeyCode == Keys.NumPad2)
                    {
                        if (czywybdan == true)
                        {
                            warunek_los = 4;
                            los4dania();
                            czywybdan = false;
                        }
                        else
                        {
                            if (warunek_los == 3) odlos3dania(2);
                            else if (warunek_los == 4) odlos4dania(2);
                            else if (warunek_los == 5) odlos5dania(2);

                            if (Liczba_los == warunek_los)
                            {
                                koniecgry();
                                Liczba_los = 0;
                                warunek_los = 0;
                                Liczba_dni++;
                                czywybdan = true;
                                postac.Location = new Point(259, 515);
                                resetopisow();
                                goto powtorz;
                            }
                            Liczba_los++;
                            if (warunek_los == 3) los3dania();
                            else if (warunek_los == 4) los4dania();
                            else if (warunek_los == 5) los5dania();
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "wyb3")
                {
                    if (postac.Bounds.IntersectsWith(x.Bounds) && e.KeyCode == Keys.NumPad3)
                    {
                        if (czywybdan == true)
                        {
                            warunek_los = 5;
                            los5dania();
                            czywybdan = false;
                        }
                        else
                        {
                            if (warunek_los == 3) odlos3dania(3);
                            else if (warunek_los == 4) odlos4dania(3);
                            else if (warunek_los == 5) odlos5dania(3);

                            if (Liczba_los == warunek_los)
                            {
                                koniecgry();
                                Liczba_los = 0;
                                warunek_los = 0;
                                Liczba_dni++;
                                czywybdan = true;
                                postac.Location = new Point(259, 515);
                                resetopisow();
                                goto powtorz;
                            }
                            Liczba_los++;
                            if (warunek_los == 3) los3dania();
                            else if (warunek_los == 4) los4dania();
                            else if (warunek_los == 5) los5dania();
                        }
                    }
                }
            }
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
