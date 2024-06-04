using MobileMusic.ucComponents;
using MobileMusic.ucTabPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileMusic
{
    internal static class Program
    {
        public static string songs_path = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) + "\\songs\\";
        public static string thumbnails_path = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) + "\\images\\thumbnails\\";
        public static string playlistThumbnails_path = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..")) + "\\images\\playlist_thumbnails\\";
        static SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=MobileMusic;Integrated Security=True;MultipleActiveResultSets=true");
        static ucSongItem playing;
        public static ucHome uc_home;
        public static ucSongs uc_songs;
        public static ucPlaylists uc_playlists;
        public static ucDownloaded ucDownloaded;
        static void ConnectToDatabase()
        {
            // create a connection to the database
            try
            {
                con.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // create a function to close the connection to the database
        static void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // create a function to execute the query
        static public void ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        // create a function to read the data from the database
        static public SqlDataReader ReadData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        static private void LoadSongs()
        {
            // Load the songs info from info.txt to insert into the database
            // the info.txt file contains many lines of song information
            // each line has format: filename;song_name;singer_name;thumbnail_filename
            // the table song in the database has the following columns: name, singer, category, filename, thumbnail
            // note that the name and singer columns are of type nvarchar
            // and for line 1 to 11, the category column is "V-pop"
            // and for line 12 to 22, the category column is "US-UK"
            // and for line 23 to 31, the category column is "K-pop"

            string info_file = songs_path + "\\info.txt";
            string[] lines = System.IO.File.ReadAllLines(info_file);
            string query = "";
            for (int i = 0; i < lines.Length; i++)
            {
                string[] info = lines[i].Split(';');
                string name = info[1];
                string singer = info[2];
                string category = "";
                if (i < 11)
                {
                    category = "V-pop";
                }
                else if (i < 22)
                {
                    category = "US-UK";
                }
                else
                {
                    category = "K-pop";
                }
                string filename = info[0];
                string thumbnail = info[3];
                query = "INSERT INTO song (name, singer, category, filename, thumbnail) VALUES (N'" + name + "', N'" + singer + "', N'" + category + "', N'" + filename + "', N'" + thumbnail + "')";
                ExecuteQuery(query);
            }   
        }

        static public void PlaySong(ucSongItem uc)
        {
            if (playing != null)
            {
                playing.Stop();
            }
            playing = uc;
            uc.Play();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectToDatabase();
            // LoadSongs();
            Application.Run(new fMain());
            CloseConnection();
        }
    }
}
