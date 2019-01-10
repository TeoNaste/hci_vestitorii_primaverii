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

        public mainMenu(bool isBack)
        {
            InitializeComponent();
            
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 800f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 450f;

            SizeF scale = new SizeF(widthRatio, heightRatio);
            
            this.Scale(scale);

            close_button.Width = (int)(close_button.Width / widthRatio);
            close_button.Height = (int) (close_button.Height / heightRatio);

            close_button.Location = new Point((int)(close_button.Location.X+close_button.Width), (int)(close_button.Location.Y));
            

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
                audioVA.settings.volume = 100;
            }
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
            start_snowdrop.Size = new Size(start_snowdrop.Width + 7, start_snowdrop.Height + 7);
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
            while (i > 0)
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
            audioVA.controls.stop();
            find.Show();
        }

        private void tree_MouseEnter(object sender, EventArgs e)
        {
            tree.Size = new Size(tree.Width + 7, tree.Height + 7);
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
    }
}
