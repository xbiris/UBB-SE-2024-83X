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
            ApplicationConfiguration.Initialize();
            Form1 FormInitial = new Form1();

            // Create an instance of UserControl1
            UserControl1 profileMenu = new UserControl1();

            // Set Dock property to Right
            profileMenu.Dock = DockStyle.Right;

            // Add UserControl1 to Form1 controls collection
            FormInitial.Controls.Add(profileMenu);

            // Handle the Resize event of Form1
            FormInitial.Resize += (sender, e) =>
            {
                // Scale UserControl1 whenever the window is resized
                profileMenu.Size = new Size(FormInitial.ClientRectangle.Width / 4, FormInitial.ClientRectangle.Height);
            };

            // Run FormInitial instead of creating a new instance of Form1
            Application.Run(FormInitial);
        }
    }
}
