namespace MobileMusic.ucTabPages
{
    partial class ucPlaylistView
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
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.comboSongs = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.btnAddSong = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lbPlaylistName = new System.Windows.Forms.Label();
            this.layoutSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl2 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.siticoneContainerControl1.SuspendLayout();
            this.siticoneContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.comboSongs);
            this.siticoneContainerControl1.Controls.Add(this.btnAddSong);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 34);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(334, 40);
            this.siticoneContainerControl1.TabIndex = 0;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // comboSongs
            // 
            this.comboSongs.BackColor = System.Drawing.Color.Transparent;
            this.comboSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboSongs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSongs.DropDownHeight = 150;
            this.comboSongs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSongs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.comboSongs.FocusedColor = System.Drawing.Color.LightGray;
            this.comboSongs.FocusedState.BorderColor = System.Drawing.Color.LightGray;
            this.comboSongs.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSongs.ForeColor = System.Drawing.Color.White;
            this.comboSongs.IntegralHeight = false;
            this.comboSongs.ItemHeight = 30;
            this.comboSongs.Location = new System.Drawing.Point(0, 0);
            this.comboSongs.Name = "comboSongs";
            this.comboSongs.Size = new System.Drawing.Size(265, 36);
            this.comboSongs.TabIndex = 0;
            // 
            // btnAddSong
            // 
            this.btnAddSong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddSong.FillColor = System.Drawing.Color.Aqua;
            this.btnAddSong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAddSong.Location = new System.Drawing.Point(265, 0);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(69, 40);
            this.btnAddSong.TabIndex = 1;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lbPlaylistName
            // 
            this.lbPlaylistName.AutoSize = true;
            this.lbPlaylistName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPlaylistName.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbPlaylistName.Location = new System.Drawing.Point(0, 0);
            this.lbPlaylistName.Name = "lbPlaylistName";
            this.lbPlaylistName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.lbPlaylistName.Size = new System.Drawing.Size(115, 34);
            this.lbPlaylistName.TabIndex = 1;
            this.lbPlaylistName.Text = "Playlist test";
            // 
            // layoutSongs
            // 
            this.layoutSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSongs.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutSongs.Location = new System.Drawing.Point(2, 2);
            this.layoutSongs.Margin = new System.Windows.Forms.Padding(2);
            this.layoutSongs.Name = "layoutSongs";
            this.layoutSongs.Padding = new System.Windows.Forms.Padding(2);
            this.layoutSongs.Size = new System.Drawing.Size(330, 396);
            this.layoutSongs.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::MobileMusic.Properties.Resources.back1;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(302, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 33);
            this.btnBack.TabIndex = 3;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // siticoneContainerControl2
            // 
            this.siticoneContainerControl2.Controls.Add(this.layoutSongs);
            this.siticoneContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl2.FillColor = System.Drawing.Color.Black;
            this.siticoneContainerControl2.Location = new System.Drawing.Point(0, 74);
            this.siticoneContainerControl2.Name = "siticoneContainerControl2";
            this.siticoneContainerControl2.Padding = new System.Windows.Forms.Padding(2);
            this.siticoneContainerControl2.Size = new System.Drawing.Size(334, 400);
            this.siticoneContainerControl2.TabIndex = 0;
            this.siticoneContainerControl2.Text = "siticoneContainerControl2";
            // 
            // ucPlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.siticoneContainerControl2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.lbPlaylistName);
            this.Name = "ucPlaylistView";
            this.Size = new System.Drawing.Size(334, 474);
            this.Load += new System.EventHandler(this.ucPlaylistView_Load);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.siticoneContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAddSong;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboSongs;
        private System.Windows.Forms.Label lbPlaylistName;
        private System.Windows.Forms.FlowLayoutPanel layoutSongs;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnBack;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl2;
    }
}
