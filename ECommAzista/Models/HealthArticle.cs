using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommAzista.Models
{
    public partial class HealthArticle
    {
        public HealthArticle()
        {
            ArticleComments = new HashSet<ArticleComments>();
            ArticleLikes = new HashSet<ArticleLikes>();
            CategoryArticlesMapping = new HashSet<CategoryArticlesMapping>();
            UserArticlesMapping = new HashSet<UserArticlesMapping>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile FileUri { get; set; }

        public string Image { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }
        public int BookmarksCount { get; set; }
        public long LastUpdatedTimeTicks { get; set; }
        public bool? IsActive { get; set; }
        public int PictureId { get; set; }

        public virtual ICollection<ArticleComments> ArticleComments { get; set; }
        public virtual ICollection<ArticleLikes> ArticleLikes { get; set; }
        public virtual ICollection<CategoryArticlesMapping> CategoryArticlesMapping { get; set; }
        public virtual ICollection<UserArticlesMapping> UserArticlesMapping { get; set; }
    }
}
