using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using UdemySignalR.API.Models;

namespace UdemySignalR.API.Hubs
{
    public class ProductHub : Hub<IProductHub>
    {
        public async Task SendProduct(Product p)
        {
            await Clients.All.ReceiveProduct(p);//sendasync diyip string olarak metod ismi yazmak yerine direkt böyle oluşturup kullanabiliyoruz.
        }
    }
}
