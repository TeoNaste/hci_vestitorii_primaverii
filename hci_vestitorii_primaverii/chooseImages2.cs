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
    public partial class chooseImages2 : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        WindowsMediaPlayer bravoPlayer = new WindowsMediaPlayer();
        private int imageFound = 0;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;

        Bitmap randunica = Properties.Resources.randunica2;
        Bitmap vultur = Properties.Resources.vultur;
        Bitmap bufnita = Properties.Resources.bufnita;

        Dictionary<Bitmap, String> images = new Dictionary<Bitmap, string>();
        Random random = new Random();
        int rInt1, rInt2, rInt3;

        public chooseImages2()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            audioVA.URL = "audio//alege_randunica.wav";
	        audioVA.settings.volume = 100;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 764f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 401f;

            SizeF scale = new SizeF(widthRatio, heightRatio);

            this.Scale(scale);

            initDictionary();
            initPictures();

        }

        private void initPictures()
        {

            Bitmap img;

            rInt1 = random.Next(0, images.Count);
            img = images.Keys.ElementAt(rInt1);
            pictureBox2.Image = img;
            images.Remove(img);

            rInt2 = random.Next(0, images.Count);
            img = images.Keys.ElementAt(rInt2);
            pictureBox3.Image = img;
            images.Remove(img);

            rInt3 = random.Next(0, images.Count);
            img = images.Keys.ElementAt(rInt3);
            pictureBox4.Image = img;
            images.Remove(img);

            initDictionary();
        }

        private void initDictionary()
        {
            images.Add(randunica, "audio//info_randunica.aac");
            images.Add(vultur, "audio//acest_vultur.mp3");
            images.Add(bufnita, "audio//aceasta_bufnita.mp3");
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
            audioVA.URL = images[(Bitmap)pictureBox2.Image];
            audioVA.controls.play();

            if (randunica != pictureBox2.Image)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
            }
            else
            {
                panel1.BackColor = Color.Green;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            audioVA.URL = images[(Bitmap)pictureBox3.Image];
            audioVA.controls.play();

            if (randunica != pictureBox3.Image)
            {
                panel2.BackColor = Color.Red;
                panel1.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
            }
            else
            {
                panel2.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            audioVA.URL = images[(Bitmap)pictureBox4.Image];
            audioVA.controls.play();

            if (randunica != pictureBox4.Image)
            {
                panel3.BackColor = Color.Red;
                panel2.BackColor = Color.Transparent;
                panel1.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
            }
            else
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            audioVA.controls.stop();
            chooseImages3 thirdLevel = new chooseImages3();
            thirdLevel.Show();
            this.Close();
        }

        private void chooseImages2_Load(object sender, EventArgs e)
        {
            audioVA.controls.play();
        }
    }
}
