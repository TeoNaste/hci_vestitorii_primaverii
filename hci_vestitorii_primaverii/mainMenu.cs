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

        public mainMenu()
        {
            InitializeComponent();
            player.URL = ".//Music//totoro.wav";
            player.settings.setMode("loop", true);
            player.settings.volume = 3;


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

            int i = 7;
            while (i > 0)
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
            chooseImages cImg = new chooseImages();
            this.Hide();
            cImg.Show();
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
        }

        private void mainMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox3.Width = (int)(Screen.PrimaryScreen.Bounds.Width /1.7) - pictureBox3OffestWidth;
                pictureBox3.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox3OffestHeight;
                //pictureBox3.Location = new Point(pictureBox3.Location.X + 190, pictureBox3.Location.Y + 90);
                pictureBox3.Location = new Point( Screen.PrimaryScreen.Bounds.Width - pictureBox3.Width, Screen.PrimaryScreen.Bounds.Height - pictureBox3.Height);


                pictureBox1.BringToFront();
                pictureBox1.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.7) - pictureBox1OffestWidth;
                pictureBox1.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox1OffestHeight;
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 90);
                pictureBox1.Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - pictureBox1.Height);
                


                pictureBox2.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.9) - pictureBox2OffestWidth;
                pictureBox2.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.75) - pictureBox2OffestHeight;
                //pictureBox2.Location = new Point(pictureBox2.Location.X + 155, pictureBox2.Location.Y + 90);
                pictureBox2.Location = new Point(Screen.PrimaryScreen.Bounds.Width - pictureBox3.Width - pictureBox2.Width, Screen.PrimaryScreen.Bounds.Height-pictureBox3.Height);

                close_button.Location = new Point(Screen.PrimaryScreen.Bounds.Width - close_button.Width,0);

                start_snowdrop.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - startSnowDropOffsetWidth;
                start_snowdrop.Height = (int)(Screen.PrimaryScreen.Bounds.Height /  2) - startSnowDropOffestHeight;
                //start_snowdrop.Location = new Point(start_snowdrop.Location.X + 100, start_snowdrop.Location.Y + 100);
                start_snowdrop.Location = new Point(Screen.PrimaryScreen.Bounds.Width - pictureBox3.Width - pictureBox2.Width - start_snowdrop.Width, pictureBox3.Location.Y + pictureBox3.Height/6);

                swallow_button.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2.2) - swallowButtonOffestWidth;
                swallow_button.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - swallowButtonOffestHidth;
                //swallow_button.Location = new Point(swallow_button.Location.X + 80, swallow_button.Location.Y + 50);
                swallow_button.Location = new Point(pictureBox1.Width + swallow_button.Width/8 , swallow_button.Height+swallow_button.Height/3);

            }
        }
    }
}
