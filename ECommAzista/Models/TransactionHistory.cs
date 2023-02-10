using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class TransactionHistory
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? OrderId { get; set; }
        public string TransactionId { get; set; }
        public string ResultMessage { get; set; }
        public string ResponseCode { get; set; }
        public DateTime? TransactionTimeTimeStamp { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
