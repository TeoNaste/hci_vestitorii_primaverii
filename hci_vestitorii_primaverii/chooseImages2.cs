﻿using hci_vestitorii_primaverii.Properties;
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
        public Random a = new Random();

        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;
        Bitmap randunica = Properties.Resources.randunica2;
        Bitmap vultur = Properties.Resources.vultur;
        Bitmap bufnita = Properties.Resources.bufnita;

        public chooseImages2()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            int MyNumber = a.Next(1, 7);
            if (MyNumber == 1)
            {
                pictureBox2.Image = randunica;
                pictureBox3.Image = vultur;
                pictureBox4.Image = bufnita;
            }
            if (MyNumber == 2)
            {
                pictureBox2.Image = randunica;
                pictureBox4.Image = vultur;
                pictureBox3.Image = bufnita;
            }
            if (MyNumber == 3)
            {
                pictureBox3.Image = randunica;
                pictureBox2.Image = vultur;
                pictureBox4.Image = bufnita;
            }
            if (MyNumber == 4)
            {
                pictureBox3.Image = randunica;
                pictureBox4.Image = vultur;
                pictureBox2.Image = bufnita;
            }
            if (MyNumber == 5)
            {
                pictureBox4.Image = randunica;
                pictureBox2.Image = vultur;
                pictureBox3.Image = bufnita;
            }
            if (MyNumber == 6)
            {
                pictureBox4.Image = randunica;
                pictureBox3.Image = vultur;
                pictureBox2.Image = bufnita;
            }
            pictureBox5.Visible = false;
            audioVA.URL = "audio//alege_randunica.wav";
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
            if (pictureBox2.Image == randunica)
            {
                panel1.BackColor = Color.Green;
                panel2.BackColor = Color.Transparent;
                panel3.BackColor = Color.Transparent;
            bravoPlayer.URL = "audio//bravo.mp3";
            bravoPlayer.controls.play();
            audioVA.URL = "audio//info_randunica.aac";
            audioVA.controls.play();

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
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//acest_vultur.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Transparent;
            if (pictureBox3.Image == randunica)
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
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//aceasta_bufnita.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Red;
            if (pictureBox4.Image == randunica)
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
