using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class OrderStatusLogs
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ChangedBy { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Order Order { get; set; }
    }
}
