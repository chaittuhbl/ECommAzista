using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class PharmacyProductMapping
    {
        public int Id { get; set; }
        public int PharmacyId { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual SsSlShop Pharmacy { get; set; }
        public virtual Product Product { get; set; }
    }
}
