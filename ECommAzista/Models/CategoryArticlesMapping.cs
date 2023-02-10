using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class CategoryArticlesMapping
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int HealthArticleId { get; set; }

        public virtual HealthArticle HealthArticle { get; set; }
    }
}
