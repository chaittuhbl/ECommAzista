using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class DiscountAppliedToHealthIssues
    {
        public int DiscountId { get; set; }
        public int HealthIssueId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual HealthIssue HealthIssue { get; set; }
    }
}
