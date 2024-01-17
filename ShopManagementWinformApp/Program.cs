using Autofac;
using BLL.Contracts;
using CONNECTIONS.Contracts;
using StartUpDI;
using System.Configuration;

namespace ShopManagementWinformApp
{
    internal static class Program
    {
        public static IContainer? _cbInstance;
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
            _cbInstance = Config.Configuration.CB.Build();
            Config.Configuration.Container = _cbInstance;
            _unitOfWork = _cbInstance.Resolve<IUnitOfWork.Contracts.IUnitOfWork>();
            Config.Configuration.ProductID = (_unitOfWork.ProductBLL?.GetAll()?.Result?.Select(x => Convert.ToInt64(x.ProductID.Substring(1))).Max() + 1) ?? 1;
            //var product = instance.Resolve<ISQLConnection>().LoadData("SELECT * FROM Product WHERE ProductId = @Product;", new Dictionary<string, string>() { { "@Product", "P001" } });
            ApplicationConfiguration.Initialize();
            Application.Run(new AppMainForm());;
        }
    }
}