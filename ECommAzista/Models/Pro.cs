using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Pro
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
    }
}
