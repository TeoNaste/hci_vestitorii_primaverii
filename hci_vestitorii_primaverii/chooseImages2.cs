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

        int pictureBox4OffsetWidth;
        int pictureBox4OffsetHeight;

        int pictureBox1OffsetWidth;
        int pictureBox1OffsetHeight;

        int pictureBox2OffsetWidth;
        int pictureBox2OffsetHeight;

        int pictureBox3OffsetWidth;
        int pictureBox3OffsetHeight;

        int pictureBox5OffsetWidth;
        int pictureBox5OffsetHeight;

        int panel1OffsetWidth, panel1OffsetHeight, panel2OffsetWidth, panel2OffsetHeight, panel3OffsetWidth, panel3OffsetHeight;

        public chooseImages2()
        {
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
            audioVA.URL = "audio//alege_randunica.wav";

            pictureBox4OffsetWidth = this.Width - pictureBox4.Width;
            pictureBox4OffsetHeight = this.Height - pictureBox4.Height;

            pictureBox1OffsetWidth = this.Width - pictureBox1.Width;
            pictureBox1OffsetHeight = this.Height - pictureBox1.Height;

            pictureBox2OffsetWidth = this.Width - pictureBox2.Width;
            pictureBox2OffsetHeight = this.Height - pictureBox2.Height;

            pictureBox3OffsetWidth = this.Width - pictureBox3.Width;
            pictureBox3OffsetHeight = this.Height - pictureBox3.Height;

            pictureBox5OffsetWidth = this.Width - pictureBox5.Width;
            pictureBox5OffsetHeight = this.Height - pictureBox5.Height;

            panel1OffsetWidth = this.Width - panel1.Width; ;
            panel1OffsetHeight = this.Height - panel1.Height;

            panel2OffsetWidth = this.Width - panel2.Width; ;
            panel2OffsetHeight = this.Height - panel2.Height;

            panel3OffsetWidth = this.Width - panel3.Width; ;
            panel3OffsetHeight = this.Height - panel3.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
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

        private void chooseImages2_Resize(object sender, EventArgs e)
        {
            panel1.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - panel1OffsetWidth;
            panel1.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - panel1OffsetHeight;
            panel1.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 20), (int)(Screen.PrimaryScreen.Bounds.Height / 20));

            pictureBox2.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - pictureBox2OffsetWidth;
            pictureBox2.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox2OffsetHeight;

            panel2.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - panel2OffsetWidth;
            panel2.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - panel2OffsetHeight;
            panel2.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 15) + panel1.Width, (int)(Screen.PrimaryScreen.Bounds.Height / 20));

            pictureBox3.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - pictureBox3OffsetWidth;
            pictureBox3.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox3OffsetHeight;

            panel3.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - panel3OffsetWidth;
            panel3.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - panel3OffsetHeight;
            panel3.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 12) + panel1.Width + panel2.Width, (int)(Screen.PrimaryScreen.Bounds.Height / 20));

            pictureBox4.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - pictureBox4OffsetWidth;
            pictureBox4.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox4OffsetHeight;

            pictureBox1.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - pictureBox1OffsetWidth;
            pictureBox1.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox1OffsetHeight;
            pictureBox1.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 10) + panel1.Width + panel2.Width + panel3.Width, (int)(Screen.PrimaryScreen.Bounds.Height / 20));

            pictureBox5.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - pictureBox1OffsetWidth;
            pictureBox5.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - pictureBox1OffsetHeight;
            pictureBox5.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 20) + panel2.Width, panel2.Height + (int)(Screen.PrimaryScreen.Bounds.Height / 20));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//acest_vultur.mp3";
            audioVA.controls.play();

            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Red;
            panel3.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//aceasta_bufnita.mp3";
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
