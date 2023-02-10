using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class HealthIssue
    {
        public HealthIssue()
        {
            DiscountAppliedToHealthIssues = new HashSet<DiscountAppliedToHealthIssues>();
            ProductHealthIssueMapping = new HashSet<ProductHealthIssueMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HealthIssueTemplateId { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public int PictureId { get; set; }
        public int PageSize { get; set; }
        public bool AllowCustomersToSelectPageSize { get; set; }
        public string PageSizeOptions { get; set; }
        public string PriceRanges { get; set; }
        public bool SubjectToAcl { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string ImageUrl { get; set; }
        public string Synonyms { get; set; }

        public virtual ICollection<DiscountAppliedToHealthIssues> DiscountAppliedToHealthIssues { get; set; }
        public virtual ICollection<ProductHealthIssueMapping> ProductHealthIssueMapping { get; set; }
    }
}
