using System;

namespace ECommAzista.ViewModels
{
    public class HealthArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }
        public int BookmarksCount { get; set; }
        public long LastUpdatedTimeTicks { get; set; }
        public bool? IsActive { get; set; }
        public int PictureId { get; set; }
    }
}
