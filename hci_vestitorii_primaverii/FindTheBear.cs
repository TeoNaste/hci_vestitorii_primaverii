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
    public partial class FindTheBear : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private Timer MyTimer;
        int toFind = 3;
        Dictionary<Bitmap, List<PictureBox>> images;
        Random r = new Random();

        public FindTheBear()
        {
            InitializeComponent();
            audioVA.URL = "audio//info_ursul.aac";
            disablePictureBoxes();
            images = new Dictionary<Bitmap, List<PictureBox>>();
            initializeDict();
        }

        private void disablePictureBoxes()
        {
            urs1_1.Visible = false;
            urs1_2.Visible = false;
            urs1_3.Visible = false;
            urs2_1.Visible = false;
            urs2_2.Visible = false;
            urs2_3.Visible = false;
            urs3_1.Visible = false;
            urs3_2.Visible = false;
            urs3_3.Visible = false;

        }

        private void initializeDict()
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("forest_bg");
            List<PictureBox> list = new List<PictureBox>();
            list.Add(urs1_1); list.Add(urs1_2); list.Add(urs1_3);
            images.Add(myImage, list);

            myImage = (Bitmap)Resources.ResourceManager.GetObject("forest_bg2");
            List<PictureBox> list2 = new List<PictureBox>();
            list2.Add(urs2_1); list2.Add(urs2_2); list2.Add(urs2_3);
            images.Add(myImage, list2);

            myImage = (Bitmap)Resources.ResourceManager.GetObject("forest_bg3");
            List<PictureBox> list3 = new List<PictureBox>();
            list3.Add(urs3_1); list3.Add(urs3_2); list3.Add(urs3_3);
            images.Add(myImage, list3);

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindTheBear_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = (23 * 1000);
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
            this.BackgroundImage = image ;
            foreach(PictureBox pic in images[image])
            {
                pic.Visible = true;
            }
            audioVA.URL = "audio//cauta_3_ursi.mp3";
            audioVA.controls.play();
        }

        private void infoBox_Click(object sender, EventArgs e)
        {
            //audioVA.controls.play();
        }

        private void urs1_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            urs1_1.Image = myImage;
            urs2_1.Image = myImage;
            urs3_1.Image = myImage;
            toFind--;
            urs1_1.Enabled = false;
            urs2_1.Enabled = false;
            urs3_1.Enabled = false;
            audio_feedback();
        }

        private void urs2_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            urs1_2.Image = myImage;
            urs2_2.Image = myImage;
            urs3_2.Image = myImage;
            toFind--;
            urs1_2.Enabled = false;
            urs2_2.Enabled = false;
            urs3_2.Enabled = false;
            audio_feedback();
        }

        private void urs3_Click(object sender, EventArgs e)
        {
            Bitmap myImage = (Bitmap)Resources.ResourceManager.GetObject("redBorder");
            urs1_3.Image = myImage;
            urs2_3.Image = myImage;
            urs3_3.Image = myImage;
            toFind--;
            urs1_3.Enabled = false;
            urs2_3.Enabled = false;
            urs3_3.Enabled = false;
            audio_feedback();
        }

        private void audio_feedback()
        {
            if(toFind == 2)
            {
                audioVA.URL = "audio//inca_2_ursi.aac";
                audioVA.controls.play();
            }
            if(toFind == 1)
            {
                audioVA.URL = "audio//inca_unul_de_gasit.aac";
                audioVA.controls.play();
            }
            if(toFind == 0)
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
            FindTheBarza findTheBarza = new FindTheBarza();
            findTheBarza.Show();
            this.Close();
        }
    }
}
