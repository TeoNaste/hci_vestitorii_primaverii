using hci_vestitorii_primaverii.Properties;
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
    public partial class FindTheBarza : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private Timer MyTimer;
        int toFind = 3;

        public FindTheBarza()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_barza.aac";
            barza1.Visible = false;
            barza2.Visible = false;
            barza3.Visible = false;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindTheBarza_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (27 * 1000);
            MyTimer.Tick += new EventHandler(play_game);
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void play_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            infoBox.Visible = false;
            barza1.Visible = true;
            barza2.Visible = true;
            barza3.Visible = true;
            this.BackgroundImage = Resources.village_bg;
            audioVA.URL = "audio//cauta_3_berze.aac";
            audioVA.controls.play();
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void barza1_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza1.Image = myImage;
            toFind--;
            audio_feedback();
        }

        private void barza2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza2.Image = myImage;
            toFind--;
            audio_feedback();
        }

        private void barza3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza3.Image = myImage;
            toFind--;
            audio_feedback();
        }

        private void audio_feedback()
        {
            if (toFind == 2)
            {
                audioVA.URL = "audio//inca_2_berze.aac";
                audioVA.controls.play();
            }
            if (toFind == 1)
            {
                audioVA.URL = "audio//inca_una_si_ai_reusit.aac";
                audioVA.controls.play();
            }
            if (toFind == 0)
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
            FindTheBee findTheBee = new FindTheBee();
            findTheBee.Show();
            this.Close();
        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
