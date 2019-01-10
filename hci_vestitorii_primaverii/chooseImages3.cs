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
    public partial class chooseImages3 : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        WindowsMediaPlayer infoGhiocel = new WindowsMediaPlayer();
        WindowsMediaPlayer alegeGhiocelul = new WindowsMediaPlayer();

        private int imageFound = 0;
        private Timer MyTimer;
        public Random a = new Random();

        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;
        Bitmap ghiocei = Properties.Resources.ghiocei;
        Bitmap trandafiri = Properties.Resources.trandafiri2;
        Bitmap floareasoarelui = Properties.Resources.floareasoarelui;

        public chooseImages3()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            infoGhiocel.URL = "audio//info_ghiocelul.aac";
            infoGhiocel.controls.play();
            int MyNumber = a.Next(1, 7);
            if (MyNumber == 1)
            {
                pictureBox2.Image = ghiocei;
                pictureBox3.Image = trandafiri;
                pictureBox4.Image = floareasoarelui;
            }
            if (MyNumber == 2)
            {
                pictureBox2.Image = ghiocei;
                pictureBox4.Image = trandafiri;
                pictureBox3.Image = floareasoarelui;
            }
            if (MyNumber == 3)
            {
                pictureBox3.Image = ghiocei;
                pictureBox2.Image = trandafiri;
                pictureBox4.Image = floareasoarelui;
            }
            if (MyNumber == 4)
            {
                pictureBox3.Image = ghiocei;
                pictureBox4.Image = trandafiri;
                pictureBox2.Image = floareasoarelui;
            }
            if (MyNumber == 5)
            {
                pictureBox4.Image = ghiocei;
                pictureBox2.Image = trandafiri;
                pictureBox3.Image = floareasoarelui;
            }
            if (MyNumber == 6)
            {
                pictureBox4.Image = ghiocei;
                pictureBox3.Image = trandafiri;
                pictureBox2.Image = floareasoarelui;
            }
        }
        private void checkWin()
        {
            MyTimer = new Timer();
            MyTimer.Interval = (4 * 1000);
            MyTimer.Tick += new EventHandler(back_button_Click);
            if (imageFound == 1)
            {
                MyTimer.Start();
            }

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == ghiocei)
            {
                panel1.BackColor = Color.Green;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
            }
            else
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
                infoGhiocel.URL = "audio//alege_ghioceii.aac";
                infoGhiocel.controls.play();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == ghiocei)
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Green;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
            }
            else
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
                infoGhiocel.URL = "audio//alege_ghioceii.aac";
                infoGhiocel.controls.play();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == ghiocei)
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Green;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
            }
            else
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Red;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
                infoGhiocel.URL = "audio//alege_ghioceii.aac";
                infoGhiocel.controls.play();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            infoGhiocel.controls.stop();
            alegeGhiocelul.controls.stop();
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
        }
    }
}
