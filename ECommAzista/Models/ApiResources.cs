using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ApiResources
    {
        public ApiResources()
        {
            ApiClaims = new HashSet<ApiClaims>();
            ApiScopes = new HashSet<ApiScopes>();
            ApiSecrets = new HashSet<ApiSecrets>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApiClaims> ApiClaims { get; set; }
        public virtual ICollection<ApiScopes> ApiScopes { get; set; }
        public virtual ICollection<ApiSecrets> ApiSecrets { get; set; }
    }
}
