using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ApiClaims
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Type { get; set; }

        public virtual ApiResources ApiResource { get; set; }
    }
}
