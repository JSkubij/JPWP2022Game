using System;
using System.Diagnostics;
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
        int[] Wartosci_jedzenia_zdrowie_Owoce = {2,3,5,2,1,4};
        int[] Wartosci_jedzenia_samopoczucie_Owoce = { 1, 2, 5, 1, 3, 2 };
        int[] Wartosci_jedzenia_kondycja_Owoce = { 2, 1, 5, 2, 3, 1 };
        string[] Opisy_Owoce = {"Jabłko","Morela","Awokado","Banan","Pomarańcza","Ananas"};
        /// Desery
        int ile_Desery=6;
        int[] Wartosci_jedzenia_zdrowie_Desery = {-2,-3,-5,0,-1,-1};
        int[] Wartosci_jedzenia_samopoczucie_Desery = { 3, 1, 2, 4, 1, 2 };
        int[] Wartosci_jedzenia_kondycja_Desery = { -5, -2, -3, -2, -2, -1 };
        string[] Opisy_Desery = {"Deser lodowy","Ciasto z owocami", "Sernik","Sernik z owocami","Pucharek lodowy","Galaretka owocowa"};
        /// Slodycze
        int ile_Slodycze=9;
        int[] Wartosci_jedzenia_zdrowie_Slodycze = {-10,-2,-1,-2,-3,-4,-1,-3,-8};
        int[] Wartosci_jedzenia_samopoczucie_Slodycze = { 10, 2, 1, 4, -3, 5, 1, -3, -2 };
        int[] Wartosci_jedzenia_kondycja_Slodycze = { -5, -3, -3, -2, -10, 3, -3, 1, -4 };
        string[] Opisy_Slodycze = {"Cukierek", "Wata cukrowa", "Ciastka z czekoladą", "Biała czekolada", "Czekolada", "Donat", "Rogalik", "Kanapka z kremem czekoladowym","Lód" };
        /// Napoje
        int ile_Napoje=5;
        int[] Wartosci_jedzenia_zdrowie_Napoje = {4,-10,5,0,10};
        int[] Wartosci_jedzenia_samopoczucie_Napoje = { 4, 3, 6, 2, 0 };
        int[] Wartosci_jedzenia_kondycja_Napoje = { 4, -10, 5, 3, 6 };
        string[] Opisy_Napoje = {"Mleko kokosowe", "Cola","Mleko owsiane","Mleko","Zielona herbata"};
        /// Fastfood
        int ile_Fastfood=6;
        int[] Wartosci_jedzenia_zdrowie_Fastfood = {-5,-10,-3,-6,-1,-3};
        int[] Wartosci_jedzenia_samopoczucie_Fastfood = { -4, -9, -2, -1, -2, -1 };
        int[] Wartosci_jedzenia_kondycja_Fastfood = { -5, 0, 0, -3, -2, -1 };
        string[] Opisy_Fastfood = {"Frytki z głebokiego oleju", "Burger", "Hot-dog","Pałeczki kurczaka","Pizza","Popcorn"};
        /// Dania
        int ile_Dania=9;
        int[] Wartosci_jedzenia_zdrowie_Dania = {3,10,4,1,8,10,4,5,6,7,9};
        int[] Wartosci_jedzenia_samopoczucie_Dania = { 4, 10, 3, 8, 10, 6, 2, 3, 4, 5, 6 };
        int[] Wartosci_jedzenia_kondycja_Dania = { 1, 10, -4, -1, 8, 10, -4, 2, 1, 4, 1 };
        string[] Opisy_Dania = {"Burito", "Płatki owsiane","Pierogi z mięsem","Jajko sadzone", "Sałatka","Sushi","Lazania","Makaron","Naleśniki z owocami"};
        /// Śnadania/Kolecje/SK
        int ile_SK=7;
        int[] Wartosci_jedzenia_zdrowie_Sk = {2, 5, 3, 2, 1, 10, 0 };
        int[] Wartosci_jedzenia_samopoczucie_Sk = { 1, 10, 2, 4, 1, 5, 5 };
        int[] Wartosci_jedzenia_kondycja_Sk = { -1, 10, -3, 4, 5, 3, -3 };
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

        /// <summary>
        /// Scieżki do obrazków produktów *BARDZO WAŻNE GRA MUSI SIĘ ZNAJDOWAĆ NA DYSKU C, ŻEBY DZIAŁAŁA POPRWANIE.
        /// </summary>
        static string[] Sciezki_do_wyborow_Ile = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Ile", "*.png");
        List<string> obrazy = Sciezki_do_wyborow_Ile.ToList();

        static string[] Sciezki_do_wyborow_Dania = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Dania", "*.png");
        List<string> obrazy1 = Sciezki_do_wyborow_Dania.ToList();

        static string[] Sciezki_do_wyborow_Desery = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Desery", "*.png");
        List<string> obrazy2 = Sciezki_do_wyborow_Desery.ToList();

        static string[] Sciezki_do_wyborow_Fast = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Fast", "*.png");
        List<string> obrazy3 = Sciezki_do_wyborow_Fast.ToList();

        static string[] Sciezki_do_wyborow_Napoj = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Napoj", "*.png");
        List<string> obrazy4 = Sciezki_do_wyborow_Napoj.ToList();

        static string[] Sciezki_do_wyborow_Owoc = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Owoc", "*.png");
        List<string> obrazy5 = Sciezki_do_wyborow_Owoc.ToList();

        static string[] Sciezki_do_wyborow_Sk = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Sk", "*.png");
        List<string> obrazy6 = Sciezki_do_wyborow_Sk.ToList();

        static string[] Sciezki_do_wyborow_Slodycze = Directory.GetFiles(@"C:\JpwpGame\Obrazy\Slodycze", "*.png");
        List<string> obrazy7 = Sciezki_do_wyborow_Slodycze.ToList();

        /// <summary>
        /// Zmienna pomocnicza do wczytywania gry
        /// </summary>
        string test = "";

        /// <summary>
        /// Deklaracja miernika czasu w grze
        /// </summary>
        Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// BARDZO WAŻNE GRA MUSI SIĘ ZNAJDOWAĆ NA DYSKU C, ŻEBY DZIAŁAŁA POPRWANIE, ZE WZGLĘDU NA ŚCIEŻKI PLIKÓW.
        /// W głównej funkcji jest sprawdzanie czy gra powinna być wczytana czy zaczęta od nowa.
        /// </summary>
        /// <param name="textToPass"></param>
        public ZdrowieToJestTo(string textToPass)
        {
            InitializeComponent();
            test = textToPass;
            if (test == "Przeslij")
            {
                ///*BARDZO WAŻNE GRA MUSI SIĘ ZNAJDOWAĆ NA DYSKU C, ŻEBY DZIAŁAŁA POPRWANIE.
                StreamReader sr = new StreamReader("C:\\JpwpGame\\zapis.txt");
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
        /// <summary>
        /// Funkcja zapisująca nasz postęp do pliku, w celu wczytania gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click_3(object sender, EventArgs e)
        {
            ///*BARDZO WAŻNE GRA MUSI SIĘ ZNAJDOWAĆ NA DYSKU C, ŻEBY DZIAŁAŁA POPRWANIE.
            StreamWriter sw = new StreamWriter("C:\\JpwpGame\\zapis.txt");
            sw.WriteLine(zdrowie);
            sw.WriteLine(samopoczucie);
            sw.WriteLine(kondycja);
            sw.WriteLine(Liczba_dni);
            sw.Close();
            Menu f3 = new Menu();
            this.Hide();
            f3.ShowDialog();
        }
        /// <summary>
        /// Funkcja timera, realizująca ruch postaci, aktualizowanie wyświetlania statystyk, funkcji stopera i automatycznego wyboru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ruchTimer(object sender, EventArgs e)
        {
            if (ruchLewo == true && postacc.Left>0)
            {
                postacc.Left -= speed;
            }
            if (ruchPrawo == true && postacc.Left<761)
            {
                postacc.Left += speed;
            }
            if (ruchGora == true && postacc.Top >0)
            {
                postacc.Top -= speed;
            }
            if (ruchDol == true && postacc.Top <542)
            {
                postacc.Top += speed;
            }

            zdrowiestatus.Text = "Zdrowie: " + zdrowie.ToString();
            samopoczuciestatus.Text ="Samopoczucie: " + samopoczucie.ToString();
            kondycjastatus.Text = "Kondycja: " + kondycja.ToString();
            liczbadni.Text = "Dzień " + Liczba_dni;
            stopwatch.Start();
            stoper();
            if (stopwatch.ElapsedMilliseconds / 1000 > 30)
            {
                stopwatch.Reset();
                autowybor();
            }
        }
        /// <summary>
        /// Funkcja losowania dla ilości 3 dań
        /// </summary>
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
        /// <summary>
        /// Funkcja losowania dla ilości 4 dań
        /// </summary>
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
        /// <summary>
        /// Funkcja losowania dla ilości 3 dań
        /// </summary>
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
        /// <summary>
        /// Funkcja egzkwowania wyborów dla ilości 5 dań
        /// </summary>
        /// <param name="klawisz">Zmienna informująca który klawisz został kliknięty</param>
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
        /// <summary>
        /// Funkcja egzkwowania wyborów dla ilości 4 dań
        /// </summary>
        /// <param name="klawisz">Zmienna informująca który klawisz został kliknięty</param>
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
        /// <summary>
        /// Funkcja egzkwowania wyborów dla ilości 3 dań
        /// </summary>
        /// <param name="klawisz">Zmienna informująca który klawisz został kliknięty</param>
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
        /// <summary>
        /// Funkcja realizująca reset tekstów w opisach produktów
        /// </summary>
        public void resetopisow() {
            Opis1.Text = "Opis 1 pola";
            Opis2.Text = "Opis 2 pola";
            Opis3.Text = "Opis 3 pola";
        }
        /// <summary>
        /// Funkcja realizująca koniec gry
        /// </summary>
        public void koniecgry()
        {
            if (zdrowie <= 20 || samopoczucie <= 20 || kondycja <= 20)
            {
                StreamWriter sw = new StreamWriter("C:\\JpwpGame\\dane.txt");
                sw.WriteLine("Przegrana! :<");
                sw.WriteLine("Udało ci się przeżyć: ");
                sw.WriteLine(Liczba_dni + " dni");
                sw.Close();
                Koncowy f4 = new Koncowy();
                this.Hide();
                f4.ShowDialog();
            }
            else if (zdrowie >= 100 && samopoczucie >= 100 && kondycja >= 100) {
                StreamWriter sw = new StreamWriter("C:\\JpwpGame\\dane.txt");
                sw.WriteLine("Udało ci się, gratulacje!");
                sw.WriteLine("Udało ci się przeżyć: ");
                sw.WriteLine(Liczba_dni+" dni");
                sw.Close();
                Koncowy f4 = new Koncowy();
                this.Hide();
                f4.ShowDialog();
            }

        }
        /// <summary>
        /// Funkcja zwiekszania wartosci stopera.
        /// </summary>
        private void stoper() {
            Czas.Text = "Czas: " + stopwatch.ElapsedMilliseconds / 1000;
        }
        /// <summary>
        /// Funkcja autoamtycznego wyboru gdy gracz go niepodejmuje.
        /// </summary>
        public void autowybor()
        {
            switch (warunek_los)
            {
                case 0:
                    zdrowie -= 0;
                    kondycja -= 0;
                    samopoczucie -= 0;
                    warunek_los = 0;
                    break;
                case 3:
                    zdrowie -= 10;
                    kondycja -= 10;
                    samopoczucie -= 10;
                    break;
                case 4:
                    zdrowie -= 15;
                    kondycja -= 15;
                    samopoczucie -= 15;
                    break;
                case 5:
                    zdrowie -= 20;
                    kondycja -= 20;
                    samopoczucie -= 20;
                    break;
            }
            warunek_los = 0;
            czywybdan = true;
            koniecgry();
            resetopisow();
        }
        /// <summary>
        /// Funkcja odpowiedzialna za mechanikę losowania i funkcjonowania gry.
        /// </summary>
        /// <param name="e"></param>
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
                    if (postacc.Bounds.IntersectsWith(x.Bounds) && e.KeyCode == Keys.NumPad1)
                    {
                        if (czywybdan == true)
                        {
                            warunek_los = 3;
                            los3dania();
                            stopwatch.Start();
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
                                postacc.Location = new Point(259,515);
                                resetopisow();
                                stopwatch.Reset();
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
                    if (postacc.Bounds.IntersectsWith(x.Bounds) && e.KeyCode == Keys.NumPad2)
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
                                postacc.Location = new Point(259, 515);
                                resetopisow();
                                stopwatch.Reset();
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
                    if (postacc.Bounds.IntersectsWith(x.Bounds) && e.KeyCode == Keys.NumPad3)
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
                                postacc.Location = new Point(259, 515);
                                resetopisow();
                                stopwatch.Reset();
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
        /// <summary>
        /// Funkcja odpowiedzialna za chodzenie w dół
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Funkcja odpowiedzialna za chodzenie w górę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Funkcja odpowiedzialna za wyłączenie aplikacji bo zamknięciu okna gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
