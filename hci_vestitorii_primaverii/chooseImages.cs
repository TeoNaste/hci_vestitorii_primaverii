using hci_vestitorii_primaverii.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace hci_vestitorii_primaverii
{
    public partial class chooseImages : Form
    {
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;
        public chooseImages()

        {         
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox2.Image = imgMickeyThinking;
            pictureBox3.Image = imgMickeyThinking;

        }

        private void treewinter_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Red;
            paneltreeautumn.BackColor = Color.Transparent;
            paneltreesummer.BackColor = Color.Transparent;
            paneltreespring.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
        }

        private void treeautumn_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Transparent;
            paneltreeautumn.BackColor = Color.Red;
            paneltreesummer.BackColor = Color.Transparent;
            paneltreespring.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;

        }

        private void treespring_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Transparent;
            paneltreeautumn.BackColor = Color.Transparent;
            paneltreesummer.BackColor = Color.Transparent;
            paneltreespring.BackColor = Color.Green;

            pictureBox1.Image = imgMickeyHappy;


        }

        private void treesummer_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Transparent;
            paneltreeautumn.BackColor = Color.Transparent;
            paneltreesummer.BackColor = Color.Red;
            paneltreespring.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
       
        }

        private void barza_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Red;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void randunica_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Green;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyHappy;
        }

        private void vultur_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Red;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void bufnita_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Red;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void crizanteme_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Red;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Transparent;

            pictureBox3.Image = imgMickeyThinking;
        }

        private void floareasoarelui_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Red;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Transparent;

            pictureBox3.Image = imgMickeyThinking;
        }

        private void trandafiri_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Red;
            panelghiocei.BackColor = Color.Transparent;

            pictureBox3.Image = imgMickeyThinking;
        }

        private void ghiocei_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Green;

            pictureBox3.Image = imgMickeyHappy;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            mainMenu mainPage = new mainMenu();
            mainPage.Show();
            this.Close();
        }
    }
}
