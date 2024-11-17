namespace NEW_GESTION_COMMANDE
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
            //Application.Run(new CLIENT());
            //Application.Run(new PRODUIT());
            //Application.Run(new COMMANDE());
            //Application.Run(new DetailCommande());
            Application.Run(new CONNEXION());
        }
    }
}