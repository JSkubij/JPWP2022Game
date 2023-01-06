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
    public partial class Koncowy : Form
    {
        public Koncowy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Koncowy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Koncowy_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\jakub\\OneDrive\\Pulpit\\Studia\\SEM 5\\JPWP\\JpwpGame\\dane.txt");
            Tytul.Text = sr.ReadLine();
            Linia1.Text = sr.ReadLine();
            Linia2.Text = sr.ReadLine();
            wynik.Text = sr.ReadLine();
            sr.Close();
        }

        private void Koncowy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Linia2_Click(object sender, EventArgs e)
        {
        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Menu f4 = new Menu();
            this.Hide();
            f4.ShowDialog();
        }

        private void wynik_Click(object sender, EventArgs e)
        {

        }
    }
}
