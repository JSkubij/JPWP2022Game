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
        ZdrowieToJestTo f6 = new ZdrowieToJestTo("test");
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pomoc f3 = new Pomoc();
            this.Hide();
            f3.ShowDialog();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textToPass = "Przeslij";
            ZdrowieToJestTo f2= new ZdrowieToJestTo(textToPass);
            f2.Show();
            this.Hide();
            ///f2.ShowDialog();
        }
    }
}
