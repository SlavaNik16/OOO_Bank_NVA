using Microsoft.AspNetCore.SignalR;

namespace SingalRApplication.Hubs
{
    public class ChatHub : Hub
    {
        int i = 0;
        public async Task Send(string message, string username = "")
        {
            if(username == "")
            {
                username = "Аноним" + i++;
            }
            await this.Clients.All.SendAsync("Send", message, username);
        }
    }
}
