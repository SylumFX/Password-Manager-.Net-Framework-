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
using System.Web;

using Password_Manager.PL.userControls;
using Password_Manager.DAL;
using Password_Manager.BLL;
using System.Web.Security;
using System.IO;

namespace Password_Manager.PL
{
    public partial class addForm : Form
    {

        PasswordReporsitory PassRepo = new PasswordReporsitory();
        EncryptionClass Crypto       = new EncryptionClass();

        public addForm()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
        }

        // To Edit
        public addForm(int _ID)
        {
            AddorEdit = false;

            idSelected = _ID;
            InitializeComponent();
        }

        int idSelected;
        bool AddorEdit = true;

        public List<string> TypesList = new List<string>()
        {
            "Other"         ,
            "Gaming"        ,
            "Entertainment" ,
            "Social Media"  
        };
        void FillCombo()
        {
            typecombo.DataSource = TypesList;
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            typecombo.Refresh();
            FillCombo();

            if (!AddorEdit)
            {
                var gotRow           = PassRepo.GetRow(idSelected);
                userBox.Texts        = gotRow.Username;
                passBox.Texts        = Crypto.Decrypt(gotRow.Password);
                webBox.Texts         = gotRow.Website;
                typecombo.Texts      = gotRow.Type;

                AddOrEdit_Btn.Text   = "Edit";
            }
        }

        #region Move Form
        // Moving Form
        private void MouseD(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void MouseM(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        Point lastPoint;
        #endregion
        #region border
        // Border Size, Raduis and Color
        private int borderSize = 1;
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

        private void paintBorderPanel1_Click(object sender, EventArgs e)
        {
            titleLabel.Focus();
        }

        // Notification
        void NotificationPopup(string ErrorOrNot)
        {
            var notiPop      = new NotificationPopup(ErrorOrNot);

            notiPop.Location = new Point(83, 12);
            notiPop.Dock     = DockStyle.None;
            notiPop.Parent   = this;
            notiPop.BringToFront();
            titleLabel.SendToBack();
            closeBtn.SendToBack();

            this.Controls.Add(notiPop);
            this.Controls.SetChildIndex(notiPop, 0);
        }

        bool toUpdate = false;

        // ADD Button
        private void customButton1_Click(object sender, EventArgs e)
        {
            bool Ifweb  =  string.IsNullOrEmpty(webBox.Texts);
            bool Ifuser = string.IsNullOrEmpty(userBox.Texts);
            bool Ifpass = string.IsNullOrEmpty(passBox.Texts);
            bool Iftype = string.IsNullOrEmpty(typecombo.Texts);

            // Edit
            if(!AddorEdit)
            {
                if (Ifweb || Ifuser || Ifpass || Iftype)
                    NotificationPopup("Error");
                else
                {
                    NotificationPopup("Correct");

                    string cryptedPass = Crypto.Encrypt(passBox.Texts);
                    PassRepo.EditRow(idSelected, webBox.Texts, userBox.Texts, cryptedPass, typecombo.Texts);
                    toUpdate = true;

                    ClearBoxes();
                }
            }
            // Add
            else if (AddorEdit)
            {
                if (Ifweb || Ifuser || Ifpass)
                    NotificationPopup("Error");
                else
                {
                    NotificationPopup("Correct");

                    string cryptedPass = Crypto.Encrypt(passBox.Texts);
                    PassRepo.AddTo(webBox.Texts, userBox.Texts, cryptedPass, typecombo.Texts);
                    toUpdate = true;

                    ClearBoxes();
                }
            }

        }

        void ClearBoxes()
        {
            webBox.Refresh();
            userBox.Refresh();
            passBox.Refresh();
        }

        // Generate Password
        private void Generate_Click(object sender, EventArgs e)
        {
            var generatedPass = Membership.GeneratePassword(16, 1);
            passBox.Texts = generatedPass;
        }

        private void webBox__TextChanged(object sender, EventArgs e)
        {

            // Styling
            bool Ifweb  = string.IsNullOrEmpty(webBox.Texts);
            bool Ifuser = string.IsNullOrEmpty(userBox.Texts);
            bool Ifpass = string.IsNullOrEmpty(passBox.Texts);

            if (!Ifweb && !Ifuser && !Ifpass )
            {
                AddOrEdit_Btn.BackColor   = Color.FromArgb(111, 119, 193);
                AddOrEdit_Btn.ForeColor   = Color.White;
                AddOrEdit_Btn.BorderColor = Color.FromArgb(111, 119, 193);
            }
            else
            {
                AddOrEdit_Btn.BorderColor = Color.FromArgb(80, 86, 141);
                AddOrEdit_Btn.ForeColor   = Color.FromArgb(80, 86, 141);
                AddOrEdit_Btn.BackColor   = Color.White;
            }
        }
        
        private void noteTxtbox__TextChanged(object sender, EventArgs e)
        {
            CounterLabel.Text = noteTxtbox.Texts.Count().ToString();
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
        private void customButton2_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "refresh-ccw.png", 0, 0, 24);
        }

        // Close Button
        bool closeBtn_Enter = false;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (toUpdate)
                this.DialogResult = DialogResult.Yes;
            else
                this.DialogResult = DialogResult.No;
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
            closeBtn.BackColor = Color.White;
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
    }
}
