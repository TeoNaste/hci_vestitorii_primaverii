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
    public partial class differencesFirstLevel : Form
    {
        private int differences = 5;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();

        int pictureBox1OffestWidth;
        int pictureBox1OffestHeight;

        int closeButtonOffsetHeight;
        int closeButtonOffestWidth;

        int minieKissOffestWidth;
        int minieKissOffestHeight;

        int diff1aOffssetWidth, diff1aOffssetHeight, diff2aOffssetWidth, diff2aOffssetHeight, diff3aOffssetWidth, diff3aOffssetHeight,
            diff4aOffssetWidth, diff4aOffssetHeight, diff5aOffssetWidth, diff5aOffssetHeight;

        int diff1bOffssetWidth, diff1bOffssetHeight, diff2bOffssetWidth, diff2bOffssetHeight, diff3bOffssetWidth, diff3bOffssetHeight,
            diff4bOffssetWidth, diff4bOffssetHeight, diff5bOffssetWidth, diff5bOffssetHeight;


        public differencesFirstLevel()
        {
            InitializeComponent();
            InitializePictureBoxBackColor();
            minieKiss.Visible = false;
            audioVA.URL = "audio//cele_5_dif.mp3";

            pictureBox1OffestWidth = this.Width - pictureBox1.Width;
            pictureBox1OffestHeight = this.Height - pictureBox1.Height;

            closeButtonOffestWidth = this.Width - button1.Width;
            closeButtonOffsetHeight = this.Height - button1.Height;

            minieKissOffestWidth = this.Width - minieKiss.Width;
            minieKissOffestHeight = this.Height - minieKiss.Height;

            diff1aOffssetWidth = this.Width - diff1a.Width;
            diff1aOffssetHeight = this.Height - diff1a.Height;

            diff2aOffssetWidth = this.Width - diff2a.Width;
            diff2aOffssetHeight = this.Height - diff2a.Height;

            diff3aOffssetWidth = this.Width - diff3a.Width;
            diff3aOffssetHeight = this.Height - diff3a.Height;

            diff4aOffssetWidth = this.Width - diff4a.Width;
            diff4aOffssetHeight = this.Height - diff4a.Height;

            diff5aOffssetWidth = this.Width - diff5a.Width;
            diff5aOffssetHeight = this.Height - diff5a.Height;

            diff1bOffssetWidth = this.Width - diff1b.Width;
            diff1bOffssetHeight = this.Height - diff1b.Height;

            diff2bOffssetWidth = this.Width - diff2b.Width;
            diff2bOffssetHeight = this.Height - diff2b.Height;

            diff3bOffssetWidth = this.Width - diff3b.Width;
            diff3bOffssetHeight = this.Height - diff3b.Height;

            diff4bOffssetWidth = this.Width - diff4b.Width;
            diff4bOffssetHeight = this.Height - diff4b.Height;

            diff5bOffssetWidth = this.Width - diff5b.Width;
            diff5bOffssetHeight = this.Height - diff5b.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
        }

        private void differencesFirstLevel_Load(object sender, EventArgs e)
        { 
           audioVA.controls.play();
        }

        private void checkWin()
        {
            MyTimer = new Timer();
            MyTimer.Interval = (4 * 1000);
            MyTimer.Tick += new EventHandler(play_button_Click);
            if(differences == 4)
            {
                audioVA.URL = "audio//inca_4_dif.aac";
                audioVA.controls.play();
            }
            if (differences == 4)
            {
                audioVA.URL = "audio//inca_4_dif.aac";
                audioVA.controls.play();
            }
            if (differences == 3)
            {
                audioVA.URL = "audio//inca_3_dif.aac";
                audioVA.controls.play();
            }
            if (differences == 2)
            {
                audioVA.URL = "audio//inca_2_dif.aac";
                audioVA.controls.play();
            }
            if (differences == 1)
            {
                audioVA.URL = "audio//inca_una_si_ai_reusit.aac";
                audioVA.controls.play();
            }
            if (differences == 0)
            {
                audioVA.URL = "audio//wow_toate_dif.aac";
                audioVA.controls.play();
                minieKiss.Visible = true;
                MyTimer.Start();
            }
        }

        private void InitializePictureBoxBackColor()
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff1a.Parent = pictureBox1;
            diff1a.BackColor = Color.Transparent;
            //diff1a.Image = myImage;

            diff1b.Parent = pictureBox1;
            diff1b.BackColor = Color.Transparent;
            //diff1b.Image = myImage;

            diff2a.Parent = pictureBox1;
            diff2a.BackColor = Color.Transparent;
            //diff2a.Image = myImage;

            diff2b.Parent = pictureBox1;
            diff2b.BackColor = Color.Transparent;
            //diff2b.Image = myImage;

            diff3a.Parent = pictureBox1;
            diff3a.BackColor = Color.Transparent;
            //diff3a.Image = myImage;

            diff3b.Parent = pictureBox1;
            diff3b.BackColor = Color.Transparent;
            //diff3b.Image = myImage;

            diff4a.Parent = pictureBox1;
            diff4a.BackColor = Color.Transparent;
            //diff4a.Image = myImage;

            diff4b.Parent = pictureBox1;
            diff4b.BackColor = Color.Transparent;
            //diff4b.Image = myImage;

            diff5a.Parent = pictureBox1;
            diff5a.BackColor = Color.Transparent;
            //diff5a.Image = myImage;

            diff5b.Parent = pictureBox1;
            diff5b.BackColor = Color.Transparent;
            //diff5b.Image = myImage;

            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void differencesFirstLevel_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox1.Width = (int)(this.Width / 1.5) - pictureBox1OffestWidth;
                pictureBox1.Height = (int)(this.Height / 1.2) - pictureBox1OffestHeight;

                button1.Location = new Point(button1.Location.X + 280, button1.Location.Y);

                minieKiss.Width = (int)(this.Width / 1.7) - minieKissOffestWidth;
                minieKiss.Height = (int)(this.Height / 1.7) - minieKissOffestHeight;
                minieKiss.Location = new Point(minieKiss.Location.X + 120, minieKiss.Location.Y + 100);

                diff1a.Width = (int)(this.Width / 2.3) - diff1aOffssetWidth;
                diff1a.Height = (int)(this.Height / 2.3) - diff1aOffssetHeight;
                diff1a.Location = new Point(diff1a.Location.X + 30, diff1a.Location.Y + 12);

                diff2a.Width = (int)(this.Width / 2.3) - diff2aOffssetWidth;
                diff2a.Height = (int)(this.Height / 1.9) - diff2aOffssetHeight;
                diff2a.Location = new Point(diff2a.Location.X + 5, diff2a.Location.Y + 50);

                diff3a.Width = (int)(this.Width / 2.4) - diff3aOffssetWidth;
                diff3a.Height = (int)(this.Height / 2.2) - diff3aOffssetHeight;
                diff3a.Location = new Point(diff3a.Location.X + 6, diff3a.Location.Y + 80);

                diff4a.Width = (int)(this.Width / 2.4) - diff4aOffssetWidth;
                diff4a.Height = (int)(this.Height / 2.4) - diff4aOffssetHeight;
                diff4a.Location = new Point(diff4a.Location.X + 41, diff4a.Location.Y + 90);

                diff5a.Width = (int)(this.Width / 2.2) - diff5aOffssetWidth;
                diff5a.Height = (int)(this.Height / 2.1) - diff5aOffssetHeight;
                diff5a.Location = new Point(diff5a.Location.X + 38, diff5a.Location.Y + 70);

                diff1b.Width = (int)(this.Width / 2.3) - diff1bOffssetWidth;
                diff1b.Height = (int)(this.Height / 2.3) - diff1bOffssetHeight;
                diff1b.Location = new Point(diff1b.Location.X + 90, diff1b.Location.Y + 12);

                diff2b.Width = (int)(this.Width / 2.3) - diff2bOffssetWidth;
                diff2b.Height = (int)(this.Height / 1.9) - diff2bOffssetHeight;
                diff2b.Location = new Point(diff2b.Location.X + 65, diff2b.Location.Y + 50);

                diff3b.Width = (int)(this.Width / 2.4) - diff3bOffssetWidth;
                diff3b.Height = (int)(this.Height / 2.2) - diff3bOffssetHeight;
                diff3b.Location = new Point(diff3b.Location.X + 66, diff3b.Location.Y + 80);

                diff4b.Width = (int)(this.Width / 2.4) - diff4bOffssetWidth;
                diff4b.Height = (int)(this.Height / 2.4) - diff4bOffssetHeight;
                diff4b.Location = new Point(diff4b.Location.X + 101, diff4b.Location.Y + 90);

                diff5b.Width = (int)(this.Width / 2.2) - diff5bOffssetWidth;
                diff5b.Height = (int)(this.Height / 2.1) - diff5bOffssetHeight;
                diff5b.Location = new Point(diff5b.Location.X + 98, diff5b.Location.Y + 70);
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            //next level
            MyTimer.Stop();
            differencesSecondLevel secondLevel = new differencesSecondLevel();
            secondLevel.Show();
            this.Close();
        }

        private bool dragging = false;
        private Point offset;

        private void differencesFirstLevel_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;

            this.offset = new Point(e.X, e.Y);
        }

        private void differencesFirstLevel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void differencesFirstLevel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)

                this.Location = new Point(this.Left - (this.offset.X - e.X), this.Top - (this.offset.Y - e.Y));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu main = new mainMenu(true);
            main.Show();
        }

        private void diff5b_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff5b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff5a.Image = myImage;
            diff5a.Enabled = false;
            diff5b.Enabled = false;
            checkWin();
        }

        private void diff1a_Click_2(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff1b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff1a.Image = myImage;
            diff1a.Enabled = false;
            diff1b.Enabled = false;
            checkWin();
        }

        private void diff1b_Click_2(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff1b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff1a.Image = myImage;
            diff1a.Enabled = false;
            diff1b.Enabled = false;
            checkWin();
        }

        private void diff2a_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff2b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff2a.Image = myImage;
            diff2a.Enabled = false;
            diff2b.Enabled = false;
            checkWin();
        }

        private void diff5a_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff5b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff5a.Image = myImage;
            diff5a.Enabled = false;
            diff5b.Enabled = false;
            checkWin();
        }

        private void diff3a_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff3b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff3a.Image = myImage;
            diff3a.Enabled = false;
            diff3b.Enabled = false;
            checkWin();

        }

        private void diff4a_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff4b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff4a.Image = myImage;
            diff4a.Enabled = false;
            diff4b.Enabled = false;
            checkWin();
        }

        private void diff2b_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff2b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff2a.Image = myImage;
            diff2a.Enabled = false;
            diff2b.Enabled = false;
            checkWin();
        }

        private void diff3b_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff3b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff3a.Image = myImage;
            diff3a.Enabled = false;
            diff3b.Enabled = false;
            checkWin();
        }

        private void diff4b_Click_1(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff4b.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff4a.Image = myImage;
            diff4a.Enabled = false;
            diff4b.Enabled = false;
            checkWin();

        }
    }
}
