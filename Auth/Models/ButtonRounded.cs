using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auth.Models
{
    [DefaultEvent("Click")]
    public class ButtonRounded : Button
    {
        private int borderRadius = 20;
        private int borderSize = 0;
        private Color borderColor = Color.DodgerBlue;
        private Color backgroundColor = Color.MediumSlateBlue;
        private Color hoverColor = Color.RoyalBlue;
        private Color clickColor = Color.DarkBlue;

        private bool isMouseOver = false;
        private bool isMouseDown = false;

        #region Properti Designer

        [Category("Appearance")]
        [DefaultValue(20)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = Math.Max(0, value);
                UpdateRegionAndRedraw();
            }
        }

        [Category("Appearance")]
        [DefaultValue(0)]
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
        [DefaultValue(typeof(Color), "DodgerBlue")]
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
        [DefaultValue(typeof(Color), "MediumSlateBlue")]
        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "RoyalBlue")]
        public Color HoverColor
        {
            get => hoverColor;
            set
            {
                hoverColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DarkBlue")]
        public Color ClickColor
        {
            get => clickColor;
            set
            {
                clickColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [DefaultValue(ContentAlignment.MiddleCenter)]
        public override ContentAlignment TextAlign
        {
            get => base.TextAlign;
            set
            {
                base.TextAlign = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        [AllowNull]
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value ?? string.Empty;
                this.Invalidate();
            }
        }

        #endregion

        public ButtonRounded()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
        }

        #region Event Handlers

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            this.Invalidate(); // Memastikan redraw otomatis saat Padding diubah
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isMouseOver = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isMouseOver = false;
            isMouseDown = false;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
                this.Invalidate();
            }
        }

        #endregion

        #region Drawing & Clipping Logic

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegionAndRedraw();
        }

        private void UpdateRegionAndRedraw()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            if (BorderRadius > 0)
            {
                using (GraphicsPath path = GetRoundedPath(new RectangleF(0, 0, this.Width, this.Height), BorderRadius))
                {
                    this.Region = new Region(path);
                }
            }
            else
            {
                this.Region = null;
            }
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color currentBg = backgroundColor;
            if (isMouseDown) currentBg = clickColor;
            else if (isMouseOver) currentBg = hoverColor;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);

            // 1. Gambar Background Tombol
            if (BorderRadius > 0)
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
                using (SolidBrush brushBg = new SolidBrush(currentBg))
                {
                    g.FillPath(brushBg, pathSurface);
                }

                if (BorderSize > 0)
                {
                    float margin = BorderSize / 2f;
                    RectangleF rectBorder = new RectangleF(margin, margin, this.Width - BorderSize, this.Height - BorderSize);
                    using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, BorderRadius))
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Center;
                        g.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (SolidBrush brushBg = new SolidBrush(currentBg))
                {
                    g.FillRectangle(brushBg, rectSurface);
                }

                if (BorderSize > 0)
                {
                    float margin = BorderSize / 2f;
                    RectangleF rectBorder = new RectangleF(margin, margin, this.Width - BorderSize, this.Height - BorderSize);
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        g.DrawRectangle(penBorder, rectBorder.X, rectBorder.Y, rectBorder.Width, rectBorder.Height);
                    }
                }
            }

            // 2. Gambar Teks Tombol (Memperhitungkan Nilai Padding)
            if (!string.IsNullOrEmpty(this.Text))
            {
                float textX = this.Padding.Left;
                float textY = this.Padding.Top;
                float textWidth = Math.Max(0, this.Width - this.Padding.Horizontal);
                float textHeight = Math.Max(0, this.Height - this.Padding.Vertical);

                RectangleF rectText = new RectangleF(textX, textY, textWidth, textHeight);

                using (StringFormat sf = GetStringFormat(this.TextAlign))
                using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                {
                    g.DrawString(this.Text, this.Font, textBrush, rectText, sf);
                }
            }
        }

        private StringFormat GetStringFormat(ContentAlignment alignment)
        {
            StringFormat sf = new StringFormat
            {
                HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            };

            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
            }

            return sf;
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

        #endregion
    }
}