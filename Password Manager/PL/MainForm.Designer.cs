using System.Windows.Forms;
using Password_Manager.PL.userControls;

namespace Password_Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.LogoutBtn = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MoveForm_Panel = new System.Windows.Forms.Panel();
            this.searchIco = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.minBtn = new System.Windows.Forms.PictureBox();
            this.maxBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.Deleted_Button = new Password_Manager.PL.userControls.CustomButton();
            this.VaultButton = new Password_Manager.PL.userControls.CustomButton();
            this.customFlowPanelLayout1 = new Password_Manager.PL.userControls.CustomFlowPanelLayout();
            this.SearchBox = new Password_Manager.userControls.CustomTextbox();
            this.AddButton = new Password_Manager.PL.userControls.CustomButton();
            this.FilterCombo = new Password_Manager.PL.userControls.myCombobox();
            this.customFlowPanelLayout2 = new Password_Manager.PL.userControls.CustomFlowPanelLayout();
            this.notesPanelBorder = new Password_Manager.PL.userControls.PaintBorderPanel();
            this.passPaintBorder = new Password_Manager.PL.userControls.PaintBorderPanel();
            this.dashPaintBorder = new Password_Manager.PL.userControls.PaintBorderPanel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.MoveForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIco)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.sidePanel.Controls.Add(this.LogoutBtn);
            this.sidePanel.Controls.Add(this.Deleted_Button);
            this.sidePanel.Controls.Add(this.VaultButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(232, 1024);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Click += new System.EventHandler(this.customFlowPanelLayout1_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.Location = new System.Drawing.Point(104, 942);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(24, 24);
            this.LogoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutBtn.TabIndex = 8;
            this.LogoutBtn.TabStop = false;
            this.LogoutBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            this.LogoutBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoutBtn_Paint);
            this.LogoutBtn.MouseEnter += new System.EventHandler(this.LogoutBtn_MouseEnter);
            this.LogoutBtn.MouseLeave += new System.EventHandler(this.LogoutBtn_MouseLeave);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(223, -8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1242, 1041);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.customFlowPanelLayout1);
            this.tabPage1.Controls.Add(this.MoveForm_Panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1234, 1032);
            this.tabPage1.TabIndex = 0;
            // 
            // MoveForm_Panel
            // 
            this.MoveForm_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.MoveForm_Panel.Controls.Add(this.searchIco);
            this.MoveForm_Panel.Controls.Add(this.SearchBox);
            this.MoveForm_Panel.Controls.Add(this.AddButton);
            this.MoveForm_Panel.Controls.Add(this.FilterCombo);
            this.MoveForm_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveForm_Panel.Location = new System.Drawing.Point(3, 3);
            this.MoveForm_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.MoveForm_Panel.Name = "MoveForm_Panel";
            this.MoveForm_Panel.Size = new System.Drawing.Size(1228, 142);
            this.MoveForm_Panel.TabIndex = 1;
            this.MoveForm_Panel.Click += new System.EventHandler(this.customFlowPanelLayout1_Click);
            this.MoveForm_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MoveForm_Panel_Paint);
            this.MoveForm_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseD);
            this.MoveForm_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseM);
            // 
            // searchIco
            // 
            this.searchIco.BackColor = System.Drawing.Color.White;
            this.searchIco.Location = new System.Drawing.Point(66, 79);
            this.searchIco.Name = "searchIco";
            this.searchIco.Size = new System.Drawing.Size(22, 22);
            this.searchIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIco.TabIndex = 1;
            this.searchIco.TabStop = false;
            this.searchIco.Paint += new System.Windows.Forms.PaintEventHandler(this.searchIco_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.customFlowPanelLayout2);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1234, 1032);
            this.tabPage2.TabIndex = 1;
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.minBtn.Location = new System.Drawing.Point(1342, 11);
            this.minBtn.Margin = new System.Windows.Forms.Padding(10);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(24, 24);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBtn.TabIndex = 4;
            this.minBtn.TabStop = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.minBtn_Paint);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.maxBtn.Location = new System.Drawing.Point(1374, 11);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(10);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(24, 24);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 3;
            this.maxBtn.TabStop = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            this.maxBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.maxBtn_Paint);
            this.maxBtn.MouseEnter += new System.EventHandler(this.maxBtn_MouseEnter);
            this.maxBtn.MouseLeave += new System.EventHandler(this.maxBtn_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.closeBtn.Location = new System.Drawing.Point(1406, 11);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.closeBtn_Paint);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // Deleted_Button
            // 
            this.Deleted_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.Deleted_Button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.Deleted_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deleted_Button.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.Deleted_Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Deleted_Button.BorderRadius = 4;
            this.Deleted_Button.BorderSize = 0;
            this.Deleted_Button.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.Deleted_Button.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(116)))), ((int)(((byte)(150)))));
            this.Deleted_Button.FlatAppearance.BorderSize = 0;
            this.Deleted_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deleted_Button.Font = new System.Drawing.Font("Work Sans Medium", 15F);
            this.Deleted_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.Deleted_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deleted_Button.Location = new System.Drawing.Point(6, 159);
            this.Deleted_Button.Margin = new System.Windows.Forms.Padding(0);
            this.Deleted_Button.Name = "Deleted_Button";
            this.Deleted_Button.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.Deleted_Button.Size = new System.Drawing.Size(220, 56);
            this.Deleted_Button.TabIndex = 6;
            this.Deleted_Button.Text = "Deleted";
            this.Deleted_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deleted_Button.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(222)))));
            this.Deleted_Button.UseVisualStyleBackColor = false;
            this.Deleted_Button.Click += new System.EventHandler(this.Deleted_Button_Click);
            this.Deleted_Button.Paint += new System.Windows.Forms.PaintEventHandler(this.NoteButton_Paint);
            // 
            // VaultButton
            // 
            this.VaultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.VaultButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.VaultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VaultButton.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.VaultButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.VaultButton.BorderRadius = 4;
            this.VaultButton.BorderSize = 0;
            this.VaultButton.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.VaultButton.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(191)))), ((int)(((byte)(234)))));
            this.VaultButton.FlatAppearance.BorderSize = 0;
            this.VaultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VaultButton.Font = new System.Drawing.Font("Work Sans SemiBold", 15F);
            this.VaultButton.ForeColor = System.Drawing.Color.White;
            this.VaultButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VaultButton.Location = new System.Drawing.Point(6, 94);
            this.VaultButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.VaultButton.Name = "VaultButton";
            this.VaultButton.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.VaultButton.Size = new System.Drawing.Size(220, 56);
            this.VaultButton.TabIndex = 4;
            this.VaultButton.Text = "Vault";
            this.VaultButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VaultButton.TextColor = System.Drawing.Color.White;
            this.VaultButton.UseVisualStyleBackColor = false;
            this.VaultButton.Click += new System.EventHandler(this.VaultButton_Click);
            this.VaultButton.Paint += new System.Windows.Forms.PaintEventHandler(this.VaultButton_Paint);
            // 
            // customFlowPanelLayout1
            // 
            this.customFlowPanelLayout1.AutoScroll = true;
            this.customFlowPanelLayout1.AutoSize = true;
            this.customFlowPanelLayout1.BackColor = System.Drawing.Color.White;
            this.customFlowPanelLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFlowPanelLayout1.Font = new System.Drawing.Font("Rubik", 8.999999F);
            this.customFlowPanelLayout1.Location = new System.Drawing.Point(3, 145);
            this.customFlowPanelLayout1.Name = "customFlowPanelLayout1";
            this.customFlowPanelLayout1.Padding = new System.Windows.Forms.Padding(30, 30, 0, 42);
            this.customFlowPanelLayout1.Size = new System.Drawing.Size(1228, 884);
            this.customFlowPanelLayout1.TabIndex = 2;
            this.customFlowPanelLayout1.Click += new System.EventHandler(this.customFlowPanelLayout1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.SearchBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(186)))));
            this.SearchBox.BorderRadius = 4;
            this.SearchBox.BorderSize = 1;
            this.SearchBox.CharLimit = 32767;
            this.SearchBox.CharPass = '\0';
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(189)))));
            this.SearchBox.Location = new System.Drawing.Point(55, 66);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Padding = new System.Windows.Forms.Padding(50, 12, 10, 12);
            this.SearchBox.PasswordChar = false;
            this.SearchBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.SearchBox.PlaceholderFont = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SearchBox.PlaceholderText = "Search...";
            this.SearchBox.Size = new System.Drawing.Size(766, 48);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.Texts = "";
            this.SearchBox.UnderlinedStyle = false;
            this.SearchBox._TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(229)))));
            this.AddButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(229)))));
            this.AddButton.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(229)))));
            this.AddButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddButton.BorderRadius = 4;
            this.AddButton.BorderSize = 0;
            this.AddButton.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(229)))));
            this.AddButton.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(229)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Rubik", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(1018, 71);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 40);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.TextColor = System.Drawing.Color.White;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterCombo
            // 
            this.FilterCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.FilterCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.FilterCombo.BorderSize = 1;
            this.FilterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.FilterCombo.Font = new System.Drawing.Font("Rubik", 12F);
            this.FilterCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.FilterCombo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(186)))));
            this.FilterCombo.Items.AddRange(new object[] {
            "By Username",
            "By Website"});
            this.FilterCombo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.FilterCombo.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.FilterCombo.Location = new System.Drawing.Point(833, 72);
            this.FilterCombo.Margin = new System.Windows.Forms.Padding(4);
            this.FilterCombo.MaximumSize = new System.Drawing.Size(322, 70);
            this.FilterCombo.MinimumSize = new System.Drawing.Size(100, 38);
            this.FilterCombo.Name = "FilterCombo";
            this.FilterCombo.Padding = new System.Windows.Forms.Padding(1);
            this.FilterCombo.Size = new System.Drawing.Size(173, 38);
            this.FilterCombo.TabIndex = 5;
            this.FilterCombo.Texts = "Filter";
            // 
            // customFlowPanelLayout2
            // 
            this.customFlowPanelLayout2.AutoScroll = true;
            this.customFlowPanelLayout2.AutoSize = true;
            this.customFlowPanelLayout2.BackColor = System.Drawing.Color.White;
            this.customFlowPanelLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customFlowPanelLayout2.Font = new System.Drawing.Font("Rubik", 8.999999F);
            this.customFlowPanelLayout2.Location = new System.Drawing.Point(3, 3);
            this.customFlowPanelLayout2.Name = "customFlowPanelLayout2";
            this.customFlowPanelLayout2.Padding = new System.Windows.Forms.Padding(30, 30, 0, 42);
            this.customFlowPanelLayout2.Size = new System.Drawing.Size(1228, 1026);
            this.customFlowPanelLayout2.TabIndex = 3;
            // 
            // notesPanelBorder
            // 
            this.notesPanelBorder.BackColor = System.Drawing.Color.Transparent;
            this.notesPanelBorder.chosenPaintColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.notesPanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesPanelBorder.Location = new System.Drawing.Point(0, 0);
            this.notesPanelBorder.Name = "notesPanelBorder";
            this.notesPanelBorder.Size = new System.Drawing.Size(232, 54);
            this.notesPanelBorder.TabIndex = 2;
            this.notesPanelBorder.Value = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            // 
            // passPaintBorder
            // 
            this.passPaintBorder.BackColor = System.Drawing.Color.Transparent;
            this.passPaintBorder.chosenPaintColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.passPaintBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passPaintBorder.Location = new System.Drawing.Point(0, 0);
            this.passPaintBorder.Name = "passPaintBorder";
            this.passPaintBorder.Size = new System.Drawing.Size(232, 54);
            this.passPaintBorder.TabIndex = 2;
            this.passPaintBorder.Value = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            // 
            // dashPaintBorder
            // 
            this.dashPaintBorder.BackColor = System.Drawing.Color.Transparent;
            this.dashPaintBorder.chosenPaintColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.dashPaintBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashPaintBorder.Location = new System.Drawing.Point(0, 0);
            this.dashPaintBorder.Name = "dashPaintBorder";
            this.dashPaintBorder.Size = new System.Drawing.Size(232, 54);
            this.dashPaintBorder.TabIndex = 2;
            this.dashPaintBorder.Value = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutBtn)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.MoveForm_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private PL.userControls.PaintBorderPanel passPaintBorder;
        private PL.userControls.PaintBorderPanel notesPanelBorder;
        private PictureBox closeBtn;
        private PictureBox maxBtn;
        private PictureBox minBtn;
        private PaintBorderPanel dashPaintBorder;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel MoveForm_Panel;
        private CustomButton AddButton;
        private myCombobox FilterCombo;
        private PictureBox searchIco;
        private TabPage tabPage2;
        private CustomFlowPanelLayout customFlowPanelLayout1;
        private CustomButton VaultButton;
        private CustomButton Deleted_Button;
        private PictureBox LogoutBtn;
        private userControls.CustomTextbox SearchBox;
        private CustomFlowPanelLayout customFlowPanelLayout2;
    }
}

