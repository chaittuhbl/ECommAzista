using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class StateProvince
    {
        public StateProvince()
        {
            Address = new HashSet<Address>();
            Plants = new HashSet<Plants>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Plants> Plants { get; set; }
    }
}
