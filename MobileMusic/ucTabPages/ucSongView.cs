using MobileMusic.ucComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic.ucTabPages
{
    public partial class ucSongView : UserControl
    {
        Song song;
        public EventHandler backClicked;
        ucAddComment ucAddComment;
        ucSongItem ucSongItem;
        public ucSongView(Song song, ucSongItem uc)
        {
            InitializeComponent();
            this.song = song;
            this.flpComments.Visible = true;
            this.ucAddComment = new ucAddComment();

            if (uc.player != null)
            {
                this.btnPlay.Image = Properties.Resources.pause;
            }
            
            // Add ucAddComment to the middle of this user control
            this.Controls.Add(ucAddComment);
            ucAddComment.Location = new Point(50, (this.Height - ucAddComment.Height) / 2);
            ucAddComment.backClicked += ucAddComment_backClick;
            ucAddComment.BringToFront();
            ucAddComment.Hide();
            this.ucSongItem = uc;
        }

        private void LoadScore()
        {
            string query = "SELECT score FROM song WHERE id = " + song.id;
            SqlDataReader dr = Program.ReadData(query);
            if (dr.Read())
            {
                double score = Convert.ToDouble(dr["score"]);
                if (score > 0)
                {
                    // Display score with 2 decimal places
                    this.lbScore.Text = "Review: " + score.ToString("0.00") + "/5";
                    return;
                }

            }
            this.lbScore.Text = "No review yet";

        }

        private void ucSongView_Load(object sender, EventArgs e)
        {
            // Load song info
            this.lbSongName.Text = song.song_name;
            this.lbSingerName.Text = song.singer_name;
            this.pbThumbnail.Image = Image.FromFile(Program.thumbnails_path + song.thumbnail_filename);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;

            if (song.isFavorite) this.btnFavorite.Image = Properties.Resources.favorite_checked;

            flpComments.Controls.Clear();
            flpComments.AutoScroll = true;
            flpComments.VerticalScroll.Visible = true;
            flpComments.VerticalScroll.Enabled = true;

            // Load comments
            string query = "SELECT * FROM comment WHERE song_id = " + song.id + " ORDER BY comment_time DESC";
            SqlDataReader dr = Program.ReadData(query);
            while (dr.Read())
            {
                string display_name = dr["display_name"].ToString();
                string comment = dr["comment"].ToString();
                DateTime cmt_time = (DateTime)dr["comment_time"];
                int score = (int)dr["score"];
                ucComment ucCmt = new ucComment(display_name, comment, cmt_time, score);
                ucCmt.Dock = DockStyle.Top;
                ucCmt.MinimumSize = new Size(flpComments.ClientSize.Width - 2, ucCmt.Height);
                flpComments.Controls.Add(ucCmt);
            }

            LoadScore();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, e);
        }

        private void ucAddComment_backClick(object sender, EventArgs e)
        {
            ucAddComment.Hide();
            LoadScore();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            ucAddComment.SetSong(song);
            ucAddComment.SetFlp(flpComments);
            ucAddComment.Show();
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ucSongItem.TryPlay();
            
            // change the icon
            if (ucSongItem.player != null)
            {
                this.btnPlay.Image = Properties.Resources.pause;
            }
            else
            {
                this.btnPlay.Image = Properties.Resources.play;
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (song.isFavorite )
            {
                song.isFavorite = false;
                this.btnFavorite.Image = Properties.Resources.favorite_unchecked;
                string query = "UPDATE song SET is_favorite = 0 WHERE id = " + song.id;
                Program.ExecuteQuery(query);

                this.ucSongItem.Reload();
            }
            else
            {
                song.isFavorite = true;
                this.btnFavorite.Image = Properties.Resources.favorite_checked;
                string query = "UPDATE song SET is_favorite = 1 WHERE id = " + song.id;
                Program.ExecuteQuery(query);

                this.ucSongItem.Reload();
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Download the song. Open a save file dialog to choose the location to save the song, save the file with name is song name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";
            saveFileDialog.FileName = song.song_name + ".mp3";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName == "")
                {
                    MessageBox.Show("Please enter a file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sourceFile = Program.songs_path + song.filename;
                string destFile = saveFileDialog.FileName;
                // if the file already exists, replace it
                if (System.IO.File.Exists(destFile))
                {
                    System.IO.File.Delete(destFile);
                }
                System.IO.File.Copy(sourceFile, destFile);
                MessageBox.Show("Song downloaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // add to the download history in database if the song is not in the download history
                // if the song is already in the download history, update the last downloaded time
                string query = "SELECT * FROM download WHERE song_id = " + song.id;
                SqlDataReader dr = Program.ReadData(query);
                if (dr.HasRows)
                {
                    query = "UPDATE download SET downloaded_time = GETDATE() WHERE song_id = " + song.id;
                }
                else
                {
                    query = "INSERT INTO download (song_id, downloaded_time) VALUES (" + song.id + ", GETDATE())";
                }
                Program.ExecuteQuery(query);
                //downloadChanged?.Invoke(this, e);
            }
            Program.ucDownloaded.Reload();
        }
    }
}
