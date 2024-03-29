using Autofac;
using BLL.Contracts;
using CONNECTIONS.Contracts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using MySqlX.XDevAPI;
using StartUpDI;
using System.Configuration;

namespace ShopManagementWinformApp
{
    internal static partial class Program
    {
        public static IContainer? CBInstance;
        public static IUnitOfWork.Contracts.IUnitOfWork? _unitOfWork;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Config.Configuration.CB.RegisterModule(new StartUpModule());
            CBInstance = Config.Configuration.CB.Build();
            Config.Configuration.Container = CBInstance;
            _unitOfWork = CBInstance.Resolve<IUnitOfWork.Contracts.IUnitOfWork>();
            Config.Configuration.ProductID = (_unitOfWork.ProductBLL?.GetAll()?.Result?.Select(x => Convert.ToInt64(x.ProductID.Substring(1))).Max() + 1) ?? 1;
            //var product = instance.Resolve<ISQLConnection>().LoadData("SELECT * FROM Product WHERE ProductId = @Product;", new Dictionary<string, string>() { { "@Product", "P001" } });
            CreateWebHostBuilder().Build().RunAsync();
            ApplicationConfiguration.Initialize();
            Application.Run(new AppMainForm());
        }

        private static IWebHostBuilder CreateWebHostBuilder() =>
            WebHost.CreateDefaultBuilder()
                .UseStartup<SU>();
    }
}