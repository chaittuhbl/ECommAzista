using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class DiscountUsageHistory
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public int OrderId { get; set; }
        public string DiscountDetails { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int? DiscountId1 { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Discount DiscountId1Navigation { get; set; }
        public virtual Order Order { get; set; }
    }
}
