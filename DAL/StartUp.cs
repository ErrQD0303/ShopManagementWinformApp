using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DAL.Contracts;

namespace DAL
{
    public static class StartUp
    {
        public static ContainerBuilder AddDALDI(this ContainerBuilder cb)
        {
            cb.RegisterType<ProductDAL>().As<IProductDAL>();
            return cb;
        }
    }
}
