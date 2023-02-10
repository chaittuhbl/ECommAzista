using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class PillReminderSlots
    {
        public int Id { get; set; }
        public int PillReminderId { get; set; }
        public DateTime? Day { get; set; }
        public string Time { get; set; }
        public bool IsSkipped { get; set; }
        public bool IsTaken { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public virtual PillReminder PillReminder { get; set; }
    }
}
