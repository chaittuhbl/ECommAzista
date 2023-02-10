using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class AskPharmaConfiguration
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsPublished { get; set; }
    }
}
