using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Picture
    {
        public Picture()
        {
            CategoryBannerImagesMapping = new HashSet<CategoryBannerImagesMapping>();
            PictureBinary = new HashSet<PictureBinary>();
            ProductPictureMapping = new HashSet<ProductPictureMapping>();
        }

        public int Id { get; set; }
        public string MimeType { get; set; }
        public string SeoFilename { get; set; }
        public string AltAttribute { get; set; }
        public string TitleAttribute { get; set; }
        public bool IsNew { get; set; }

        public virtual ICollection<CategoryBannerImagesMapping> CategoryBannerImagesMapping { get; set; }
        public virtual ICollection<PictureBinary> PictureBinary { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMapping { get; set; }
    }
}
