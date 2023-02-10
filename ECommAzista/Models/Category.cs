using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryBannerImagesMapping = new HashSet<CategoryBannerImagesMapping>();
            DiscountAppliedToCategories = new HashSet<DiscountAppliedToCategories>();
            ProductCategoryMapping = new HashSet<ProductCategoryMapping>();
            TopCategories = new HashSet<TopCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryTemplateId { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public int ParentCategoryId { get; set; }
        public int PictureId { get; set; }
        public int PageSize { get; set; }
        public bool AllowCustomersToSelectPageSize { get; set; }
        public string PageSizeOptions { get; set; }
        public string PriceRanges { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool IncludeInTopMenu { get; set; }
        public bool SubjectToAcl { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string ImageUrl { get; set; }
        public string F1 { get; set; }

        public virtual ICollection<CategoryBannerImagesMapping> CategoryBannerImagesMapping { get; set; }
        public virtual ICollection<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; }
        public virtual ICollection<ProductCategoryMapping> ProductCategoryMapping { get; set; }
        public virtual ICollection<TopCategories> TopCategories { get; set; }
    }
}
