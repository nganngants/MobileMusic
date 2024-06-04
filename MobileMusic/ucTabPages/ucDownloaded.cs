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
    public partial class ucDownloaded : UserControl
    { 
        public ucDownloaded()
        {
            InitializeComponent();
            layoutDownloaded.AutoScroll = true;
            layoutDownloaded.VerticalScroll.Visible = true;
            layoutDownloaded.VerticalScroll.Enabled = true;
        }

        private void ucDownloaded_Load(object sender, EventArgs e)
        {
            LoadDownloadedSongs();
        }

        public void Reload()
        {
            LoadDownloadedSongs();
        }

        private void LoadDownloadedSongs()
        {
            this.layoutDownloaded.Controls.Clear();
            // Load all downloaded songs
            string query = "SELECT * FROM song JOIN download ON song.id = download.song_id ORDER BY downloaded_time DESC";
            SqlDataReader dr = Program.ReadData(query);
            while (dr.Read())
            {
                int song_id = (int)dr["song_id"];
                string song_name = dr["name"].ToString();
                string singer_name = dr["singer"].ToString();
                string filename = dr["filename"].ToString();
                string thumbnail = dr["thumbnail"].ToString();
                DateTime downloadedTime = (DateTime)dr["downloaded_time"];
                DownloadedSong downloadedSong = new DownloadedSong(song_id, song_name, singer_name, filename, thumbnail, downloadedTime);
                ucDownloadedItem ucDownloadedItem = new ucDownloadedItem(downloadedSong);
                this.layoutDownloaded.Controls.Add(ucDownloadedItem);
            }
        }

        public void DownloadChanged(int song_id)
        {
            // check if there is a downloaded song with the given song_id in layoutDownloaded, if yes, remove it
            foreach (ucDownloadedItem item in this.layoutDownloaded.Controls)
            {
                if (item.song.id == song_id)
                {
                    this.layoutDownloaded.Controls.Remove(item);
                    break;
                }
            }

            // Load the downloaded song with the given song_id
            string query = "SELECT * FROM song JOIN download ON song.id = download.song_id WHERE song.id = " + song_id;
            SqlDataReader dr = Program.ReadData(query);
            if (dr.Read())
            {
                string song_name = dr["name"].ToString();
                string singer_name = dr["singer"].ToString();
                string filename = dr["filename"].ToString();
                string thumbnail = dr["thumbnail"].ToString();
                DateTime downloadedTime = (DateTime)dr["downloaded_time"];
                DownloadedSong downloadedSong = new DownloadedSong(song_id, song_name, singer_name, filename, thumbnail, downloadedTime);
                ucDownloadedItem ucDownloadedItem = new ucDownloadedItem(downloadedSong);
                ucDownloadedItem.Dock = DockStyle.Top;
                this.layoutDownloaded.Controls.Add(ucDownloadedItem);
                // move the new downloaded song to the top
                this.layoutDownloaded.Controls.SetChildIndex(ucDownloadedItem, 0);
            }
        }

    }
}
