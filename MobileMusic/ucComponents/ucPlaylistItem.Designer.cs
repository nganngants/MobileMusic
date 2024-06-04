namespace MobileMusic.ucComponents
{
    partial class ucPlaylistItem
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbNumSongs = new System.Windows.Forms.Label();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnClear = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.siticoneContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.BackColor = System.Drawing.Color.Black;
            this.pbThumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbThumbnail.Image = global::MobileMusic.Properties.Resources.default_playlist;
            this.pbThumbnail.ImageRotate = 0F;
            this.pbThumbnail.Location = new System.Drawing.Point(2, 2);
            this.pbThumbnail.Margin = new System.Windows.Forms.Padding(2);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(57, 58);
            this.pbThumbnail.TabIndex = 0;
            this.pbThumbnail.TabStop = false;
            this.pbThumbnail.Click += new System.EventHandler(this.ucPlaylistItem_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(64, 6);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(98, 21);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "New Playlist";
            this.lbName.Click += new System.EventHandler(this.ucPlaylistItem_Click);
            // 
            // lbNumSongs
            // 
            this.lbNumSongs.AutoSize = true;
            this.lbNumSongs.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumSongs.ForeColor = System.Drawing.Color.White;
            this.lbNumSongs.Location = new System.Drawing.Point(68, 26);
            this.lbNumSongs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumSongs.Name = "lbNumSongs";
            this.lbNumSongs.Size = new System.Drawing.Size(58, 17);
            this.lbNumSongs.TabIndex = 2;
            this.lbNumSongs.Text = "31 songs";
            this.lbNumSongs.Click += new System.EventHandler(this.ucPlaylistItem_Click);
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.btnClear);
            this.siticoneContainerControl2.Controls.Add(this.btnDelete);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneContainerControl2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(365, 2);
            this.siticoneContainerControl2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(83, 58);
            this.siticoneContainerControl2.TabIndex = 8;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::MobileMusic.Properties.Resources.clear;
            this.btnClear.ImageSize = new System.Drawing.Size(27, 27);
            this.btnClear.Location = new System.Drawing.Point(8, 15);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnClear.Size = new System.Drawing.Size(30, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(38, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(30, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ucPlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.siticoneContainerControl2);
            this.Controls.Add(this.lbNumSongs);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbThumbnail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPlaylistItem";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(450, 62);
            this.Click += new System.EventHandler(this.ucPlaylistItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.siticoneContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox pbThumbnail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNumSongs;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnClear;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnDelete;
    }
}
