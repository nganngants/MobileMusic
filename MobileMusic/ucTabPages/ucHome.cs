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
    public partial class ucHome : UserControl
    {
        List<Song> recentList;
        public ucHome()
        {
            InitializeComponent();
            this.layoutRecent.AutoScroll = true;
            this.layoutRecent.VerticalScroll.Enabled = true;

            // Resize the images in two picture boxes to fit the picture box
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void Reload()
        {
            LoadRecentList();
        }

        private void LoadRecentList()
        {
            // Load the recent list from the database
            string query = "SELECT * FROM song WHERE last_played IS NOT NULL ORDER BY last_played DESC";
            SqlDataReader dr = Program.ReadData(query);
            recentList = new List<Song>();

            while (dr.Read())
            {
                DateTime? lastPlayed = dr["last_played"] == DBNull.Value ? null : (DateTime?)dr["last_played"];
                Song song = new Song((int)dr["id"], dr["filename"].ToString(), dr["name"].ToString(), dr["singer"].ToString(),
                                                        dr["thumbnail"].ToString(), dr["category"].ToString(), Convert.ToBoolean(dr["is_favorite"]), lastPlayed);
                recentList.Add(song);
            }

            this.layoutRecent.Controls.Clear();
            foreach (Song song in recentList)
            {
                ucRecentSongItem uc = new ucRecentSongItem(song);
                this.layoutRecent.Controls.Add(uc);
            }
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            LoadRecentList();
        }
    }
}
