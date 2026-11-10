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
            Passwordtxt = new Auth.Models.TextBoxIconRounded();
            Emailtxt = new Auth.Models.TextBoxIconRounded();
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
            panelAdvancedRounded1.BottomRightRadius = 50;
            panelAdvancedRounded1.Controls.Add(pictureBox2);
            panelAdvancedRounded1.Controls.Add(linkLabel1);
            panelAdvancedRounded1.Controls.Add(buttonRounded1);
            panelAdvancedRounded1.Controls.Add(label2);
            panelAdvancedRounded1.Controls.Add(label1);
            panelAdvancedRounded1.Controls.Add(Passwordtxt);
            panelAdvancedRounded1.Controls.Add(Emailtxt);
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
            linkLabel1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Firebrick;
            linkLabel1.Location = new Point(59, 351);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(112, 22);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa Kata Sandi?";
            // 
            // buttonRounded1
            // 
            buttonRounded1.BackColor = Color.Firebrick;
            buttonRounded1.BackgroundColor = Color.Firebrick;
            buttonRounded1.BorderColor = Color.Transparent;
            buttonRounded1.ClickColor = Color.Maroon;
            buttonRounded1.FlatAppearance.BorderSize = 0;
            buttonRounded1.FlatStyle = FlatStyle.Flat;
            buttonRounded1.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRounded1.ForeColor = Color.White;
            buttonRounded1.HoverColor = Color.Maroon;
            buttonRounded1.Location = new Point(59, 400);
            buttonRounded1.Name = "buttonRounded1";
            buttonRounded1.Size = new Size(150, 40);
            buttonRounded1.TabIndex = 7;
            buttonRounded1.Text = "Masuk";
            buttonRounded1.UseVisualStyleBackColor = false;
            buttonRounded1.Click += buttonRounded1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 186);
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
            label1.Location = new Point(59, 155);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(409, 37);
            label1.TabIndex = 3;
            label1.Text = "Selamat Datang di Portal SSO MyLMS";
            label1.Click += label1_Click;
            // 
            // Passwordtxt
            // 
            Passwordtxt.BackColor = Color.White;
            Passwordtxt.BorderFocusColor = Color.Maroon;
            Passwordtxt.BorderHoverColor = Color.Maroon;
            Passwordtxt.Cursor = Cursors.IBeam;
            Passwordtxt.Location = new Point(59, 307);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Padding = new Padding(14, 10, 14, 10);
            Passwordtxt.PasswordChar = '●';
            Passwordtxt.PlaceholderText = "Massukan Kata Sandi";
            Passwordtxt.Size = new Size(300, 36);
            Passwordtxt.TabIndex = 2;
            Passwordtxt.UseSystemPasswordChar = true;
            Passwordtxt.TextChanged += textBoxIconRounded2_TextChanged;
            // 
            // Emailtxt
            // 
            Emailtxt.BackColor = Color.White;
            Emailtxt.BorderFocusColor = Color.Maroon;
            Emailtxt.BorderHoverColor = Color.Maroon;
            Emailtxt.Cursor = Cursors.IBeam;
            Emailtxt.Location = new Point(59, 249);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Padding = new Padding(14, 10, 14, 10);
            Emailtxt.PlaceholderText = "Masukkan Email";
            Emailtxt.Size = new Size(300, 36);
            Emailtxt.TabIndex = 1;
            Emailtxt.TextChanged += textBoxIconRounded1_TextChanged;
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
            label3.Location = new Point(59, 230);
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
            label4.Location = new Point(59, 288);
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
            Text = "myLMS";
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
        private Models.TextBoxIconRounded Passwordtxt;
        private Models.TextBoxIconRounded Emailtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Models.ButtonRounded buttonRounded1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
    }
}