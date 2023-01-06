using System;
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
    public partial class Pomoc : Form
    {
        public Pomoc()
        {
            InitializeComponent();
        }

        private void Opisgry_Click(object sender, EventArgs e)
        {

        }

        private void powrot_Click(object sender, EventArgs e)
        {
            Menu f4 = new Menu();
            this.Hide();
            f4.ShowDialog();
        }

        private void Opisporady_Click(object sender, EventArgs e)
        {

        }

        private void Tytulporady_Click(object sender, EventArgs e)
        {

        }

        private void Pomoc_Load(object sender, EventArgs e)
        {

        }

        private void Tytulopis_Click(object sender, EventArgs e)
        {

        }

        private void tytul_pomoc_Click(object sender, EventArgs e)
        {

        }

        private void Pomoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void steropis_Click(object sender, EventArgs e)
        {

        }
    }
}
