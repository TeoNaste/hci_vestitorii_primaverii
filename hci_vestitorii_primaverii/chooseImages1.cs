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
    public partial class chooseImages1 : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private int imageFound = 0;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;

        public chooseImages1()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            audioVA.URL = "audio//3_imagini_primavara.aac";
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
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Green;

            pictureBox1.Image = imgMickeyHappy;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
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
    }
}