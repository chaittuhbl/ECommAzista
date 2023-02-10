using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ProductCompositionMapping
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CompositionId { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Composition Composition { get; set; }
        public virtual Product Product { get; set; }
    }
}
