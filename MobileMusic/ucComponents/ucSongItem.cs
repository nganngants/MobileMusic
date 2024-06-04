using MobileMusic.ucTabPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MobileMusic.ucComponents
{
    public partial class ucSongItem : UserControl
    {
        public Song song;
        public EventHandler favoriteClicked;
        public EventHandler downloadChanged;
        public EventHandler deleteClicked;
        public EventHandler songClicked;
        public EventHandler addClicked;
        public WindowsMediaPlayer player;
        public ucSongItem()
        {
            InitializeComponent();
        }

        public ucSongItem(Song song)
        {
            InitializeComponent();
            this.song = song;
            this.lbSongName.Text = song.song_name;
            this.lbSinger.Text = song.singer_name;
            this.pbThumbnail.Image = Image.FromFile(Program.thumbnails_path + song.thumbnail_filename);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;

            if (song.isFavorite) this.btnFavorite.Image = Properties.Resources.favorite_checked;
        }

        public void Reload()
        {
            string query = "SELECT * FROM song WHERE id = " + song.id;
            SqlDataReader dr = Program.ReadData(query);
            dr.Read();
            song = new Song((int)dr["id"], dr["filename"].ToString(), dr["name"].ToString(), dr["singer"].ToString(),
                                           dr["thumbnail"].ToString(), dr["category"].ToString(), (int)dr["is_favorite"] == 1);
            if (song.isFavorite) this.btnFavorite.Image = Properties.Resources.favorite_checked;
            else this.btnFavorite.Image = Properties.Resources.favorite_unchecked;
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (song.isFavorite)
            {
                song.isFavorite = false;
                this.btnFavorite.Image = Properties.Resources.favorite_unchecked;
                string query = "UPDATE song SET is_favorite = 0 WHERE id = " + song.id;
                Program.ExecuteQuery(query);
            }
            else
            {
                song.isFavorite = true;
                this.btnFavorite.Image = Properties.Resources.favorite_checked;
                string query = "UPDATE song SET is_favorite = 1 WHERE id = " + song.id;
                System.Diagnostics.Debug.WriteLine(query);
                Program.ExecuteQuery(query);
            }
            favoriteClicked?.Invoke(this, e);
            //Program.uc_songs.Reload();
            Program.uc_playlists.Reload();
        }

        public void setEnableDeleteButton(bool state)
        {
            this.btnDelete.Visible = state;
        }

        public void setEnableDownloadButton(bool state)
        {
            this.btnDownload.Visible = state;
        }

        public void setEnableAddButton(bool state)
        {
            this.btnAddToPlaylist.Visible = state;
        }

        public void setEnableFavoriteButton(bool state)
        {
            this.btnFavorite.Visible = state;
        }

        public void Stop()
        {
            if (player == null) return;
            // change the pause button to play button
            this.btnPlay.Image = Properties.Resources.play;
            player.controls.pause();
            player = null;
        }

        public void Play()
        {
            // change the play button to pause button
            this.btnPlay.Image = Properties.Resources.pause;
            // play the song
            string path = Program.songs_path + song.filename;
            player = new WindowsMediaPlayer();
            player.URL = path;
            player.controls.play();
        }

        public void TryPlay()
        {
            // if the song is playing, stop it
            if (player != null)
            {
                Stop();
                return;
            }
            // update last_played of song
            string query = "UPDATE song SET last_played = GETDATE() WHERE id = " + song.id;
            song.lastPlayed = DateTime.Now;
            Program.ExecuteQuery(query);

            Program.PlaySong(this);

            Program.uc_home.Reload();
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            TryPlay();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteClicked?.Invoke(this, e);
        }

        private void ucSongItem_Click(object sender, EventArgs e)
        {
            songClicked?.Invoke(this, e);
        }

        private void btnAddToPlaylist_Click(object sender, EventArgs e)
        {
            addClicked?.Invoke(this, e);
        }
    }
}
