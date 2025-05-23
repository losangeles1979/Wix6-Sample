namespace Wix6_Sample
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
            Form1 form = new Form1();

            // Startup position at center of screen
            form.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form); // Fix for CS1002
        }
    }
}