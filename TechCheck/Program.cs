namespace TechCheck
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Önce Login formunu (Form1) bir deðiþken olarak oluþturuyoruz
            Form1 loginForm = new Form1();

            // 2. Login formunu çalýþtýrýyoruz
            Application.Run(loginForm);
        }
    }
}