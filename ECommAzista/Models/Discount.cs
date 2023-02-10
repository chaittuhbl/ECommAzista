using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Discount
    {
        public Discount()
        {
            DiscountAppliedToCategories = new HashSet<DiscountAppliedToCategories>();
            DiscountAppliedToCompositions = new HashSet<DiscountAppliedToCompositions>();
            DiscountAppliedToCustomers = new HashSet<DiscountAppliedToCustomers>();
            DiscountAppliedToHealthIssues = new HashSet<DiscountAppliedToHealthIssues>();
            DiscountAppliedToManufacturers = new HashSet<DiscountAppliedToManufacturers>();
            DiscountAppliedToPharmacies = new HashSet<DiscountAppliedToPharmacies>();
            DiscountAppliedToProducts = new HashSet<DiscountAppliedToProducts>();
            DiscountRequirement = new HashSet<DiscountRequirement>();
            DiscountUsageHistoryDiscount = new HashSet<DiscountUsageHistory>();
            DiscountUsageHistoryDiscountId1Navigation = new HashSet<DiscountUsageHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? MaximumDiscountAmount { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public bool RequiresCouponCode { get; set; }
        public string CouponCode { get; set; }
        public bool IsCumulative { get; set; }
        public int DiscountLimitationId { get; set; }
        public int LimitationTimes { get; set; }
        public int? MaximumDiscountedQuantity { get; set; }
        public bool AppliedToSubCategories { get; set; }
        public decimal? MinOrderTotal { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public int PictureId { get; set; }
        public string PictureUrl { get; set; }

        public virtual ICollection<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; }
        public virtual ICollection<DiscountAppliedToCompositions> DiscountAppliedToCompositions { get; set; }
        public virtual ICollection<DiscountAppliedToCustomers> DiscountAppliedToCustomers { get; set; }
        public virtual ICollection<DiscountAppliedToHealthIssues> DiscountAppliedToHealthIssues { get; set; }
        public virtual ICollection<DiscountAppliedToManufacturers> DiscountAppliedToManufacturers { get; set; }
        public virtual ICollection<DiscountAppliedToPharmacies> DiscountAppliedToPharmacies { get; set; }
        public virtual ICollection<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; }
        public virtual ICollection<DiscountRequirement> DiscountRequirement { get; set; }
        public virtual ICollection<DiscountUsageHistory> DiscountUsageHistoryDiscount { get; set; }
        public virtual ICollection<DiscountUsageHistory> DiscountUsageHistoryDiscountId1Navigation { get; set; }
    }
}
