using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.PL.userControls
{
    public partial class NotificationPopup : UserControl
    {
        public NotificationPopup()
        {
            InitializeComponent();
        }
        public NotificationPopup(string ErrorOrSucc)
        {
            getMessage = ErrorOrSucc;
            InitializeComponent();
        }

        #region Border
        private int borderSize = 1;
        private int borderRadius = 4;
        private Color borderColor = Color.MediumSlateBlue;

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
        public string MessageText
        {
            get { return GetMessage; }
            set
            {
                GetMessage = value;
            }
        }
        string GetMessage = "Error";
        #endregion

        string getMessage { get; set; }
        private void NotificationPopup_Load(object sender, EventArgs e)
        {
            if (getMessage == "Error")
            {
                this.BackColor   = Color.FromArgb(239, 201, 198);
                label1.ForeColor = Color.FromArgb(185, 45, 37);
                label1.Text      = "Please fill out the fields correctly";
                iconPic.Image    = Properties.Resources.Error_Circle;
                closePic.Image   = Properties.Resources.Close_Red;
                borderColor      = Color.FromArgb(185, 45, 37);
            }
            else 
            {
                this.BackColor   = Color.FromArgb(222, 242, 214);
                label1.ForeColor = Color.FromArgb(91, 113, 80);
                label1.Text      = "Succesfully added";
                iconPic.Image    = Properties.Resources.check;
                closePic.Image   = Properties.Resources.Close_Green;
                borderColor      = Color.FromArgb(91, 113, 80);
            }

        }

        private void closePic_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void closePic_MouseEnter(object sender, EventArgs e)
        {
            if (getMessage == "Error")
                closePic.BackColor = Color.FromArgb(235, 157, 151);
            else
                closePic.BackColor = Color.FromArgb(192, 222, 180);
        }
        private void closePic_MouseLeave(object sender, EventArgs e)
        {
            closePic.BackColor = Color.Transparent;
        }
    }
}
