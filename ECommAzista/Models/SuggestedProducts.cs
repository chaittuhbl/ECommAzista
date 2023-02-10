using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class SuggestedProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int StatusId { get; set; }
        public int PharmacyId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public virtual SsSlShop Pharmacy { get; set; }
    }
}
