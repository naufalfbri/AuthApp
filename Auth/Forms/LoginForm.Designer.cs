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
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            buttonRounded1 = new Auth.Models.ButtonRounded();
            label2 = new Label();
            label1 = new Label();
            textBoxIconRounded2 = new Auth.Models.TextBoxIconRounded();
            textBoxIconRounded1 = new Auth.Models.TextBoxIconRounded();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panelAdvancedRounded1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelAdvancedRounded1
            // 
            panelAdvancedRounded1.BackColor = Color.White;
            panelAdvancedRounded1.BorderColor = Color.White;
            panelAdvancedRounded1.BottomLeftRadius = 0;
            panelAdvancedRounded1.BottomRightRadius = 200;
            panelAdvancedRounded1.Controls.Add(pictureBox2);
            panelAdvancedRounded1.Controls.Add(linkLabel1);
            panelAdvancedRounded1.Controls.Add(buttonRounded1);
            panelAdvancedRounded1.Controls.Add(label2);
            panelAdvancedRounded1.Controls.Add(label1);
            panelAdvancedRounded1.Controls.Add(textBoxIconRounded2);
            panelAdvancedRounded1.Controls.Add(textBoxIconRounded1);
            panelAdvancedRounded1.Controls.Add(pictureBox1);
            panelAdvancedRounded1.Controls.Add(label3);
            panelAdvancedRounded1.Controls.Add(label4);
            panelAdvancedRounded1.Location = new Point(0, 0);
            panelAdvancedRounded1.Name = "panelAdvancedRounded1";
            panelAdvancedRounded1.Size = new Size(640, 632);
            panelAdvancedRounded1.TabIndex = 0;
            panelAdvancedRounded1.TopLeftRadius = 0;
            panelAdvancedRounded1.TopRightRadius = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_Yayasan_Pendidikan_Telkom;
            pictureBox2.Location = new Point(30, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Firebrick;
            linkLabel1.Location = new Point(30, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa Kata Sandi?";
            // 
            // buttonRounded1
            // 
            buttonRounded1.BackColor = Color.Firebrick;
            buttonRounded1.BorderColor = Color.Transparent;
            buttonRounded1.ClickColor = Color.Maroon;
            buttonRounded1.FlatAppearance.BorderSize = 0;
            buttonRounded1.FlatStyle = FlatStyle.Flat;
            buttonRounded1.ForeColor = Color.White;
            buttonRounded1.HoverColor = Color.Maroon;
            buttonRounded1.Location = new Point(30, 400);
            buttonRounded1.Name = "buttonRounded1";
            buttonRounded1.Size = new Size(150, 40);
            buttonRounded1.TabIndex = 7;
            buttonRounded1.Text = "Masuk";
            buttonRounded1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 186);
            label2.Name = "label2";
            label2.Size = new Size(240, 22);
            label2.TabIndex = 4;
            label2.Text = "Silakan masuk dengan akun SSO Anda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 155);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(409, 37);
            label1.TabIndex = 3;
            label1.Text = "Selamat Datang di Portal SSO MyLMS";
            label1.Click += label1_Click;
            // 
            // textBoxIconRounded2
            // 
            textBoxIconRounded2.BackColor = Color.White;
            textBoxIconRounded2.BorderFocusColor = Color.Maroon;
            textBoxIconRounded2.BorderHoverColor = Color.Maroon;
            textBoxIconRounded2.Cursor = Cursors.IBeam;
            textBoxIconRounded2.Location = new Point(30, 307);
            textBoxIconRounded2.Name = "textBoxIconRounded2";
            textBoxIconRounded2.Padding = new Padding(14, 10, 14, 10);
            textBoxIconRounded2.PlaceholderText = "Massukan Kata Sandi";
            textBoxIconRounded2.Size = new Size(300, 36);
            textBoxIconRounded2.TabIndex = 2;
            textBoxIconRounded2.TextChanged += textBoxIconRounded2_TextChanged;
            // 
            // textBoxIconRounded1
            // 
            textBoxIconRounded1.BackColor = Color.White;
            textBoxIconRounded1.BorderFocusColor = Color.Maroon;
            textBoxIconRounded1.BorderHoverColor = Color.Maroon;
            textBoxIconRounded1.Cursor = Cursors.IBeam;
            textBoxIconRounded1.Location = new Point(30, 249);
            textBoxIconRounded1.Name = "textBoxIconRounded1";
            textBoxIconRounded1.Padding = new Padding(14, 10, 14, 10);
            textBoxIconRounded1.PlaceholderText = "Masukkan Email";
            textBoxIconRounded1.Size = new Size(300, 36);
            textBoxIconRounded1.TabIndex = 1;
            textBoxIconRounded1.TextChanged += textBoxIconRounded1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(239, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 230);
            label3.Name = "label3";
            label3.Size = new Size(42, 22);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 288);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 6;
            label4.Text = "Kata Sandi";
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
            panelAdvancedRounded1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Models.PanelAdvancedRounded panelAdvancedRounded1;
        private PictureBox pictureBox1;
        private Models.TextBoxIconRounded textBoxIconRounded2;
        private Models.TextBoxIconRounded textBoxIconRounded1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Models.ButtonRounded buttonRounded1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
    }
}