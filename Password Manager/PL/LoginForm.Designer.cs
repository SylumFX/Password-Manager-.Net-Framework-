namespace Password_Manager.PL
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.piN_Code1 = new Password_Manager.PL.userControls.PIN_Code();
            this.passIco = new System.Windows.Forms.PictureBox();
            this.userIco = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RememberBox = new System.Windows.Forms.CheckBox();
            this.SignUpButton = new Password_Manager.PL.userControls.CustomButton();
            this.LoginButton = new Password_Manager.PL.userControls.CustomButton();
            this.UsernameBox = new Password_Manager.userControls.CustomTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BackBtn = new Password_Manager.PL.userControls.CustomButton();
            this.MP_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LName_Box = new Password_Manager.userControls.CustomTextbox();
            this.FName_Box = new Password_Manager.userControls.CustomTextbox();
            this.piN_Code2 = new Password_Manager.PL.userControls.PIN_Code();
            this.SignUp_Btn = new Password_Manager.PL.userControls.CustomButton();
            this.User_Box = new Password_Manager.userControls.CustomTextbox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIco)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(-7, -8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 464);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.piN_Code1);
            this.tabPage1.Controls.Add(this.passIco);
            this.tabPage1.Controls.Add(this.userIco);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.RememberBox);
            this.tabPage1.Controls.Add(this.SignUpButton);
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.UsernameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseD);
            // 
            // piN_Code1
            // 
            this.piN_Code1.BackColor = System.Drawing.Color.Transparent;
            this.piN_Code1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.piN_Code1.BorderSize = 1;
            this.piN_Code1.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piN_Code1.Location = new System.Drawing.Point(150, 182);
            this.piN_Code1.Margin = new System.Windows.Forms.Padding(6);
            this.piN_Code1.Name = "piN_Code1";
            this.piN_Code1.Size = new System.Drawing.Size(193, 50);
            this.piN_Code1.TabIndex = 1;
            this.piN_Code1._TextChanged += new System.EventHandler(this.UsernameBox__TextChanged);
            // 
            // passIco
            // 
            this.passIco.Location = new System.Drawing.Point(97, 195);
            this.passIco.Name = "passIco";
            this.passIco.Size = new System.Drawing.Size(24, 24);
            this.passIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passIco.TabIndex = 30;
            this.passIco.TabStop = false;
            this.passIco.Paint += new System.Windows.Forms.PaintEventHandler(this.passIco_Paint);
            // 
            // userIco
            // 
            this.userIco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.userIco.Location = new System.Drawing.Point(97, 137);
            this.userIco.Name = "userIco";
            this.userIco.Size = new System.Drawing.Size(24, 24);
            this.userIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIco.TabIndex = 29;
            this.userIco.TabStop = false;
            this.userIco.Paint += new System.Windows.Forms.PaintEventHandler(this.userIco_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(137)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 15);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseD);
            // 
            // RememberBox
            // 
            this.RememberBox.AutoSize = true;
            this.RememberBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.RememberBox.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RememberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(140)))), ((int)(((byte)(169)))));
            this.RememberBox.Location = new System.Drawing.Point(85, 244);
            this.RememberBox.Name = "RememberBox";
            this.RememberBox.Size = new System.Drawing.Size(113, 21);
            this.RememberBox.TabIndex = 3;
            this.RememberBox.Text = "Remember me";
            this.RememberBox.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.SignUpButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.SignUpButton.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.SignUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SignUpButton.BorderRadius = 4;
            this.SignUpButton.BorderSize = 0;
            this.SignUpButton.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.SignUpButton.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Work Sans Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.SignUpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpButton.Location = new System.Drawing.Point(16, 391);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(106, 48);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.LoginButton.BgColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.LoginButton.BorderRadius = 4;
            this.LoginButton.BorderSize = 1;
            this.LoginButton.ClrEnter = System.Drawing.Color.Transparent;
            this.LoginButton.ClrLeave = System.Drawing.Color.Transparent;
            this.LoginButton.Enabled = false;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Work Sans Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LoginButton.ForeColor = System.Drawing.Color.LightGray;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(85, 280);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(322, 48);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextColor = System.Drawing.Color.LightGray;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.UsernameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.UsernameBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.UsernameBox.BorderRadius = 4;
            this.UsernameBox.BorderSize = 1;
            this.UsernameBox.CharLimit = 32767;
            this.UsernameBox.CharPass = '\0';
            this.UsernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.UsernameBox.Location = new System.Drawing.Point(85, 127);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameBox.Multiline = false;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Padding = new System.Windows.Forms.Padding(50, 10, 2, 10);
            this.UsernameBox.PasswordChar = false;
            this.UsernameBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.UsernameBox.PlaceholderFont = new System.Drawing.Font("Work Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.Size = new System.Drawing.Size(322, 44);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.Texts = "";
            this.UsernameBox.UnderlinedStyle = false;
            this.UsernameBox._TextChanged += new System.EventHandler(this.UsernameBox__TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.BackBtn);
            this.tabPage2.Controls.Add(this.MP_Label);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.LName_Box);
            this.tabPage2.Controls.Add(this.FName_Box);
            this.tabPage2.Controls.Add(this.piN_Code2);
            this.tabPage2.Controls.Add(this.SignUp_Btn);
            this.tabPage2.Controls.Add(this.User_Box);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.BackBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.BackBtn.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.BackBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BackBtn.BorderRadius = 4;
            this.BackBtn.BorderSize = 0;
            this.BackBtn.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.BackBtn.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Work Sans Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.Location = new System.Drawing.Point(15, 25);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(30, 30);
            this.BackBtn.TabIndex = 38;
            this.BackBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.customButton1_Click);
            this.BackBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.BackBtn_Paint);
            // 
            // MP_Label
            // 
            this.MP_Label.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MP_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.MP_Label.Location = new System.Drawing.Point(109, 226);
            this.MP_Label.Margin = new System.Windows.Forms.Padding(0);
            this.MP_Label.Name = "MP_Label";
            this.MP_Label.Size = new System.Drawing.Size(85, 46);
            this.MP_Label.TabIndex = 37;
            this.MP_Label.Text = "Master Password";
            this.MP_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(137)))), ((int)(((byte)(232)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 15);
            this.panel2.TabIndex = 28;
            // 
            // LName_Box
            // 
            this.LName_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.LName_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.LName_Box.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.LName_Box.BorderRadius = 4;
            this.LName_Box.BorderSize = 1;
            this.LName_Box.CharLimit = 32767;
            this.LName_Box.CharPass = '\0';
            this.LName_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.LName_Box.Location = new System.Drawing.Point(255, 161);
            this.LName_Box.Margin = new System.Windows.Forms.Padding(0);
            this.LName_Box.Multiline = false;
            this.LName_Box.Name = "LName_Box";
            this.LName_Box.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.LName_Box.PasswordChar = false;
            this.LName_Box.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.LName_Box.PlaceholderFont = new System.Drawing.Font("Work Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LName_Box.PlaceholderText = "Last Name";
            this.LName_Box.Size = new System.Drawing.Size(152, 44);
            this.LName_Box.TabIndex = 36;
            this.LName_Box.Texts = "";
            this.LName_Box.UnderlinedStyle = false;
            this.LName_Box._TextChanged += new System.EventHandler(this.User_Box__TextChanged);
            // 
            // FName_Box
            // 
            this.FName_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.FName_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.FName_Box.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.FName_Box.BorderRadius = 4;
            this.FName_Box.BorderSize = 1;
            this.FName_Box.CharLimit = 32767;
            this.FName_Box.CharPass = '\0';
            this.FName_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.FName_Box.Location = new System.Drawing.Point(85, 161);
            this.FName_Box.Margin = new System.Windows.Forms.Padding(0);
            this.FName_Box.Multiline = false;
            this.FName_Box.Name = "FName_Box";
            this.FName_Box.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.FName_Box.PasswordChar = false;
            this.FName_Box.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.FName_Box.PlaceholderFont = new System.Drawing.Font("Work Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FName_Box.PlaceholderText = "First Name";
            this.FName_Box.Size = new System.Drawing.Size(152, 44);
            this.FName_Box.TabIndex = 35;
            this.FName_Box.Texts = "";
            this.FName_Box.UnderlinedStyle = false;
            this.FName_Box._TextChanged += new System.EventHandler(this.User_Box__TextChanged);
            // 
            // piN_Code2
            // 
            this.piN_Code2.BackColor = System.Drawing.Color.Transparent;
            this.piN_Code2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.piN_Code2.BorderSize = 1;
            this.piN_Code2.Font = new System.Drawing.Font("Work Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piN_Code2.Location = new System.Drawing.Point(214, 226);
            this.piN_Code2.Margin = new System.Windows.Forms.Padding(6);
            this.piN_Code2.Name = "piN_Code2";
            this.piN_Code2.Size = new System.Drawing.Size(193, 50);
            this.piN_Code2.TabIndex = 34;
            this.piN_Code2._TextChanged += new System.EventHandler(this.User_Box__TextChanged);
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.BackColor = System.Drawing.Color.Transparent;
            this.SignUp_Btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SignUp_Btn.BgColor = System.Drawing.Color.Transparent;
            this.SignUp_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.SignUp_Btn.BorderRadius = 4;
            this.SignUp_Btn.BorderSize = 1;
            this.SignUp_Btn.ClrEnter = System.Drawing.Color.Transparent;
            this.SignUp_Btn.ClrLeave = System.Drawing.Color.Transparent;
            this.SignUp_Btn.Enabled = false;
            this.SignUp_Btn.FlatAppearance.BorderSize = 0;
            this.SignUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp_Btn.Font = new System.Drawing.Font("Work Sans Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SignUp_Btn.ForeColor = System.Drawing.Color.LightGray;
            this.SignUp_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUp_Btn.Location = new System.Drawing.Point(85, 308);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(322, 48);
            this.SignUp_Btn.TabIndex = 33;
            this.SignUp_Btn.Text = "Sign up";
            this.SignUp_Btn.TextColor = System.Drawing.Color.LightGray;
            this.SignUp_Btn.UseVisualStyleBackColor = false;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // User_Box
            // 
            this.User_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.User_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.User_Box.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.User_Box.BorderRadius = 4;
            this.User_Box.BorderSize = 1;
            this.User_Box.CharLimit = 32767;
            this.User_Box.CharPass = '\0';
            this.User_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.User_Box.Location = new System.Drawing.Point(85, 98);
            this.User_Box.Margin = new System.Windows.Forms.Padding(0);
            this.User_Box.Multiline = false;
            this.User_Box.Name = "User_Box";
            this.User_Box.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.User_Box.PasswordChar = false;
            this.User_Box.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.User_Box.PlaceholderFont = new System.Drawing.Font("Work Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.User_Box.PlaceholderText = "Username";
            this.User_Box.Size = new System.Drawing.Size(322, 44);
            this.User_Box.TabIndex = 0;
            this.User_Box.Texts = "";
            this.User_Box.UnderlinedStyle = false;
            this.User_Box._TextChanged += new System.EventHandler(this.User_Box__TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(454, 22);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 7;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.closeBtn_Paint);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 449);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Work Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "²";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox RememberBox;
        private userControls.CustomButton SignUpButton;
        private userControls.CustomButton LoginButton;
        private Password_Manager.userControls.CustomTextbox UsernameBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox userIco;
        private System.Windows.Forms.PictureBox passIco;
        private userControls.PIN_Code piN_Code1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel panel2;
        private userControls.PIN_Code piN_Code2;
        private userControls.CustomButton SignUp_Btn;
        private Password_Manager.userControls.CustomTextbox User_Box;
        private Password_Manager.userControls.CustomTextbox FName_Box;
        private Password_Manager.userControls.CustomTextbox LName_Box;
        private System.Windows.Forms.Label MP_Label;
        private userControls.CustomButton BackBtn;
    }
}