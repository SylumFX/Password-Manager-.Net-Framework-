namespace Password_Manager.PL.userControls
{
    partial class NotificationPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.iconPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(45)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closePic
            // 
            this.closePic.Image = global::Password_Manager.Properties.Resources.Close_Red;
            this.closePic.Location = new System.Drawing.Point(300, 16);
            this.closePic.Margin = new System.Windows.Forms.Padding(0);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(24, 24);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePic.TabIndex = 2;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            this.closePic.MouseEnter += new System.EventHandler(this.closePic_MouseEnter);
            this.closePic.MouseLeave += new System.EventHandler(this.closePic_MouseLeave);
            // 
            // iconPic
            // 
            this.iconPic.Image = global::Password_Manager.Properties.Resources.Error_Circle;
            this.iconPic.Location = new System.Drawing.Point(16, 16);
            this.iconPic.Margin = new System.Windows.Forms.Padding(0);
            this.iconPic.Name = "iconPic";
            this.iconPic.Size = new System.Drawing.Size(24, 24);
            this.iconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPic.TabIndex = 0;
            this.iconPic.TabStop = false;
            // 
            // NotificationPopup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(201)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPic);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NotificationPopup";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(340, 56);
            this.Load += new System.EventHandler(this.NotificationPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox iconPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closePic;
    }
}
