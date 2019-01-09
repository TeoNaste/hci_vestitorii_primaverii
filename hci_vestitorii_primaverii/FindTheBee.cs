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
    public partial class FindTheBee : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private Timer MyTimer;
        int toFind = 3;

        public FindTheBee()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_albine.aac";
            bee1.Visible = false;
            bee2.Visible = false;
            bee3.Visible = false;

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

        private void FindTheBee_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (17 * 1000);
            MyTimer.Tick += new EventHandler(play_game);
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void play_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            infoBox.Visible = false;
            bee1.Visible = true;
            bee2.Visible = true;
            bee3.Visible = true;
            this.BackgroundImage = Resources.flori_bg;
            audioVA.URL = "audio//cauta_3_albine.aac";
            audioVA.controls.play();
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void bee1_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            bee1.Image = myImage;
            toFind--;
            bee1.Enabled = false;
            audio_feedback();
        }

        private void bee2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            bee2.Image = myImage;
            toFind--;
            bee2.Enabled = false;
            audio_feedback();
        }

        private void bee3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            bee3.Image = myImage;
            toFind--;
            bee3.Enabled = false;
            audio_feedback();
        }

        private void audio_feedback()
        {
            if (toFind == 2)
            {
                audioVA.URL = "audio//inca_2_albine.aac";
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
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
        }

        private void infoBox_Click_1(object sender, EventArgs e)
        {

        }
    }
}
