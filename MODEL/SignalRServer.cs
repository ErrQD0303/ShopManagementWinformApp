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
            add => _hubConnection!.On("ReceiveMessage", value);
            remove => _hubConnection!.Remove("ReceiveMessage");
        }
        public async Task Start()
        {
            await _hubConnection!.StartAsync();
        }

        public async Task Send(string user, string message)
        {
            await _hubConnection!.InvokeCoreAsync("SendMessage", args: new[] {user, message});
        }
    }
}
