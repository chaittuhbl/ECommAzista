using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ApiScopes
    {
        public ApiScopes()
        {
            ApiScopeClaims = new HashSet<ApiScopeClaims>();
        }

        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Emphasize { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }

        public virtual ApiResources ApiResource { get; set; }
        public virtual ICollection<ApiScopeClaims> ApiScopeClaims { get; set; }
    }
}
