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
using System.Diagnostics;

namespace hci_vestitorii_primaverii
{
    public partial class chooseImages : Form
    {
        private int imagesFound = 0;
        private Timer MyTimer;
        ResourceManager rm = Resources.ResourceManager;
        Bitmap imgMickeyHappy = Properties.Resources.MickeyHappy;
        Bitmap imgMickeyThinking = Properties.Resources.MickeyThinking;


        int pictureBox4OffsetWidth;
        int pictureBox4OffsetHeight;

        int pictureBox1OffsetWidth;
        int pictureBox1OffsetHeight;

        int pictureBox2OffsetWidth;
        int pictureBox2OffsetHeight;

        int pictureBox3OffsetWidth;
        int pictureBox3OffsetHeight;

        int treeWinterOffsetWidth, treeWinterOffsetHeight, treeAutumnOffsetWidth, treeAutumnOffsetHeight, treeSpringOffsetWidth, treeSpringOffsetHeight,
            treeSummerOffsetWidth, treeSummerOffsetHeight;

        int paneltreeWinterOffsetWidth, paneltreeWinterOffsetHeight, paneltreeAutumnOffsetWidth, paneltreeAutumnOffsetHeight, paneltreeSpringOffsetWidth,
            paneltreeSpringOffsetHeight, paneltreeSummerOffsetWidth, paneltreeSummerOffsetHeight;

        int barzaOffsetWidth, barzaOffsetHeight, vulturOffsetWidth, vulturOffsetHeight, randunicaOffsetWidth, randunicaOffsetHeight, bufnitaOffsetWidth, bufnitaOffsetHeight;

        int panelbarzaOffsetWidth, panelbarzaOffsetHeight, panelvulturOffsetWidth, panelvulturOffsetHeight, panelrandunicaOffsetWidth, panelrandunicaOffsetHeight,
            panelbufnitaOffsetWidth, panelbufnitaOffsetHeight;

        int crizantemeOffsetWidth, crizantemeOffsetHeight, ghioceiOffsetWidth, ghioceiOffsetHeight, flSoareluiOffsetWidth, flSoareluiOffsetHeight,
            trandafiriOffsetWidth, trandafiriOffsetHeight;

        int panelcrizantemeOffsetWidth, panelcrizantemeOffsetHeight, panelghioceiOffsetWidth, panelghioceiOffsetHeight, panelflSoareluiOffsetWidth, 
            panelflSoareluiOffsetHeight, paneltrandafiriOffsetWidth, paneltrandafiriOffsetHeight;


