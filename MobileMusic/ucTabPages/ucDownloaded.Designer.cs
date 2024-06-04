namespace MobileMusic.ucTabPages
{
    partial class ucDownloaded
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
            this.layoutDownloaded = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // layoutDownloaded
            // 
            this.layoutDownloaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDownloaded.Location = new System.Drawing.Point(0, 0);
            this.layoutDownloaded.Name = "layoutDownloaded";
            this.layoutDownloaded.Padding = new System.Windows.Forms.Padding(3);
            this.layoutDownloaded.Size = new System.Drawing.Size(568, 709);
            this.layoutDownloaded.TabIndex = 0;
            // 
            // ucDownloaded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.layoutDownloaded);
            this.Name = "ucDownloaded";
            this.Size = new System.Drawing.Size(568, 709);
            this.Load += new System.EventHandler(this.ucDownloaded_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutDownloaded;
    }
}
