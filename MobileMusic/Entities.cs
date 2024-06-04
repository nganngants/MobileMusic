using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
/*
 * This file contains the definition for various entities used in the application
 * Song: represents a song in the application
 * 
 */
namespace MobileMusic
{
    /*
     * Definition of song in SQL database:
     * create table song (
	        id int identity(1,1) primary key,
	        name nvarchar(128) not null,
	        singer nvarchar(128),
	        category varchar(64) check (category in ('US-UK', 'V-pop', 'K-pop')),
	        filename varchar(128),
	        thumbnail varchar(128),
	        last_played smalldatetime,
	        is_favorite int check (is_favorite in (0, 1)) default 0
        )
     */
    public class Song
    {
        public int id;
        public string filename;
        public string song_name;
        public string singer_name;
        public string thumbnail_filename;
        public string category;
        public bool isFavorite;
        public bool isPlaying;
        public DateTime? lastPlayed;
        public bool downloaded;

        public Song(int id, string filename, string song_name, string singer_name, string thumbnail_filename, string category,
                    bool isFavorite, DateTime? lastPlayed = null)
        {
            this.id = id;
            this.filename = filename;
            this.song_name = song_name;
            this.singer_name = singer_name;
            this.thumbnail_filename = thumbnail_filename;
            this.category = category;
            this.isFavorite = isFavorite;
            this.isPlaying = false;
            this.lastPlayed = lastPlayed;
            this.downloaded = checkDownloaded();
        }

        public static bool operator !=(Song s1, Song s2)
        {
            return s1.id != s2.id;
        }

        public static bool operator ==(Song s1, Song s2)
        {
            return s1.id == s2.id;
        }

        public int Id { get => id;}
        public string DisplaySongName { get => song_name + " - " + singer_name;}

        private bool checkDownloaded()
        {
            string query = "SELECT * FROM download WHERE song_id = " + this.id;
            SqlDataReader dr = Program.ReadData(query);
            return dr.HasRows;
        }
    }

    /*
     create table playlist (    
	    id int identity(1,1) primary key,
	    name nvarchar(128) not null,
	    thumbnail varchar(128)
    )   */

    public class Playlist
    {
        public int id;
        public string name;
        public string thumbnail_filename;
        public List<Song> songs;

        public Playlist(int id, string name, string thumbnail_filename)
        {
            this.id = id;
            this.name = name;
            this.thumbnail_filename = thumbnail_filename;
            this.songs = new List<Song>();
            LoadSongs();
        }

        public string Name { get { return name; }}

        public int Id { get { return id; }}

        public void LoadSongs()
        {
            string query = "SELECT * FROM song JOIN playlist_song ON song.id = playlist_song.song_id WHERE playlist_id = " + this.id;
            SqlDataReader dr = Program.ReadData(query);
            while (dr.Read())
            {
                Song song = new Song((int)dr["song_id"], dr["filename"].ToString(), dr["name"].ToString(), dr["singer"].ToString(), dr["thumbnail"].ToString(), dr["category"].ToString(), (int)dr["is_favorite"] == 1);
                this.songs.Add(song);
            }
        }

        public bool ContainsSong(Song song)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i] == song)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddSong(Song song)
        {
            if (!ContainsSong(song))
            {
                songs.Add(song);
                string query = "INSERT INTO playlist_song (playlist_id, song_id) VALUES (" + this.id + ", " + song.id + ")";
                Program.ExecuteQuery(query);
            }
        }

        public void RemoveSong(Song song)
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i] == song)
                {
                    songs.RemoveAt(i);
                    string query = "DELETE FROM playlist_song WHERE playlist_id = " + this.id + " AND song_id = " + song.id;
                    Program.ExecuteQuery(query);
                    return;
                }
            }
        }

    }

    public class DownloadedSong
    {
        public int id;
        public string filename;
        public string song_name;
        public string singer_name;
        public string thumbnail_filename;
        public DateTime downloadedTime;

        public DownloadedSong(int id, string song_name, string singer_name, string filename, string thumbnail_filename, DateTime downloadedTime)
        {
            this.id = id;
            this.filename = filename;
            this.song_name = song_name;
            this.singer_name = singer_name;
            this.thumbnail_filename = thumbnail_filename;
            this.downloadedTime = downloadedTime;
        }
    }
}