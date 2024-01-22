using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Contracts
{
    public interface ISignalRServer
    {
        event Action<string, string> AddMessage;
        Task Start();
        Task Send(string user, string message);
    }
}
