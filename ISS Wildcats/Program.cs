using ISS_Wildcats.Backend.Models;

namespace ISS_Wildcats
{
    internal static class Program
    {
        static void Main()
        {
            string connectionString = "Server=localhost;Port=3306;Database=spookify;Uid=root;Pwd='';";
            Song song = new Song(connectionString, 1);
            Console.WriteLine(song.Url);
        }
    }
}