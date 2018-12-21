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

        int pictureBox4OffsetWidth;
        int pictureBox4OffsetHeight;

        int pictureBox1OffsetWidth;
        int pictureBox1OffsetHeight;

        int pictureBox2OffsetWidth;
        int pictureBox2OffsetHeight;

        int pictureBox3OffsetWidth;
        int pictureBox3OffsetHeight;

        public FindTheBarza()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_barza.aac";
            barza1.Visible = false;
            barza2.Visible = false;
            barza3.Visible = false;

            pictureBox4OffsetWidth = this.Width - infoBox.Width;
            pictureBox4OffsetHeight = this.Height - infoBox.Height;

            pictureBox1OffsetWidth = this.Width - barza1.Width;
            pictureBox1OffsetHeight = this.Height - barza1.Height;

            pictureBox2OffsetWidth = this.Width - barza2.Width;
            pictureBox2OffsetHeight = this.Height - barza2.Height;

            pictureBox3OffsetWidth = this.Width - barza3.Width;
            pictureBox3OffsetHeight = this.Height - barza3.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
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
            barza1.Enabled = false;
            audio_feedback();
        }

        private void barza2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza2.Image = myImage;
            toFind--;
            barza2.Enabled = false;
            audio_feedback();
        }

        private void barza3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza3.Image = myImage;
            toFind--;
            barza3.Enabled = false;
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

        private void FindTheBarza_Resize(object sender, EventArgs e)
        {
            close_button.Location = new Point(Screen.PrimaryScreen.Bounds.Width - close_button.Width, 0);

            infoBox.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.3) - pictureBox4OffsetWidth;
            infoBox.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.3) - pictureBox4OffsetHeight;
            infoBox.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 5.1), (int)(Screen.PrimaryScreen.Bounds.Height / 4));

            barza1.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2.03) - pictureBox1OffsetWidth;
            barza1.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - pictureBox1OffsetHeight;
            barza1.Location = new Point((int)(1.3 * barza1.Width), barza1.Height - 50);


            barza2.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - pictureBox2OffsetWidth;
            barza2.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.9) - pictureBox2OffsetHeight;
            barza2.Location = new Point(barza2.Width + barza2.Width/2, Screen.PrimaryScreen.Bounds.Height - barza2.Height - barza2.Height/5);


            barza3.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2.15) - pictureBox3OffsetWidth;
            barza3.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.6) - pictureBox3OffsetHeight;
            barza3.Location = new Point(Screen.PrimaryScreen.Bounds.Width - barza3.Width - barza3.Width/2, Screen.PrimaryScreen.Bounds.Height - barza3.Height);
        }
    }
}
