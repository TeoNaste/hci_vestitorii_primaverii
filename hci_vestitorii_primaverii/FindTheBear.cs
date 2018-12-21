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
    public partial class FindTheBear : Form
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

        public FindTheBear()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_ursul.aac";
            urs1.Visible = false;
            urs2.Visible = false;
            urs3.Visible = false;

            pictureBox4OffsetWidth = this.Width - infoBox.Width;
            pictureBox4OffsetHeight = this.Height - infoBox.Height;

            pictureBox1OffsetWidth = this.Width - urs1.Width;
            pictureBox1OffsetHeight = this.Height - urs1.Height;

            pictureBox2OffsetWidth = this.Width - urs2.Width;
            pictureBox2OffsetHeight = this.Height - urs2.Height;

            pictureBox3OffsetWidth = this.Width - urs3.Width;
            pictureBox3OffsetHeight = this.Height - urs3.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
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
            //audioVA.controls.play();
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

        private void FindTheBear_Resize(object sender, EventArgs e)
        {
            close_button.Location = new Point(Screen.PrimaryScreen.Bounds.Width - close_button.Width, 0);

            infoBox.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.3) - pictureBox4OffsetWidth;
            infoBox.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.3) - pictureBox4OffsetHeight;
            infoBox.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 5.1), (int)(Screen.PrimaryScreen.Bounds.Height / 4));

            urs1.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2.3) - pictureBox1OffsetWidth;
            urs1.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - pictureBox1OffsetHeight;
            urs1.Location = new Point(Screen.PrimaryScreen.Bounds.Width - urs1.Width - urs1.Width/3, Screen.PrimaryScreen.Bounds.Height - 3*urs1.Height);


            urs2.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.7) - pictureBox2OffsetWidth;
            urs2.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox2OffsetHeight;
            urs2.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + (int)(urs2.Width / 2.9), (int)(Screen.PrimaryScreen.Bounds.Height / 2.2));


            urs3.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.9) - pictureBox3OffsetWidth;
            urs3.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - pictureBox3OffsetHeight;
            urs3.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - (int)(2.5 * urs1.Height));

        }
    }
}
