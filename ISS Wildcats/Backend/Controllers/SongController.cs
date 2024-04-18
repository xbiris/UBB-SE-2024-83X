using ISS_Wildcats.Backend.Models;
using Mysqlx.Expect;

namespace ISS_Wildcats.Backend.Controllers;

using System;
using System.Media;

public class SongController
{
    private Song song;
    private TimeSpan currentPosition;
    private SoundPlayer player;

    public SongController(string connectionString, int songID)
    {
        song = new Song(connectionString, songID);
        currentPosition = TimeSpan.Zero;
        player = new SoundPlayer();
    }

    public void Play()
    {
        try
        {
            player = new SoundPlayer(song.Url);
            player.Play();
        }
        catch (Exception e)
        {
            Console.WriteLine("pfhahhaaahahahahhhha");
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
