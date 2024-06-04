namespace MobileMusic
{
    partial class fMain
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneContainerControl1 = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.tabPlaylists = new System.Windows.Forms.TabPage();
            this.tabDownloaded = new System.Windows.Forms.TabPage();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneContainerControl1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(436, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(34, 28);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneContainerControl1
            // 
            this.siticoneContainerControl1.Controls.Add(this.siticoneControlBox1);
            this.siticoneContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneContainerControl1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneContainerControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticoneContainerControl1.Name = "siticoneContainerControl1";
            this.siticoneContainerControl1.Size = new System.Drawing.Size(470, 28);
            this.siticoneContainerControl1.TabIndex = 1;
            this.siticoneContainerControl1.Text = "siticoneContainerControl1";
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabSongs);
            this.tabControl.Controls.Add(this.tabPlaylists);
            this.tabControl.Controls.Add(this.tabDownloaded);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(115, 80);
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(470, 687);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.LightCyan;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.LightCyan;
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.Cyan;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.Cyan;
            this.tabControl.TabButtonSize = new System.Drawing.Size(115, 80);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabControl.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalBottom;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Black;
            this.tabHome.Location = new System.Drawing.Point(4, 4);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabHome.Size = new System.Drawing.Size(462, 599);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // tabSongs
            // 
            this.tabSongs.BackColor = System.Drawing.Color.Black;
            this.tabSongs.Location = new System.Drawing.Point(4, 4);
            this.tabSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSongs.Size = new System.Drawing.Size(480, 599);
            this.tabSongs.TabIndex = 1;
            this.tabSongs.Text = "Songs";
            // 
            // tabPlaylists
            // 
            this.tabPlaylists.BackColor = System.Drawing.Color.Black;
            this.tabPlaylists.Location = new System.Drawing.Point(4, 4);
            this.tabPlaylists.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPlaylists.Name = "tabPlaylists";
            this.tabPlaylists.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPlaylists.Size = new System.Drawing.Size(480, 599);
            this.tabPlaylists.TabIndex = 2;
            this.tabPlaylists.Text = "Playlists";
            // 
            // tabDownloaded
            // 
            this.tabDownloaded.BackColor = System.Drawing.Color.Black;
            this.tabDownloaded.Location = new System.Drawing.Point(4, 4);
            this.tabDownloaded.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDownloaded.Name = "tabDownloaded";
            this.tabDownloaded.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDownloaded.Size = new System.Drawing.Size(462, 599);
            this.tabDownloaded.TabIndex = 3;
            this.tabDownloaded.Text = "Downloaded";
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.siticoneContainerControl1;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(470, 715);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.siticoneContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.siticoneContainerControl1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.TabPage tabPlaylists;
        private System.Windows.Forms.TabPage tabDownloaded;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl siticoneContainerControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}

