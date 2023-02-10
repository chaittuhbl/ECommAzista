using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class VersionControl
    {
        public int Id { get; set; }
        public string VersionId { get; set; }
        public string ProductType { get; set; }
    }
}
