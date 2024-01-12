using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Windows.Forms;
using Password_Manager.BLL;
using Password_Manager.PL.userControls;

namespace Password_Manager.PL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Repo
        LoginRepository LoginRepo = new LoginRepository();

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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.FromArgb(185, 185, 191);
        }

        // Textchanges in both textboxes
        private void UsernameBox__TextChanged(object sender, EventArgs e)
        {
            bool UserIsFull = !string.IsNullOrEmpty(UsernameBox.Texts);
            bool PassIsFull = piN_Code1.Value.Count() == 4;

            if (UserIsFull && PassIsFull)
            {
                LoginButton.Enabled     = true;
                LoginButton.BackColor   = Color.FromArgb(109, 117, 186);
                LoginButton.ForeColor   = Color.White;
                LoginButton.BorderSize  = 0;
            }
            else
            {
                LoginButton.Enabled     = false;
                LoginButton.BackColor   = Color.Transparent;
                LoginButton.BorderSize  = 1;
                LoginButton.ForeColor   = Color.FromArgb(185, 185, 191);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string pass = piN_Code1.Value;
            if(LoginRepo.isRight(UsernameBox.Texts , pass))
            {
                if(RememberBox.Checked)
                {
                    Properties.Settings.Default.IsLogged = true;
                    Properties.Settings.Default.User_ID  = LoginRepo.usersID(UsernameBox.Texts, pass);
                    MessageBox.Show(Properties.Settings.Default.User_ID.ToString());
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.User_ID = LoginRepo.usersID(UsernameBox.Texts, pass);
                    Properties.Settings.Default.Save();
                }

                this.Hide();
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentiales");
            }

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        // Move Form
        private void MouseD(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void MouseM(object sender, MouseEventArgs e)
        {

        }
        Point lastPoint;

        public void WebLogo_Alias(PaintEventArgs e, string icoFullName, int X, int Y, int Size)
        {
            if (!string.IsNullOrEmpty(icoFullName))
            {
                Image image = 
                    new Bitmap(@Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Resources\\" + icoFullName, true);
                int width   = image.Width;
                int height  = image.Height;

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

        private void passIco_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "lock1.png", 0, 0, 24);
        }

        private void userIco_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "user.png", 0, 0, 24);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void User_Box__TextChanged(object sender, EventArgs e)
        {
            var Ifuser = string.IsNullOrEmpty(UsernameBox.Texts);
            var IfFname = string.IsNullOrEmpty(FName_Box.Texts);
            var IfLname = string.IsNullOrEmpty(LName_Box.Texts);
            var IfPin = piN_Code2.Value.Count() == 4;

            if(Ifuser && IfFname && IfLname && !IfPin)
            {
                SignUp_Btn.Enabled = false;
                SignUp_Btn.BackColor = Color.Transparent;
            }
            else
            {
                SignUp_Btn.Enabled = true;
                SignUp_Btn.BackColor = Color.FromArgb(109, 117, 186);
                SignUpButton.ForeColor = Color.White;
            }
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            LoginRepo.AddUser(User_Box.Texts, piN_Code2.Value, FName_Box.Texts, LName_Box.Texts);
            var r = new NotificationPopup();
            tabPage2.Controls.Add(r);
        }

        private void BackBtn_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "chevron-left1.png", 0, 0, 30);
        }
    }
}
