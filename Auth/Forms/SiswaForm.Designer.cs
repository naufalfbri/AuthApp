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
            panelRounded2 = new Auth.Models.PanelRounded();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panelRounded1 = new Auth.Models.PanelRounded();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panelRounded2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelRounded1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelRounded2
            // 
            panelRounded2.BackColor = Color.White;
            panelRounded2.BorderColor = Color.White;
            panelRounded2.Controls.Add(label1);
            panelRounded2.Controls.Add(pictureBox1);
            panelRounded2.Controls.Add(pictureBox3);
            panelRounded2.Dock = DockStyle.Top;
            panelRounded2.Location = new Point(0, 0);
            panelRounded2.Name = "panelRounded2";
            panelRounded2.Size = new Size(1549, 93);
            panelRounded2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1280, 31);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 3;
            label1.Text = "Vyan Octavyan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Telkom_Logo;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.image_removebg_preview;
            pictureBox3.Location = new Point(1471, 13);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panelRounded1
            // 
            panelRounded1.BackColor = Color.Firebrick;
            panelRounded1.Controls.Add(label4);
            panelRounded1.Controls.Add(pictureBox2);
            panelRounded1.Controls.Add(label3);
            panelRounded1.Controls.Add(label2);
            panelRounded1.Location = new Point(22, 115);
            panelRounded1.Name = "panelRounded1";
            panelRounded1.Size = new Size(423, 181);
            panelRounded1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 18);
            label2.Name = "label2";
            label2.Size = new Size(137, 32);
            label2.TabIndex = 0;
            label2.Text = "Nilai Siswa";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 53);
            label3.Margin = new Padding(0, 3, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(268, 28);
            label3.TabIndex = 1;
            label3.Text = "Cek persentase nilai pelajaran";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Simple_Line;
            pictureBox2.Location = new Point(255, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 75);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(35, 101);
            label4.Name = "label4";
            label4.Size = new Size(66, 45);
            label4.TabIndex = 5;
            label4.Text = "0%";
            // 
            // SiswaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 813);
            Controls.Add(panelRounded1);
            Controls.Add(panelRounded2);
            Name = "SiswaForm";
            Text = " ";
            Load += SiswaForm_Load;
            panelRounded2.ResumeLayout(false);
            panelRounded2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelRounded1.ResumeLayout(false);
            panelRounded1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Models.PanelRounded panelRounded2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private Models.PanelRounded panelRounded1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
    }
}