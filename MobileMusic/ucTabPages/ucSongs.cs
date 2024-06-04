using MobileMusic.ucComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib.Tiff;

namespace MobileMusic.ucTabPages
{
    public partial class ucSongs : UserControl
    {
        TabPage songsPage;
        List<ucSongItem> allList;
        ucDownloaded ucDownloaded;
        ucAddToPlaylist ucAddToPlaylist;

        public ucSongs(TabPage page, ucDownloaded ucDownloaded)
        {
            InitializeComponent();

            this.layoutAll.AutoScroll = true;
            this.layoutAll.VerticalScroll.Enabled = true;
            this.layoutAll.HorizontalScroll.Enabled = false;

            this.layoutVpop.AutoScroll = true;
            this.layoutVpop.VerticalScroll.Enabled = true;
            this.layoutVpop.HorizontalScroll.Enabled = false;

            this.layoutUSUK.AutoScroll = true;
            this.layoutUSUK.VerticalScroll.Enabled = true;
            this.layoutUSUK.HorizontalScroll.Enabled = false;

            this.layoutKpop.AutoScroll = true;
            this.layoutKpop.VerticalScroll.Enabled = true;
            this.layoutKpop.HorizontalScroll.Enabled = false;

            this.layoutFavorite.AutoScroll = true;
            this.layoutFavorite.VerticalScroll.Enabled = true;
            this.layoutFavorite.HorizontalScroll.Enabled = false;

            this.songsPage = page;
            this.ucDownloaded = ucDownloaded;

            ucAddToPlaylist = new ucAddToPlaylist();
            this.Controls.Add(ucAddToPlaylist);
            ucAddToPlaylist.closeClicked += (sender, e) =>
            {
                ucAddToPlaylist.Hide();
            };
            // set the location of the user control to the middle of the form
            ucAddToPlaylist.Location = new Point((this.Width - ucAddToPlaylist.Width) / 2, (this.Height - ucAddToPlaylist.Height) / 2);
            ucAddToPlaylist.BringToFront();
            ucAddToPlaylist.Hide();
        }

        public ucSongItem newSongItem(Song song)
        {
            ucSongItem ucSong = new ucSongItem(song);
            ucSong.favoriteClicked += favoriteChanged;
            ucSong.downloadChanged += DownloadChanged;
            ucSong.ClientSize = new Size(400, 70);
            ucSong.Dock = DockStyle.Top;
            ucSong.songClicked += ucSongItem_Clicked;
            ucSong.addClicked += ucSongItem_AddClicked;
            return ucSong;
        }

        public void Reload()
        {
            foreach (ucSongItem ucSong in layoutAll.Controls)
            {
                ucSong.Reload();
            }

            foreach (ucSongItem ucSong in layoutVpop.Controls)
            {
                ucSong.Reload();
            }

            foreach (ucSongItem ucSong in layoutUSUK.Controls)
            {
                ucSong.Reload();
            }

            foreach (ucSongItem ucSong in layoutKpop.Controls)
            {
                ucSong.Reload();
            }

            foreach (ucSongItem ucSong in layoutFavorite.Controls)
            {
                ucSong.Reload();
            }
        }

        public void LoadSongs()
        {
            // Load all songs from the database to songs array
            string query = "SELECT * FROM song ORDER BY name";
            SqlDataReader dr = Program.ReadData(query);
            allList = new List<ucSongItem>();

            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string filename = dr["filename"].ToString();
                string song_name = dr["name"].ToString();
                string singer_name = dr["singer"].ToString();
                string thumbnail_filename = dr["thumbnail"].ToString();
                string category = dr["category"].ToString();
                bool isFavorite = Convert.ToBoolean(dr["is_favorite"]);
                DateTime? lastPlayed = dr["last_played"] == DBNull.Value ? null : (DateTime?)dr["last_played"];
                Song song = new Song(id, filename, song_name, singer_name, thumbnail_filename, category, isFavorite, lastPlayed);
                ucSongItem ucSong = newSongItem(song);
                allList.Add(ucSong); 
                layoutAll.Controls.Add(ucSong);

                if (category == "V-pop")
                {
                    ucSongItem uc = newSongItem(song);
                    layoutVpop.Controls.Add(uc);
                }
                else if (category == "US-UK")
                {
                    ucSongItem uc = newSongItem(song);
                    layoutUSUK.Controls.Add(uc);
                }
                else if (category == "K-pop")
                {
                    ucSongItem uc = newSongItem(song);
                    layoutKpop.Controls.Add(uc);
                }

                if (isFavorite)
                {
                    ucSongItem uc = newSongItem(song);
                    layoutFavorite.Controls.Add(uc);
                }
            }
        }

        private void ucSongs_Load(object sender, EventArgs e)
        {
            LoadSongs();
            // ensure that the songs array is not empty
            if (allList.Count == 0)
            {
                MessageBox.Show("No songs found in the database");
                return;
            }
        }

