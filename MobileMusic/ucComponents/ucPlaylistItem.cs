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
    public partial class ucPlaylistItem : UserControl
    {
        public EventHandler playlistItemClicked;
        public Playlist playlist;
        public ucPlaylistItem(Playlist playlist)
        {
            InitializeComponent();
            this.lbName.Text = playlist.name;
            this.lbNumSongs.Text = playlist.songs.Count + " songs";
            this.pbThumbnail.Image = Image.FromFile(Program.playlistThumbnails_path + playlist.thumbnail_filename);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;

            this.playlist = playlist;
        }

        private void ucPlaylistItem_Click(object sender, EventArgs e)
        {
            playlistItemClicked?.Invoke(this, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // ask user if they want to clear all songs in this playlist
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear all songs in this playlist?", "Clear playlist", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM playlist_song WHERE playlist_id = " + playlist.id;
                Program.ExecuteQuery(query);
                this.lbNumSongs.Text = "0 songs";
                playlist.songs.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ask user if they want to delete this playlist
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this playlist?", "Delete playlist", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM playlist_song WHERE playlist_id = " + playlist.id;
                Program.ExecuteQuery(query);
                query = "DELETE FROM playlist WHERE id = " + playlist.id;
                Program.ExecuteQuery(query);
                this.Dispose();
            }
        }
    }
}
