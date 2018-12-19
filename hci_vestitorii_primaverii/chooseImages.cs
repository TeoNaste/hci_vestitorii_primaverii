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
    public partial class chooseImages : Form
    {
        WindowsMediaPlayer audioVA = new WindowsMediaPlayer();
        private int imagesFound = 0;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;
        public chooseImages()
        {         
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox2.Image = imgMickeyThinking;
            pictureBox3.Image = imgMickeyThinking;
            audioVA.URL = "audio//3_imagini_primavara.aac";
            
            pictureBox4OffsetWidth = this.Width - pictureBox4.Width;
            pictureBox4OffsetHeight = this.Height - pictureBox4.Height;

            pictureBox1OffsetWidth = this.Width - pictureBox1.Width;
            pictureBox1OffsetHeight = this.Height - pictureBox1.Height;

            pictureBox2OffsetWidth = this.Width - pictureBox2.Width;
            pictureBox2OffsetHeight = this.Height - pictureBox2.Height;

            pictureBox3OffsetWidth = this.Width - pictureBox3.Width;
            pictureBox3OffsetHeight = this.Height - pictureBox3.Height;

            treeAutumnOffsetWidth = this.Width - treeautumn.Width;
            treeAutumnOffsetHeight = this.Height - treeautumn.Height;
            treeWinterOffsetWidth = this.Width - treewinter.Width;
            treeWinterOffsetHeight = this.Height - treewinter.Height;
            treeSpringOffsetWidth = this.Width - treespring.Width;
            treeSpringOffsetHeight = this.Height - treespring.Height;
            treeSummerOffsetWidth = this.Width - treesummer.Width;
            treeSummerOffsetHeight = this.Height - treesummer.Height;

            paneltreeAutumnOffsetWidth = this.Width - paneltreeautumn.Width;
            paneltreeAutumnOffsetHeight = this.Height - paneltreeautumn.Height;
            paneltreeWinterOffsetWidth = this.Width - paneltreewinter.Width;
            paneltreeWinterOffsetHeight = this.Height - paneltreewinter.Height;
            paneltreeSpringOffsetWidth = this.Width - paneltreespring.Width;
            paneltreeSpringOffsetHeight = this.Height - paneltreespring.Height;
            paneltreeSummerOffsetWidth = this.Width - paneltreesummer.Width;
            paneltreeSummerOffsetHeight = this.Height - paneltreesummer.Height;

            barzaOffsetWidth = this.Width - barza.Width;
            barzaOffsetHeight = this.Height - barza.Height;
            vulturOffsetWidth = this.Width - vultur.Width;
            vulturOffsetHeight = this.Height - vultur.Height;
            bufnitaOffsetWidth = this.Width - bufnita.Width;
            bufnitaOffsetHeight = this.Height - bufnita.Height;
            randunicaOffsetWidth = this.Width - randunica.Width;
            randunicaOffsetHeight = this.Height - randunica.Height;

            panelbarzaOffsetWidth = this.Width - panelbarza.Width;
            panelbarzaOffsetHeight = this.Height - panelbarza.Height;
            panelvulturOffsetWidth = this.Width - panelvultur.Width;
            panelvulturOffsetHeight = this.Height - panelvultur.Height;
            panelbufnitaOffsetWidth = this.Width - panelbufnita.Width;
            panelbufnitaOffsetHeight = this.Height - panelbufnita.Height;
            panelrandunicaOffsetWidth = this.Width - panelrandunica.Width;
            panelrandunicaOffsetHeight = this.Height - panelrandunica.Height;

            crizantemeOffsetWidth = this.Width -   crizanteme.Width;
            crizantemeOffsetHeight = this.Height - crizanteme.Height;
            flSoareluiOffsetWidth = this.Width - floareasoarelui.Width;
            flSoareluiOffsetHeight = this.Height - floareasoarelui.Height;
            trandafiriOffsetWidth = this.Width - trandafiri.Width;
            trandafiriOffsetHeight = this.Height - trandafiri.Height;
            ghioceiOffsetWidth = this.Width - ghiocei.Width;
            ghioceiOffsetHeight = this.Height - ghiocei.Height;

            panelcrizantemeOffsetWidth = this.Width - panelcrizanteme.Width;
            panelcrizantemeOffsetHeight = this.Height - panelcrizanteme.Height;
            panelflSoareluiOffsetWidth = this.Width - panelfloareasoarelui.Width;
            panelflSoareluiOffsetHeight = this.Height - panelfloareasoarelui.Height;
            paneltrandafiriOffsetWidth = this.Width - paneltrandafiri.Width;
            paneltrandafiriOffsetHeight = this.Height - paneltrandafiri.Height;
            panelghioceiOffsetWidth = this.Width - panelghiocei.Width;
            panelghioceiOffsetHeight = this.Height - panelghiocei.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            this.WindowState = FormWindowState.Maximized;

        }

        private void checkWin()
        {
            MyTimer = new Timer();
            MyTimer.Interval = (4 * 1000);
            MyTimer.Tick += new EventHandler(back_button_Click);
            if (imagesFound == 3)
            {
                MyTimer.Start();
            }

        }

        private void back_button_Click(object sender,EventArgs e)
        {
            MyTimer.Stop();
            mainMenu main = new mainMenu(true);
            main.Show();
            this.Close();
        }

        private void treewinter_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Red;
            paneltreeautumn.BackColor = Color.Transparent;
            paneltreesummer.BackColor = Color.Transparent;
            paneltreespring.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
        }

        private void treeautumn_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Transparent;
            paneltreeautumn.BackColor = Color.Red;
            paneltreesummer.BackColor = Color.Transparent;
            paneltreespring.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;

        }

        private void treespring_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Transparent;
            paneltreeautumn.BackColor = Color.Transparent;
            paneltreesummer.BackColor = Color.Transparent;
            paneltreespring.BackColor = Color.Green;
            imagesFound++;
            treespring.Enabled = false;
            treesummer.Enabled = false;
            treeautumn.Enabled = false;
            treewinter.Enabled = false;
            checkWin();
            pictureBox1.Image = imgMickeyHappy;


        }

        private void treesummer_Click(object sender, EventArgs e)
        {
            paneltreewinter.BackColor = Color.Transparent;
            paneltreeautumn.BackColor = Color.Transparent;
            paneltreesummer.BackColor = Color.Red;
            paneltreespring.BackColor = Color.Transparent;

            pictureBox1.Image = imgMickeyThinking;
       
        }

        private void cioara_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Red;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void randunica_Click(object sender, EventArgs e)
        {
           
            audioVA.URL = "audio//info_randunica.aac";
            audioVA.controls.play();

            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Green;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;
            imagesFound++;
            randunica.Enabled = false;
            vultur.Enabled = false;
            bufnita.Enabled = false;
            barza.Enabled = false;
            pictureBox2.Image = imgMickeyHappy;
            checkWin();
        }

        private void vultur_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Red;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void bufnita_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Transparent;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Red;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void crizanteme_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Red;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Transparent;

            pictureBox3.Image = imgMickeyThinking;
        }

        private void floareasoarelui_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Red;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Transparent;

            pictureBox3.Image = imgMickeyThinking;
        }

        private void trandafiri_Click(object sender, EventArgs e)
        {
            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Red;
            panelghiocei.BackColor = Color.Transparent;

            pictureBox3.Image = imgMickeyThinking;
        }

        private void ghiocei_Click(object sender, EventArgs e)
        {
            audioVA.URL = "audio//info_ghiocelul.aac";
            audioVA.controls.play();

            panelcrizanteme.BackColor = Color.Transparent;
            panelfloareasoarelui.BackColor = Color.Transparent;
            paneltrandafiri.BackColor = Color.Transparent;
            panelghiocei.BackColor = Color.Green;
            imagesFound++;
            ghiocei.Enabled = false;
            floareasoarelui.Enabled = false;
            trandafiri.Enabled = false;
            crizanteme.Enabled = false;
            checkWin();
            pictureBox3.Image = imgMickeyHappy;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
