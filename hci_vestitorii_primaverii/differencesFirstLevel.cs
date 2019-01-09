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
        private int differences = 7;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();

        public differencesFirstLevel()
        {
            InitializeComponent();
            InitializePictureBoxBackColor();
            minieKiss.Visible = false;
            audioVA.URL = "audio//cele_7_dif.mp3";

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 800f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 450f;

            SizeF scale = new SizeF(widthRatio, heightRatio);

            this.Scale(scale);

            button1.Width = (int)(button1.Width / widthRatio);
            button1.Height = (int)(button1.Height / heightRatio);

            button1.Location = new Point((int)(button1.Location.X + button1.Width), (int)(button1.Location.Y));

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
            if (differences == 6)
            {
                audioVA.URL = "audio//inca_6_dif.aac";
                audioVA.controls.play();
            }
            if (differences == 5)
            {
                audioVA.URL = "audio//inca_5_dif.aac";
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

            diff6b.Parent = pictureBox1;
            diff6b.BackColor = Color.Transparent;

            diff6a.Parent = pictureBox1;
            diff6a.BackColor = Color.Transparent;

            diff7b.Parent = pictureBox1;
            diff7b.BackColor = Color.Transparent;

            diff7a.Parent = pictureBox1;
            diff7a.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void diff7a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff7a.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff7b.Image = myImage;
            diff7a.Enabled = false;
            diff7b.Enabled = false;
            checkWin();
        }

        private void diff7b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff7a.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff7b.Image = myImage;
            diff7a.Enabled = false;
            diff7b.Enabled = false;
            checkWin();
        }

        private void diff6a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff6a.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff6b.Image = myImage;
            diff6a.Enabled = false;
            diff6b.Enabled = false;
            checkWin();
        }

        private void diff6b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            diff6a.Image = myImage;
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff6b.Image = myImage;
            diff6a.Enabled = false;
            diff6b.Enabled = false;
            checkWin();
        }
    }
}
