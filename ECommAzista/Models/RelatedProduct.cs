using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class RelatedProduct
    {
        public int Id { get; set; }
        public int ProductId1 { get; set; }
        public int ProductId2 { get; set; }
        public int DisplayOrder { get; set; }
    }
}
