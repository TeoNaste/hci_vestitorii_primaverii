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
    public partial class differencesSecondLevel : Form
    {
        private int differences = 7;
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
            diff4aOffssetWidth, diff4aOffssetHeight, diff5aOffssetWidth, diff5aOffssetHeight, diff6aOffssetWidth, diff6aOffssetHeight,
            diff7aOffssetWidth, diff7aOffssetHeight;

        int diff1bOffssetWidth, diff1bOffssetHeight, diff2bOffssetWidth, diff2bOffssetHeight, diff3bOffssetWidth, diff3bOffssetHeight,
            diff4bOffssetWidth, diff4bOffssetHeight, diff5bOffssetWidth, diff5bOffssetHeight, diff6bOffssetWidth, diff6bOffssetHeight,
            diff7bOffssetWidth, diff7bOffssetHeight;


        public differencesSecondLevel()
        {
            InitializeComponent();
            finish_button.Visible = false;
            minieKiss.Visible = false;

            InitializePictureBoxBackColor();

            pictureBox1OffestWidth = this.Width - pictureBox1.Width;
            pictureBox1OffestHeight = this.Height - pictureBox1.Height;

            pictureBox3OffestWidth = this.Width - pictureBox3.Width;
            pictureBox3OffestHeight = this.Height - pictureBox3.Height;

            closeButtonOffestWidth = this.Width - close_button.Width;
            closeButtonOffsetHeight = this.Height - close_button.Height;

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

            diff6aOffssetWidth = this.Width - diff6a.Width;
            diff6aOffssetHeight = this.Height - diff6a.Height;

            diff7aOffssetWidth = this.Width - diff7a.Width;
            diff7aOffssetHeight = this.Height - diff7a.Height;

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

            diff6bOffssetWidth = this.Width - diff6b.Width;
            diff6bOffssetHeight = this.Height - diff6b.Height;

            diff7bOffssetWidth = this.Width - diff7b.Width;
            diff7bOffssetHeight = this.Height - diff7b.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializePictureBoxBackColor()
        {
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
            
            diff6a.Parent = pictureBox1;
            diff6a.BackColor = Color.Transparent;
            
            diff6b.Parent = pictureBox1;
            diff6b.BackColor = Color.Transparent;

            diff7a.Parent = pictureBox1;
            diff7a.BackColor = Color.Transparent;

            diff7b.Parent = pictureBox1;
            diff7b.BackColor = Color.Transparent;
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkWin()
        {
            MyTimer = new Timer();
            MyTimer.Interval = (4 * 1000);
            MyTimer.Tick += new EventHandler(finish_button_Click);
            if (differences == 0)
            {
                minieKiss.Visible = true;
                MyTimer.Start();
            }
        }

        private void diff1a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff1b.Image = myImage;
            diff1a.Image = myImage;
            diff1a.Enabled = false;
            diff1b.Enabled = false;
            checkWin();
        }

        private void diff3a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff3b.Image = myImage;
            diff3a.Image = myImage;
            diff3a.Enabled = false;
            diff3b.Enabled = false;
            checkWin();
        }

        private void diff2a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff2b.Image = myImage;
            diff2a.Image = myImage;
            diff2a.Enabled = false;
            diff2b.Enabled = false;
            checkWin();
        }

        private void diff4a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff4b.Image = myImage;
            diff4a.Image = myImage;
            diff4a.Enabled = false;
            diff4b.Enabled = false;
            checkWin();
        }

        private void diff5a_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff5b.Image = myImage;
            diff5a.Image = myImage;
            diff5a.Enabled = false;
            diff5b.Enabled = false;
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

        private void diff1b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff1b.Image = myImage;
            diff1a.Image = myImage;
            diff1a.Enabled = false;
            diff1b.Enabled = false;
            checkWin();
        }

        private void diff3b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff3b.Image = myImage;
            diff3a.Image = myImage;
            diff3a.Enabled = false;
            diff3b.Enabled = false;
            checkWin();
        }

        private void diff2b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff2b.Image = myImage;
            diff2a.Image = myImage;
            diff2a.Enabled = false;
            diff2b.Enabled = false;
            checkWin();
        }

        private void diff4b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff4b.Image = myImage;
            diff4a.Image = myImage;
            diff4a.Enabled = false;
            diff4b.Enabled = false;
            checkWin();
        }

        private void diff5b_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)rm.GetObject("redBorder");
            differences--;
            rimainingDifferences.Text = differences.ToString();
            diff5b.Image = myImage;
            diff5a.Image = myImage;
            diff5a.Enabled = false;
            diff5b.Enabled = false;
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

        private void finish_button_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            mainMenu mainPage = new mainMenu(true);
            mainPage.Show();
            this.Close();
        }

        private bool dragging = false;
        private Point offset;

        private void differencesSecondLevel_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;

            this.offset = new Point(e.X, e.Y);
        }

        private void differencesSecondLevel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)

                this.Location = new Point(this.Left - (this.offset.X - e.X), this.Top - (this.offset.Y - e.Y));
        }

        private void differencesSecondLevel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
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

        private void back_button_Click(object sender, EventArgs e)
        {
            mainMenu mainPage = new mainMenu(true);
            mainPage.Show();
            this.Close();
        }

        private void differencesSecondLevel_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pictureBox1.Width = (int)(this.Width / 1.5) - pictureBox1OffestWidth;
                pictureBox1.Height = (int)(this.Height / 1.2) - pictureBox1OffestHeight;

                pictureBox3.Width = (int)(this.Width / 1.5) - pictureBox3OffestWidth;
                pictureBox3.Height = (int)(this.Height / 1.5) - pictureBox3OffestHeight;
                pictureBox3.Location = new Point(pictureBox3.Location.X + 190, pictureBox3.Location.Y + 90);

                close_button.Location = new Point(close_button.Location.X + 280, close_button.Location.Y);

                minieKiss.Width = (int)(this.Width / 1.7) - minieKissOffestWidth;
                minieKiss.Height = (int)(this.Height / 1.7) - minieKissOffestHeight;
                minieKiss.Location = new Point(minieKiss.Location.X + 120, minieKiss.Location.Y + 100);

                diff1a.Width = (int)(this.Width / 2.3) - diff1aOffssetWidth;
                diff1a.Height = (int)(this.Height / 2.3) - diff1aOffssetHeight;
                diff1a.Location = new Point(diff1a.Location.X + 40, diff1a.Location.Y + 27);

                diff2a.Width = (int)(this.Width / 2.3) - diff2aOffssetWidth;
                diff2a.Height = (int)(this.Height / 2.3) - diff2aOffssetHeight;
                diff2a.Location = new Point(diff2a.Location.X + 8, diff2a.Location.Y + 42);

                diff3a.Width = (int)(this.Width / 2.3) - diff3aOffssetWidth;
                diff3a.Height = (int)(this.Height / 2.25) - diff3aOffssetHeight;
                diff3a.Location = new Point(diff3a.Location.X + 17, diff3a.Location.Y + 40);

                diff4a.Width = (int)(this.Width / 2.3) - diff4aOffssetWidth;
                diff4a.Height = (int)(this.Height / 2.25) - diff4aOffssetHeight;
                diff4a.Location = new Point(diff4a.Location.X, diff4a.Location.Y + 70);

                diff5a.Width = (int)(this.Width / 2.3) - diff5aOffssetWidth;
                diff5a.Height = (int)(this.Height / 2.25) - diff5aOffssetHeight;
                diff5a.Location = new Point(diff5a.Location.X + 21, diff5a.Location.Y + 70);

                diff6a.Width = (int)(this.Width / 2.3) - diff6aOffssetWidth;
                diff6a.Height = (int)(this.Height / 2.1) - diff6aOffssetHeight;
                diff6a.Location = new Point(diff6a.Location.X + 50, diff6a.Location.Y + 75);

                diff7a.Width = (int)(this.Width / 2.3) - diff7aOffssetWidth;
                diff7a.Height = (int)(this.Height / 2.1) - diff7aOffssetHeight;
                diff7a.Location = new Point(diff7a.Location.X + 30, diff7a.Location.Y + 75);

                diff1b.Width = (int)(this.Width / 2.3) - diff1bOffssetWidth;
                diff1b.Height = (int)(this.Height / 2.3) - diff1bOffssetHeight;
                diff1b.Location = new Point(diff1b.Location.X + 100, diff1b.Location.Y + 27);

                diff2b.Width = (int)(this.Width / 2.3) - diff2bOffssetWidth;
                diff2b.Height = (int)(this.Height / 2.3) - diff2bOffssetHeight;
                diff2b.Location = new Point(diff2b.Location.X + 68, diff2b.Location.Y + 42);

                diff3b.Width = (int)(this.Width / 2.3) - diff3bOffssetWidth;
                diff3b.Height = (int)(this.Height / 2.25) - diff3bOffssetHeight;
                diff3b.Location = new Point(diff3b.Location.X + 77, diff3b.Location.Y + 40);

                diff4b.Width = (int)(this.Width / 2.3) - diff4bOffssetWidth;
                diff4b.Height = (int)(this.Height / 2.25) - diff4bOffssetHeight;
                diff4b.Location = new Point(diff4b.Location.X + 60, diff4b.Location.Y + 70);

                diff5b.Width = (int)(this.Width / 2.3) - diff5bOffssetWidth;
                diff5b.Height = (int)(this.Height / 2.25) - diff5bOffssetHeight;
                diff5b.Location = new Point(diff5b.Location.X + 81, diff5b.Location.Y + 70);

                diff6b.Width = (int)(this.Width / 2.3) - diff6bOffssetWidth;
                diff6b.Height = (int)(this.Height / 2.1) - diff6bOffssetHeight;
                diff6b.Location = new Point(diff6b.Location.X + 110, diff6b.Location.Y + 75);

                diff7b.Width = (int)(this.Width / 2.3) - diff7bOffssetWidth;
                diff7b.Height = (int)(this.Height / 2.1) - diff7bOffssetHeight;
                diff7b.Location = new Point(diff7b.Location.X + 90, diff7b.Location.Y + 75);

            }
        }
    }
}
