using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class DiscountAppliedToCustomers
    {
        public int DiscountId { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
