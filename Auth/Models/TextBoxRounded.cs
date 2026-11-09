using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auth.Models
{
    [DefaultEvent("TextChanged")]
    public class TextBoxIconRounded : UserControl
    {
        private readonly TextBox innerTextBox = new TextBox();
        private readonly PictureBox pictureBoxIcon = new PictureBox();
        private readonly Label lblPlaceholder = new Label();

        private int borderRadius = 15;
        private int borderSize = 1;
        private Color borderColor = Color.LightGray;
        private Color borderFocusColor = Color.DodgerBlue;
        private Color placeholderColor = Color.Gray;
        private string placeholderText = string.Empty;
        private bool isFocused = false;

        #region Properti Designer

        [Category("Appearance")]
        [Description("Teks petunjuk (placeholder) yang tetap tampil saat teks kosong.")]
        [DefaultValue("")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value ?? string.Empty;
                lblPlaceholder.Text = placeholderText;
                CheckPlaceholder();
            }
        }

        [Category("Appearance")]
        [Description("Warna teks placeholder.")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;
                lblPlaceholder.ForeColor = value;
            }
        }

        [Category("Appearance")]
        [Description("Gambar ikon di sebelah kiri textbox.")]
        [DefaultValue(null)]
        public Image? Icon
        {
            get => pictureBoxIcon.Image;
            set
            {
                pictureBoxIcon.Image = value;
                pictureBoxIcon.Visible = (value != null);
                UpdateLayoutPadding();
            }
        }

        [Category("Appearance")]
        [Description("Radius kelengkungan sudut.")]
        [DefaultValue(15)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Ketebalan garis border.")]
        [DefaultValue(1)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Warna border normal.")]
        [DefaultValue(typeof(Color), "LightGray")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Warna border saat aktif (focused).")]
        [DefaultValue(typeof(Color), "DodgerBlue")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set => borderFocusColor = value;
        }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get => innerTextBox.UseSystemPasswordChar;
            set => innerTextBox.UseSystemPasswordChar = value;
        }

        [Category("Behavior")]
        [DefaultValue('\0')]
        public char PasswordChar
        {
            get => innerTextBox.PasswordChar;
            set => innerTextBox.PasswordChar = value;
        }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool Multiline
        {
            get => innerTextBox.Multiline;
            set
            {
                innerTextBox.Multiline = value;
                UpdateControlHeight();
            }
        }

        [Category("Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                innerTextBox.BackColor = value;
                pictureBoxIcon.BackColor = value;
                lblPlaceholder.BackColor = value;
            }
        }

        [Category("Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                innerTextBox.ForeColor = value;
            }
        }

        [Category("Appearance")]
        [AllowNull]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                if (value != null)
                {
                    innerTextBox.Font = value;
                    lblPlaceholder.Font = value;
                }
                if (!this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [AllowNull]
        public override string Text
        {
            get => innerTextBox.Text;
            set
            {
                innerTextBox.Text = value ?? string.Empty;
                CheckPlaceholder();
            }
        }

        #endregion

        public new event EventHandler? TextChanged;

        public TextBoxIconRounded()
        {
            // Pengaturan PictureBox Ikon
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.Size = new Size(20, 20);
            pictureBoxIcon.Margin = new Padding(0);
            pictureBoxIcon.Visible = false;
            pictureBoxIcon.Click += (s, e) => innerTextBox.Focus();

            // Pengaturan Label Placeholder Custom
            lblPlaceholder.AutoSize = true;
            lblPlaceholder.ForeColor = placeholderColor;
            lblPlaceholder.BackColor = this.BackColor;
            lblPlaceholder.Font = this.Font;
            lblPlaceholder.Cursor = Cursors.IBeam;
            lblPlaceholder.Click += (s, e) => innerTextBox.Focus();

            // Pengaturan Inner TextBox
            innerTextBox.BorderStyle = BorderStyle.None;
            innerTextBox.Dock = DockStyle.Fill;
            innerTextBox.BackColor = this.BackColor;
            innerTextBox.ForeColor = this.ForeColor;

            innerTextBox.TextChanged += (s, e) =>
            {
                CheckPlaceholder();
                TextChanged?.Invoke(this, e);
            };
            innerTextBox.Enter += (s, e) => { isFocused = true; this.Invalidate(); };
            innerTextBox.Leave += (s, e) => { isFocused = false; this.Invalidate(); };
            innerTextBox.Click += (s, e) => this.OnClick(e);

            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Size = new Size(300, 40);

            this.Controls.Add(lblPlaceholder);
            this.Controls.Add(innerTextBox);
            this.Controls.Add(pictureBoxIcon);

            lblPlaceholder.BringToFront();

            UpdateLayoutPadding();
            UpdateControlHeight();
            CheckPlaceholder();
        }

        private void CheckPlaceholder()
        {
            lblPlaceholder.Visible = string.IsNullOrEmpty(innerTextBox.Text) && !string.IsNullOrEmpty(placeholderText);
        }

        private void UpdateLayoutPadding()
        {
            int leftPadding = (pictureBoxIcon.Image != null) ? 38 : 14;
            this.Padding = new Padding(leftPadding, 10, 14, 10);

            if (pictureBoxIcon.Image != null)
            {
                pictureBoxIcon.Location = new Point(12, (this.Height - pictureBoxIcon.Height) / 2);
            }

            lblPlaceholder.Location = new Point(leftPadding + 1, 10);
        }

        private void UpdateControlHeight()
        {
            if (!innerTextBox.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                innerTextBox.Multiline = true;
                innerTextBox.MinimumSize = new Size(0, txtHeight);
                innerTextBox.Multiline = false;

                this.Height = txtHeight + this.Padding.Top + this.Padding.Bottom;
            }
            UpdateLayoutPadding();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Mencegah flickering
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            if (this.Parent != null)
            {
                using (var brushParentBg = new SolidBrush(this.Parent.BackColor))
                {
                    g.FillRectangle(brushParentBg, this.ClientRectangle);
                }
            }

            float penThickness = BorderSize > 0 ? BorderSize : 1f;
            float margin = penThickness / 2f + 0.5f;

            RectangleF rectSurface = new RectangleF(
                margin,
                margin,
                this.Width - (margin * 2f),
                this.Height - (margin * 2f)
            );

            if (rectSurface.Width <= 0 || rectSurface.Height <= 0) return;

            Color currentBorderColor = isFocused ? BorderFocusColor : BorderColor;

            if (BorderRadius > 0)
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
                using (SolidBrush brushFill = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brushFill, pathSurface);

                    if (BorderSize > 0)
                    {
                        using (Pen penBorder = new Pen(currentBorderColor, BorderSize))
                        {
                            penBorder.Alignment = PenAlignment.Center;
                            g.DrawPath(penBorder, pathSurface);
                        }
                    }
                }
            }
            else
            {
                using (SolidBrush brushFill = new SolidBrush(this.BackColor))
                {
                    g.FillRectangle(brushFill, rectSurface);
                }

                if (BorderSize > 0)
                {
                    using (Pen penBorder = new Pen(currentBorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Center;
                        g.DrawRectangle(penBorder, rectSurface.X, rectSurface.Y, rectSurface.Width, rectSurface.Height);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = Math.Min(radius * 2F, Math.Min(rect.Width, rect.Height));

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
            this.Invalidate();
        }
    }
}