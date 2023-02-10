using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ReferralCodeCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ReferralId { get; set; }
        public int DeviceTypeId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ReferralCode Referral { get; set; }
    }
}
