namespace hci_vestitorii_primaverii
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.tree = new System.Windows.Forms.PictureBox();
            this.swallow_button = new System.Windows.Forms.PictureBox();
            this.start_snowdrop = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swallow_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_snowdrop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.Color.Transparent;
            this.tree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tree.Image = global::hci_vestitorii_primaverii.Properties.Resources.tree;
            this.tree.Location = new System.Drawing.Point(361, 132);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(154, 205);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 10;
            this.tree.TabStop = false;
            this.tree.Click += new System.EventHandler(this.tree_Click);
            this.tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tree_MouseClick);
            this.tree.MouseEnter += new System.EventHandler(this.tree_MouseEnter);
            this.tree.MouseLeave += new System.EventHandler(this.tree_MouseLeave);
            // 
            // swallow_button
            // 
            this.swallow_button.BackColor = System.Drawing.Color.Transparent;
            this.swallow_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swallow_button.Image = global::hci_vestitorii_primaverii.Properties.Resources.randunica_glow;
            this.swallow_button.Location = new System.Drawing.Point(253, 99);
            this.swallow_button.Name = "swallow_button";
            this.swallow_button.Size = new System.Drawing.Size(77, 109);
            this.swallow_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swallow_button.TabIndex = 9;
            this.swallow_button.TabStop = false;
            this.swallow_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.swallow_button_MouseClick);
            this.swallow_button.MouseEnter += new System.EventHandler(this.swallow_button_MouseEnter);
            this.swallow_button.MouseLeave += new System.EventHandler(this.swallow_button_MouseLeave);
            // 
            // start_snowdrop
            // 
            this.start_snowdrop.BackColor = System.Drawing.Color.Transparent;
            this.start_snowdrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start_snowdrop.BackgroundImage")));
            this.start_snowdrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_snowdrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_snowdrop.Image = global::hci_vestitorii_primaverii.Properties.Resources.glowing_snowdrop;
            this.start_snowdrop.Location = new System.Drawing.Point(286, 281);
            this.start_snowdrop.Name = "start_snowdrop";
            this.start_snowdrop.Size = new System.Drawing.Size(91, 91);
            this.start_snowdrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_snowdrop.TabIndex = 6;
            this.start_snowdrop.TabStop = false;
            this.start_snowdrop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start_snowdrop_MouseClick);
            this.start_snowdrop.MouseEnter += new System.EventHandler(this.start_snowdrop_MouseEnter);
            this.start_snowdrop.MouseLeave += new System.EventHandler(this.start_snowdrop_MouseLeave);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_button.ForeColor = System.Drawing.Color.Transparent;
            this.close_button.Image = global::hci_vestitorii_primaverii.Properties.Resources.close_button1;
            this.close_button.Location = new System.Drawing.Point(738, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(40, 42);
            this.close_button.TabIndex = 3;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = global::hci_vestitorii_primaverii.Properties.Resources.spring_background_2;
            this.pictureBox6.Location = new System.Drawing.Point(0, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(801, 451);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::hci_vestitorii_primaverii.Properties.Resources.spring_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_snowdrop);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.swallow_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.pictureBox6);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swallow_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_snowdrop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.PictureBox start_snowdrop;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox swallow_button;
        private System.Windows.Forms.PictureBox tree;
    }
}