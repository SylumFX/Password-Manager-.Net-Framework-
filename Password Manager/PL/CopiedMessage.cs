using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.PL
{
    public partial class CopiedMessage : Form
    {
        public CopiedMessage()
        {
            InitializeComponent();
        }

        public void WebLogo_Alias(PaintEventArgs e, string icoFullName, int X, int Y, int Size)
        {
            if (!string.IsNullOrEmpty(icoFullName))
            {
                Image image = new Bitmap(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Resources\\" + icoFullName, true);
                int width = image.Width;
                int height = image.Height;

                //e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                e.Graphics.InterpolationMode = InterpolationMode.High;
                e.Graphics.DrawImage(
                    image,
                    new Rectangle(X, Y, Size, Size),
                    // destination rectangle
                    0,
                    0,           // upper-left corner of source rectangle
                    width,       // width of source rectangle
                    height,      // height of source rectangle
                    GraphicsUnit.Pixel);
                e.Graphics.CompositingQuality = CompositingQuality.Invalid;
            }
        }
        public void WebLogo_Alias(PaintEventArgs e, string icoFullName, int X, int Y, int _height, int _width)
        {
            if (!string.IsNullOrEmpty(icoFullName))
            {
                Image image = new Bitmap(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Resources\\" + icoFullName, true);
                int width = image.Width;
                int height = image.Height;

                //e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                e.Graphics.InterpolationMode = InterpolationMode.High;
                e.Graphics.DrawImage(
                    image,
                    new Rectangle(X, Y, _width, _height),
                    // destination rectangle
                    0,
                    0,           // upper-left corner of source rectangle
                    width,       // width of source rectangle
                    height,      // height of source rectangle
                    GraphicsUnit.Pixel);
                e.Graphics.CompositingQuality = CompositingQuality.Invalid;
            }
        }

        private void CheckedIco_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "check-circle.png", 0, 0, 20);
        }

        #region border
        // Border Size, Raduis and Color
        private int borderSize    = 0;
        private int borderRadius  = 4;
        private Color borderColor = Color.Black;
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        #endregion

        private void paintBorderPanel1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
