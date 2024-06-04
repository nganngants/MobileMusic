using MobileMusic.ucComponents;
using MobileMusic.ucTabPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            Program.uc_home = new ucHome();
            Program.uc_home.Dock = DockStyle.Fill;

            Program.uc_playlists = new ucPlaylists(tabPlaylists);
            Program.uc_playlists.Dock = DockStyle.Fill;

            Program.ucDownloaded = new ucDownloaded();
            Program.ucDownloaded.Dock = DockStyle.Fill;

            Program.uc_songs = new ucSongs(tabSongs, Program.ucDownloaded);
            Program.uc_songs.Dock = DockStyle.Fill;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.tabHome.Controls.Add(Program.uc_home);
            this.tabSongs.Controls.Add(Program.uc_songs);
            this.tabPlaylists.Controls.Add(Program.uc_playlists);
            this.tabDownloaded.Controls.Add(Program.ucDownloaded);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}
