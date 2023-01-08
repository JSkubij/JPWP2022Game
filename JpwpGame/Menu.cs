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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Guzik odpowiedzialny za uruchomienie nowej gry.
        /// </summary>
        /// <param name="sender">Źródło zdarzenia</param>
        /// <param name="e">Parametr dla klasy bazowej dla klas argumentów zdarzeń</param>
        private void button1_Click(object sender, EventArgs e)
        {
            ZdrowieToJestTo f6 = new ZdrowieToJestTo("test");
            this.Hide();
            f6.ShowDialog();
        }
        /// <summary>
        /// Guzik odpowiedzialny na uruchomienie okna pomoc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Pomoc f3 = new Pomoc();
            this.Hide();
            f3.ShowDialog();
        }
        /// <summary>
        /// Funkcja odpowiedzialna za wyłączenie aplikacji bo zamknięciu okna menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Guzik wyjścia z gry, wyłącza aplikację.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Guzik odpowiedzialny za wczytanie zapisu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string textToPass = "Przeslij";
            ZdrowieToJestTo f2= new ZdrowieToJestTo(textToPass);
            f2.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
