using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class TopCategories
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public string PictureUrl { get; set; }
        public int PictureId { get; set; }

        public virtual Category Category { get; set; }
    }
}
