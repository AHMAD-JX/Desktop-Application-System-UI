using System;
using System.Collections.Generic;

namespace Home_GYM.models
{
    public partial class UserClient
    {
        public int Id { get; set; }
        public int? Iduser { get; set; }
        public DateTime? DateOfregister { get; set; }

        public virtual UserGym IduserNavigation { get; set; }
    }
}
