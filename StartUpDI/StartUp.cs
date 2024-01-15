using Autofac;
using CONNECTIONS;
using BLL;

namespace StartUpDI
{
    public class StartUpModule : Module
    {
        protected override void Load(ContainerBuilder cb)
        {
            cb.AddConnectionStringDI();
            cb.AddDI();
        }
    }
}
