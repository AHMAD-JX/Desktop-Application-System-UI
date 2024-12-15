using System;
using System.Collections.Generic;

namespace Home_GYM.models
{
    public partial class UserGym
    {
        public UserGym()
        {
            UserClients = new HashSet<UserClient>();
        }

        public int Id { get; set; }
        public string NameUser { get; set; }
        public string TypeUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<UserClient> UserClients { get; set; }
    }
}
