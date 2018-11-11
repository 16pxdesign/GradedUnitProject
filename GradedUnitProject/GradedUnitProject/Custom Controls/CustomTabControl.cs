using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedUnitProject
{
    class CustomTabControl : TabControl
    {
        #region Variables
        private int itemWidth = 240;
        private int itemHeight = 50;
        private Color backTabColor = Color.FromArgb(45, 45, 48);
        private Color borderColor = Color.FromArgb(30, 30, 30);
        private Color backColor = Color.FromArgb(45, 45, 48);
        private Color overheaderColor = Color.FromArgb(0, 122, 204);
        private Color textColor = Color.FromArgb(255, 255, 255);
        private readonly StringFormat centerText = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        #endregion

        #region set / get

        [Category("Custom"), Browsable(true)]
        public Color TextColor
        {
            get
            {
                return this.textColor;
            }

            set
            {
                this.textColor = value;
            }
        }


        [Category("Custom"), Browsable(true)]
        public Color OverheaderColor
        {
            get
            {
                return this.overheaderColor;
            }

            set
            {
                this.overheaderColor = value;
            }
        }

        [Category("Custom"), Browsable(true)]
        public new Color BackColor
        {
            get
            {
                return this.backColor;
            }

            set
            {
                this.backColor = value;
            }
        }

        [Category("Custom"), Browsable(true)]
        public Color BackTabColor
        {
            get
            {
                return this.backTabColor;
            }

            set
            {
                this.backTabColor = value;
            }
        }

        [Category("Custom"), Browsable(true)]
        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }

            set
            {
                this.borderColor = value;
            }
        }


        #endregion


        #region Constructor
        public CustomTabControl()
        {
            SetStyle(
            ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw
            | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            this.SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(itemWidth, itemHeight);
        }
        #endregion 

        #region Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(this.backColor);

            try
            {
                SelectedTab.BackColor = this.backTabColor;
                SelectedTab.BorderStyle = BorderStyle.None;
            }
            catch
            {
            }

            for (var i = 0; i < TabCount; i++)
            {
                var HeaderSize = new Rectangle(new Point(GetTabRect(i).Location.X + 3, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
                var Header = new Rectangle(HeaderSize.Location, new Size(HeaderSize.Width, HeaderSize.Height));

                if (i == SelectedIndex)
                {
                    g.FillRectangle(new SolidBrush(Color.Transparent), Header);
                    g.FillRectangle(
                        new SolidBrush(this.overheaderColor),
                        new Rectangle(Header.X - 5, Header.Y - 3, Header.Width, Header.Height + 5));


                    g.DrawString(
                        TabPages[i].Text,
                        Font,
                        new SolidBrush(this.textColor),
                        Header,
                        this.centerText);

                }
                else
                {

                    g.DrawString(
                        TabPages[i].Text,
                        Font,
                        new SolidBrush(this.textColor),
                        Header,
                        this.centerText);
                }

                g.FillRectangle(new SolidBrush(this.backColor), new Rectangle(0, itemHeight, Width, Height - itemHeight));
                g.DrawLine(new Pen(this.overheaderColor, 5), new Point(0, itemHeight + 2), new Point(Width, itemHeight + 2));

                g.DrawRectangle(new Pen(this.borderColor, 2), new Rectangle(0, 0, Width, Height));
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }
        }
        #endregion




    }
}

