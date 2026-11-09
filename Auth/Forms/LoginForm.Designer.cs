namespace Auth.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelAdvancedRounded1 = new Auth.Models.PanelAdvancedRounded();
            textBoxIconRounded2 = new Auth.Models.TextBoxIconRounded();
            textBoxIconRounded1 = new Auth.Models.TextBoxIconRounded();
            pictureBox1 = new PictureBox();
            panelAdvancedRounded1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelAdvancedRounded1
            // 
            panelAdvancedRounded1.BackColor = Color.White;
            panelAdvancedRounded1.BorderColor = Color.White;
            panelAdvancedRounded1.BottomLeftRadius = 0;
            panelAdvancedRounded1.BottomRightRadius = 200;
            panelAdvancedRounded1.Controls.Add(textBoxIconRounded2);
            panelAdvancedRounded1.Controls.Add(textBoxIconRounded1);
            panelAdvancedRounded1.Controls.Add(pictureBox1);
            panelAdvancedRounded1.Location = new Point(0, 0);
            panelAdvancedRounded1.Name = "panelAdvancedRounded1";
            panelAdvancedRounded1.Size = new Size(640, 632);
            panelAdvancedRounded1.TabIndex = 0;
            panelAdvancedRounded1.TopLeftRadius = 0;
            panelAdvancedRounded1.TopRightRadius = 0;
            // 
            // textBoxIconRounded2
            // 
            textBoxIconRounded2.BackColor = Color.White;
            textBoxIconRounded2.Location = new Point(30, 257);
            textBoxIconRounded2.Name = "textBoxIconRounded2";
            textBoxIconRounded2.Padding = new Padding(14, 10, 14, 10);
            textBoxIconRounded2.PlaceholderText = "Password";
            textBoxIconRounded2.Size = new Size(300, 36);
            textBoxIconRounded2.TabIndex = 2;
            // 
            // textBoxIconRounded1
            // 
            textBoxIconRounded1.BackColor = Color.White;
            textBoxIconRounded1.Location = new Point(30, 215);
            textBoxIconRounded1.Name = "textBoxIconRounded1";
            textBoxIconRounded1.Padding = new Padding(14, 10, 14, 10);
            textBoxIconRounded1.PlaceholderText = "Email";
            textBoxIconRounded1.Size = new Size(300, 36);
            textBoxIconRounded1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1262, 630);
            Controls.Add(panelAdvancedRounded1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1278, 713);
            MinimumSize = new Size(1278, 619);
            Name = "LoginForm";
            Text = "AuthApp";
            Load += LoginForm_Load;
            panelAdvancedRounded1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Models.PanelAdvancedRounded panelAdvancedRounded1;
        private PictureBox pictureBox1;
        private Models.TextBoxIconRounded textBoxIconRounded2;
        private Models.TextBoxIconRounded textBoxIconRounded1;
    }
}