        public chooseImages()
        {         
            InitializeComponent();
            pictureBox1.Image = imgMickeyThinking;
            pictureBox2.Image = imgMickeyThinking;
            pictureBox3.Image = imgMickeyThinking;

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
            mainMenu main = new mainMenu();
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

        private void barza_Click(object sender, EventArgs e)
        {
            panelbarza.BackColor = Color.Red;
            panelrandunica.BackColor = Color.Transparent;
            panelvultur.BackColor = Color.Transparent;
            panelbufnita.BackColor = Color.Transparent;

            pictureBox2.Image = imgMickeyThinking;
        }

        private void randunica_Click(object sender, EventArgs e)
        {
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

        

        private void chooseImages_Resize(object sender, EventArgs e)
        {
            pictureBox4.Width = (int)(this.Width / 1.5) - pictureBox4OffsetWidth;
            pictureBox4.Height = (int)(this.Height / 1.5) - pictureBox4OffsetHeight;
            pictureBox4.Location = new Point(pictureBox4.Location.X + 190, pictureBox4.Location.Y + 90);

            button1.Location = new Point(button1.Location.X + 280, button1.Location.Y);

            pictureBox1.Width = (int)(this.Width / 2.2) - pictureBox1OffsetWidth;
            pictureBox1.Height = (int)(this.Height / 1.7) - pictureBox1OffsetHeight;
            pictureBox1.Location = new Point(pictureBox1.Location.X + 125, pictureBox1.Location.Y);

            pictureBox2.Width = (int)(this.Width / 2.2) - pictureBox2OffsetWidth;
            pictureBox2.Height = (int)(this.Height / 1.7) - pictureBox2OffsetHeight;
            pictureBox2.Location = new Point(pictureBox2.Location.X + 125, pictureBox2.Location.Y + 55);

            pictureBox3.Width = (int)(this.Width / 2.2) - pictureBox3OffsetWidth;
            pictureBox3.Height = (int)(this.Height / 1.7) - pictureBox3OffsetHeight;
            pictureBox3.Location = new Point(pictureBox3.Location.X + 125 , pictureBox3.Location.Y + 110 );

            crizanteme.Width = (int)(this.Width / 2.2) - crizantemeOffsetWidth;
            crizanteme.Height = (int)(this.Height / 1.7) - crizantemeOffsetHeight;
            
            panelcrizanteme.Width = (int)(this.Width / 2.2) - panelcrizantemeOffsetWidth;
            panelcrizanteme.Height = (int)(this.Height / 1.7) - panelcrizantemeOffsetHeight;
            panelcrizanteme.Location = new Point(panelcrizanteme.Location.X, panelcrizanteme.Location.Y + 110);

            floareasoarelui.Width = (int)(this.Width / 2.2) - flSoareluiOffsetWidth;
            floareasoarelui.Height = (int)(this.Height / 1.7) - flSoareluiOffsetHeight;

            panelfloareasoarelui.Width = (int)(this.Width / 2.2) - panelflSoareluiOffsetWidth;
            panelfloareasoarelui.Height = (int)(this.Height / 1.7) - panelflSoareluiOffsetHeight;
            panelfloareasoarelui.Location = new Point(panelfloareasoarelui.Location.X + floareasoarelui.Width-20, panelfloareasoarelui.Location.Y + 110);

            trandafiri.Width = (int)(this.Width / 2.2) - trandafiriOffsetWidth;
            trandafiri.Height = (int)(this.Height / 1.7) - trandafiriOffsetHeight;

            paneltrandafiri.Width = (int)(this.Width / 2.2) - paneltrandafiriOffsetWidth;
            paneltrandafiri.Height = (int)(this.Height / 1.7) - paneltrandafiriOffsetHeight;
            paneltrandafiri.Location = new Point(paneltrandafiri.Location.X + trandafiri.Width + floareasoarelui.Width-45, paneltrandafiri.Location.Y + 110);

            ghiocei.Width = (int)(this.Width / 2.2) - ghioceiOffsetWidth;
            ghiocei.Height = (int)(this.Height / 1.7) - ghioceiOffsetHeight;

            panelghiocei.Width = (int)(this.Width / 2.2) - panelghioceiOffsetWidth;
            panelghiocei.Height = (int)(this.Height / 1.7) - panelghioceiOffsetHeight;
            panelghiocei.Location = new Point(panelghiocei.Location.X + ghiocei.Width+trandafiri.Width+floareasoarelui.Width-55, panelghiocei.Location.Y + 110);



            barza.Width = (int)(this.Width / 2.2) - barzaOffsetWidth;
            barza.Height = (int)(this.Height / 1.7) - barzaOffsetHeight;

            panelbarza.Width = (int)(this.Width / 2.2) - panelbarzaOffsetWidth;
            panelbarza.Height = (int)(this.Height / 1.7) - panelbarzaOffsetHeight;
            panelbarza.Location = new Point(panelbarza.Location.X, panelbarza.Location.Y + 55);

            randunica.Width = (int)(this.Width / 2.2) - randunicaOffsetWidth;
            randunica.Height = (int)(this.Height / 1.7) - randunicaOffsetHeight;

            panelrandunica.Width = (int)(this.Width / 2.2) - panelrandunicaOffsetWidth;
            panelrandunica.Height = (int)(this.Height / 1.7) - panelrandunicaOffsetHeight;
            panelrandunica.Location = new Point(panelrandunica.Location.X + randunica.Width - 20, panelrandunica.Location.Y + 55);

            vultur.Width = (int)(this.Width / 2.2) - vulturOffsetWidth;
            vultur.Height = (int)(this.Height / 1.7) - vulturOffsetHeight;

            panelvultur.Width = (int)(this.Width / 2.2) - panelvulturOffsetWidth;
            panelvultur.Height = (int)(this.Height / 1.7) - panelvulturOffsetHeight;
            panelvultur.Location = new Point(panelvultur.Location.X + vultur.Width + floareasoarelui.Width - 45, panelvultur.Location.Y + 55);

            bufnita.Width = (int)(this.Width / 2.2) - bufnitaOffsetWidth;
            bufnita.Height = (int)(this.Height / 1.7) - bufnitaOffsetHeight;

            panelbufnita.Width = (int)(this.Width / 2.2) - panelbufnitaOffsetWidth;
            panelbufnita.Height = (int)(this.Height / 1.7) - panelbufnitaOffsetHeight;
            panelbufnita.Location = new Point(panelbufnita.Location.X + bufnita.Width + trandafiri.Width + floareasoarelui.Width - 55, panelbufnita.Location.Y + 55);




            treewinter.Width = (int)(this.Width / 2.2) - treeWinterOffsetWidth;
            treewinter.Height = (int)(this.Height / 1.7) - treeWinterOffsetHeight;

            paneltreewinter.Width = (int)(this.Width / 2.2) - paneltreeWinterOffsetWidth;
            paneltreewinter.Height = (int)(this.Height / 1.7) - paneltreeWinterOffsetHeight;
            paneltreewinter.Location = new Point(paneltreewinter.Location.X, paneltreewinter.Location.Y + 0);

            treeautumn.Width = (int)(this.Width / 2.2) - treeAutumnOffsetWidth;
            treeautumn.Height = (int)(this.Height / 1.7) - treeAutumnOffsetHeight;

            paneltreeautumn.Width = (int)(this.Width / 2.2) - paneltreeAutumnOffsetWidth;
            paneltreeautumn.Height = (int)(this.Height / 1.7) - paneltreeAutumnOffsetHeight;
            paneltreeautumn.Location = new Point(paneltreeautumn.Location.X + treeautumn.Width - 15, paneltreeautumn.Location.Y + 0);

            treespring.Width = (int)(this.Width / 2.2) - treeSpringOffsetWidth;
            treespring.Height = (int)(this.Height / 1.7) - treeSpringOffsetHeight;

            paneltreespring.Width = (int)(this.Width / 2.2) - paneltreeSpringOffsetWidth;
            paneltreespring.Height = (int)(this.Height / 1.7) - paneltreeSpringOffsetHeight;
            paneltreespring.Location = new Point(paneltreespring.Location.X + treespring.Width + floareasoarelui.Width - 35, paneltreespring.Location.Y + 0);

            treesummer.Width = (int)(this.Width / 2.2) - treeSummerOffsetWidth;
            treesummer.Height = (int)(this.Height / 1.7) - treeSummerOffsetHeight;

            paneltreesummer.Width = (int)(this.Width / 2.2) - paneltreeSummerOffsetWidth;
            paneltreesummer.Height = (int)(this.Height / 1.7) - paneltreeSummerOffsetHeight;
            paneltreesummer.Location = new Point(paneltreesummer.Location.X + treesummer.Width + trandafiri.Width + floareasoarelui.Width - 55, paneltreesummer.Location.Y + 0);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
