using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ApiScopeClaims
    {
        public int Id { get; set; }
        public int ApiScopeId { get; set; }
        public string Type { get; set; }

        public virtual ApiScopes ApiScope { get; set; }
    }
}
