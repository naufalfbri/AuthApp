using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auth.Models
{
    public class PanelRounded : Panel
    {
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.DodgerBlue;

        [Category("Appearance")]
        [DefaultValue(20)]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(2)]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Color), "DodgerBlue")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public PanelRounded()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(200, 100);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Mencegah flickering saat repainting
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // Bersihkan background area luar dengan warna Parent Form
            if (this.Parent != null)
            {
                using (var brushParentBg = new SolidBrush(this.Parent.BackColor))
                {
                    g.FillRectangle(brushParentBg, this.ClientRectangle);
                }
            }

            // Memberikan margin internal aman agar garis/lengkungan tidak terpotong batas kanvas
            float penThickness = BorderSize > 0 ? BorderSize : 1f;
            float margin = penThickness / 2f + 0.5f;

            RectangleF rectSurface = new RectangleF(
                margin,
                margin,
                this.Width - (margin * 2f),
                this.Height - (margin * 2f)
            );

            if (rectSurface.Width <= 0 || rectSurface.Height <= 0) return;

            if (BorderRadius > 0)
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
                using (SolidBrush brushFill = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brushFill, pathSurface);

                    if (BorderSize > 0)
                    {
                        using (Pen penBorder = new Pen(BorderColor, BorderSize))
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
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
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

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate();
        }
    }
}