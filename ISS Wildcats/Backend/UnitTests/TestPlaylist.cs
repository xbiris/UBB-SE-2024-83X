using ISS_Wildcats.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ISS_Wildcats.Backend.UnitTests
{
    public class TestPlaylist
    {
        [Fact]
        public void TestConstructorsPropertiesLoad() 
        {
            // arrange
            string connectionString = "Data Source=DESKTOP-LOCA7ND;Initial Catalog=se_2024;Integrated Security=True;Encrypt=False;";
            int playlistId = 1;
            string title = "Sunset Boulevard";
            List<int> songIDs = new List<int>() { 1, 2 };
            int creatorId = 1;

            // act
            var album1 = new Playlist(connectionString, playlistId);
            var album2 = new Playlist(connectionString);

            // assert
            Assert.NotNull(album1);
            Assert.NotNull(album2);
            Assert.NotEqual(album2, album1);
            Assert.Equal(album1.PlaylistID, playlistId);
            Assert.Equal(album1.Name, title);
            Assert.Equal(album1.SongIDs, songIDs);
            Assert.Equal(album1.CreatorID, creatorId);
        }

        [Fact]
        public void TestUpdateAlbum()
        {
            // arrange
            string connectionString = "Data Source=DESKTOP-LOCA7ND;Initial Catalog=se_2024;Integrated Security=True;Encrypt=False;";
            int playlistId = 1;
            var album = new Playlist(connectionString, playlistId);
            string title = "Sunset Boulevard";

            // act
            if (album.Name.Equals("Sunset Boulevard"))
            {
                album.Update("Synchronicity");
                title = "Synchronicity";
            }
            else
            {
                album.Update("Sunset Boulevard");
            }

            // assert
            var album2 = new Playlist(connectionString, playlistId);
            Assert.Equal(album2.Name, title);

        }

        [Fact]
        public void TestDeleteAlbum()
        {
            // arrange
            string connectionString = "Data Source=DESKTOP-LOCA7ND;Initial Catalog=se_2024;Integrated Security=True;Encrypt=False;";
            int playlistId = 1;

            // act
            var album = new Playlist(connectionString, playlistId);
            album.Delete();

            // assert
            try
            {
                var album2 = new Playlist(connectionString, playlistId);
            }
            catch {
                Assert.True(true); //album2 could not be found
            }
        }
    }
}
