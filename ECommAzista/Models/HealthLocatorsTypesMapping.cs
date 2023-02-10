using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthLocatorsTypesMapping
    {
        public int Id { get; set; }
        public int HealthLocatorsId { get; set; }
        public int HealthLocatorsTypesId { get; set; }

        public virtual HealthLocators HealthLocators { get; set; }
        public virtual HealthLocatorsTypes HealthLocatorsTypes { get; set; }
    }
}
