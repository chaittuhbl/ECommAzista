using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ClientCorsOrigins
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Origin { get; set; }

        public virtual Clients Client { get; set; }
    }
}
