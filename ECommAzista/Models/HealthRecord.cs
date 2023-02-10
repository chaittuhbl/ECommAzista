using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthRecord
    {
        public HealthRecord()
        {
            HealthRecordPictureMapping = new HashSet<HealthRecordPictureMapping>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HealthRecordType { get; set; }
        public string HealthRecordDoctor { get; set; }
        public string HealthRecordPatient { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedOnUtc { get; set; }

        public virtual ICollection<HealthRecordPictureMapping> HealthRecordPictureMapping { get; set; }
    }
}
