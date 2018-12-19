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

namespace hci_vestitorii_primaverii
{
    public partial class differencesFirstLevel : Form
    {
        private int differences = 5;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;

        int pictureBox1OffestWidth;
        int pictureBox1OffestHeight;

        int pictureBox3OffestWidth;
        int pictureBox3OffestHeight;

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

            pictureBox1OffestWidth = this.Width - pictureBox1.Width;
            pictureBox1OffestHeight = this.Height - pictureBox1.Height;

            pictureBox3OffestWidth = this.Width - pictureBox3.Width;
            pictureBox3OffestHeight = this.Height - pictureBox3.Height;

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
            minieKiss.Visible = false;

        }

        private void differencesFirstLevel_Load(object sender, EventArgs e)
        {

        }

        private void checkWin()
        {
            MyTimer = new Timer();
            MyTimer.Interval = (4 * 1000);
            MyTimer.Tick += new EventHandler(play_button_Click);
            if (differences == 0)
            {
                minieKiss.Visible = true;
                MyTimer.Start();
            }
        }

        private void InitializePictureBoxBackColor()
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
             
            diff1a.Parent = pictureBox1;
            diff1a.BackColor = Color.Transparent;

            diff1b.Parent = pictureBox1;
            diff1b.BackColor = Color.Transparent;

            diff2a.Parent = pictureBox1;
            diff2a.BackColor = Color.Transparent;

            diff2b.Parent = pictureBox1;
            diff2b.BackColor = Color.Transparent;

            diff3a.Parent = pictureBox1;
            diff3a.BackColor = Color.Transparent;

            diff3b.Parent = pictureBox1;
            diff3b.BackColor = Color.Transparent;

            diff4a.Parent = pictureBox1;
            diff4a.BackColor = Color.Transparent;

            diff4b.Parent = pictureBox1;
            diff4b.BackColor = Color.Transparent;

            diff5a.Parent = pictureBox1;
            diff5a.BackColor = Color.Transparent;

            diff5b.Parent = pictureBox1;
            diff5b.BackColor = Color.Transparent;
        }

        private void diff1b_Click_1(object sender, EventArgs e)
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

        private void diff1a_Click_1(object sender, EventArgs e)
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

        private void diff2a_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diff2b_Click(object sender, EventArgs e)
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

        private void diff3a_Click(object sender, EventArgs e)
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

        private void diff5a_Click(object sender, EventArgs e)
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

        private void diff4a_Click(object sender, EventArgs e)
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

        private void diff3b_Click(object sender, EventArgs e)
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

        private void diff5b_Click(object sender, EventArgs e)
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

        private void diff4b_Click(object sender, EventArgs e)
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

        private void diff6a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff6b.Image = myImage;
            diff6a.Image = myImage;
            diff6a.Enabled = false;
            diff6b.Enabled = false;
            checkWin();

        }

        private void diff7a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff7b.Image = myImage;
            diff7a.Image = myImage;
            diff7a.Enabled = false;
            diff7b.Enabled = false;
            checkWin();
        }

        private void diff8a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff8b.Image = myImage;
            diff8a.Image = myImage;
            diff8a.Enabled = false;
            diff8b.Enabled = false;
            checkWin();
        }

        private void diff9a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff9b.Image = myImage;
            diff9a.Image = myImage;
            diff9a.Enabled = false;
            diff9b.Enabled = false;
            checkWin();
        }

        private void diff10a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff10b.Image = myImage;
            diff10a.Image = myImage;
            diff10a.Enabled = false;
            diff10b.Enabled = false;
            checkWin();
        }

        private void diff11a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff11b.Image = myImage;
            diff11a.Image = myImage;
            diff11a.Enabled = false;
            diff11b.Enabled = false;
            checkWin();
        }

        private void diff12a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff12b.Image = myImage;
            diff12a.Image = myImage;
            diff12a.Enabled = false;
            diff12b.Enabled = false;
            checkWin();
        }

        private void diff6b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff6b.Image = myImage;
            diff6a.Image = myImage;
            diff6a.Enabled = false;
            diff6b.Enabled = false;
            checkWin();
        }

        private void diff7b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff7b.Image = myImage;
            diff7a.Image = myImage;
            diff7a.Enabled = false;
            diff7b.Enabled = false;
            checkWin();
        }

        private void diff8b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff8b.Image = myImage;
            diff8a.Image = myImage;
            diff8a.Enabled = false;
            diff8b.Enabled = false;
            checkWin();
        }

        private void diff9b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff9b.Image = myImage;
            diff9a.Image = myImage;
            diff9a.Enabled = false;
            diff9b.Enabled = false;
            checkWin();
        }

        private void diff10b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff10b.Image = myImage;
            diff10a.Image = myImage;
            diff10a.Enabled = false;
            diff10b.Enabled = false;
            checkWin();
        }

        private void diff11b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff11b.Image = myImage;
            diff11a.Image = myImage;
            diff11a.Enabled = false;
            diff11b.Enabled = false;
            checkWin();
        }

        private void diff12b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff12b.Image = myImage;
            diff12a.Image = myImage;
            diff12a.Enabled = false;
            diff12b.Enabled = false;
            checkWin();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            mainMenu mainPage = new mainMenu();
            mainPage.Show();
            this.Close();
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
    }
}
