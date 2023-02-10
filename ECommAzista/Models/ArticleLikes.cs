using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ArticleLikes
    {
        public int Id { get; set; }
        public int HealthArticleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual HealthArticle HealthArticle { get; set; }
    }
}
