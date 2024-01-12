using System.Windows.Forms;
using Password_Manager.PL;

namespace Password_Manager.PL
{
    partial class addForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.categLabel = new System.Windows.Forms.Label();
            this.webLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.typecombo = new Password_Manager.PL.userControls.myCombobox();
            this.GenerateBtn = new Password_Manager.PL.userControls.CustomButton();
            this.noteTxtbox = new Password_Manager.userControls.CustomTextbox();
            this.AddOrEdit_Btn = new Password_Manager.PL.userControls.CustomButton();
            this.passBox = new Password_Manager.userControls.CustomTextbox();
            this.userBox = new Password_Manager.userControls.CustomTextbox();
            this.webBox = new Password_Manager.userControls.CustomTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Work Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.titleLabel.Location = new System.Drawing.Point(54, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(158, 29);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Add Password";
            // 
            // categLabel
            // 
            this.categLabel.AutoSize = true;
            this.categLabel.Font = new System.Drawing.Font("Work Sans Medium", 11.25F);
            this.categLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.categLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categLabel.Location = new System.Drawing.Point(56, 332);
            this.categLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 6);
            this.categLabel.Name = "categLabel";
            this.categLabel.Size = new System.Drawing.Size(75, 22);
            this.categLabel.TabIndex = 13;
            this.categLabel.Text = "Category";
            // 
            // webLabel
            // 
            this.webLabel.AutoSize = true;
            this.webLabel.Font = new System.Drawing.Font("Work Sans Medium", 11.25F);
            this.webLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.webLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.webLabel.Location = new System.Drawing.Point(56, 107);
            this.webLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 6);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(69, 22);
            this.webLabel.TabIndex = 5;
            this.webLabel.Text = "Website";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Work Sans Medium", 11.25F);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.userLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userLabel.Location = new System.Drawing.Point(56, 182);
            this.userLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 6);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(85, 22);
            this.userLabel.TabIndex = 11;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Work Sans Medium", 11.25F);
            this.passLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.passLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passLabel.Location = new System.Drawing.Point(56, 257);
            this.passLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 6);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(81, 22);
            this.passLabel.TabIndex = 19;
            this.passLabel.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 83);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseD);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseM);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(352, 40);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 6;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.closeBtn_Paint);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Work Sans Medium", 11.25F);
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.noteLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.noteLabel.Location = new System.Drawing.Point(56, 415);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 6);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(45, 22);
            this.noteLabel.TabIndex = 24;
            this.noteLabel.Text = "Note";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.MaxLabel.Location = new System.Drawing.Point(346, 585);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(39, 17);
            this.MaxLabel.TabIndex = 26;
            this.MaxLabel.Text = "/100";
            // 
            // CounterLabel
            // 
            this.CounterLabel.Font = new System.Drawing.Font("Rubik", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.CounterLabel.Location = new System.Drawing.Point(311, 585);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(39, 17);
            this.CounterLabel.TabIndex = 27;
            this.CounterLabel.Text = "0";
            this.CounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 14);
            this.panel2.TabIndex = 22;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseD);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseM);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Work Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Password";
            // 
            // typecombo
            // 
            this.typecombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.typecombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            this.typecombo.BorderSize = 1;
            this.typecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.typecombo.Font = new System.Drawing.Font("Work Sans Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typecombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.typecombo.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.typecombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.typecombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.typecombo.Location = new System.Drawing.Point(56, 364);
            this.typecombo.Margin = new System.Windows.Forms.Padding(4);
            this.typecombo.MaximumSize = new System.Drawing.Size(322, 45);
            this.typecombo.MinimumSize = new System.Drawing.Size(322, 44);
            this.typecombo.Name = "typecombo";
            this.typecombo.Padding = new System.Windows.Forms.Padding(1);
            this.typecombo.Size = new System.Drawing.Size(322, 45);
            this.typecombo.TabIndex = 3;
            this.typecombo.Texts = "";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.GenerateBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.GenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GenerateBtn.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.GenerateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GenerateBtn.BorderRadius = 4;
            this.GenerateBtn.BorderSize = 0;
            this.GenerateBtn.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.GenerateBtn.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.GenerateBtn.FlatAppearance.BorderSize = 0;
            this.GenerateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateBtn.Location = new System.Drawing.Point(343, 293);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Padding = new System.Windows.Forms.Padding(4);
            this.GenerateBtn.Size = new System.Drawing.Size(24, 24);
            this.GenerateBtn.TabIndex = 25;
            this.GenerateBtn.TextColor = System.Drawing.Color.White;
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.Generate_Click);
            this.GenerateBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.customButton2_Paint);
            // 
            // noteTxtbox
            // 
            this.noteTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.noteTxtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            this.noteTxtbox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.noteTxtbox.BorderRadius = 4;
            this.noteTxtbox.BorderSize = 1;
            this.noteTxtbox.CharLimit = 100;
            this.noteTxtbox.CharPass = '\0';
            this.noteTxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.noteTxtbox.Location = new System.Drawing.Point(56, 441);
            this.noteTxtbox.Margin = new System.Windows.Forms.Padding(0);
            this.noteTxtbox.Multiline = true;
            this.noteTxtbox.Name = "noteTxtbox";
            this.noteTxtbox.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.noteTxtbox.PasswordChar = false;
            this.noteTxtbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.noteTxtbox.PlaceholderFont = new System.Drawing.Font("Work Sans Medium", 12F);
            this.noteTxtbox.PlaceholderText = "";
            this.noteTxtbox.Size = new System.Drawing.Size(322, 139);
            this.noteTxtbox.TabIndex = 4;
            this.noteTxtbox.Texts = "";
            this.noteTxtbox.UnderlinedStyle = false;
            this.noteTxtbox._TextChanged += new System.EventHandler(this.noteTxtbox__TextChanged);
            // 
            // AddOrEdit_Btn
            // 
            this.AddOrEdit_Btn.BackColor = System.Drawing.Color.White;
            this.AddOrEdit_Btn.BackgroundColor = System.Drawing.Color.White;
            this.AddOrEdit_Btn.BgColor = System.Drawing.Color.White;
            this.AddOrEdit_Btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.AddOrEdit_Btn.BorderRadius = 4;
            this.AddOrEdit_Btn.BorderSize = 2;
            this.AddOrEdit_Btn.ClrEnter = System.Drawing.Color.White;
            this.AddOrEdit_Btn.ClrLeave = System.Drawing.Color.White;
            this.AddOrEdit_Btn.FlatAppearance.BorderSize = 0;
            this.AddOrEdit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrEdit_Btn.Font = new System.Drawing.Font("Work Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrEdit_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.AddOrEdit_Btn.Location = new System.Drawing.Point(55, 617);
            this.AddOrEdit_Btn.Name = "AddOrEdit_Btn";
            this.AddOrEdit_Btn.Size = new System.Drawing.Size(325, 46);
            this.AddOrEdit_Btn.TabIndex = 5;
            this.AddOrEdit_Btn.Text = "Add";
            this.AddOrEdit_Btn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(141)))));
            this.AddOrEdit_Btn.UseVisualStyleBackColor = false;
            this.AddOrEdit_Btn.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.passBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            this.passBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.passBox.BorderRadius = 4;
            this.passBox.BorderSize = 1;
            this.passBox.CharLimit = 32767;
            this.passBox.CharPass = '\0';
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.passBox.Location = new System.Drawing.Point(56, 283);
            this.passBox.Margin = new System.Windows.Forms.Padding(0);
            this.passBox.Multiline = false;
            this.passBox.Name = "passBox";
            this.passBox.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.passBox.PasswordChar = false;
            this.passBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.passBox.PlaceholderFont = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passBox.PlaceholderText = "***************";
            this.passBox.Size = new System.Drawing.Size(322, 44);
            this.passBox.TabIndex = 2;
            this.passBox.Texts = "";
            this.passBox.UnderlinedStyle = false;
            this.passBox._TextChanged += new System.EventHandler(this.webBox__TextChanged);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.userBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            this.userBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.userBox.BorderRadius = 4;
            this.userBox.BorderSize = 1;
            this.userBox.CharLimit = 32767;
            this.userBox.CharPass = '\0';
            this.userBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.userBox.Location = new System.Drawing.Point(56, 208);
            this.userBox.Margin = new System.Windows.Forms.Padding(0);
            this.userBox.Multiline = false;
            this.userBox.Name = "userBox";
            this.userBox.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.userBox.PasswordChar = false;
            this.userBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.userBox.PlaceholderFont = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userBox.PlaceholderText = "user@email.co or user1234";
            this.userBox.Size = new System.Drawing.Size(322, 44);
            this.userBox.TabIndex = 1;
            this.userBox.Texts = "";
            this.userBox.UnderlinedStyle = false;
            this.userBox._TextChanged += new System.EventHandler(this.webBox__TextChanged);
            // 
            // webBox
            // 
            this.webBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.webBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(244)))));
            this.webBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this.webBox.BorderRadius = 4;
            this.webBox.BorderSize = 1;
            this.webBox.CharLimit = 32767;
            this.webBox.CharPass = '\0';
            this.webBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(170)))));
            this.webBox.Location = new System.Drawing.Point(56, 133);
            this.webBox.Margin = new System.Windows.Forms.Padding(0);
            this.webBox.Multiline = false;
            this.webBox.Name = "webBox";
            this.webBox.Padding = new System.Windows.Forms.Padding(20, 10, 2, 10);
            this.webBox.PasswordChar = false;
            this.webBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(160)))), ((int)(((byte)(215)))));
            this.webBox.PlaceholderFont = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.webBox.PlaceholderText = "ex: www.google.com";
            this.webBox.Size = new System.Drawing.Size(322, 44);
            this.webBox.TabIndex = 0;
            this.webBox.Texts = "";
            this.webBox.UnderlinedStyle = false;
            this.webBox._TextChanged += new System.EventHandler(this.webBox__TextChanged);
            // 
            // addForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 704);
            this.Controls.Add(this.typecombo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteTxtbox);
            this.Controls.Add(this.AddOrEdit_Btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.webLabel);
            this.Controls.Add(this.webBox);
            this.Controls.Add(this.categLabel);
            this.Controls.Add(this.CounterLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addForm";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.Click += new System.EventHandler(this.paintBorderPanel1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox closeBtn;
        private Label titleLabel;
        private Label categLabel;
        private Password_Manager.userControls.CustomTextbox webBox;
        private Label webLabel;
        private Label userLabel;
        private Password_Manager.userControls.CustomTextbox userBox;
        private Label passLabel;
        private Password_Manager.userControls.CustomTextbox passBox;
        private Panel panel1;
        private userControls.CustomButton AddOrEdit_Btn;
        private Label noteLabel;
        private Password_Manager.userControls.CustomTextbox noteTxtbox;
        private userControls.CustomButton GenerateBtn;
        private Label MaxLabel;
        private Label CounterLabel;
        private Panel panel2;
        private Label label1;
        private userControls.myCombobox typecombo;
    }
}