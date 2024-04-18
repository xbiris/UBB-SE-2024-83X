namespace ISS_Wildcats.Backend.Models;

using System;
using MySql.Data.MySqlClient;

public class Song
{
    public int SongID { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public string Url { get; set; }
    public DateTime ReleaseDate { get; set; }

    private readonly string connectionString;

    // For interactions with database
    public Song(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // For controller interactions
    public Song(string connectionString, int songID)
    {
        this.connectionString = connectionString;
        LoadSongFromDatabase(songID);
    }

    private void LoadSongFromDatabase(int songID)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "SELECT * FROM Songs WHERE SongID = @SongID";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SongID", songID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        SongID = Convert.ToInt32(reader["SongID"]);
                        Title = reader["Title"].ToString();
                        Artist = reader["Artist"].ToString();
                        Album = reader["Album"].ToString();
                        Genre = reader["Genre"].ToString();
                        Duration = Convert.ToInt32(reader["Duration"]);
                        ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                        Url = reader["Url"].ToString();
                    }
                    else
                    {
                        throw new ArgumentException("Song not found in the database.");
                    }
                }
            }
        }
    }

    public void Add()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "INSERT INTO Songs (Title, Artist, Album, Genre, Duration, ReleaseDate) " +
                        "VALUES (@Title, @Artist, @Album, @Genre, @Duration, @ReleaseDate, @Url)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Artist", Artist);
                cmd.Parameters.AddWithValue("@Album", Album);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                cmd.Parameters.AddWithValue("@Url", Url);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public static Song Get(int songID, string connectionString)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "SELECT * FROM Songs WHERE SongID = @SongID";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SongID", songID);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Song(connectionString)
                        {
                            SongID = Convert.ToInt32(reader["SongID"]),
                            Title = reader["Title"].ToString(),
                            Artist = reader["Artist"].ToString(),
                            Album = reader["Album"].ToString(),
                            Genre = reader["Genre"].ToString(),
                            Duration = Convert.ToInt32(reader["Duration"]),
                            ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]),
                            Url = reader["Url"].ToString()
                        };
                    }
                    else
                    {
                        return null; // Song not found
                    }
                }
            }
        }
    }

    public void Update()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "UPDATE Songs SET Title = @Title, Artist = @Artist, Album = @Album, " +
                        "Genre = @Genre, Duration = @Duration, ReleaseDate = @ReleaseDate, Url = @Url WHERE SongID = @SongID";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Artist", Artist);
                cmd.Parameters.AddWithValue("@Album", Album);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@Duration", Duration);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                cmd.Parameters.AddWithValue("@SongID", SongID);
                cmd.Parameters.AddWithValue("@Url", Url);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Delete()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "DELETE FROM Songs WHERE SongID = @SongID";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@SongID", SongID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
