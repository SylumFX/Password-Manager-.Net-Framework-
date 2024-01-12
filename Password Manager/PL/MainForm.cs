using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Password_Manager.DAL;
using Password_Manager.userControls;
using Password_Manager.PL ;
using System.Drawing.Drawing2D;
using System.Reflection;
using Password_Manager.BLL;
using Password_Manager.PL.userControls;
using System.Media;
using System.IO;

namespace Password_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Flickering 
            this.DoubleBuffered = true;

            InitializeComponent();
        }

        // Users ID
        int currentUser = Properties.Settings.Default.User_ID;

        //DB
        PasswordReporsitory passRepo    = new PasswordReporsitory();
        EncryptionClass EncryptRepo     = new EncryptionClass();

        #region Close Max Min Buttons and Move Form
        // Move Form
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
        private void MoveForm_Panel_Paint(object sender, PaintEventArgs e)
        {
            //Paint Event
            ControlPaint.DrawBorder(e.Graphics, this.MoveForm_Panel.ClientRectangle, Color.FromArgb(224, 224, 224), ButtonBorderStyle.Solid);
        }

        // Close Button
        bool closeBtn_Enter = false;
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        // Max Button
        bool maxBtn_Enter = false;
        private void maxBtn_Click(object sender, EventArgs e)
        {
            var LABEL = customFlowPanelLayout1.Controls.Find("label1", false).FirstOrDefault() as Label;

            if (this.WindowState == FormWindowState.Normal)
            {
                maxBtn_Enter     = true;
                this.WindowState = FormWindowState.Maximized;
                tabControl1.Size = new Size(1700, 1080);
                LABEL.Size = new Size(1400, 38);
            }
            else
            {
                maxBtn_Enter     = false;
                this.WindowState = FormWindowState.Normal;
                tabControl1.Size = new Size(1242, 1041);
                LABEL.Size = new Size(1400, 38);
            }

            tabControl1.Location = new Point(224, -9);
            maxBtn.Refresh();
        }
        private void maxBtn_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                maxBtn_Enter = true;

            maxBtn.BackColor = Color.FromArgb(232, 232, 232);
            maxBtn.Refresh();
        }
        private void maxBtn_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                maxBtn_Enter = true;

            maxBtn.BackColor = Color.FromArgb(244, 245, 255);
            maxBtn.Refresh();
        }
        private void maxBtn_Paint(object sender, PaintEventArgs e)
        {
            if (maxBtn_Enter)
                WebLogo_Alias(e, "2_square.png", 0, 0, 24);
            else
                WebLogo_Alias(e, "square.png", 0, 0, 24);
        }

        // Min Button
        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            minBtn.BackColor = Color.FromArgb(232, 232, 232);
        }
        private void minBtn_MouseLeave(object sender, EventArgs e)
        {

            minBtn.BackColor = Color.FromArgb(244, 245, 255);
        }
        private void minBtn_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "minus.png", 0, 0, 24);
        }


        #endregion

        #region Side Panel
        //// Side Panel
        /// Password panel
        private void VaultButton_Paint(object sender, PaintEventArgs e)
        {
            if (!vaultClicked)
                WebLogo_Alias(e, "lock2.png", 24, 18, 20);
            else
                WebLogo_Alias(e, "lock.png", 24, 18, 20);
        }
        bool vaultClicked = true;
        private void VaultButton_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != 0)
            {
                deleteClicked = false;
                vaultClicked = true;
                VaultButton.Refresh();
                Deleted_Button.Refresh();

                tabControl1.SelectedIndex = 0;
                Deleted_Button.BackColor = Color.Transparent;
                Deleted_Button.ForeColor = Color.FromArgb(184, 187, 222);

                VaultButton.BackColor = Color.FromArgb(186, 191, 234);
                VaultButton.ForeColor = Color.White;
            }
        }
        // Deleted Panel
        private void Deleted_Button_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != 1)
            {
                vaultClicked = false;
                deleteClicked = true;
                Deleted_Button.Refresh();
                VaultButton.Refresh();

                tabControl1.SelectedIndex = 1;
                Deleted_Button.BackColor = Color.FromArgb(186, 191, 234); 
                Deleted_Button.ForeColor = Color.White;

                VaultButton.BackColor = Color.Transparent;
                VaultButton.ForeColor = Color.FromArgb(184, 187, 222);
            }
        }
        private void NoteButton_Paint(object sender, PaintEventArgs e)
        {
            if(deleteClicked)
                WebLogo_Alias(e, "trash-3.png", 24, 18, 20);
            else
                WebLogo_Alias(e, "trash-21.png", 24, 18, 20);
        }

        bool deleteClicked = false;
        #endregion

        //************************* LOAD *************************//
        private void Form1_Load(object sender, EventArgs e)
        {
            // Exculdes Taskbar
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            CreateAllDeleted();
            CreateAllNps();
        }

        //************************* Create Password UCs *************************//
        // All
        void CreateLabel()
        {
            Label l1 = new Label();
            l1.Name = "L1";
            l1.AutoSize = true;
            l1.Size = new Size(1124, 28);
            customFlowPanelLayout1.Controls.Add(l1);
            CreateTypeCombo_Label();
        }
        void CreateAllDeleted()
        {
            foreach (var item in passRepo.DeletedPasses(currentUser))
            {
                newPasswords nP_Control = new newPasswords();
                // Properties
                nP_Control.websiteLabel.Text = item.Website;
                nP_Control.types1.getType = item.Type;
                nP_Control.userLabel.Text = item.Username;
                nP_Control.Name = "Np_" + item.ID.ToString();
                nP_Control.BorderColor = Color.FromArgb(238, 238, 238);
                nP_Control.BorderSize = 1;
                nP_Control.BorderRadius = 4;
                // Events
                nP_Control._CopyPassClick += NP_Control__CopyPassClick;
                nP_Control._CopyUserClick += NP_Control__CopyUserClick;
                nP_Control._Opened        += NP_Control__Opened;
                nP_Control._ModifyClick   += NP_Control__ModifyClick;
                nP_Control._DeleteClick   += NP_Control__DeleteClick;
                nP_Control._FavClick      += NP_Control_FavClick;

                if (item.Website.ToLower().Contains("youtube"))
                    nP_Control.IcoName = "WebLogo.png";
                else if (item.Website.ToLower().Contains("netflix"))
                    nP_Control.IcoName = "netflix.png";
                else if (item.Website.ToLower().Contains("facebook"))
                    nP_Control.IcoName = "fblogo.png";
                else if (item.Website.ToLower().Contains("twitter"))
                    nP_Control.IcoName = "twittLogo.png";
                else if (item.Website.ToLower().Contains("steampowerd"))
                    nP_Control.IcoName = "steamlogo.png";
                else if (item.Website.ToLower().Contains("epicgames"))
                    nP_Control.IcoName = "epicgmaes.png";


                customFlowPanelLayout2.Controls.Add(nP_Control);
            }
        }


        void CreateAllNps()
        {
            CreateLabel();
            var TypeCombo_ = customFlowPanelLayout1.Controls.Find("TypeCombo", false).FirstOrDefault() as myCombobox;
            TypeCombo_.Texts = "All";

            foreach (var item in passRepo.NonDeleted_OrderedByDate(currentUser))
            {
                newPasswords nP_Control = new newPasswords();
                // Properties
                nP_Control.websiteLabel.Text = item.Website;
                nP_Control.types1.getType    = item.Type;
                nP_Control.userLabel.Text    = item.Username;
                nP_Control.Name              = "Np_" + item.ID.ToString();
                nP_Control.BorderColor       = Color.FromArgb(238, 238, 238);
                nP_Control.BorderSize        = 1;
                nP_Control.BorderRadius      = 4;
                // Events
                nP_Control._CopyPassClick   += NP_Control__CopyPassClick;
                nP_Control._CopyUserClick   += NP_Control__CopyUserClick;
                nP_Control._Opened          += NP_Control__Opened;
                nP_Control._ModifyClick     += NP_Control__ModifyClick;
                nP_Control._DeleteClick     += NP_Control__DeleteClick;
                nP_Control._FavClick        += NP_Control_FavClick;

                if (item.Website.ToLower().Contains("youtube"))
                    nP_Control.IcoName = "WebLogo.png";
                else if (item.Website.ToLower().Contains("netflix"))
                    nP_Control.IcoName = "netflix.png";
                else if (item.Website.ToLower().Contains("facebook"))
                    nP_Control.IcoName = "fblogo.png";
                else if (item.Website.ToLower().Contains("twitter"))
                    nP_Control.IcoName = "twittLogo.png";
                else if (item.Website.ToLower().Contains("steampowerd"))
                    nP_Control.IcoName = "steamlogo.png";
                else if (item.Website.ToLower().Contains("epicgames"))
                    nP_Control.IcoName = "epicgmaes.png";

                if(item.isFavorite)
                {
                    nP_Control.isClicked = true;
                    nP_Control.FavButton_.Refresh();
                }

                customFlowPanelLayout1.Controls.Add(nP_Control);
            }
        }

        // To Delete
        private void NP_Control__DeleteClick(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            var r = new WarningMessageBox().ShowDialog();
            if(r == DialogResult.Yes)
            { 
                var _ID = int.Parse(nameOf_Active_Np.Substring(3));
                passRepo.ToDelete(_ID);

                customFlowPanelLayout1.Controls.Clear();
                CreateAllNps();

                customFlowPanelLayout2.Controls.Clear();
                CreateAllDeleted();
            }
        }
        // To Modify
        private void NP_Control__ModifyClick(object sender, EventArgs e)
        {
            var _ID = int.Parse(nameOf_Active_Np.Substring(3));
            var editForm = new addForm(_ID).ShowDialog();

            if (editForm == DialogResult.Yes)
            {
                customFlowPanelLayout1.Controls.Clear();
                CreateAllNps();
            }
        }
        // To Fav
        private void NP_Control_FavClick(object sender, EventArgs e)
        {
            newPasswords np = sender as newPasswords;
            nameOf_Active_Np = np.Name;

            var _ID = int.Parse(nameOf_Active_Np.Substring(3));

            if (!passRepo.GetRow(_ID).isFavorite)
                passRepo.ToFavorite(_ID, false);
            else
                passRepo.ToFavorite(_ID, true);
        }
        // To Copy Pass
        private void NP_Control__CopyPassClick(object sender, EventArgs e)
        {
            var _ID         = int.Parse(nameOf_Active_Np.Substring(3));
            var SelectedNp  = passRepo.GetRow(_ID);
            var passDecrypt = EncryptRepo.Decrypt(SelectedNp.Password);
            Clipboard.SetText(passDecrypt);
            new CopiedMessage().Show();
        }
        // To Copy User
        private void NP_Control__CopyUserClick(object sender, EventArgs e)
        {
            var _ID        = int.Parse(nameOf_Active_Np.Substring(3));
            var SelectedNp = passRepo.GetRow(_ID);
            var User       = SelectedNp.Username;
            Clipboard.SetText(User);
            new CopiedMessage().Show();
        }

        // Context Menu Opened
        private void NP_Control__Opened(object sender, EventArgs e)
        {
            newPasswords np  = sender as newPasswords;
            nameOf_Active_Np = np.Name;
        }
        string nameOf_Active_Np { get; set; }


        //*************************         ADD         *************************//
        private void button1_Click(object sender, EventArgs e)
        {
            var addForm = new addForm().ShowDialog();
            if (addForm == DialogResult.Yes)
            {
                customFlowPanelLayout1.Controls.Clear();
                CreateAllNps();
            }
        }

        //************************* SEARCH and SEARCH BY *************************//
        private void searchIco_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "search-clr.png", 0, 0, 20);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var TypeCombo = customFlowPanelLayout1.Controls.Find("TypeCombo", false).FirstOrDefault() as myCombobox;

            if (FilterCombo.Texts == "By Username")
            {
                if(TypeCombo.Texts == "All")
                {
                    foreach( var item in passRepo.NonDeleted_OrderedByDate(currentUser))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
                else if(TypeCombo.Texts == "Social Media")
                {
                    foreach (var item in passRepo.GetTypeOf("Social Media"))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID.ToString(), true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
                else if(TypeCombo.Texts == "Gaming")
                {
                    foreach (var item in passRepo.GetTypeOf("Gaming"))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
                else if(TypeCombo.Texts == "Entertainment")
                {
                    foreach (var item in passRepo.GetTypeOf("Entertainment"))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.userLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
            }
            else if (FilterCombo.Texts == "By Website")
            {
                if (TypeCombo.Texts == "All")
                {
                    foreach (var item in passRepo.NonDeleted_OrderedByDate(currentUser))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
                else if (TypeCombo.Texts == "Social Media")
                {
                    foreach (var item in passRepo.GetTypeOf("Social Media"))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID.ToString(), true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
                else if (TypeCombo.Texts == "Gaming")
                {
                    foreach (var item in passRepo.GetTypeOf("Gaming"))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
                else if (TypeCombo.Texts == "Entertainment")
                {
                    foreach (var item in passRepo.GetTypeOf("Entertainment"))
                    {
                        newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;

                        if (!NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = false;
                        else if (NpCtl.websiteLabel.Text.ToLower().Contains(SearchBox.Texts.ToLower()))
                            NpCtl.Visible = true;

                        if (string.IsNullOrEmpty(SearchBox.Texts) || SearchBox.Texts == "Search...")
                            NpCtl.Visible = true;
                    }
                }
            }
        }

        //************************* Show only specific type *************************//
        // TypeCombo
        void CreateTypeCombo_Label()
        {
            Label lb = new Label();
            lb.AutoSize = false;

            if (this.WindowState == FormWindowState.Maximized)
                lb.Size = new Size(1450, 28);
            else
                lb.Size = new Size(960, 38);

            lb.Name = "label1";

            myCombobox TypeCombo = new myCombobox();
            TypeCombo.BackColor = System.Drawing.Color.White;
            TypeCombo.BorderColor = System.Drawing.Color.White;
            TypeCombo.BorderSize = 1;
            TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            TypeCombo.Font = new System.Drawing.Font("Rubik", 12F);
            TypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(96)))), ((int)(((byte)(117)))));
            TypeCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(186)))));
            TypeCombo.Items.AddRange(new object[] {
            "All",
            "Social Media",
            "Entertainment",
            "Gaming"});
            TypeCombo.ListBackColor = System.Drawing.Color.White;
            TypeCombo.ListTextColor = System.Drawing.Color.DimGray;
            TypeCombo.Location = new System.Drawing.Point(34, 34);
            TypeCombo.Margin = new System.Windows.Forms.Padding(4);
            TypeCombo.MaximumSize = new System.Drawing.Size(322, 70);
            TypeCombo.MinimumSize = new System.Drawing.Size(100, 38);
            TypeCombo.Name = "TypeCombo";
            TypeCombo.Padding = new System.Windows.Forms.Padding(1);
            TypeCombo.Size = new System.Drawing.Size(173, 38);
            TypeCombo.TabIndex = 6;
            TypeCombo.Texts = "";
            TypeCombo.OnSelectedIndexChanged += new System.EventHandler(this.TypeCombo_OnSelectedIndexChanged);

            customFlowPanelLayout1.Controls.Add(TypeCombo);
            customFlowPanelLayout1.Controls.Add(lb);
        }
        private void TypeCombo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var TypeCombo = customFlowPanelLayout1.Controls.Find("TypeCombo",false).FirstOrDefault() as myCombobox;

            if (TypeCombo.Texts == "All")
            {
                customFlowPanelLayout1.Controls.Clear();
                CreateAllNps();
                var TypeCombo_ = customFlowPanelLayout1.Controls.Find("TypeCombo", false).FirstOrDefault() as myCombobox;
                TypeCombo_.Texts = "All";
            }
            else if (TypeCombo.Texts == "Social Media")
            {
                foreach (var item in passRepo.NonDeleted_OrderedByDate(currentUser))
                {
                    newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;
                    NpCtl.Visible = true;

                    if (NpCtl.types1.label1.Text != "Social Media")
                        NpCtl.Visible = false;
                }
            }
            else if (TypeCombo.Texts == "Gaming")
            {
                foreach (var item in passRepo.NonDeleted_OrderedByDate(currentUser))
                {
                    newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;
                    NpCtl.Visible = true;

                    if (NpCtl.types1.label1.Text != "Gaming")
                        NpCtl.Visible = false;
                }
            }
            else if (TypeCombo.Texts == "Entertainment")
            {
                foreach (var item in passRepo.NonDeleted_OrderedByDate(currentUser))
                {
                    newPasswords NpCtl = customFlowPanelLayout1.Controls.Find("Np_" + item.ID, true).FirstOrDefault() as newPasswords;
                    NpCtl.Visible = true;

                    if (NpCtl.types1.label1.Text != "Entertainment")
                        NpCtl.Visible = false;
                }
            }
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
        private void customFlowPanelLayout1_Click(object sender, EventArgs e)
        {
            sidePanel.Focus();
        }


        // Log out
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            var mb = new WarningMessageBox("Log Out").ShowDialog();
            if (mb == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                new LoginForm().Show();
                this.Hide();
            }
        }
        private void LogoutBtn_Paint(object sender, PaintEventArgs e)
        {
            WebLogo_Alias(e, "log-out.png", 0, 0, 24);
        }
        private void LogoutBtn_MouseEnter(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.FromArgb(79, 82, 112);
        }
        private void LogoutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogoutBtn.BackColor = Color.Transparent;
        }

    }
}
