using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ForwardOrderToPharmacy
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BasePharmacyId { get; set; }
        public int DestinationPharmacyId { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
