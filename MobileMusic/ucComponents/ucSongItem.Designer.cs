namespace MobileMusic.ucComponents
{
    partial class ucSongItem
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
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbSinger = new System.Windows.Forms.Label();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnAddToPlaylist = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnPlay = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnDownload = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnFavorite = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.pbThumbnail = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
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
            this.lbSongName.Click += new System.EventHandler(this.ucSongItem_Click);
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
            this.lbSinger.Click += new System.EventHandler(this.ucSongItem_Click);
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.lbSinger);
            this.siticoneContainerControl1.Controls.Add(this.lbSongName);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(64, 2);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(185, 61);
            this.siticoneContainerControl1.TabIndex = 6;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            this.siticoneContainerControl1.Click += new System.EventHandler(this.ucSongItem_Click);
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.btnAddToPlaylist);
            this.siticoneContainerControl2.Controls.Add(this.btnPlay);
            this.siticoneContainerControl2.Controls.Add(this.btnDownload);
            this.siticoneContainerControl2.Controls.Add(this.btnFavorite);
            this.siticoneContainerControl2.Controls.Add(this.btnDelete);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(249, 2);
            this.siticoneContainerControl2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(149, 61);
            this.siticoneContainerControl2.TabIndex = 7;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            this.siticoneContainerControl2.Click += new System.EventHandler(this.ucSongItem_Click);
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToPlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToPlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToPlaylist.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddToPlaylist.FillColor = System.Drawing.Color.Transparent;
            this.btnAddToPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnAddToPlaylist.Image = global::MobileMusic.Properties.Resources.add;
            this.btnAddToPlaylist.ImageSize = new System.Drawing.Size(27, 27);
            this.btnAddToPlaylist.Location = new System.Drawing.Point(-3, 15);
            this.btnAddToPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnAddToPlaylist.Size = new System.Drawing.Size(31, 31);
            this.btnAddToPlaylist.TabIndex = 7;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.btnAddToPlaylist_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlay.FillColor = System.Drawing.Color.Transparent;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = global::MobileMusic.Properties.Resources.play;
            this.btnPlay.ImageSize = new System.Drawing.Size(27, 27);
            this.btnPlay.Location = new System.Drawing.Point(28, 15);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnPlay.Size = new System.Drawing.Size(31, 31);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDownload.FillColor = System.Drawing.Color.Transparent;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Image = global::MobileMusic.Properties.Resources.download;
            this.btnDownload.ImageSize = new System.Drawing.Size(27, 27);
            this.btnDownload.Location = new System.Drawing.Point(59, 15);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnDownload.Size = new System.Drawing.Size(30, 31);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFavorite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFavorite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFavorite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFavorite.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFavorite.FillColor = System.Drawing.Color.Transparent;
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.Image = global::MobileMusic.Properties.Resources.favorite_unchecked;
            this.btnFavorite.ImageSize = new System.Drawing.Size(27, 27);
            this.btnFavorite.Location = new System.Drawing.Point(89, 15);
            this.btnFavorite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnFavorite.Size = new System.Drawing.Size(30, 31);
            this.btnFavorite.TabIndex = 5;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MobileMusic.Properties.Resources.trash;
            this.btnDelete.ImageSize = new System.Drawing.Size(27, 27);
            this.btnDelete.Location = new System.Drawing.Point(119, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(30, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.BorderRadius = 4;
            this.pbThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbThumbnail.Image = global::MobileMusic.Properties.Resources.default_song;
            this.pbThumbnail.ImageRotate = 0F;
            this.pbThumbnail.Location = new System.Drawing.Point(2, 2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(62, 61);
            this.pbThumbnail.TabIndex = 0;
            this.pbThumbnail.TabStop = false;
            this.pbThumbnail.Click += new System.EventHandler(this.ucSongItem_Click);
            // 
            // ucSongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.siticoneContainerControl2);
            this.Controls.Add(this.pbThumbnail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucSongItem";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(400, 65);
            this.Click += new System.EventHandler(this.ucSongItem_Click);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl1.PerformLayout();
            this.siticoneContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox pbThumbnail;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbSinger;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnPlay;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnDownload;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnFavorite;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnAddToPlaylist;
    }
}
