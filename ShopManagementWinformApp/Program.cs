using Autofac;
using CONNECTIONS.Contracts;
using StartUpDI;

namespace ShopManagementWinformApp
{
    internal static class Program
    {
        private static ContainerBuilder _cb;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            _cb = new ContainerBuilder();
            _cb.RegisterModule(new StartUpModule());
            var instance = _cb.Build();
            //var product = instance.Resolve<ISQLConnection>().LoadData("SELECT * FROM Product WHERE ProductId = @Product;", new Dictionary<string, string>() { { "@Product", "P001" } });
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());;
        }
    }
}