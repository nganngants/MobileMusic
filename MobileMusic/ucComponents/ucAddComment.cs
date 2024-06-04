using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.ucComponents
{
    public partial class ucAddComment : UserControl
    {
        Song song;
        public EventHandler backClicked;
        int score;
        FlowLayoutPanel flpComments;
        public ucAddComment()
        {
            InitializeComponent();
        }

        public void SetSong(Song song)
        {
            this.song = song;
            score = 0;
        }

        public void SetFlp(FlowLayoutPanel flp)
        {
            this.flpComments = flp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, e);
        }

        private void star1_Click(object sender, EventArgs e)
        {
            this.star1.BackgroundImage = Properties.Resources.star_filled;
            this.star2.BackgroundImage = Properties.Resources.star;
            this.star3.BackgroundImage = Properties.Resources.star;
            this.star4.BackgroundImage = Properties.Resources.star;
            this.star5.BackgroundImage = Properties.Resources.star;
            score = 1;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            this.star1.BackgroundImage = Properties.Resources.star_filled;
            this.star2.BackgroundImage = Properties.Resources.star_filled;
            this.star3.BackgroundImage = Properties.Resources.star;
            this.star4.BackgroundImage = Properties.Resources.star;
            this.star5.BackgroundImage = Properties.Resources.star;
            score = 2;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            this.star1.BackgroundImage = Properties.Resources.star_filled;
            this.star2.BackgroundImage = Properties.Resources.star_filled;
            this.star3.BackgroundImage = Properties.Resources.star_filled;
            this.star4.BackgroundImage = Properties.Resources.star;
            this.star5.BackgroundImage = Properties.Resources.star;
            score = 3;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            this.star1.BackgroundImage = Properties.Resources.star_filled;
            this.star2.BackgroundImage = Properties.Resources.star_filled;
            this.star3.BackgroundImage = Properties.Resources.star_filled;
            this.star4.BackgroundImage = Properties.Resources.star_filled;
            this.star5.BackgroundImage = Properties.Resources.star;
            score = 4;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            this.star1.BackgroundImage = Properties.Resources.star_filled;
            this.star2.BackgroundImage = Properties.Resources.star_filled;
            this.star3.BackgroundImage = Properties.Resources.star_filled;
            this.star4.BackgroundImage = Properties.Resources.star_filled;
            this.star5.BackgroundImage = Properties.Resources.star_filled;
            score = 5;
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbComment_Click(object sender, EventArgs e)
        {
            tbComment.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (score == 0)
            {
                // show warning box with ok button
                MessageBox.Show("Please rate the song before adding a comment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // query: INSERT INTO comment (song_id, display_name, comment, comment_time) VALUES (song.id, Program.user.display_name, tbComment.Text, DateTime.Now)
            string display_name = tbDisplayName.Text;
            string comment = tbComment.Text;

            if (comment == "Add comment") comment = ""; 

            if (display_name == "")
            {
                display_name = "anonymous";
            }

            string query = "INSERT INTO comment (song_id, display_name, comment, comment_time, score) VALUES (" + song.id + ", N'" + display_name + "', N'" + comment + "', GETDATE(), " + score + ")";
            Program.ExecuteQuery(query);

            tbDisplayName.Text = "";
            tbComment.Text = "Add comment";

            this.star1.BackgroundImage = Properties.Resources.star;
            this.star2.BackgroundImage = Properties.Resources.star;
            this.star3.BackgroundImage = Properties.Resources.star;
                this.star4.BackgroundImage = Properties.Resources.star;
            this.star5.BackgroundImage = Properties.Resources.star;

            // Load the new comment to flpComments
            ucComment ucCmt = new ucComment(display_name, comment, DateTime.Now, score);
            ucCmt.Dock = DockStyle.Top;
            flpComments.Controls.Add(ucCmt);

            // move the new comment to the top
            flpComments.Controls.SetChildIndex(ucCmt, 0);

            backClicked?.Invoke(this, e);
        }
    }
}
