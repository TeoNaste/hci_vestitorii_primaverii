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
    public partial class FindTheBarza : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private Timer MyTimer;
        int toFind = 3;
        Dictionary<Bitmap,List<PictureBox>> images;
        Random r = new Random();

        public FindTheBarza()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_barza.aac";
            audioVA.settings.volume = 100;
            disablePictureBoxes();
            images = new Dictionary<Bitmap, List<PictureBox>>();
            initializeDict();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindTheBarza_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (27 * 1000);
            MyTimer.Tick += new EventHandler(play_game);
            audioVA.controls.play();
            MyTimer.Start();
        }

        private void play_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            infoBox.Visible = false;
            int rInt = r.Next(0, images.Count);
            Bitmap image = images.Keys.ElementAt(rInt);
            this.BackgroundImage = image;
            foreach (PictureBox pic in images[image])
            {
                pic.Visible = true;
            }
            audioVA.URL = "audio//cauta_3_berze.aac";
            audioVA.controls.play();
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
           // MyTimer.Stop();
           // audioVA.controls.play();
            //MyTimer.Start();
        }

        private void barza2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza1_2.Image = myImage;
            barza2_2.Image = myImage;
            barza3_2.Image = myImage;
            toFind--;
            barza1_2.Enabled = false;
            barza2_2.Enabled = false;
            barza3_2.Enabled = false;
            audio_feedback();
        }

        private void barza1_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza1_1.Image = myImage;
            barza2_1.Image = myImage;
            barza3_1.Image = myImage;
            toFind--;
            barza1_1.Enabled = false;
            barza2_1.Enabled = false;
            barza3_1.Enabled = false;
            audio_feedback();
        }

        private void barza3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            barza1_3.Image = myImage;
            barza2_3.Image = myImage;
            barza3_3.Image = myImage;
            toFind--;
            barza1_3.Enabled = false;
            barza2_3.Enabled = false;
            barza3_3.Enabled = false;
            audio_feedback();
        }

        private void audio_feedback()
        {
            if (toFind == 2)
            {
                audioVA.URL = "audio//inca_2_berze.aac";
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

        private void initializeDict()
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("village_bg");
            List<PictureBox> list = new List<PictureBox>();
            list.Add(barza1_1); list.Add(barza1_2); list.Add(barza1_3);
            images.Add(myImage, list);

            myImage = (Bitmap)Resources.ResourceManager.GetObject("village_bg2");
            List<PictureBox> list2 = new List<PictureBox>();
            list2.Add(barza2_1); list2.Add(barza2_2); list2.Add(barza2_3);
            images.Add(myImage, list2);

            myImage = (Bitmap)Resources.ResourceManager.GetObject("village_bg3");
            List<PictureBox> list3 = new List<PictureBox>();
            list3.Add(barza3_1); list3.Add(barza3_2); list3.Add(barza3_3);
            images.Add(myImage, list3);

        }

        private void disablePictureBoxes()
        {
            barza1_1.Visible = false;
            barza1_2.Visible = false;
            barza1_3.Visible = false;
            barza2_1.Visible = false;
            barza2_2.Visible = false;
            barza2_3.Visible = false;
            barza3_1.Visible = false;
            barza3_2.Visible = false;
            barza3_3.Visible = false;
        }

        private void next_game(object sender, EventArgs e)
        {
            MyTimer.Stop();
            FindTheBee findTheBee = new FindTheBee();
            findTheBee.Show();
            this.Close();
        }

        private void close_button_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
