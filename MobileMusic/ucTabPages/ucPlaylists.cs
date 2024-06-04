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
    public partial class ucPlaylists : UserControl
    {
        TabPage playlistsPage;
        List<Playlist> playlists;
        public ucPlaylists()
        {
            InitializeComponent();
        }

        public ucPlaylists(TabPage page)
        {
            InitializeComponent();
            LoadPlaylists();
            this.playlistsPage = page;
        }

        public void Reload()
        {
            LoadPlaylists();
            if (playlistsPage.Controls.Count > 1)
            {
                ucPlaylistView uc = (ucPlaylistView)playlistsPage.Controls[0];
                uc.Reload();
            }
        }

        private ucPlaylistItem newPlaylistItem(Playlist playlist)
        {

            ucPlaylistItem uc = new ucPlaylistItem(playlist);
            uc.playlistItemClicked += playlistItemClicked;
            return uc;
        }

        private void LoadPlaylists()
        {
            // Load all playlists from the database to playlists array
            string query = "SELECT * FROM playlist";
            SqlDataReader dr = Program.ReadData(query);
            playlists = new List<Playlist>();
            this.layoutPlaylists.Controls.Clear();
            while (dr.Read())
            {
                Playlist playlist = new Playlist(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                playlists.Add(playlist);
            }

            // Display all playlists
            foreach (Playlist playlist in playlists)
            {
                ucPlaylistItem uc = newPlaylistItem(playlist);
                this.layoutPlaylists.Controls.Add(uc);
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            if (tbPlaylistName.Text != "")
            {
                string playlistName = tbPlaylistName.Text;
                string query = "INSERT INTO playlist (name, thumbnail) VALUES (N'" + playlistName + "', 'default-playlist.png')";
                Program.ExecuteQuery(query);
                tbPlaylistName.Text = "";

                LoadPlaylists();
            }
        }

        private void ucPlaylists_Load(object sender, EventArgs e)
        {

        }

        private void playlistItemClicked(object sender, EventArgs e)
        {
            ucPlaylistItem uc = (ucPlaylistItem)sender;
            Playlist playlist = uc.playlist;
            ucPlaylistView ucPlaylistView = new ucPlaylistView(playlist, playlistsPage);
            ucPlaylistView.Dock = DockStyle.Fill;
            ucPlaylistView.backClicked += playlistView_BackClicked;
            this.playlistsPage.Controls.Add(ucPlaylistView);
            ucPlaylistView.BringToFront();
        }

        private void playlistView_BackClicked(object sender, EventArgs e)
        {
            this.playlistsPage.Controls.Remove((ucPlaylistView)sender);
            LoadPlaylists();
        }
    }
}
