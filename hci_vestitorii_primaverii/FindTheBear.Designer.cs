namespace hci_vestitorii_primaverii
{
    partial class FindTheBear
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
            this.urs1 = new System.Windows.Forms.PictureBox();
            this.urs2 = new System.Windows.Forms.PictureBox();
            this.urs3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urs3)).BeginInit();
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
            this.close_button.TabIndex = 4;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // infoBox
            // 
            this.infoBox.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.urs_barlog;
            this.infoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBox.Location = new System.Drawing.Point(160, 108);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(457, 279);
            this.infoBox.TabIndex = 5;
            this.infoBox.TabStop = false;
            this.infoBox.Click += new System.EventHandler(this.infoBox_Click);
            // 
            // urs1
            // 
            this.urs1.BackColor = System.Drawing.Color.Transparent;
            this.urs1.Location = new System.Drawing.Point(454, 200);
            this.urs1.Name = "urs1";
            this.urs1.Size = new System.Drawing.Size(173, 155);
            this.urs1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urs1.TabIndex = 6;
            this.urs1.TabStop = false;
            this.urs1.Click += new System.EventHandler(this.urs1_Click);
            // 
            // urs2
            // 
            this.urs2.BackColor = System.Drawing.Color.Transparent;
            this.urs2.Location = new System.Drawing.Point(688, 150);
            this.urs2.Name = "urs2";
            this.urs2.Size = new System.Drawing.Size(100, 100);
            this.urs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urs2.TabIndex = 7;
            this.urs2.TabStop = false;
            this.urs2.Click += new System.EventHandler(this.urs2_Click);
            // 
            // urs3
            // 
            this.urs3.BackColor = System.Drawing.Color.Transparent;
            this.urs3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urs3.Location = new System.Drawing.Point(-5, 188);
            this.urs3.Name = "urs3";
            this.urs3.Size = new System.Drawing.Size(100, 109);
            this.urs3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urs3.TabIndex = 8;
            this.urs3.TabStop = false;
            this.urs3.Click += new System.EventHandler(this.urs3_Click);
            // 
            // FindTheBear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.spring_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.urs3);
            this.Controls.Add(this.urs2);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.urs1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindTheBear";
            this.Text = "FindTheObject";
            this.Load += new System.EventHandler(this.FindTheBear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urs3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox infoBox;
        private System.Windows.Forms.PictureBox urs1;
        private System.Windows.Forms.PictureBox urs2;
        private System.Windows.Forms.PictureBox urs3;
    }
}