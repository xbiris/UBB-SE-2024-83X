using ISS_Wildcats.Backend.Models;

namespace ISS_Wildcats
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 FormInitial = new Form1();
            Application.Run(FormInitial);
        }
    }
}
