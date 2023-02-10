using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class IdentityClaims
    {
        public int Id { get; set; }
        public int IdentityResourceId { get; set; }
        public string Type { get; set; }

        public virtual IdentityResources IdentityResource { get; set; }
    }
}
