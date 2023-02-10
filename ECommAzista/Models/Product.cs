using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Product
    {
        public Product()
        {
            BackInStockSubscription = new HashSet<BackInStockSubscription>();
            BestSellingProducts = new HashSet<BestSellingProducts>();
            DiscountAppliedToProducts = new HashSet<DiscountAppliedToProducts>();
            OrderItem = new HashSet<OrderItem>();
            PharmacyProductMapping = new HashSet<PharmacyProductMapping>();
            PlantProductMapping = new HashSet<PlantProductMapping>();
            ProductAttributeCombination = new HashSet<ProductAttributeCombination>();
            ProductCategoryMapping = new HashSet<ProductCategoryMapping>();
            ProductCompositionMapping = new HashSet<ProductCompositionMapping>();
            ProductHealthIssueMapping = new HashSet<ProductHealthIssueMapping>();
            ProductManufacturerMapping = new HashSet<ProductManufacturerMapping>();
            ProductPictureMapping = new HashSet<ProductPictureMapping>();
            ProductProductAttributeMapping = new HashSet<ProductProductAttributeMapping>();
            ProductProductTagMapping = new HashSet<ProductProductTagMapping>();
            ProductReview = new HashSet<ProductReview>();
            ProductSpecificationAttributeMapping = new HashSet<ProductSpecificationAttributeMapping>();
            ProductWarehouseInventory = new HashSet<ProductWarehouseInventory>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            StockQuantityHistory = new HashSet<StockQuantityHistory>();
            TierPrice = new HashSet<TierPrice>();
        }

        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public int ParentGroupedProductId { get; set; }
        public bool VisibleIndividually { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string AdminComment { get; set; }
        public int ProductTemplateId { get; set; }
        public int VendorId { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public bool AllowCustomerReviews { get; set; }
        public int ApprovedRatingSum { get; set; }
        public int NotApprovedRatingSum { get; set; }
        public int ApprovedTotalReviews { get; set; }
        public int NotApprovedTotalReviews { get; set; }
        public bool SubjectToAcl { get; set; }
        public bool LimitedToStores { get; set; }
        public string Sku { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string Gtin { get; set; }
        public bool IsGiftCard { get; set; }
        public int GiftCardTypeId { get; set; }
        public decimal? OverriddenGiftCardAmount { get; set; }
        public bool RequireOtherProducts { get; set; }
        public string RequiredProductIds { get; set; }
        public bool AutomaticallyAddRequiredProducts { get; set; }
        public bool IsDownload { get; set; }
        public int DownloadId { get; set; }
        public bool UnlimitedDownloads { get; set; }
        public int MaxNumberOfDownloads { get; set; }
        public int? DownloadExpirationDays { get; set; }
        public int DownloadActivationTypeId { get; set; }
        public bool HasSampleDownload { get; set; }
        public int SampleDownloadId { get; set; }
        public bool HasUserAgreement { get; set; }
        public string UserAgreementText { get; set; }
        public bool IsRecurring { get; set; }
        public int RecurringCycleLength { get; set; }
        public int RecurringCyclePeriodId { get; set; }
        public int RecurringTotalCycles { get; set; }
        public bool IsRental { get; set; }
        public int RentalPriceLength { get; set; }
        public int RentalPricePeriodId { get; set; }
        public bool IsShipEnabled { get; set; }
        public bool IsFreeShipping { get; set; }
        public bool ShipSeparately { get; set; }
        public decimal AdditionalShippingCharge { get; set; }
        public int DeliveryDateId { get; set; }
        public bool IsTaxExempt { get; set; }
        public int TaxCategoryId { get; set; }
        public bool IsTelecommunicationsOrBroadcastingOrElectronicServices { get; set; }
        public int ManageInventoryMethodId { get; set; }
        public int ProductAvailabilityRangeId { get; set; }
        public bool UseMultipleWarehouses { get; set; }
        public int WarehouseId { get; set; }
        public int StockQuantity { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public bool DisplayStockQuantity { get; set; }
        public int MinStockQuantity { get; set; }
        public int LowStockActivityId { get; set; }
        public int NotifyAdminForQuantityBelow { get; set; }
        public int BackorderModeId { get; set; }
        public bool AllowBackInStockSubscriptions { get; set; }
        public int OrderMinimumQuantity { get; set; }
        public int OrderMaximumQuantity { get; set; }
        public string AllowedQuantities { get; set; }
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }
        public bool NotReturnable { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool DisableWishlistButton { get; set; }
        public bool AvailableForPreOrder { get; set; }
        public DateTime? PreOrderAvailabilityStartDateTimeUtc { get; set; }
        public bool CallForPrice { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProductCost { get; set; }
        public bool CustomerEntersPrice { get; set; }
        public decimal MinimumCustomerEnteredPrice { get; set; }
        public decimal MaximumCustomerEnteredPrice { get; set; }
        public bool BasepriceEnabled { get; set; }
        public decimal BasepriceAmount { get; set; }
        public int BasepriceUnitId { get; set; }
        public decimal BasepriceBaseAmount { get; set; }
        public int BasepriceBaseUnitId { get; set; }
        public bool MarkAsNew { get; set; }
        public DateTime? MarkAsNewStartDateTimeUtc { get; set; }
        public DateTime? MarkAsNewEndDateTimeUtc { get; set; }
        public bool HasTierPrices { get; set; }
        public bool HasDiscountsApplied { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public DateTime? AvailableStartDateTimeUtc { get; set; }
        public DateTime? AvailableEndDateTimeUtc { get; set; }
        public int DisplayOrder { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
        public string ColorCode { get; set; }
        public string GenericCode { get; set; }
        public string CombinationCode { get; set; }
        public string EmedBrandId { get; set; }
        public string Strength { get; set; }
        public string Formulation { get; set; }
        public string PackageDescription { get; set; }
        public int? PackageInNumbers { get; set; }
        public decimal? PricePerUnit { get; set; }
        public string TherapeuticName { get; set; }
        public string GenericName { get; set; }
        public string AdultDosage { get; set; }
        public string ChildrenDosage { get; set; }
        public string Indication { get; set; }
        public string ContraIndication { get; set; }
        public string SideEffectsOrAdverseEffects { get; set; }
        public string PrecautionOrWarning { get; set; }
        public string DrugInteractions { get; set; }
        public string RecomandAdultDosage { get; set; }
        public string RecomandChildrenDosage { get; set; }
        public string PregnancyAlert { get; set; }
        public string LactationAlert { get; set; }
        public string DrivingAlert { get; set; }
        public string LiverAlert { get; set; }
        public string KidneyAlert { get; set; }
        public string SymptomsAndOverdoseTreatment { get; set; }
        public string StorageCondition { get; set; }
        public string AvailabiltyPackage { get; set; }
        public string Cautions { get; set; }
        public bool IsPriceIncludingTax { get; set; }
        public int TaxId { get; set; }
        public string F1 { get; set; }

        public virtual ICollection<BackInStockSubscription> BackInStockSubscription { get; set; }
        public virtual ICollection<BestSellingProducts> BestSellingProducts { get; set; }
        public virtual ICollection<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        public virtual ICollection<PharmacyProductMapping> PharmacyProductMapping { get; set; }
        public virtual ICollection<PlantProductMapping> PlantProductMapping { get; set; }
        public virtual ICollection<ProductAttributeCombination> ProductAttributeCombination { get; set; }
        public virtual ICollection<ProductCategoryMapping> ProductCategoryMapping { get; set; }
        public virtual ICollection<ProductCompositionMapping> ProductCompositionMapping { get; set; }
        public virtual ICollection<ProductHealthIssueMapping> ProductHealthIssueMapping { get; set; }
        public virtual ICollection<ProductManufacturerMapping> ProductManufacturerMapping { get; set; }
        public virtual ICollection<ProductPictureMapping> ProductPictureMapping { get; set; }
        public virtual ICollection<ProductProductAttributeMapping> ProductProductAttributeMapping { get; set; }
        public virtual ICollection<ProductProductTagMapping> ProductProductTagMapping { get; set; }
        public virtual ICollection<ProductReview> ProductReview { get; set; }
        public virtual ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMapping { get; set; }
        public virtual ICollection<ProductWarehouseInventory> ProductWarehouseInventory { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual ICollection<StockQuantityHistory> StockQuantityHistory { get; set; }
        public virtual ICollection<TierPrice> TierPrice { get; set; }
    }
}
