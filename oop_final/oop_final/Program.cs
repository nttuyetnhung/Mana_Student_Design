namespace oop_final
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}