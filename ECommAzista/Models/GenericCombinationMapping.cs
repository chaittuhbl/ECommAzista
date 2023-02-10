using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class GenericCombinationMapping
    {
        public int Id { get; set; }
        public int CombinationMasterId { get; set; }
        public int GenericMasterId { get; set; }

        public virtual GenericMaster CombinationMaster { get; set; }
        public virtual CombinationMaster GenericMaster { get; set; }
    }
}
