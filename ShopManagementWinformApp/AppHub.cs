using Microsoft.AspNetCore.SignalR;

namespace ShopManagementWinformApp
{
    public class AppHub : Hub
    {
        public async Task OnDataChanged(string user, string message)
        {
            await Clients.All.SendAsync("SendMessage", user, message);
        }
    }
}