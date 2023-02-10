using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ProductHealthIssueMapping
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int HealthIssueId { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        public virtual HealthIssue HealthIssue { get; set; }
        public virtual Product Product { get; set; }
    }
}
