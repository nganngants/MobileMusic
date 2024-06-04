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
using MobileMusic.ucComponents;

namespace MobileMusic.ucTabPages
{
    public partial class ucPlaylistView : UserControl
    {
        Playlist playlist;
        List<Song> outSongs;
        public EventHandler backClicked;
        TabPage playlistPage;
        public ucPlaylistView(Playlist playlist, TabPage page)
        {
            InitializeComponent();
            this.playlist = playlist;
            this.playlistPage = page;
            this.lbPlaylistName.Text = playlist.name;

            this.layoutSongs.AutoScroll = true;
            this.layoutSongs.HorizontalScroll.Enabled = false;
            this.layoutSongs.HorizontalScroll.Visible = false;
            this.layoutSongs.VerticalScroll.Visible = true;
            this.layoutSongs.VerticalScroll.Enabled = true;
        }

        private void ucPlaylistView_Load(object sender, EventArgs e)
        {
            LoadPlaylistSongs();
            LoadSongsToComboBox();
        }

        public void Reload()
        {
            foreach (ucSongItem uc in layoutSongs.Controls)
            {
                uc.Reload();
            }
        }

        private ucSongItem newSongItem (Song song)
        {
            ucSongItem uc = new ucSongItem(song);
            uc.Dock = DockStyle.Top;
            uc.setEnableAddButton(false);
            uc.setEnableDeleteButton(true);
            //uc.setEnableFavoriteButton(false);
            uc.ClientSize = new Size(370, 65);
            uc.deleteClicked += SongItem_DeleteClicked;
            uc.songClicked += ucSongItem_Clicked;
            uc.favoriteClicked += Program.uc_songs.favoriteChanged;
            return uc;
        }

        private void LoadPlaylistSongs()
        {
            outSongs = new List<Song>();
            string query = "SELECT * FROM song";
            SqlDataReader dr = Program.ReadData(query);
            while (dr.Read())
            {
                Song song = new Song((int)dr["id"], dr["filename"].ToString(), dr["name"].ToString(), dr["singer"].ToString(),
                                      dr["thumbnail"].ToString(), dr["category"].ToString(), (int)dr["is_favorite"] == 1);
                if (!playlist.ContainsSong(song))
                {
                    outSongs.Add(song);
                }
            }

            foreach (Song song in playlist.songs)
            {
                ucSongItem ucSongItem = newSongItem(song);
                this.layoutSongs.Controls.Add(ucSongItem);
            }
        }

        private void LoadSongsToComboBox()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = outSongs;
            comboSongs.DataSource = null;
            comboSongs.DataSource = bindingSource.DataSource;
            comboSongs.DisplayMember = "DisplaySongName";
            comboSongs.ValueMember = "Id";
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            // add the selected song to the playlist
            int song_id = (int)comboSongs.SelectedValue;

            // add the song to the inSongs list
            Song song = outSongs.Find(s => s.id == song_id);
            playlist.AddSong(song);
            ucSongItem ucSongItem = newSongItem(song);
            this.layoutSongs.Controls.Add(ucSongItem);

            for (int i = 0; i < outSongs.Count; i++)
            {
                if (outSongs[i].id == song_id)
                {
                    outSongs.RemoveAt(i);
                    break;
                }
            }
            // remove the song from the combo box
            LoadSongsToComboBox();
        }

        private void SongItem_DeleteClicked(object sender, EventArgs e)
        {
            ucSongItem ucSongItem = (ucSongItem)sender;
            Song song = ucSongItem.song;
            playlist.RemoveSong(song);
            this.layoutSongs.Controls.Remove(ucSongItem);
            outSongs.Add(song);
            LoadSongsToComboBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backClicked?.Invoke(this, e);
        }

        public void ucSongItem_Clicked(object sender, EventArgs e)
        {
            ucSongItem uc = (ucSongItem)sender;
            ucSongView ucSongView = new ucSongView(uc.song, uc);
            ucSongView.Dock = DockStyle.Fill;
            ucSongView.backClicked += ucSongView_Back;
            playlistPage.Controls.Add(ucSongView);
            ucSongView.BringToFront();
        }

        public void ucSongView_Back(object sender, EventArgs e)
        {
            playlistPage.Controls.Remove((ucSongView)sender);
        }
    }
}
