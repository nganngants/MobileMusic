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
    public partial class ucDownloadedItem : UserControl
    {
        public DownloadedSong song;

        public ucDownloadedItem(DownloadedSong song)
        {
            InitializeComponent();
            this.lbSongName.Text = song.song_name;
            this.lbSinger.Text = song.singer_name;
            this.lbDownloadTime.Text = "Downloaded at " + song.downloadedTime.ToString();
            this.pbThumbnail.Image = Image.FromFile(Program.thumbnails_path + song.thumbnail_filename);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;

            this.song = song;
        }

        public void Reload()
        {
            string query = "SELECT * FROM download WHERE song_id = " + song.id;
            SqlDataReader dr = Program.ReadData(query);
            dr.Read();
            song = new DownloadedSong(song.id, song.song_name, song.singer_name, song.filename, song.thumbnail_filename, (DateTime)dr["downloaded_time"]);
            this.lbDownloadTime.Text = "Downloaded at " + song.downloadedTime.ToString();
        }
    }
}
