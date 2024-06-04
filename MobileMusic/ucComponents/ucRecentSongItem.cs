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
    public partial class ucRecentSongItem : UserControl
    {
        Song song;
        public ucRecentSongItem()
        {
            InitializeComponent();
        }

        public ucRecentSongItem(Song song)
        {
            this.song = song;
            InitializeComponent();
            this.lbSongName.Text = song.song_name;
            this.lbSinger.Text = song.singer_name;
            this.lbTime.Text = "Last played: " + song.lastPlayed.ToString();
            this.pbThumbnail.Image = Image.FromFile(Program.thumbnails_path + song.thumbnail_filename);
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
