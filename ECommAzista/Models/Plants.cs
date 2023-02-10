using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Plants
    {
        public int Id { get; set; }
        public string PlantName { get; set; }
        public int StateId { get; set; }
        public string DeliveryFee { get; set; }
        public string Active { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Deleted { get; set; }
        public int? DisplayOrder { get; set; }
        public string PageSizeOptions { get; set; }
        public int? PageSize { get; set; }
        public bool? Published { get; set; }
        public bool? SubjectToAcl { get; set; }

        public virtual StateProvince State { get; set; }
    }
}
