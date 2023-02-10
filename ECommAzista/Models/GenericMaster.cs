using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class GenericMaster
    {
        public GenericMaster()
        {
            GenericCombinationMapping = new HashSet<GenericCombinationMapping>();
        }

        public int Id { get; set; }
        public string GenericCode { get; set; }
        public string GenericName { get; set; }
        public string GenericSynonyms { get; set; }
        public string Group { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<GenericCombinationMapping> GenericCombinationMapping { get; set; }
    }
}
