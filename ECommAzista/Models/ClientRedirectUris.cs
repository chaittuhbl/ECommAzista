using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ClientRedirectUris
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string RedirectUri { get; set; }

        public virtual Clients Client { get; set; }
    }
}
