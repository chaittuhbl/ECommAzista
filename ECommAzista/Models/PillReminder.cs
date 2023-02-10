using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class PillReminder
    {
        public PillReminder()
        {
            PillReminderSlots = new HashSet<PillReminderSlots>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PillName { get; set; }
        public string PillType { get; set; }
        public string ShapeType { get; set; }
        public string ColorCode { get; set; }
        public string Dosage { get; set; }
        public string DoseTimes { get; set; }
        public string Image { get; set; }
        public string Alarm { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsCompleted { get; set; }
        public long LastUpdatedTimeTicks { get; set; }
        public bool IsModulerView { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsSelectAll { get; set; }
        public string RecurringValue { get; set; }
        public string Brand { get; set; }
        public string Generic { get; set; }

        public virtual ICollection<PillReminderSlots> PillReminderSlots { get; set; }
    }
}
