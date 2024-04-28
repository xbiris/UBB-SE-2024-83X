using ISS_Wildcats.Backend.Models;

namespace ISS_Wildcats
{
    internal static class Program
    {
        static void Main()
        {
            Song song = new Song("titlu", "url", 0, 0, 0);
            Console.WriteLine(song.songUrl);
            ApplicationConfiguration.Initialize();
            Form1 FormInitial = new Form1();
            Application.Run(FormInitial);
        }
    }
}
