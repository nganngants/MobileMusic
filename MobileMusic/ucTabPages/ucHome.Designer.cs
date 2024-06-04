namespace MobileMusic.ucTabPages
{
    partial class ucHome
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
            this.conRecent = new Siticone.Desktop.UI.WinForms.SiticoneContainerControl();
            this.layoutRecent = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conRecent
            // 
            this.conRecent.Controls.Add(this.layoutRecent);
            this.conRecent.Controls.Add(this.label1);
            this.conRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conRecent.FillColor = System.Drawing.Color.Transparent;
            this.conRecent.Location = new System.Drawing.Point(3, 388);
            this.conRecent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conRecent.Name = "conRecent";
            this.conRecent.Size = new System.Drawing.Size(623, 353);
            this.conRecent.TabIndex = 2;
            this.conRecent.Text = "siticoneContainerControl1";
            // 
            // layoutRecent
            // 
            this.layoutRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRecent.Location = new System.Drawing.Point(0, 39);
            this.layoutRecent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutRecent.Name = "layoutRecent";
            this.layoutRecent.Size = new System.Drawing.Size(623, 314);
            this.layoutRecent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(623, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recently played";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneSeparator1.FillColor = System.Drawing.Color.LightGray;
            this.siticoneSeparator1.Location = new System.Drawing.Point(3, 376);
            this.siticoneSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(623, 12);
            this.siticoneSeparator1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::MobileMusic.Properties.Resources.ad_2;
            this.pictureBox2.Location = new System.Drawing.Point(3, 182);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(623, 194);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MobileMusic.Properties.Resources.ad_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.conRecent);
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucHome";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(629, 743);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.conRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneContainerControl conRecent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel layoutRecent;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator siticoneSeparator1;
    }
}
