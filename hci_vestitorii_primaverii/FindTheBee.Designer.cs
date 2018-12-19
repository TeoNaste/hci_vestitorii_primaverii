namespace hci_vestitorii_primaverii
{
    partial class FindTheBee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close_button = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.PictureBox();
            this.bee1 = new System.Windows.Forms.PictureBox();
            this.bee2 = new System.Windows.Forms.PictureBox();
            this.bee3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee3)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_button.ForeColor = System.Drawing.Color.Transparent;
            this.close_button.Image = global::hci_vestitorii_primaverii.Properties.Resources.close_button1;
            this.close_button.Location = new System.Drawing.Point(748, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(40, 42);
            this.close_button.TabIndex = 11;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.bees;
            this.infoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBox.Location = new System.Drawing.Point(183, 106);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(420, 287);
            this.infoBox.TabIndex = 12;
            this.infoBox.TabStop = false;
            // 
            // bee1
            // 
            this.bee1.BackColor = System.Drawing.Color.Transparent;
            this.bee1.Location = new System.Drawing.Point(103, 195);
            this.bee1.Name = "bee1";
            this.bee1.Size = new System.Drawing.Size(74, 81);
            this.bee1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bee1.TabIndex = 13;
            this.bee1.TabStop = false;
            this.bee1.Click += new System.EventHandler(this.bee1_Click);
            // 
            // bee2
            // 
            this.bee2.BackColor = System.Drawing.Color.Transparent;
            this.bee2.Location = new System.Drawing.Point(571, 353);
            this.bee2.Name = "bee2";
            this.bee2.Size = new System.Drawing.Size(99, 70);
            this.bee2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bee2.TabIndex = 14;
            this.bee2.TabStop = false;
            this.bee2.Click += new System.EventHandler(this.bee2_Click);
            // 
            // bee3
            // 
            this.bee3.BackColor = System.Drawing.Color.Transparent;
            this.bee3.Location = new System.Drawing.Point(628, 34);
            this.bee3.Name = "bee3";
            this.bee3.Size = new System.Drawing.Size(77, 66);
            this.bee3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bee3.TabIndex = 15;
            this.bee3.TabStop = false;
            this.bee3.Click += new System.EventHandler(this.bee3_Click);
            // 
            // FindTheBee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.spring_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bee3);
            this.Controls.Add(this.bee1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.bee2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindTheBee";
            this.Text = "FindTheBee";
            this.Load += new System.EventHandler(this.FindTheBee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bee3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox infoBox;
        private System.Windows.Forms.PictureBox bee1;
        private System.Windows.Forms.PictureBox bee2;
        private System.Windows.Forms.PictureBox bee3;
    }
}