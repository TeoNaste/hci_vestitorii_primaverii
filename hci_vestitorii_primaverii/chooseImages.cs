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
using WMPLib;

namespace hci_vestitorii_primaverii
{
    public partial class chooseImages : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private int imagesFound = 0;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;

        public chooseImages()

        {         
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox2.Image = imgMickeyThinking;
            pictureBox3.Image = imgMickeyThinking;
            audioVA.URL = "audio//3_imagini_primavara.aac";
        }

        private void checkWin()
        {
            MyTimer = new Timer();
            MyTimer.Interval = (4 * 1000);
            MyTimer.Tick += new EventHandler(back_button_Click);
            if (imagesFound == 3)
            {
                MyTimer.Start();
            }

        }

        private void back_button_Click(object sender,EventArgs e)
        {
            MyTimer.Stop();
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
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
            imagesFound++;
            checkWin();
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

        private void cioara_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Red;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void randunica_Click(object sender, EventArgs e)
        {
           
            audioVA.URL = "audio//info_randunica.aac";
            audioVA.controls.play();

            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Green;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;
            imagesFound++;
            pictureBox2.Image = imgMickeyHappy;
            checkWin();
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
            audioVA.URL = "audio//info_ghiocelul.aac";
            audioVA.controls.play();

            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Green;
            imagesFound++;
            checkWin();
            pictureBox3.Image = imgMickeyHappy;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chooseImages_Load(object sender, EventArgs e)
        {
            audioVA.controls.play();
        }
    }
}
