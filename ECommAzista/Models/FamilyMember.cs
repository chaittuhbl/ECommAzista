using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class FamilyMember
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string RelationName { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
