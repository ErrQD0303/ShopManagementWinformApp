using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONNECTIONS.Contracts
{
    public interface ISQLConnection
    {
        Task Execute(string query, object[]? parameters = null);
        DataSet LoadData(string query, object[]? parameters = null);
        DataSet ExecuteSP(string spName, object[]? parameters = null);
    }
}
