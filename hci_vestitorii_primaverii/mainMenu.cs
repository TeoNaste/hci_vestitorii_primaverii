using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using WMPLib;

namespace hci_vestitorii_primaverii
{
    public partial class mainMenu : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();

        int pictureBox3OffestWidth;
        int pictureBox3OffestHeight;

        int pictureBox1OffestWidth;
        int pictureBox1OffestHeight;

        int pictureBox2OffestWidth;
        int pictureBox2OffestHeight;

        int closeButtonOffsetHeight;
        int closeButtonOffestWidth;

        int startSnowDropOffsetWidth;
        int startSnowDropOffestHeight;

        int swallowButtonOffestWidth;
        int swallowButtonOffestHidth;

        public mainMenu(bool isBack)
        {
            InitializeComponent();
            if (!isBack)
            {
                player.URL = ".//Music//totoro.wav";
                player.settings.setMode("loop", true);
                player.settings.volume = 3;
                audioVA.URL = "audio//hai_sa_meniu.wav";
            }
            else
            {
                audioVA.URL = "audio//alege_meniu.wav";
            }


            pictureBox3OffestWidth = this.Width - pictureBox3.Width;
            pictureBox3OffestHeight = this.Height - pictureBox3.Height;

            pictureBox1OffestWidth = this.Width - pictureBox1.Width;
            pictureBox1OffestHeight = this.Height - pictureBox1.Height;

            pictureBox2OffestWidth = this.Width - pictureBox2.Width;
            pictureBox2OffestHeight = this.Height - pictureBox2.Height;

            closeButtonOffestWidth = this.Width - close_button.Width;
            closeButtonOffsetHeight = this.Height - close_button.Height;

            startSnowDropOffsetWidth = this.Width - start_snowdrop.Width;
            startSnowDropOffestHeight = this.Height - start_snowdrop.Height;

            swallowButtonOffestWidth = this.Width - swallow_button.Width;
            swallowButtonOffestHidth = this.Height - swallow_button.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;

            pictureBox4.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            player.controls.play();
            audioVA.controls.play();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_snowdrop_MouseEnter(object sender, EventArgs e)
        {
            start_snowdrop.Size = new Size(start_snowdrop.Width + 7, start_snowdrop.Height + 5);
        }

        private void start_snowdrop_MouseLeave(object sender, EventArgs e)
        {

            while (start_snowdrop.Width > 91 && start_snowdrop.Height > 89)
            {
                start_snowdrop.Width--;
                start_snowdrop.Height--;
                Application.DoEvents();
                i--;
            }

        }


        private bool dragging = false;
        private Point offset;

        private void mainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;

            this.offset = new Point(e.X, e.Y);
        }



        private void mainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)

                this.Location = new Point(this.Left - (this.offset.X - e.X), this.Top - (this.offset.Y - e.Y));
        }

        private void mainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void start_snowdrop_MouseClick(object sender, MouseEventArgs e)
        {
            chooseImages1 cImg = new chooseImages1();
            this.Hide();
            cImg.Show();
            audioVA.controls.stop();
        }

        private void swallow_button_MouseEnter(object sender, EventArgs e)
        {
            swallow_button.Size = new Size(swallow_button.Width + 7, swallow_button.Height + 7);
        }

        private void swallow_button_MouseLeave(object sender, EventArgs e)
        {
            int i = 7;
            while (i >0)
            {
                swallow_button.Width--;
                swallow_button.Height--;
                Application.DoEvents();
                i--;
            }
        }

        private void swallow_button_MouseClick(object sender, MouseEventArgs e)
        {
            differencesFirstLevel f1 = new differencesFirstLevel();
            this.Hide();
            f1.Show();
            audioVA.controls.stop();
        }

   
    }
}
