using MODEL.Contracts;
using Microsoft.AspNetCore.SignalR.Client;

namespace MODEL
{
    internal class SignalRServer : ISignalRServer
    {
        private readonly HubConnection? _hubConnection;
        public SignalRServer()
        {
            string url = @"http://localhost:5000/appHub";
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(url)
                .Build();
        }
        public event Action<string, string> AddMessage
        {
            add => _hubConnection!.On("SendMessage", value);
            remove => _hubConnection!.Remove("SendMessage");
        }
        public async Task Start()
        {
            await _hubConnection!.StartAsync();
        }

        public async Task Send(string user, string message)
        {
            await _hubConnection!.InvokeCoreAsync("OnDataChanged", args: new[] {user, message});
        }
    }
}
