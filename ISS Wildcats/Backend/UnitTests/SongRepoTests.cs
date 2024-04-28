using ISS_Wildcats.Backend.Models;
using ISS_Wildcats.Backend.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ISS_Wildcats.Backend.UnitTests
{
    public class SongRepoTests
    {
        [Fact]
        public void TestSongRepoAddGet()
        {
            // arrange
            var album = new SongRepo();

            string title = "Billie Jean";
            string songUrl = "http://example.com/song5.mp3";
            int id = 200;
            int len = 200;
            int albumId = 3;

            var song = new Song(title, songUrl, id, len, albumId);

            // act
            album.AddSong(song);

            // assert
            Assert.Equal(album.getSongByTitle(title).title, title);
            Assert.Equal(album.getSongByTitle(title).length, len);
            Assert.Equal(album.getSongByTitle(title).albumId, albumId);
        }

        [Fact]
        public void TestGetById()
        {
            // arrange
            var album = new SongRepo();

            string title = "Event Horizon";
            string songUrl = "http://example.com/song4.mp3";
            int id = 4;
            int len = 305;
            int albumId = 3;

            // act
            var songFromMethod = album.GetSongById(id);

            // assert
            Assert.Equal(title, songFromMethod.title);
            Assert.Equal(songUrl, songFromMethod.songUrl);
            Assert.Equal(id, songFromMethod.id);
            Assert.Equal(len, songFromMethod.length);
            Assert.Equal(albumId, songFromMethod.albumId);
        }

        [Fact]
        public void TestGetByUrl()
        {
            // arrange
            var album = new SongRepo();

            string title = "Event Horizon";
            string songUrl = "http://example.com/song4.mp3";
            int id = 4;
            int len = 305;
            int albumId = 3;

            // act
            var songFromMethod = album.GetSongByUrl(songUrl);

            // assert
            Assert.Equal(title, songFromMethod.title);
            Assert.Equal(songUrl, songFromMethod.songUrl);
            Assert.Equal(id, songFromMethod.id);
            Assert.Equal(len, songFromMethod.length);
            Assert.Equal(albumId, songFromMethod.albumId);
        }

        [Fact]
        public void TestSongRepoDelete()
        {
            // arrange
            var album = new SongRepo();

            string title = "Event Horizon";
            string songUrl = "http://example.com/song4.mp3";
            int id = 4;
            int len = 305;
            int albumId = 3;

            var song = new Song(title, songUrl, id, len, albumId);

            // act
            album.DeleteSong(song);

            // assert
            Assert.Null(album.GetSongById(4));
        }

        [Fact]
        public void TestGetLists()
        {
            // arrange
            var album = new SongRepo();

            int creatorId = 2;
            int albumId = 3;

            // act
            var songsByCreator = album.GetSongsByCreator(creatorId);
            var albumSongsById = album.GetSongsFromAlbum(albumId);

            // assert
            Assert.NotNull(songsByCreator);
            Assert.NotNull(albumSongsById);
        }
    }
}
