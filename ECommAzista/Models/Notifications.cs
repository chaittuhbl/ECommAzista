using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsActive { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
