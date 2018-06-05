using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR_React.Server
{
    public class ChatHub : Hub
    {
        public void SendToAll(string name, string message)
        {
			Clients.All.SendAsync("sendToAll", name, message);
        }

		public override Task OnConnectedAsync()
		{
			return base.OnConnectedAsync();
		}
	}
}