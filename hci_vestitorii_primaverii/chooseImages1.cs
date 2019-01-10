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
    public partial class chooseImages1 : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        WindowsMediaPlayer audioCopac = new WindowsMediaPlayer();
        private int imageFound = 0;
        private Timer MyTimer;

        public Random a = new Random();

        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;
        Bitmap treespring = Properties.Resources.treespring2;
        Bitmap treeautumn = Properties.Resources.treeautumn2;
        Bitmap treewinter = Properties.Resources.treewinter2;

        public chooseImages1()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            audioVA.URL = "audio//alege_copacul_inflorit.aac";
	    audioVA.settings.volume = 100;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 764f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 401f;

            SizeF scale = new SizeF(widthRatio, heightRatio);

            this.Scale(scale);

            close_button.Width = (int)(close_button.Width / widthRatio);
            close_button.Height = (int)(close_button.Height / heightRatio);

            close_button.Location = new Point((int)(close_button.Location.X + close_button.Width), (int)(close_button.Location.Y));

            audioVA.settings.volume = 100;
            audioVA.URL = "audio//3_imagini_primavara.aac";
            int MyNumber = a.Next(1, 7);
            if (MyNumber == 1)
            {
                pictureBox2.Image = treewinter;
                pictureBox3.Image = treeautumn;
                pictureBox4.Image = treespring;
            }
            if (MyNumber == 2)
            {
                pictureBox2.Image = treewinter;
                pictureBox4.Image = treeautumn;
                pictureBox3.Image = treespring;
            }
            if (MyNumber == 3)
            {
                pictureBox3.Image = treewinter;
                pictureBox2.Image = treeautumn;
                pictureBox4.Image = treespring;
            }
            if (MyNumber == 4)
            {
                pictureBox3.Image = treewinter;
                pictureBox4.Image = treeautumn;
                pictureBox2.Image = treespring;
            }
            if (MyNumber == 5)
            {
                pictureBox4.Image = treewinter;
                pictureBox2.Image = treeautumn;
                pictureBox3.Image = treespring;
            }
            if (MyNumber == 6)
            {
                pictureBox4.Image = treewinter;
                pictureBox3.Image = treeautumn;
                pictureBox2.Image = treespring;
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
            audioVA.URL = "audio//aceasta_iarna.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            if (pictureBox2.Image == treespring)
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
                audioCopac.URL = "audio//alege_copacul_inflorit.aac";
                audioCopac.controls.play();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//aceasta_toamna.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Transparent;
            if (pictureBox3.Image == treespring)
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
                audioCopac.URL = "audio//alege_copacul_inflorit.aac";
                audioCopac.controls.play();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bravoPlayer.URL = "audio//bravo.mp3";
            bravoPlayer.controls.play();
            audioVA.URL = "audio//spring_tree.aac";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Green;
            if (pictureBox4.Image == treespring)
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Green;

                pictureBox1.Image = imgMickeyHappy;
                pictureBox5.Visible = true;
                audioCopac.controls.stop();
            }
            else
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Red;

                pictureBox1.Image = imgMickeyThinking;
                pictureBox5.Visible = false;
                audioCopac.URL = "audio//alege_copacul_inflorit.aac";
                audioCopac.controls.play();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            audioVA.controls.stop();
            audioCopac.controls.stop();
            audioVA.controls.stop();
            chooseImages2 secondLevel = new chooseImages2();
            secondLevel.Show();
            this.Close();
        }

        private void chooseImages1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(pictureBox5.Width + 4, pictureBox5.Height + 4);
        }

        private void chooseImages1_MouseLeave(object sender, EventArgs e)
        {
            int i = 4;
            while (i > 0)
            {
                pictureBox5.Width--;
                pictureBox5.Height--;
                Application.DoEvents();
                i--;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
