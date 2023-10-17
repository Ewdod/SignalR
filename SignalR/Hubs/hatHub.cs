using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class hatHub : Hub
    {
        public async Task MesajGonder(string kullanici, string mesaj)
        {
            await Clients.All.SendAsync("mesajal", kullanici, mesaj);
        }

        public async Task KonumGonder(string renk, int x, int y)
        {

            await Clients.All.SendAsync("KonumAlindi",Context.ConnectionId, renk, x, y);
        }
    }
}