        private void Search(FlowLayoutPanel layout, string search)
        {
            foreach (ucComponents.ucSongItem ucSong in layout.Controls)
            {
                if (ucSong.song.song_name.ToLower().Contains(search.ToLower()) || ucSong.song.singer_name.ToLower().Contains(search.ToLower()))
                {
                    ucSong.Visible = true;
                }
                else
                {
                    ucSong.Visible = false;
                }
            }
        }

        private void tbSearchAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tbSearchAll.Text;
                if (search == "") return;
                Search(layoutAll, search);
                this.btnClearAll.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClearAll.Visible = false;
            tbSearchAll.Text = "";
            foreach (ucComponents.ucSongItem ucSong in layoutAll.Controls)
            {
                ucSong.Visible = true;
            }
        }

        // write similar code for the other 3 search textboxes
        private void tbSearchVpop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tbSearchVpop.Text;
                if (search == "") return;
                Search(layoutVpop, search);
                this.btnClearVpop.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClearVpop_Click(object sender, EventArgs e)
        {
            btnClearAll.Visible = false;
            tbSearchVpop.Text = "";
            foreach (ucComponents.ucSongItem ucSong in layoutVpop.Controls)
            {
                ucSong.Visible = true;
            }
        }

        private void tbSearchUSUK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tbSearchUSUK.Text;
                if (search == "") return;
                Search(layoutUSUK, search);
                this.btnClearUsuk.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClearUsuk_Click(object sender, EventArgs e)
        {
            btnClearUsuk.Visible = false;
            tbSearchUSUK.Text = "";
            foreach (ucComponents.ucSongItem ucSong in layoutUSUK.Controls)
            {
                ucSong.Visible = true;
            }
        }

        private void tbSearchKpop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tbSearchKpop.Text;
                if (search == "") return;
                Search(layoutKpop, search);
                this.btnClearKpop.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClearKpop_Click(object sender, EventArgs e)
        {
            btnClearKpop.Visible = false;
            tbSearchKpop.Text = "";
            foreach (ucComponents.ucSongItem ucSong in layoutKpop.Controls)
            {
                ucSong.Visible = true;
            }
        }
        private void tbSearchFavorite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = tbSearchFavorite.Text;
                if (search == "") return;
                Search(layoutFavorite, search);
                this.btnClearFavorite.Visible = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClearFavorite_Click(object sender, EventArgs e)
        {
            btnClearFavorite.Visible = false;
            tbSearchFavorite.Text = "";
            foreach (ucComponents.ucSongItem ucSong in layoutFavorite.Controls)
            {
                ucSong.Visible = true;
            }
        }

        public void favoriteChanged(object sender, EventArgs e)
        {
            ucSongItem uc = (ucSongItem)sender;
            if (uc.song.isFavorite)
            {
                ucSongItem ucSong = newSongItem(uc.song);
                layoutFavorite.Controls.Add(ucSong);
            }
            else
            {
                foreach (ucSongItem ucSong in layoutFavorite.Controls)
                {
                    if (ucSong.song.id == uc.song.id)
                    {
                        System.Diagnostics.Debug.WriteLine("remove: " , ucSong.song.song_name);
                        layoutFavorite.Controls.Remove(ucSong);
                        break;
                    }
                }
            }

            foreach (ucSongItem ucSong in layoutAll.Controls)
            {
                if (ucSong.song.id == uc.song.id)
                {
                    ucSong.song.isFavorite = uc.song.isFavorite;
                    ucSong.Reload();
                    break;
                }
            }

            foreach (ucSongItem ucSong in layoutVpop.Controls)
            {
                if (ucSong.song.id == uc.song.id)
                {
                    ucSong.song.isFavorite = uc.song.isFavorite;
                    ucSong.Reload();
                    break;
                }
            }

            foreach (ucSongItem ucSong in layoutUSUK.Controls)
            {
                if (ucSong.song.id == uc.song.id)
                {
                    ucSong.song.isFavorite = uc.song.isFavorite;
                    ucSong.Reload();
                    break;
                }
            }

            foreach (ucSongItem ucSong in layoutKpop.Controls)
            {
                if (ucSong.song.id == uc.song.id)
                {
                    ucSong.song.isFavorite = uc.song.isFavorite;
                    ucSong.Reload();
                    break;
                }
            }
        }

        public void ucSongItem_Clicked(object sender, EventArgs e)
        {
            ucSongItem uc = (ucSongItem)sender;
            ucSongView ucSongView = new ucSongView(uc.song, uc);
            ucSongView.Dock = DockStyle.Fill;
            ucSongView.backClicked += ucSongView_Back;
            songsPage.Controls.Add(ucSongView);
            ucSongView.BringToFront();
        }

        public void ucSongView_Back(object sender, EventArgs e)
        {
            songsPage.Controls.Remove((ucSongView)sender);
        }

        public void ucSongItem_AddClicked(object sender, EventArgs e)
        {
            ucSongItem uc = (ucSongItem)sender;
            ucAddToPlaylist.setSong(uc.song);
            ucAddToPlaylist.LoadPlaylists();
            ucAddToPlaylist.Show();
        }

        private void DownloadChanged(object sender, EventArgs e)
        {
            ucSongItem uc = (ucSongItem)sender;
            ucDownloaded.DownloadChanged(uc.song.id);
        }
    }

}
