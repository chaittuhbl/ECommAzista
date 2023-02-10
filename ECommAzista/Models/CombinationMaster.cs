using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class CombinationMaster
    {
        public CombinationMaster()
        {
            GenericCombinationMapping = new HashSet<GenericCombinationMapping>();
        }

        public int Id { get; set; }
        public string CombinationId { get; set; }
        public string CombiGenericName { get; set; }
        public string Group { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GenericCombinationMapping> GenericCombinationMapping { get; set; }
    }
}
