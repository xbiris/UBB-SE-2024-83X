using ISS_Wildcats.Backend.Models;
using System.Collections.Generic;

namespace ISS_Wildcats.Backend.Service
{
	public interface ISongRepoService
	{
		void AddSong(Song song);
		Song GetSongById(int songId);
		Song GetSongByTitle(string title);
		Song GetSongByUrl(string songUrl);
		void DeleteSong(Song song);
		List<Song> GetSongsByCreator(int creatorId);
		List<Song> GetSongsFromAlbum(int albumId);
	}
}
