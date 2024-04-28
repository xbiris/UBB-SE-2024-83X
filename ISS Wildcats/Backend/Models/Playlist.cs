namespace ISS_Wildcats.Backend.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

public class Playlist
{
	public int PlaylistID { get; set; }
	public string Name { get; set; }
	public List<int> SongIDs { get; set; } = new List<int>();
	public int CreatorID { get; set; }

	private readonly string connectionString;

	public Playlist(string connectionString)
	{
		this.connectionString = connectionString;
	}

	public Playlist(string connectionString, int playlistID)
	{
		this.connectionString = connectionString;
		LoadPlaylistFromDatabase(playlistID);
	}

	private void LoadPlaylistFromDatabase(int playlistID)
	{
		using (var connection = new SqlConnection(connectionString))
		{
			connection.Open();
			var query = "SELECT Playlist.id, Playlist.playlist_name, Playlist.creator_id, PlaylistSong.song_id " +
						"FROM Playlist " +
						"LEFT JOIN PlaylistSong ON Playlist.id = PlaylistSong.playlist_id " +
						"WHERE Playlist.id = @PlaylistID";
			using (var cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@PlaylistID", playlistID);
				using (var reader = cmd.ExecuteReader())
				{
					bool isFirstRow = true;
					while (reader.Read())
					{
						if (isFirstRow)
						{
							PlaylistID = reader.GetInt32(reader.GetOrdinal("id"));
							Name = reader.GetString(reader.GetOrdinal("playlist_name"));
							CreatorID = reader.GetInt32(reader.GetOrdinal("creator_id"));
							isFirstRow = false;
						}
						if (!reader.IsDBNull(reader.GetOrdinal("song_id")))
						{
							SongIDs.Add(reader.GetInt32(reader.GetOrdinal("song_id")));
						}
					}
					if (isFirstRow)
					{
						throw new ArgumentException("Playlist not found in the database.");
					}
				}
			}
		}
	}

	public void AddSong(int songID)
	{
		using (var connection = new SqlConnection(connectionString))
		{
			connection.Open();
			var query = "INSERT INTO PlaylistSong (playlist_id, song_id) VALUES (@PlaylistID, @SongID)";
			using (var cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@PlaylistID", PlaylistID);
				cmd.Parameters.AddWithValue("@SongID", songID);
				cmd.ExecuteNonQuery();
			}
			SongIDs.Add(songID);
		}
	}

	public void RemoveSong(int songID)
	{
		using (var connection = new SqlConnection(connectionString))
		{
			connection.Open();
			var query = "DELETE FROM PlaylistSong WHERE playlist_id = @PlaylistID AND song_id = @SongID";
			using (var cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@PlaylistID", PlaylistID);
				cmd.Parameters.AddWithValue("@SongID", songID);
				cmd.ExecuteNonQuery();
			}
			SongIDs.Remove(songID);
		}
	}

	public void Update()
	{
		using (var connection = new SqlConnection(connectionString))
		{
			connection.Open();
			var query = "UPDATE Playlist SET playlist_name = @Name WHERE id = @PlaylistID";
			using (var cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@Name", Name);
				cmd.Parameters.AddWithValue("@PlaylistID", PlaylistID);
				cmd.ExecuteNonQuery();
			}
		}
	}

	public void Delete()
	{
		using (var connection = new SqlConnection(connectionString))
		{
			connection.Open();
			var query = "DELETE FROM PlaylistSong WHERE playlist_id = @PlaylistID; " +
						"DELETE FROM Playlist WHERE id = @PlaylistID";
			using (var cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@PlaylistID", PlaylistID);
				cmd.ExecuteNonQuery();
			}
		}
	}
}
