namespace MobileMusic.ucComponents
{
    partial class ucAddToPlaylist
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
            this.comboPlaylists = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.btnClose = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPlaylists
            // 
            this.comboPlaylists.BackColor = System.Drawing.Color.Transparent;
            this.comboPlaylists.BorderColor = System.Drawing.Color.Cyan;
            this.comboPlaylists.BorderRadius = 3;
            this.comboPlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboPlaylists.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaylists.FillColor = System.Drawing.Color.Black;
            this.comboPlaylists.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPlaylists.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboPlaylists.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboPlaylists.ForeColor = System.Drawing.Color.White;
            this.comboPlaylists.ItemHeight = 30;
            this.comboPlaylists.Location = new System.Drawing.Point(8, 44);
            this.comboPlaylists.Margin = new System.Windows.Forms.Padding(2);
            this.comboPlaylists.Name = "comboPlaylists";
            this.comboPlaylists.Size = new System.Drawing.Size(256, 36);
            this.comboPlaylists.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add to playlist";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.Cyan;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Cyan;
            this.btnAdd.Location = new System.Drawing.Point(40, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.btnAdd);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(8, 80);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Padding = new System.Windows.Forms.Padding(40, 10, 40, 5);
            this.siticoneContainerControl1.Size = new System.Drawing.Size(256, 47);
            this.siticoneContainerControl1.TabIndex = 3;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CustomClick = true;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.IconColor = System.Drawing.Color.Cyan;
            this.btnClose.Location = new System.Drawing.Point(228, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucAddToPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.siticoneContainerControl1);
            this.Controls.Add(this.comboPlaylists);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAddToPlaylist";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 5);
            this.Size = new System.Drawing.Size(272, 132);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox comboPlaylists;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox btnClose;
    }
}
