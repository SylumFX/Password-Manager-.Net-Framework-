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
    public partial class WarningMessageBox : Form
    {
        public WarningMessageBox()
        {
            InitializeComponent();
        }
        public WarningMessageBox(string _IsDeleteOrLogOut)
        {
            InitializeComponent();
            IsDeleteOrLogOut = _IsDeleteOrLogOut;
        }
        string IsDeleteOrLogOut { get; set; }
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

        // Close Button
        bool closeBtn_Enter = false;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn_Enter = true;
            closeBtn.BackColor = Color.FromArgb(240, 63, 63);
            closeBtn.Refresh();

            //closeBtn.Image = Properties.Resources.x_White;
        }
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn_Enter = false;
            closeBtn.BackColor = Color.FromArgb(244, 245, 255);
            closeBtn.Refresh();

            //closeBtn.Image = Properties.Resources.x;
        }
        private void closeBtn_Paint(object sender, PaintEventArgs e)
        {
            if (closeBtn_Enter)
                WebLogo_Alias(e, "x_White.png", 0, 0, 24);
            else
                WebLogo_Alias(e, "x.png", 0, 0, 24);
        }


        private void warningIco_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "warning.png", 0, 0, 38);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void paintBorderPanel1_Load(object sender, EventArgs e)
        {
            if(IsDeleteOrLogOut == "Log Out")
            {
                CaptionLbl.Text   = "Log out?";
                TextLbl.Text      = "You are signing out. Are you sure?";
                deleteButton.Text = "Log out";
            }
        }

        #region border
        // Border Size, Raduis and Color
        private int borderSize = 0;
        private int borderRadius = 4;
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


    }
}
