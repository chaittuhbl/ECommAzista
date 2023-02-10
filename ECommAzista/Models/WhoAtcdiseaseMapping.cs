using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class WhoAtcdiseaseMapping
    {
        public int Id { get; set; }
        public string Amg { get; set; }
        public string Amgdescription { get; set; }
        public string Tscode { get; set; }
        public string TscodeDescription { get; set; }
        public string Psg { get; set; }
        public string Psgdescription { get; set; }
        public string Csg { get; set; }
        public string Csgdescription { get; set; }
        public string ChemicalSubStance { get; set; }
        public string GenericMolecules { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
