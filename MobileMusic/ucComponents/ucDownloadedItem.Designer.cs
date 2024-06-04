namespace MobileMusic.ucComponents
{
    partial class ucDownloadedItem
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
            this.pbThumbnail = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbDownloadTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.siticoneContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbThumbnail.FillColor = System.Drawing.Color.Transparent;
            this.pbThumbnail.ImageRotate = 0F;
            this.pbThumbnail.Location = new System.Drawing.Point(2, 2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(69, 69);
            this.pbThumbnail.TabIndex = 0;
            this.pbThumbnail.TabStop = false;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.lbDownloadTime);
            this.siticoneContainerControl1.Controls.Add(this.lbSinger);
            this.siticoneContainerControl1.Controls.Add(this.lbSongName);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(71, 2);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(358, 69);
            this.siticoneContainerControl1.TabIndex = 7;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // lbSinger
            // 
            this.lbSinger.AutoSize = true;
            this.lbSinger.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSinger.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinger.ForeColor = System.Drawing.Color.White;
            this.lbSinger.Location = new System.Drawing.Point(2, 25);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(74, 17);
            this.lbSinger.TabIndex = 2;
            this.lbSinger.Text = "Taylor Swift";
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.BackColor = System.Drawing.Color.Black;
            this.lbSongName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(2, 4);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(137, 21);
            this.lbSongName.TabIndex = 1;
            this.lbSongName.Text = "Out of the woods";
            // 
            // lbDownloadTime
            // 
            this.lbDownloadTime.AutoSize = true;
            this.lbDownloadTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDownloadTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownloadTime.ForeColor = System.Drawing.Color.White;
            this.lbDownloadTime.Location = new System.Drawing.Point(2, 42);
            this.lbDownloadTime.Name = "lbDownloadTime";
            this.lbDownloadTime.Size = new System.Drawing.Size(90, 16);
            this.lbDownloadTime.TabIndex = 0;
            this.lbDownloadTime.Text = "Downloaded at ";
            // 
            // ucDownloadedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.pbThumbnail);
            this.Name = "ucDownloadedItem";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(431, 73);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox pbThumbnail;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbDownloadTime;
    }
}
