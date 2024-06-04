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

namespace MobileMusic.ucComponents
{
    public partial class ucAddToPlaylist : UserControl
    {
        Song song;
        public EventHandler closeClicked;
        public ucAddToPlaylist()
        {
            InitializeComponent();
        }

        public void setSong(Song song)
        {
            this.song = song;
        }

        public void LoadPlaylists()
        {
            // Load all playlists that the song is not in to the combo box
            string query = "SELECT * FROM playlist WHERE id NOT IN (SELECT playlist_id FROM playlist_song WHERE song_id = " + song.id + ")";
            SqlDataReader dr = Program.ReadData(query);
            List<Playlist> list = new List<Playlist>();
            while (dr.Read())
            {
                Playlist playlist = new Playlist(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                list.Add(playlist);
            }
            
            var bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            this.comboPlaylists.DataSource = null;
            this.comboPlaylists.DataSource = bindingSource.DataSource;
            this.comboPlaylists.DisplayMember = "Name";
            this.comboPlaylists.ValueMember = "Id";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeClicked?.Invoke(this, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add the song to the selected playlist
            int playlistId = (int)this.comboPlaylists.SelectedValue;
            string query = "INSERT INTO playlist_song (playlist_id, song_id) VALUES (" + playlistId + ", " + song.id + ")";
            Program.ExecuteQuery(query);
            closeClicked?.Invoke(this, e);

            Program.uc_playlists.Reload();
        }
    }
}
