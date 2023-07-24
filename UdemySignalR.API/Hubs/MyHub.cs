﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UdemySignalR.API.Hubs
{
    public class MyHub : Hub
    {
        private static int ClientCount { get; set; } = 0;
        public static List<string> Names { get; set; } = new List<string>();//API açık olduğu sürece clientlar belli olacak.Database kullanmadığımız için burda tutuyoruz eğitim için.

        //Clientların çağıracağı methodları tanımlıyoruz
        public async Task SendName(string name)
        {
            Names.Add(name);
            //Clientlardaki (string yazılan isimdeki method) çalışacak ve message değerini de aynı zamanda gönderecek.
            await Clients.All.SendAsync("ReceiveName", name);
        }

        public async Task GetNames()
        {
            await Clients.All.SendAsync("ReceiveNames", Names);
        }

        public override async Task OnConnectedAsync()
        {
            ClientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", ClientCount);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            ClientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", ClientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}