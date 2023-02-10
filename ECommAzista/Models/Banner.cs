using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Banner
    {
        public int Id { get; set; }
        public int BannerTypeId { get; set; }
        public int BannerPositionId { get; set; }
        public string ImageUrl { get; set; }
        public string RedirectUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int DisplayOrder { get; set; }
        public int PictureId { get; set; }
        public long LastUpdatedTimeTicks { get; set; }
        public int NavigationId { get; set; }
    }
}
