using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthRecordPictureMapping
    {
        public int Id { get; set; }
        public int HealthRecordId { get; set; }
        public int PictureId { get; set; }
        public int DisplayOrder { get; set; }
        public string PictureUrl { get; set; }

        public virtual HealthRecord HealthRecord { get; set; }
    }
}
