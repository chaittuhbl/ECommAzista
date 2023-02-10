using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class DiscountAppliedToPharmacies
    {
        public int DiscountId { get; set; }
        public int SsSlShopId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual SsSlShop SsSlShop { get; set; }
    }
}
