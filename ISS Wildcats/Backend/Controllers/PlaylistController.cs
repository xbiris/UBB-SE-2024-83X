using ISS_Wildcats.Backend.Models;
using System;
using Mysqlx.Expect;
namespace ISS_Wildcats.Backend.Controllers
{
    public class PlaylistController
    {
        private Playlist playlist;
        

        public PlaylistController(string connectionString, int playlistID)
        {
            playlist = new Playlist(connectionString, playlistID);
        }

        //mai avem de implementat aici.
    }
}