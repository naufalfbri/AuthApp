using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auth.Models
{
    public class PanelAdvancedRounded : Panel
    {
        private int topLeftRadius = 30;
        private int topRightRadius = 30;
        private int bottomRightRadius = 30;
        private int bottomLeftRadius = 30;
        private int borderSize = 0;
        private Color borderColor = Color.DodgerBlue;

        [Category("Appearance")]
        [DefaultValue(30)]
        public int TopLeftRadius
        {
            get => topLeftRadius;
            set { topLeftRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(30)]
        public int TopRightRadius
        {
            get => topRightRadius;
            set { topRightRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(30)]
        public int BottomRightRadius
        {
            get => bottomRightRadius;
            set { bottomRightRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(30)]
        public int BottomLeftRadius
        {
            get => bottomLeftRadius;
            set { bottomLeftRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(0)]
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

        public PanelAdvancedRounded()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(200, 100);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Mengosongkan background default untuk mencegah flicker
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Mengaktifkan Rendering Kualitas Tinggi & Anti-Aliasing
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // 1. Gambar background Form/Parent di area luar sudut
            if (this.Parent != null)
            {
                using (var brushParentBg = new SolidBrush(this.Parent.BackColor))
                {
                    g.FillRectangle(brushParentBg, this.ClientRectangle);
                }
            }

            RectangleF rectSurface = new RectangleF(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, TopLeftRadius, TopRightRadius, BottomRightRadius, BottomLeftRadius))
            using (SolidBrush brushFill = new SolidBrush(this.BackColor))
            {
                // 2. Isi warna panel dengan sudut mulus
                g.FillPath(brushFill, pathSurface);

                // 3. Gambar garis border jika ada
                if (BorderSize > 0)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        g.DrawPath(penBorder, pathSurface);
                    }
                }
            }
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float rTL, float rTR, float rBR, float rBL)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Sudut Kiri Atas
            if (rTL > 0)
                path.AddArc(rect.X, rect.Y, rTL * 2F, rTL * 2F, 180, 90);
            else
                path.AddLine(rect.X, rect.Y, rect.X, rect.Y);

            // Sudut Kanan Atas
            if (rTR > 0)
                path.AddArc(rect.Right - (rTR * 2F), rect.Y, rTR * 2F, rTR * 2F, 270, 90);
            else
                path.AddLine(rect.Right, rect.Y, rect.Right, rect.Y);

            // Sudut Kanan Bawah
            if (rBR > 0)
                path.AddArc(rect.Right - (rBR * 2F), rect.Bottom - (rBR * 2F), rBR * 2F, rBR * 2F, 0, 90);
            else
                path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Bottom);

            // Sudut Kiri Bawah
            if (rBL > 0)
                path.AddArc(rect.X, rect.Bottom - (rBL * 2F), rBL * 2F, rBL * 2F, 90, 90);
            else
                path.AddLine(rect.X, rect.Bottom, rect.X, rect.Bottom);

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