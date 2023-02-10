using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ClientSecrets
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public virtual Clients Client { get; set; }
    }
}
