using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using MODEL.Contracts;

namespace MODEL
{
    public static class StartUp
    {
        public static ContainerBuilder AddModelDI(this ContainerBuilder cb)
        {
            cb.RegisterType<Product>().As<IProduct>();
            cb.RegisterType<SignalRServer>().As<ISignalRServer>();
            return cb;
        }
    }
}
