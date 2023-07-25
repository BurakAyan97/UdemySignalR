using System.Collections;
using System.Collections.Generic;

namespace UdemySignalR.API.Models
{
    public class Team
    {
        public Team()
        {
            //team.users.add şeklinde kullanmak istiyorsan ctorda nesne örneği oluşturman lazım.
            Users = new List<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        //Nav props
        public virtual ICollection<User> Users { get; set; }
    }
}
