using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ClientPostLogoutRedirectUris
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string PostLogoutRedirectUri { get; set; }

        public virtual Clients Client { get; set; }
    }
}
