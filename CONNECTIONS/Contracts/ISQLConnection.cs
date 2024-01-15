﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONNECTIONS.Contracts
{
    public interface ISQLConnection
    {
        void Execute(string query, Dictionary<string, string>? parameters = null);
        DataSet LoadData(string query, Dictionary<string, string>? parameters = null);
        DataSet ExecuteSP(string spName, Dictionary<string, string>? parameters = null);
    }
}
