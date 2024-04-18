using ISS_Wildcats.Backend.Models;
using Mysqlx.Expect;

namespace ISS_Wildcats.Backend.Controllers;

using System;
using System.Windows.Media;

public class SongController
{
    private Song song;
    private TimeSpan currentPosition;
    private MediaPlayer player;

    public SongController(string connectionString, int songID)
    {
        song = new Song(connectionString, songID);
        currentPosition = TimeSpan.Zero;
        player = new MediaPlayer();
    }

    public void Play()
    {
        try
        {
            player.Open(new Uri(song.Url));
            player.Play();
        }
        catch (Exception e)
        {
            Console.WriteLine("Unable to play song.");
        }
    }

    public void Pause()
    {
        if (player.CanPause)
        {
            player.Pause();
        }
    }

    public void Seek(int seconds)
    {
        TimeSpan newPosition = new TimeSpan(0, 0, seconds);
        player.Position = newPosition;
    }
}
