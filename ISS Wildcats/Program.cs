namespace ISS_Wildcats
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Test
            ApplicationConfiguration.Initialize();
            Form1 FormInitial = new Form1();
//            FormInitial.Resize += (sender, e) =>
//            {
                // Scale UserControl1 whenever the window is resized
//                FormInitial.profileMenu.Size = new Size(FormInitial.ClientRectangle.Width / 4, FormInitial.ClientRectangle.Height);
//            };

            // Create an instance of UserControl1


            // Set Dock property to Right

            // Handle the Resize event of Form1


            // Run FormInitial instead of creating a new instance of Form1
            Application.Run(FormInitial);
        }
    }
}
