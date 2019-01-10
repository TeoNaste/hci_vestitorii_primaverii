using hci_vestitorii_primaverii.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace hci_vestitorii_primaverii
{
    public partial class FindTheBee : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private Timer MyTimer;
        int toFind = 3;
        Dictionary<Bitmap, List<PictureBox>> images;
        Random r = new Random();

        public FindTheBee()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_albine.aac";
            audioVA.settings.volume = 100;
            disablePictureBoxes();
            images = new Dictionary<Bitmap, List<PictureBox>>();
            initializeDict();

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 800f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 450f;

            SizeF scale = new SizeF(widthRatio, heightRatio);

            this.Scale(scale);

            close_button.Width = (int)(close_button.Width / widthRatio);
            close_button.Height = (int)(close_button.Height / heightRatio);

            close_button.Location = new Point((int)(close_button.Location.X + close_button.Width), (int)(close_button.Location.Y));

        }

	private void initializeDict()
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("flori_bg");
            List<PictureBox> list = new List<PictureBox>();
            list.Add(bee1_1); list.Add(bee1_2); list.Add(bee1_3);
            images.Add(myImage, list);

            myImage = (Bitmap)Resources.ResourceManager.GetObject("flori_bg2");
            List<PictureBox> list2 = new List<PictureBox>();
            list2.Add(bee2_1); list2.Add(bee2_2); list2.Add(bee2_3);
            images.Add(myImage, list2);

        }

        private void disablePictureBoxes()
        {
            bee1_1.Visible = false;
            bee1_2.Visible = false;
            bee1_3.Visible = false;
            bee2_1.Visible = false;
            bee2_2.Visible = false;
            bee2_3.Visible = false;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindTheBee_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (17 * 1000);
            MyTimer.Tick += new EventHandler(play_game);
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void play_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            infoBox.Visible = false;
            infoBox.Visible = false;
            int rInt = r.Next(0, images.Count);
            Bitmap image = images.Keys.ElementAt(rInt);
            this.BackgroundImage = image;
            foreach (PictureBox pic in images[image])
            {
                pic.Visible = true;
            }
            audioVA.URL = "audio//cauta_3_albine.aac";
            audioVA.controls.play();
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void bee1_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            bee1_1.Image = myImage;
            bee2_1.Image = myImage;
            toFind--;
            bee1_1.Enabled = false;
            bee2_1.Enabled = false;
            audio_feedback();
        }

        private void bee2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            bee1_2.Image = myImage;
            bee2_2.Image = myImage;
            toFind--;
            bee1_2.Enabled = false;
            bee2_2.Enabled = false;
            audio_feedback();
        }

        private void bee3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            bee1_3.Image = myImage;
            bee2_3.Image = myImage;
            toFind--;
            bee1_3.Enabled = false;
            bee2_3.Enabled = false;
            audio_feedback();
        }

        private void audio_feedback()
        {
            if (toFind == 2)
            {
                audioVA.URL = "audio//inca_2_albine.aac";
                audioVA.controls.play();
            }
            if (toFind == 1)
            {
                audioVA.URL = "audio//inca_una_si_ai_reusit.aac";
                audioVA.controls.play();
            }
            if (toFind == 0)
            {
                audioVA.URL = "audio//asa_ca_palpitant.aac";
                audioVA.controls.play();
                MyTimer = new Timer();
                MyTimer.Interval = (5 * 1000);
                MyTimer.Tick += new EventHandler(next_game);
                MyTimer.Start();
            }
        }

        private void next_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
        }

        private void infoBox_Click_1(object sender, EventArgs e)
        {

        }
    }
}
