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

        public mainMenu()
        {
            InitializeComponent();
            player.URL = ".//Music//totoro.wav";
            player.settings.setMode("loop", true);
            player.settings.volume = 3;
            audioVA.settings.volume = 25;
            audioVA.URL = "audio//hai_sa_meniu.wav";
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
            start_snowdrop.Size = new Size(98, 96);
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

   
    }
}
