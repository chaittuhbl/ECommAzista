using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ClientGrantTypes
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string GrantType { get; set; }

        public virtual Clients Client { get; set; }
    }
}
