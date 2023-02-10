using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthLocatorsTypes
    {
        public HealthLocatorsTypes()
        {
            HealthLocatorsTypesMapping = new HashSet<HealthLocatorsTypesMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IconImage { get; set; }
        public string PictureId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ICollection<HealthLocatorsTypesMapping> HealthLocatorsTypesMapping { get; set; }
    }
}
