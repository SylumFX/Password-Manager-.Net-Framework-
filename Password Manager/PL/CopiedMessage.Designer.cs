namespace Password_Manager.PL
{
    partial class CopiedMessage
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
            this.components = new System.ComponentModel.Container();
            this.paintBorderPanel1 = new Password_Manager.PL.userControls.PaintBorderPanel();
            this.CopiedLabel = new System.Windows.Forms.Label();
            this.CheckedIco = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CheckedIco)).BeginInit();
            this.SuspendLayout();
            // 
            // paintBorderPanel1
            // 
            this.paintBorderPanel1.chosenPaintColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paintBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintBorderPanel1.Location = new System.Drawing.Point(0, 0);
            this.paintBorderPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.paintBorderPanel1.Name = "paintBorderPanel1";
            this.paintBorderPanel1.Size = new System.Drawing.Size(140, 100);
            this.paintBorderPanel1.TabIndex = 0;
            this.paintBorderPanel1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paintBorderPanel1.Load += new System.EventHandler(this.paintBorderPanel1_Load);
            // 
            // CopiedLabel
            // 
            this.CopiedLabel.AutoSize = true;
            this.CopiedLabel.Font = new System.Drawing.Font("Work Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CopiedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(142)))), ((int)(((byte)(104)))));
            this.CopiedLabel.Location = new System.Drawing.Point(34, 50);
            this.CopiedLabel.Name = "CopiedLabel";
            this.CopiedLabel.Size = new System.Drawing.Size(72, 26);
            this.CopiedLabel.TabIndex = 2;
            this.CopiedLabel.Text = "Copied";
            // 
            // CheckedIco
            // 
            this.CheckedIco.Location = new System.Drawing.Point(60, 30);
            this.CheckedIco.Name = "CheckedIco";
            this.CheckedIco.Size = new System.Drawing.Size(20, 20);
            this.CheckedIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckedIco.TabIndex = 1;
            this.CheckedIco.TabStop = false;
            this.CheckedIco.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckedIco_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CopiedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(140, 100);
            this.Controls.Add(this.CheckedIco);
            this.Controls.Add(this.CopiedLabel);
            this.Controls.Add(this.paintBorderPanel1);
            this.Font = new System.Drawing.Font("Work Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CopiedMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopiedMessage";
            ((System.ComponentModel.ISupportInitialize)(this.CheckedIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControls.PaintBorderPanel paintBorderPanel1;
        private System.Windows.Forms.PictureBox CheckedIco;
        private System.Windows.Forms.Label CopiedLabel;
        private System.Windows.Forms.Timer timer1;
    }
}