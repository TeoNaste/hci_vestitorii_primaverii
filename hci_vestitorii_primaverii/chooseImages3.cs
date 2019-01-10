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
        WindowsMediaPlayer bravoPlayer = new WindowsMediaPlayer();
        private int imageFound = 0;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;

        public chooseImages3()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            audioVA.URL = "audio//alege_ghioceii.aac";
            audioVA.settings.volume = 100;
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
            audioVA.URL = "audio//acest_transafir.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bravoPlayer.URL = "audio//bravo.mp3";
            bravoPlayer.controls.play();
            audioVA.URL = "audio//info_ghiocelul.aac";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Green;
            panel3.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyHappy;
            pictureBox5.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//aceasta_floarea_soarelui.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Red;

            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            audioVA.controls.stop();
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
        }

        private void chooseImages3_Load(object sender, EventArgs e)
        {
            audioVA.controls.play();
        }
    }
}
