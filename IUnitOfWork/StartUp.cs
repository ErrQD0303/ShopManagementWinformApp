using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUnitOfWork
{
    public static class StartUp
    {
        public static ContainerBuilder AddUOWDI(this ContainerBuilder cb)
        {
            cb.RegisterType<UnitOfWork>().As<IUnitOfWork.Contracts.IUnitOfWork>();
            return cb;
        }
    }
}
