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
        private int differences = 6;
        ResourceManager rm = Resources.ResourceManager;

        public differencesSecondLevel()
        {
            InitializeComponent();
            finish_button.Visible = false;
            InitializePictureBoxBackColor();
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
            
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            mainMenu mainPage = new mainMenu();
            mainPage.Show();
            this.Close();
        }

        private void checkWin()
        {
            if (differences == 0)
            {
                finish_button.Visible = true;
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
            mainMenu mainPage = new mainMenu();
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
    }
}
