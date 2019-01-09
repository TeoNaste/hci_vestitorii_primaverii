﻿using hci_vestitorii_primaverii.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace hci_vestitorii_primaverii
{
    public partial class FindTheBear : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private Timer MyTimer;
        int toFind = 3;

        public FindTheBear()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_ursul.aac";
            urs1.Visible = false;
            urs2.Visible = false;
            urs3.Visible = false;

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 800f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 450f;

            SizeF scale = new SizeF(widthRatio, heightRatio);

            this.Scale(scale);

            close_button.Width = (int)(close_button.Width / widthRatio);
            close_button.Height = (int)(close_button.Height / heightRatio);

            close_button.Location = new Point((int)(close_button.Location.X + close_button.Width), (int)(close_button.Location.Y));

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindTheBear_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (23 * 1000);
            MyTimer.Tick += new EventHandler(play_game);
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void play_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            infoBox.Visible = false;
            //infoBox.Size = new Size(1, 1);
            urs1.Visible = true;
            urs2.Visible = true;
            urs3.Visible = true;
            this.BackgroundImage = Resources.forest_bg;
            audioVA.URL = "audio//cauta_3_ursi.mp3";
            audioVA.controls.play();
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
            audioVA.controls.play();
        }

        private void urs1_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            urs1.Image = myImage;
            toFind--;
            urs1.Enabled = false;
            audio_feedback();
        }

        private void urs2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            urs2.Image = myImage;
            toFind--;
            urs2.Enabled = false;
            audio_feedback();
        }

        private void urs3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            urs3.Image = myImage;
            toFind--;
            urs3.Enabled = false;
            audio_feedback();
        }

        private void audio_feedback()
        {
            if(toFind == 2)
            {
                audioVA.URL = "audio//inca_2_ursi.aac";
                audioVA.controls.play();
            }
            if(toFind == 1)
            {
                audioVA.URL = "audio//inca_unul_de_gasit.aac";
                audioVA.controls.play();
            }
            if(toFind == 0)
            {
                audioVA.URL = "audio//asa_ca_palpitant.aac";
                audioVA.controls.play();
                MyTimer = new Timer();
                MyTimer.Interval = (5 * 1000);
                MyTimer.Tick += new EventHandler(next_game);
                MyTimer.Start();
            }
        }

        private void next_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            FindTheBarza findTheBarza = new FindTheBarza();
            findTheBarza.Show();
            this.Close();
        }
    }
}
