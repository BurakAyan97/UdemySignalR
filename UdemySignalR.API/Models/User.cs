﻿namespace UdemySignalR.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Nav props
        public virtual Team Team { get; set; }
    }
}
