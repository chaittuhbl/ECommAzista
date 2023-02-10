using System;

namespace ECommAzista.Models
{
    public partial class OtpValidation
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Otp { get; set; }
        public DateTime CreatedOn { get; set; }
        public string IpAddress { get; set; }
    }
}
