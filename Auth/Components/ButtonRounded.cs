using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auth.Components
{
    public class ButtonRounded : Button
    {
        // Fields
        private int _borderSize = 0;
        private int _borderRadius = 20;
        private Color _borderColor = Color.FromArgb(178, 34, 34);
        private Color _backgroundColor = Color.FromArgb(178, 34, 34);
        private Color _hoverColor = Color.FromArgb(205, 55, 55);
        private Color _clickColor = Color.FromArgb(145, 25, 25);
        private bool _isHovered = false;
        private bool _isPressed = false;

        // Properties
        [Category("Appearance Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("Appearance Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = Math.Max(0, value);
                this.Invalidate();
            }
        }

        [Category("Appearance Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                this.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor
        {
            get => _hoverColor;
            set
            {
                _hoverColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ClickColor
        {
            get => _clickColor;
            set
            {
                _clickColor = value;
                this.Invalidate();
            }
        }

        // Constructor
        public ButtonRounded()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = _backgroundColor;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            this.Resize += Button_Resize;
        }

        private void Button_Resize(object? sender, EventArgs e)
        {
            if (_borderRadius > this.Height / 2)
                _borderRadius = this.Height / 2;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = Math.Min(radius * 2F, Math.Min(rect.Width, rect.Height));

            if (curveSize <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 2F, this.Height - 2F);

            Color currentBackColor = _backgroundColor;
            if (!this.Enabled)
                currentBackColor = Color.Gray;
            else if (_isPressed)
                currentBackColor = _clickColor != Color.Empty ? _clickColor : ControlPaint.Dark(_backgroundColor, 0.15f);
            else if (_isHovered)
                currentBackColor = _hoverColor != Color.Empty ? _hoverColor : ControlPaint.Light(_backgroundColor, 0.1f);

            Color parentBackColor = this.Parent != null ? this.Parent.BackColor : Color.White;

            if (_borderRadius > 1)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, Math.Max(0, _borderRadius - 1F)))
                using (SolidBrush brushSurface = new SolidBrush(currentBackColor))
                using (Pen penSurface = new Pen(parentBackColor, 2.2F))
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    this.Region = new Region(pathSurface);
                    g.FillPath(brushSurface, pathSurface);
                    g.DrawPath(penSurface, pathSurface);

                    if (_borderSize >= 1)
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        g.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                using (SolidBrush brushSurface = new SolidBrush(currentBackColor))
                {
                    g.FillRectangle(brushSurface, rectSurface);
                }

                if (_borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(_borderColor, _borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            TextFormatFlags flags = TextFormatFlags.HorizontalCenter |
                                    TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.EndEllipsis;
            TextRenderer.DrawText(g, this.Text, this.Font, this.ClientRectangle, this.ForeColor, flags);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += Parent_BackColorChanged;
            }
        }

        private void Parent_BackColorChanged(object? sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            _isPressed = false;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                _isPressed = true;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            this.Invalidate();
        }
    }
}