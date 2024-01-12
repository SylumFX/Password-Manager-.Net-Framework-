using Password_Manager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Password_Manager.PL.userControls;
using Password_Manager.PL;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.IO;

namespace Password_Manager.userControls
{
    public partial class newPasswords : UserControl
    {
        public newPasswords()
        {
            //Flickering 
            this.DoubleBuffered = true;
            
            InitializeComponent();
        }

        
        #region Border

        private int borderSize = 1;
        private int borderRadius = 0;
        private Color borderColor = Color.Red;

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
        #region -> Overridden methods
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
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
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

        [Category("Advanced")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Advanced")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value >= 1)
                {
                    borderSize = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Advanced")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }
        [Category("Advanced")]
        public string IcoName
        {
            get { return getIcoFullName; }
            set
            {
                getIcoFullName = value;
            }
        }
        string getIcoFullName { get; set; }
        #endregion

        [Category("Advanced")]
        public string getType
        {
            get { return Type; }
            set
            {
                Type = value;
            }
        }
        string Type { get; set; }

        public event EventHandler _CopyPassClick;
        public event EventHandler _CopyUserClick;
        public event EventHandler _Opened;
        public event EventHandler _ModifyClick;
        public event EventHandler _DeleteClick;
        public event EventHandler _FavClick;

        // Copy Password
        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_CopyPassClick != null)
                _CopyPassClick.Invoke(sender, e);
        }
        // Copy Username
        private void copyUsernameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_CopyUserClick != null)
                _CopyUserClick.Invoke(sender, e);
        }


        // Click
        // Modify Password
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ModifyClick != null)
                _ModifyClick.Invoke(sender, e);
        }
        // Delete Password
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_DeleteClick != null)
                _DeleteClick.Invoke(sender, e);
        }
        // Launch
        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!websiteLabel.Text.ToLower().Contains("www."))
                System.Diagnostics.Process.Start("www." + websiteLabel.Text);
            else
                System.Diagnostics.Process.Start(websiteLabel.Text);
        }
        // Right Click
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (_Opened != null)
                _Opened.Invoke(this, e);
        }

        // Image Quality
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

        private void newPasswords_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, getIcoFullName, 24, 24, 24);
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MousePosition);
        }
        private void customButton1_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "more-vertical.png", 0, 0, 24, 24);
        }

        private void Fav_Ico_Click(object sender, EventArgs e)
        {
            if(_FavClick != null)
                _FavClick(this, e);

            if(isClicked)
                isClicked = false;
            else
                isClicked = true;

            FavButton_.Refresh();
        }
        private void Fav_Ico_Enter(object sender, EventArgs e)
        {
            favEnterOrLeave = true;
            FavButton_.Refresh();
            FavButton_.BackColor = Color.FromArgb(252, 252, 252);
        }
        private void Fav_Ico_Leave(object sender, EventArgs e)
        {
            favEnterOrLeave = false;
            FavButton_.Refresh();
            FavButton_.BackColor = Color.FromArgb(252, 252, 252);
        }
        public bool favEnterOrLeave = false;
        public bool isClicked = false;

        private void Fav_Ico_Paint(object sender, PaintEventArgs e)
        {
            if (isClicked)
                WebLogo_Alias(e, "star-Focus.png", 0, 0, 24);
            else if (favEnterOrLeave)
                WebLogo_Alias(e, "star.png", 0, 0, 24);
            else if(!isClicked)
                WebLogo_Alias(e, "star-default.png", 0, 0, 24);

        }

        private void copyPasswordToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "copy.png", 0, 0, 16);
        }

        private void copyUsernameToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "copy.png", 0, 0, 16);
        }

        private void deleteToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "trash-Red.png", 0, 0, 16);
        }

        private void modifyToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "edit.png", 0, 0, 16);
        }

    }
}
