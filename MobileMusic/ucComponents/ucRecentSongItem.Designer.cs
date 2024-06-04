namespace MobileMusic.ucComponents
{
    partial class ucRecentSongItem
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
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.pbThumbnail = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSinger
            // 
            this.lbSinger.AutoSize = true;
            this.lbSinger.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSinger.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinger.ForeColor = System.Drawing.Color.White;
            this.lbSinger.Location = new System.Drawing.Point(85, 27);
            this.lbSinger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(94, 22);
            this.lbSinger.TabIndex = 5;
            this.lbSinger.Text = "Taylor Swift";
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.BackColor = System.Drawing.Color.Black;
            this.lbSongName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(85, 0);
            this.lbSongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(170, 27);
            this.lbSongName.TabIndex = 4;
            this.lbSongName.Text = "Out of the woods";
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.BorderRadius = 4;
            this.pbThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbThumbnail.Image = global::MobileMusic.Properties.Resources.default_song;
            this.pbThumbnail.ImageRotate = 0F;
            this.pbThumbnail.Location = new System.Drawing.Point(0, 0);
            this.pbThumbnail.Margin = new System.Windows.Forms.Padding(4);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(85, 85);
            this.pbThumbnail.TabIndex = 3;
            this.pbThumbnail.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(85, 49);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(90, 20);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "Last played: ";
            // 
            // ucRecentSongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbSinger);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.pbThumbnail);
            this.Name = "ucRecentSongItem";
            this.Size = new System.Drawing.Size(569, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbSongName;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox pbThumbnail;
        private System.Windows.Forms.Label lbTime;
    }
}
