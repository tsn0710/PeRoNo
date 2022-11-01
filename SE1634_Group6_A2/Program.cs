using System.Xml.Serialization;

using assignment2prn.GUI;
namespace assignment2prn
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
            MainGUI a = new MainGUI();
            a.Width = 1600;
            a.Height = 1080;
            Application.Run(a);
        }
    }
}