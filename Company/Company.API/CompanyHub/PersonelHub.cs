using Microsoft.AspNetCore.SignalR;

namespace Company.API.CompanyHub
{
    public class PersonelHub : Hub
    {
        public async Task PersonelUpdated()
        {
            await Clients.All.SendAsync("PersonelList");
        }
    }
}
