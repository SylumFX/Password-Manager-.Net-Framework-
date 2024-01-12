using System.Windows.Forms;

namespace Password_Manager.userControls
{
    partial class newPasswords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.webLogo = new System.Windows.Forms.PictureBox();
            this.FavButton_ = new Password_Manager.PL.userControls.CustomButton();
            this.customButton1 = new Password_Manager.PL.userControls.CustomButton();
            this.types1 = new Password_Manager.PL.userControls.Types();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Work Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPasswordToolStripMenuItem,
            this.copyUsernameToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.launchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 215);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.AutoSize = false;
            this.copyPasswordToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.copyPasswordToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyPasswordToolStripMenuItem.Font = new System.Drawing.Font("Work Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.copyPasswordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyPasswordToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.copyPasswordToolStripMenuItem.Text = "Copy Password";
            this.copyPasswordToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.copyPasswordToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            this.copyPasswordToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.copyPasswordToolStripMenuItem_Paint);
            // 
            // copyUsernameToolStripMenuItem
            // 
            this.copyUsernameToolStripMenuItem.AutoSize = false;
            this.copyUsernameToolStripMenuItem.Font = new System.Drawing.Font("Work Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyUsernameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.copyUsernameToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyUsernameToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.copyUsernameToolStripMenuItem.Name = "copyUsernameToolStripMenuItem";
            this.copyUsernameToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.copyUsernameToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.copyUsernameToolStripMenuItem.Text = "Copy Username";
            this.copyUsernameToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.copyUsernameToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.copyUsernameToolStripMenuItem.Click += new System.EventHandler(this.copyUsernameToolStripMenuItem_Click_1);
            this.copyUsernameToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.copyUsernameToolStripMenuItem_Paint);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.IndianRed;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 5);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AutoSize = false;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Work Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.deleteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            this.deleteToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.deleteToolStripMenuItem_Paint);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.AutoSize = false;
            this.modifyToolStripMenuItem.Font = new System.Drawing.Font("Work Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.modifyToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            this.modifyToolStripMenuItem.Paint += new System.Windows.Forms.PaintEventHandler(this.modifyToolStripMenuItem_Paint);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.AutoSize = false;
            this.launchToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.launchToolStripMenuItem.Font = new System.Drawing.Font("Work Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.launchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.launchToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.launchToolStripMenuItem.Text = "Launch";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoEllipsis = true;
            this.websiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.websiteLabel.Font = new System.Drawing.Font("Work Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.websiteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.websiteLabel.Location = new System.Drawing.Point(24, 113);
            this.websiteLabel.Margin = new System.Windows.Forms.Padding(24, 8, 0, 24);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(203, 18);
            this.websiteLabel.TabIndex = 7;
            this.websiteLabel.Text = "Website";
            this.websiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLabel
            // 
            this.userLabel.AutoEllipsis = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Work Sans Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.userLabel.Location = new System.Drawing.Point(24, 88);
            this.userLabel.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(203, 18);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "User or Email";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // webLogo
            // 
            this.webLogo.Location = new System.Drawing.Point(24, 24);
            this.webLogo.Margin = new System.Windows.Forms.Padding(0);
            this.webLogo.Name = "webLogo";
            this.webLogo.Size = new System.Drawing.Size(24, 24);
            this.webLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.webLogo.TabIndex = 8;
            this.webLogo.TabStop = false;
            this.webLogo.Visible = false;
            // 
            // FavButton_
            // 
            this.FavButton_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FavButton_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FavButton_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FavButton_.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FavButton_.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FavButton_.BorderRadius = 4;
            this.FavButton_.BorderSize = 0;
            this.FavButton_.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FavButton_.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.FavButton_.FlatAppearance.BorderSize = 0;
            this.FavButton_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavButton_.ForeColor = System.Drawing.Color.White;
            this.FavButton_.Location = new System.Drawing.Point(224, 111);
            this.FavButton_.Name = "FavButton_";
            this.FavButton_.Padding = new System.Windows.Forms.Padding(4);
            this.FavButton_.Size = new System.Drawing.Size(24, 24);
            this.FavButton_.TabIndex = 15;
            this.FavButton_.TextColor = System.Drawing.Color.White;
            this.FavButton_.UseVisualStyleBackColor = false;
            this.FavButton_.Click += new System.EventHandler(this.Fav_Ico_Click);
            this.FavButton_.Paint += new System.Windows.Forms.PaintEventHandler(this.Fav_Ico_Paint);
            this.FavButton_.Enter += new System.EventHandler(this.Fav_Ico_Enter);
            this.FavButton_.Leave += new System.EventHandler(this.Fav_Ico_Leave);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customButton1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 4;
            this.customButton1.BorderSize = 0;
            this.customButton1.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.customButton1.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(224, 26);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(4);
            this.customButton1.Size = new System.Drawing.Size(24, 24);
            this.customButton1.TabIndex = 11;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            this.customButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.customButton1_Paint);
            // 
            // types1
            // 
            this.types1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.types1.BorderColor = System.Drawing.Color.Transparent;
            this.types1.BorderRadius = 10;
            this.types1.BorderSize = 1;
            this.types1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.types1.getType = null;
            this.types1.Location = new System.Drawing.Point(24, 60);
            this.types1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.types1.Name = "types1";
            this.types1.Size = new System.Drawing.Size(88, 20);
            this.types1.TabIndex = 10;
            // 
            // newPasswords
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.FavButton_);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.types1);
            this.Controls.Add(this.webLogo);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.websiteLabel);
            this.Font = new System.Drawing.Font("Work Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 16, 16);
            this.Name = "newPasswords";
            this.Padding = new System.Windows.Forms.Padding(24, 24, 16, 24);
            this.Size = new System.Drawing.Size(270, 154);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.newPasswords_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem copyPasswordToolStripMenuItem;
        private ToolStripMenuItem copyUsernameToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        public ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem launchToolStripMenuItem;
        public Label websiteLabel;
        public Label userLabel;
        public PictureBox webLogo;
        public PL.userControls.Types types1;
        private PL.userControls.CustomButton customButton1;
        internal PL.userControls.CustomButton FavButton_;
    }
}
