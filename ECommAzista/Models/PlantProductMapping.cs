using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class PlantProductMapping
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public int ProductId { get; set; }
        public string Active { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsFeaturedProduct { get; set; }
        public bool? Deleted { get; set; }

        public virtual Product Product { get; set; }
    }
}
