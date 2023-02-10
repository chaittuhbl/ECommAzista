using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class ArticleComments
    {
        public int Id { get; set; }
        public int HealthArticleId { get; set; }
        public int CustomerId { get; set; }
        public string CommentText { get; set; }
        public DateTime? CreatedOnUtc { get; set; }
        public DateTime? UpdatedOnUtc { get; set; }

        public virtual HealthArticle HealthArticle { get; set; }
    }
}
