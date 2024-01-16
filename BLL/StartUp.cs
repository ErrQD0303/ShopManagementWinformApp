using Autofac;
using MODEL.Contracts;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Contracts;

namespace BLL
{
    public static class StartUp
    {
        public static ContainerBuilder AddBLDI(this ContainerBuilder cb)
        {
            cb.RegisterType<ProductBLL>().As<IProductBLL>();
            return cb;
        }
    }
}
