using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatSample.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string name, int[] values )
        {
            // Call the broadcastMessage method to update clients.
            await Clients.All.SendAsync("ReceiveBatch", name, values);
        }
    }
}