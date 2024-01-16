using Autofac;
using CONNECTIONS;
using BLL;
using DAL;
using IUnitOfWork;
using MODEL;

namespace StartUpDI
{
    public class StartUpModule : Module
    {
        protected override void Load(ContainerBuilder cb)
        {
            cb.AddConnectionStringDI()
                .AddBLDI()
                .AddDALDI()
                .AddUOWDI()
                .AddModelDI();
        }
    }
}
