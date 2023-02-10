using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartDateString { get; set; }
        public string EndDateString { get; set; }
        public int PictureId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
