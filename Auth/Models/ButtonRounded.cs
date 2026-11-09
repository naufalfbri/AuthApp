using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace Auth.Models
{
    [DefaultEvent("Click")]
    public class ButtonRounded : Button
    {
        private int borderRadius = 15;
        private int borderSize = 0;
        private Color borderColor = Color.DodgerBlue;
        private Color hoverColor = Color.RoyalBlue;
        private Color clickColor = Color.Navy;

        // Variabel animasi warna dengan penamaan timer eksplisit
        private Color currentBackColor;
        private Color targetBackColor;
        private readonly WinFormsTimer animationTimer = new WinFormsTimer();
        private bool enableAnimation = true;

        #region Properti Designer

        [Category("Appearance")]
        [Description("Radius kelengkungan sudut tombol.")]
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
        [Description("Warna garis border.")]
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
        [Description("Warna background saat kursor mengarah ke tombol (hover).")]
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
        [Description("Warna background saat tombol ditekan (click).")]
        [DefaultValue(typeof(Color), "Navy")]
        public Color ClickColor
        {
            get => clickColor;
            set
            {
                clickColor = value;
                this.Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Menentukan apakah animasi transisi warna aktif.")]
        [DefaultValue(true)]
        public bool EnableAnimation
        {
            get => enableAnimation;
            set => enableAnimation = value;
        }

        [Category("Appearance")]
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                if (!animationTimer.Enabled)
                {
                    currentBackColor = value;
                    targetBackColor = value;
                }
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
                base.Text = value;
                this.Invalidate();
            }
        }

        #endregion

        public ButtonRounded()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.DodgerBlue;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;

            currentBackColor = this.BackColor;
            targetBackColor = this.BackColor;

            // Inisialisasi Timer Animasi (60 FPS / 15ms)
            animationTimer.Interval = 15;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        #region Logika Transisi & Animasi

        private void StartColorAnimation(Color targetColor)
        {
            targetBackColor = targetColor;

            if (enableAnimation && !this.DesignMode)
            {
                animationTimer.Start();
            }
            else
            {
                currentBackColor = targetColor;
                this.Invalidate();
            }
        }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
        {
            if (currentBackColor.ToArgb() == targetBackColor.ToArgb())
            {
                animationTimer.Stop();
                return;
            }

            int r = InterpolateComponent(currentBackColor.R, targetBackColor.R);
            int g = InterpolateComponent(currentBackColor.G, targetBackColor.G);
            int b = InterpolateComponent(currentBackColor.B, targetBackColor.B);
            int a = InterpolateComponent(currentBackColor.A, targetBackColor.A);

            currentBackColor = Color.FromArgb(a, r, g, b);
            this.Invalidate();
        }

        private int InterpolateComponent(int current, int target)
        {
            if (current == target) return target;
            int diff = target - current;
            int step = Math.Sign(diff) * Math.Max(1, Math.Abs(diff) / 3);
            int next = current + step;

            return (diff > 0 && next > target) || (diff < 0 && next < target) ? target : next;
        }

        #endregion

        #region Event Mouse State

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            StartColorAnimation(HoverColor);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            StartColorAnimation(this.BackColor);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            StartColorAnimation(ClickColor);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                StartColorAnimation(HoverColor);
            else
                StartColorAnimation(this.BackColor);
        }

        #endregion

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Mengosongkan pemrosesan background default untuk mencegah flicker
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;

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

            if (BorderRadius > 0)
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, BorderRadius))
                using (SolidBrush brushFill = new SolidBrush(currentBackColor))
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
                using (SolidBrush brushFill = new SolidBrush(currentBackColor))
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

            TextRenderer.DrawText(
                g,
                this.Text,
                this.Font,
                this.ClientRectangle,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak
            );
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
            this.Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                animationTimer.Stop();
                animationTimer.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}