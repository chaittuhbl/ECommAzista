using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class BestSellingProducts
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Product Product { get; set; }
    }
}
