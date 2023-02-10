using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ShippingChargesCategory
    {
        public int Id { get; set; }
        public string ChargeBy { get; set; }
        public string ActiveStatus { get; set; }
        public string Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}
