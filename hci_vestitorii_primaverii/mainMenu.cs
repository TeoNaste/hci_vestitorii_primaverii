using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;


namespace hci_vestitorii_primaverii
{
    public partial class mainMenu : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();

        int pictureBox3OffestWidth;
        int pictureBox3OffestHeight;

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

            pictureBox3OffestWidth = this.Width - tree.Width;
            pictureBox3OffestHeight = this.Height - tree.Height;

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

            pictureBox6.Bounds = Screen.PrimaryScreen.Bounds;
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
            int i = 7;
            while (i>0)
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

        private void tree_MouseClick(object sender, MouseEventArgs e)
        {
            FindTheBear find = new FindTheBear();
            this.Hide();
            find.Show();
            audioVA.controls.stop();
        }

        private void tree_MouseEnter(object sender, EventArgs e)
        {
            tree.Size = new Size(tree.Width + 7, tree.Height  + 7);
        }

        private void tree_MouseLeave(object sender, EventArgs e)
        {
            int i = 7;
            while (i > 0)
            {
                tree.Width--;
                tree.Height--;
                Application.DoEvents();
                i--;
            }
        }

        private void pictureBox6_Resize(object sender, EventArgs e)
        {
            
        }

        private void mainMenu_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                tree.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 1.7) - pictureBox3OffestWidth;
                tree.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 1.5) - pictureBox3OffestHeight;
                //pictureBox3.Location = new Point(pictureBox3.Location.X + 190, pictureBox3.Location.Y + 90);
                tree.Location = new Point(Screen.PrimaryScreen.Bounds.Width - tree.Width*2 - tree.Width/4, Screen.PrimaryScreen.Bounds.Height - tree.Height - tree.Height/2 - tree.Height/8);

                close_button.Location = new Point(Screen.PrimaryScreen.Bounds.Width - close_button.Width, 0);

                start_snowdrop.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2) - startSnowDropOffsetWidth;
                start_snowdrop.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - startSnowDropOffestHeight;
                //start_snowdrop.Location = new Point(start_snowdrop.Location.X + 100, start_snowdrop.Location.Y + 100);
                start_snowdrop.Location = new Point(Screen.PrimaryScreen.Bounds.Width - tree.Width - tree.Width - start_snowdrop.Width, tree.Location.Y + tree.Height - start_snowdrop.Height/2);

                swallow_button.Width = (int)(Screen.PrimaryScreen.Bounds.Width / 2.2) - swallowButtonOffestWidth;
                swallow_button.Height = (int)(Screen.PrimaryScreen.Bounds.Height / 2) - swallowButtonOffestHidth;
                //swallow_button.Location = new Point(swallow_button.Location.X + 80, swallow_button.Location.Y + 50);
                swallow_button.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Width / 3.5) + swallow_button.Width / 4, swallow_button.Height + swallow_button.Height / 3);
            }
        }

        private void tree_Click(object sender, EventArgs e)
        {

        }
    }
}
