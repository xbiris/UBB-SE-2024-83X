using ISS_Wildcats.Backend.Models;

namespace ISS_Wildcats.Backend.Controllers;

using ISS_Wildcats.Backend.Repos;
using System;
using System.Windows.Media;

public class SongController
{
    private int songId;
    private SongRepo songRepo;  
    private TimeSpan currentPosition;
    private MediaPlayer player;

    public SongController(int songID)
    {
        this.songId = songID;
        currentPosition = TimeSpan.Zero;
        player = new MediaPlayer();
        songRepo = new SongRepo();
    }

    public void Play()
    {
        try
        {
            player.Open(new Uri(songRepo.GetSongById(songId).songUrl));
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
