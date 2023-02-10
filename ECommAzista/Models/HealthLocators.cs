using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthLocators
    {
        public HealthLocators()
        {
            HealthLocatorsTypesMapping = new HashSet<HealthLocatorsTypesMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int PictureId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string StartTime { get; set; }
        public string CloseTime { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public virtual ICollection<HealthLocatorsTypesMapping> HealthLocatorsTypesMapping { get; set; }
    }
}
