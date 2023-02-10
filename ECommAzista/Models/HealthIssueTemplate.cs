using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthIssueTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewPath { get; set; }
        public int DisplayOrder { get; set; }
    }
}
