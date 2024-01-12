namespace Password_Manager.PL
{
    partial class WarningMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new Password_Manager.PL.userControls.CustomButton();
            this.cancelBtn = new Password_Manager.PL.userControls.CustomButton();
            this.TextLbl = new System.Windows.Forms.Label();
            this.CaptionLbl = new System.Windows.Forms.Label();
            this.paintBorderPanel1 = new Password_Manager.PL.userControls.PaintBorderPanel();
            this.warningIco = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Location = new System.Drawing.Point(1, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 58);
            this.panel1.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.deleteButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.deleteButton.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.deleteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.deleteButton.BorderRadius = 4;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.ClrEnter = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.deleteButton.ClrLeave = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Work Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(168, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 34);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.White;
            this.cancelBtn.BgColor = System.Drawing.Color.White;
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cancelBtn.BorderRadius = 4;
            this.cancelBtn.BorderSize = 1;
            this.cancelBtn.ClrEnter = System.Drawing.Color.White;
            this.cancelBtn.ClrLeave = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Work Sans Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.cancelBtn.Location = new System.Drawing.Point(86, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(76, 34);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Font = new System.Drawing.Font("Work Sans Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.TextLbl.Location = new System.Drawing.Point(57, 67);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(256, 20);
            this.TextLbl.TabIndex = 1;
            this.TextLbl.Text = "This will be removed. Are you sure?";
            // 
            // CaptionLbl
            // 
            this.CaptionLbl.AutoSize = true;
            this.CaptionLbl.Font = new System.Drawing.Font("Work Sans Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CaptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.CaptionLbl.Location = new System.Drawing.Point(64, 25);
            this.CaptionLbl.Name = "CaptionLbl";
            this.CaptionLbl.Size = new System.Drawing.Size(54, 17);
            this.CaptionLbl.TabIndex = 3;
            this.CaptionLbl.Text = "Delete?";
            // 
            // paintBorderPanel1
            // 
            this.paintBorderPanel1.chosenPaintColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.paintBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBorderPanel1.Location = new System.Drawing.Point(0, 0);
            this.paintBorderPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.paintBorderPanel1.Name = "paintBorderPanel1";
            this.paintBorderPanel1.Size = new System.Drawing.Size(370, 174);
            this.paintBorderPanel1.TabIndex = 2;
            this.paintBorderPanel1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.paintBorderPanel1.Load += new System.EventHandler(this.paintBorderPanel1_Load);
            // 
            // warningIco
            // 
            this.warningIco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.warningIco.BackColor = System.Drawing.Color.White;
            this.warningIco.Location = new System.Drawing.Point(19, 14);
            this.warningIco.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.warningIco.Name = "warningIco";
            this.warningIco.Size = new System.Drawing.Size(38, 38);
            this.warningIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.warningIco.TabIndex = 8;
            this.warningIco.TabStop = false;
            this.warningIco.Paint += new System.Windows.Forms.PaintEventHandler(this.warningIco_Paint);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(323, 14);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0, 14, 14, 0);
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
            // WarningMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 174);
            this.Controls.Add(this.warningIco);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.CaptionLbl);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paintBorderPanel1);
            this.Font = new System.Drawing.Font("Work Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WarningMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarningMessageBox";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warningIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TextLbl;
        private userControls.CustomButton cancelBtn;
        private userControls.CustomButton deleteButton;
        private userControls.PaintBorderPanel paintBorderPanel1;
        private System.Windows.Forms.Label CaptionLbl;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox warningIco;
    }
}