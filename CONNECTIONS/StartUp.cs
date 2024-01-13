using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CONNECTIONS.Contracts;

namespace CONNECTIONS
{
    public static class StartUp
    {
        public static ContainerBuilder AddConnectionStringDI(this ContainerBuilder cb)
        {
            cb.RegisterInstance(MySQLConnection.Instance).As<ISQLConnection>();
            return cb;
        }
    }
}
