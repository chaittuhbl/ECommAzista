using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class CustomerDeviceIdMapping
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceUniqueId { get; set; }
        public string Version { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceVersion { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
    }
}
