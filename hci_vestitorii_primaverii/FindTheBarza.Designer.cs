namespace hci_vestitorii_primaverii
{
    partial class FindTheBarza
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
            this.infoBox = new System.Windows.Forms.PictureBox();
            this.barza1 = new System.Windows.Forms.PictureBox();
            this.barza2 = new System.Windows.Forms.PictureBox();
            this.barza3 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barza2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barza3)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.berze;
            this.infoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoBox.Location = new System.Drawing.Point(188, 105);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(398, 287);
            this.infoBox.TabIndex = 6;
            this.infoBox.TabStop = false;
            this.infoBox.Click += new System.EventHandler(this.infoBox_Click);
            // 
            // barza1
            // 
            this.barza1.BackColor = System.Drawing.Color.Transparent;
            this.barza1.Location = new System.Drawing.Point(143, 43);
            this.barza1.Name = "barza1";
            this.barza1.Size = new System.Drawing.Size(136, 103);
            this.barza1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barza1.TabIndex = 7;
            this.barza1.TabStop = false;
            this.barza1.Click += new System.EventHandler(this.barza1_Click);
            // 
            // barza2
            // 
            this.barza2.BackColor = System.Drawing.Color.Transparent;
            this.barza2.Location = new System.Drawing.Point(179, 348);
            this.barza2.Name = "barza2";
            this.barza2.Size = new System.Drawing.Size(100, 90);
            this.barza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barza2.TabIndex = 8;
            this.barza2.TabStop = false;
            this.barza2.Click += new System.EventHandler(this.barza2_Click);
            // 
            // barza3
            // 
            this.barza3.BackColor = System.Drawing.Color.Transparent;
            this.barza3.Location = new System.Drawing.Point(663, 285);
            this.barza3.Name = "barza3";
            this.barza3.Size = new System.Drawing.Size(100, 164);
            this.barza3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barza3.TabIndex = 9;
            this.barza3.TabStop = false;
            this.barza3.Click += new System.EventHandler(this.barza3_Click);
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
            this.close_button.TabIndex = 10;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click_1);
            // 
            // FindTheBarza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.spring_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.barza3);
            this.Controls.Add(this.barza2);
            this.Controls.Add(this.barza1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindTheBarza";
            this.Text = "FindTheBarza";
            this.Load += new System.EventHandler(this.FindTheBarza_Load);
            this.Resize += new System.EventHandler(this.FindTheBarza_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barza2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barza3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox infoBox;
        private System.Windows.Forms.PictureBox barza1;
        private System.Windows.Forms.PictureBox barza2;
        private System.Windows.Forms.PictureBox barza3;
        private System.Windows.Forms.Button close_button;
    }
}