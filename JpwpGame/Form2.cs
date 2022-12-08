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
    public partial class Form2 : Form
    {
        bool ruchPrawo, ruchLewo, ruchGora, ruchDol;

        int speed = 12;
        public Form2()
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
