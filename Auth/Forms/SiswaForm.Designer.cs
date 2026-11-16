using Auth.Components;

namespace Auth.Forms
{
    partial class SiswaForm
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
            buttonRounded1 = new ButtonRounded();
            panelRounded1 = new PanelRounded();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            buttonRounded7 = new ButtonRounded();
            pictureBox1 = new PictureBox();
            buttonRounded6 = new ButtonRounded();
            buttonRounded5 = new ButtonRounded();
            panelRounded2 = new PanelRounded();
            pictureBox3 = new PictureBox();
            panelRounded3 = new PanelRounded();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            panelRounded1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRounded2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelRounded3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRounded1
            // 
            buttonRounded1.BackColor = Color.FromArgb(178, 34, 34);
            buttonRounded1.BackgroundColor = Color.FromArgb(178, 34, 34);
            buttonRounded1.BorderColor = Color.FromArgb(178, 34, 34);
            buttonRounded1.BorderRadius = 20;
            buttonRounded1.BorderSize = 0;
            buttonRounded1.ClickColor = Color.FromArgb(145, 25, 25);
            buttonRounded1.FlatStyle = FlatStyle.Flat;
            buttonRounded1.ForeColor = Color.White;
            buttonRounded1.HoverColor = Color.FromArgb(205, 55, 55);
            buttonRounded1.Location = new Point(0, 0);
            buttonRounded1.Name = "buttonRounded1";
            buttonRounded1.Size = new Size(150, 40);
            buttonRounded1.TabIndex = 0;
            buttonRounded1.UseVisualStyleBackColor = false;
            // 
            // panelRounded1
            // 
            panelRounded1.BackColor = Color.Firebrick;
            panelRounded1.BorderColor = Color.Transparent;
            panelRounded1.Controls.Add(label4);
            panelRounded1.Controls.Add(pictureBox2);
            panelRounded1.Controls.Add(label3);
            panelRounded1.Controls.Add(label2);
            panelRounded1.Location = new Point(31, 192);
            panelRounded1.Margin = new Padding(4, 5, 4, 5);
            panelRounded1.Name = "panelRounded1";
            panelRounded1.Size = new Size(604, 223);
            panelRounded1.TabIndex = 3;
            panelRounded1.Paint += panelRounded1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 65);
            label4.TabIndex = 5;
            label4.Text = "0%";
            label4.Click += this.label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Simple_Line;
            pictureBox2.Location = new Point(355, 105);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 80);
            label3.Margin = new Padding(0, 5, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 28);
            label3.TabIndex = 1;
            label3.Text = "Cek persentase nilai pelajaran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 30);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 45);
            label2.TabIndex = 0;
            label2.Text = "Nilai Siswa";
            label2.Click += label2_Click;
            // 
            // buttonRounded7
            // 
            buttonRounded7.BackColor = Color.FromArgb(178, 34, 34);
            buttonRounded7.BackgroundColor = Color.FromArgb(178, 34, 34);
            buttonRounded7.BorderColor = Color.FromArgb(178, 34, 34);
            buttonRounded7.BorderRadius = 20;
            buttonRounded7.BorderSize = 0;
            buttonRounded7.ClickColor = Color.FromArgb(145, 25, 25);
            buttonRounded7.FlatStyle = FlatStyle.Flat;
            buttonRounded7.ForeColor = Color.White;
            buttonRounded7.HoverColor = Color.FromArgb(205, 55, 55);
            buttonRounded7.Location = new Point(0, 0);
            buttonRounded7.Name = "buttonRounded7";
            buttonRounded7.Size = new Size(150, 40);
            buttonRounded7.TabIndex = 0;
            buttonRounded7.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Telkom_Logo;
            pictureBox1.Location = new Point(17, 22);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonRounded6
            // 
            buttonRounded6.BackColor = Color.FromArgb(178, 34, 34);
            buttonRounded6.BackgroundColor = Color.FromArgb(178, 34, 34);
            buttonRounded6.BorderColor = Color.FromArgb(178, 34, 34);
            buttonRounded6.BorderRadius = 20;
            buttonRounded6.BorderSize = 0;
            buttonRounded6.ClickColor = Color.FromArgb(145, 25, 25);
            buttonRounded6.FlatStyle = FlatStyle.Flat;
            buttonRounded6.ForeColor = Color.White;
            buttonRounded6.HoverColor = Color.FromArgb(205, 55, 55);
            buttonRounded6.Location = new Point(0, 0);
            buttonRounded6.Name = "buttonRounded6";
            buttonRounded6.Size = new Size(150, 40);
            buttonRounded6.TabIndex = 0;
            buttonRounded6.UseVisualStyleBackColor = false;
            // 
            // buttonRounded5
            // 
            buttonRounded5.BackColor = Color.FromArgb(178, 34, 34);
            buttonRounded5.BackgroundColor = Color.FromArgb(178, 34, 34);
            buttonRounded5.BorderColor = Color.FromArgb(178, 34, 34);
            buttonRounded5.BorderRadius = 20;
            buttonRounded5.BorderSize = 0;
            buttonRounded5.ClickColor = Color.FromArgb(145, 25, 25);
            buttonRounded5.FlatStyle = FlatStyle.Flat;
            buttonRounded5.ForeColor = Color.White;
            buttonRounded5.HoverColor = Color.FromArgb(205, 55, 55);
            buttonRounded5.Location = new Point(0, 0);
            buttonRounded5.Name = "buttonRounded5";
            buttonRounded5.Size = new Size(150, 40);
            buttonRounded5.TabIndex = 0;
            buttonRounded5.UseVisualStyleBackColor = false;
            // 
            // panelRounded2
            // 
            panelRounded2.BackColor = Color.White;
            panelRounded2.BorderColor = Color.White;
            panelRounded2.Controls.Add(pictureBox1);
            panelRounded2.Controls.Add(pictureBox3);
            panelRounded2.Dock = DockStyle.Top;
            panelRounded2.Location = new Point(0, 0);
            panelRounded2.Margin = new Padding(4, 5, 4, 5);
            panelRounded2.Name = "panelRounded2";
            panelRounded2.Size = new Size(1924, 155);
            panelRounded2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.image_removebg_preview;
            pictureBox3.Location = new Point(2101, 22);
            pictureBox3.Margin = new Padding(6, 7, 6, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panelRounded3
            // 
            panelRounded3.BackColor = Color.White;
            panelRounded3.BorderColor = Color.Transparent;
            panelRounded3.Controls.Add(label1);
            panelRounded3.Controls.Add(label6);
            panelRounded3.Controls.Add(label7);
            panelRounded3.Location = new Point(662, 192);
            panelRounded3.Margin = new Padding(4, 5, 4, 5);
            panelRounded3.Name = "panelRounded3";
            panelRounded3.Size = new Size(698, 223);
            panelRounded3.TabIndex = 6;
            panelRounded3.Paint += panelRounded3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(30, 80);
            label6.Margin = new Padding(0, 5, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 1;
            label6.Text = "Jangan bolos ya\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(30, 30);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(236, 45);
            label7.TabIndex = 0;
            label7.Text = "Presensi Siswa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 65);
            label1.TabIndex = 6;
            label1.Text = "0%";
            label1.Click += label1_Click;
            // 
            // SiswaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panelRounded3);
            Controls.Add(panelRounded1);
            Controls.Add(panelRounded2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SiswaForm";
            Text = " ";
            Load += SiswaForm_Load;
            panelRounded1.ResumeLayout(false);
            panelRounded1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRounded2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelRounded3.ResumeLayout(false);
            panelRounded3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ButtonRounded buttonRounded1;
        private PanelRounded panelRounded1;
        private PictureBox pictureBox1;
        private PanelRounded panelRounded2;
        private ButtonRounded buttonRounded5;
        private ButtonRounded buttonRounded6;
        private ButtonRounded buttonRounded7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PanelRounded panelRounded3;
        private Label label6;
        private Label label7;
    }
}