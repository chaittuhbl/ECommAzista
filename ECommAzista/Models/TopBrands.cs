using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class TopBrands
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public int DisplayOrder { get; set; }
        public string PictureUrl { get; set; }
        public int PictureId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
    }
}
