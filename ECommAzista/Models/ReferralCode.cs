using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ReferralCode
    {
        public ReferralCode()
        {
            ReferralCodeCustomer = new HashSet<ReferralCodeCustomer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Verified { get; set; }
        public int AndroidSignUpCount { get; set; }
        public int AndroidSignInCount { get; set; }
        public int IossignUpCount { get; set; }
        public int IossignInCount { get; set; }
        public string Tags { get; set; }
        public string Referralcode1 { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ICollection<ReferralCodeCustomer> ReferralCodeCustomer { get; set; }
    }
}
