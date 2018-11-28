using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace hci_vestitorii_primaverii
{
    public partial class mainMenu : Form
    {

        public mainMenu()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_snowdrop_MouseEnter(object sender, EventArgs e)
        {
            //start_snowdrop.Size = new Size(94, 92);
        }

        private void start_snowdrop_MouseLeave(object sender, EventArgs e)
        {

            while (start_snowdrop.Width > 91 && start_snowdrop.Height > 91)
            {
                start_snowdrop.Width--;
                start_snowdrop.Height--;
                Application.DoEvents();
            }

        }

        private void play_button_Click(object sender, EventArgs e)
        {
            //open the game forum i guess
            differencesFirstLevel f1 = new differencesFirstLevel();
            this.Hide();
            f1.Show();
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

        /**  private void start_button_MouseEnter(object sender, EventArgs e)
          {
              start_button.Size = new Size(148, 136);
          }

          private void start_button_MouseLeave(object sender, EventArgs e)
          {
              while (start_button.Width > 144)
              {
                  start_button.Width--;
                  start_button.Height--;
                  Application.DoEvents();
              }
          }**/

    }
}
