using Autofac;
using CONNECTIONS;

namespace StartUpDI
{
    public class StartUpModule : Module
    {

        protected override void Load(ContainerBuilder cb)
        {
            cb.AddConnectionStringDI();
        }
    }
}
