using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class DiscountAppliedToCompositions
    {
        public int DiscountId { get; set; }
        public int CompositionId { get; set; }

        public virtual Composition Composition { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
