using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public string ActivityType { get; set; }
        public int Rating1 { get; set; }
        public string Comment { get; set; }
        public bool IsPublished { get; set; }
        public int? ActivityCreatedBy { get; set; }
    }
}
