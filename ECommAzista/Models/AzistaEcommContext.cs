using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ECommAzista.Models
{
    public partial class AzistaEcommContext : DbContext
    {
        public AzistaEcommContext()
        {
        }

        public AzistaEcommContext(DbContextOptions<AzistaEcommContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AclRecord> AclRecord { get; set; }
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogType { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttribute { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValue { get; set; }
        public virtual DbSet<Affiliate> Affiliate { get; set; }
        public virtual DbSet<ApiClaims> ApiClaims { get; set; }
        public virtual DbSet<ApiResources> ApiResources { get; set; }
        public virtual DbSet<ApiScopeClaims> ApiScopeClaims { get; set; }
        public virtual DbSet<ApiScopes> ApiScopes { get; set; }
        public virtual DbSet<ApiSecrets> ApiSecrets { get; set; }
        public virtual DbSet<ArticleComments> ArticleComments { get; set; }
        public virtual DbSet<ArticleLikes> ArticleLikes { get; set; }
        public virtual DbSet<AskPharmaConfiguration> AskPharmaConfiguration { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscription { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<Batch1> Batch1 { get; set; }
        public virtual DbSet<Batch1Complete1137Done> Batch1Complete1137Done { get; set; }
        public virtual DbSet<Batch2> Batch2 { get; set; }
        public virtual DbSet<Batch2Complete138238Done> Batch2Complete138238Done { get; set; }
        public virtual DbSet<Batch2XlnmFilterDatabase> Batch2XlnmFilterDatabase { get; set; }
        public virtual DbSet<Batch3> Batch3 { get; set; }
        public virtual DbSet<Batch3239383Done> Batch3239383Done { get; set; }
        public virtual DbSet<Batch3XlnmFilterDatabase> Batch3XlnmFilterDatabase { get; set; }
        public virtual DbSet<Batch4> Batch4 { get; set; }
        public virtual DbSet<Batch4Branded384554Done> Batch4Branded384554Done { get; set; }
        public virtual DbSet<Batch4XlnmFilterDatabase> Batch4XlnmFilterDatabase { get; set; }
        public virtual DbSet<Batch4Z3e37a1edCb8d481e92dc65adcadbe026WvuFilterData> Batch4Z3e37a1edCb8d481e92dc65adcadbe026WvuFilterData { get; set; }
        public virtual DbSet<Batch5> Batch5 { get; set; }
        public virtual DbSet<Batch5Mixed555868Done> Batch5Mixed555868Done { get; set; }
        public virtual DbSet<Batch5XlnmFilterDatabase> Batch5XlnmFilterDatabase { get; set; }
        public virtual DbSet<Batch5Z3e37a1edCb8d481e92dc65adcadbe026WvuFilterData> Batch5Z3e37a1edCb8d481e92dc65adcadbe026WvuFilterData { get; set; }
        public virtual DbSet<Batch6> Batch6 { get; set; }
        public virtual DbSet<Batch6PersonalCare8691000> Batch6PersonalCare8691000 { get; set; }
        public virtual DbSet<Batch6XlnmFilterDatabase> Batch6XlnmFilterDatabase { get; set; }
        public virtual DbSet<BestSellingProducts> BestSellingProducts { get; set; }
        public virtual DbSet<BlogComment> BlogComment { get; set; }
        public virtual DbSet<BlogPost> BlogPost { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Book2> Book2 { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<CategoriesReference> CategoriesReference { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryArticlesMapping> CategoryArticlesMapping { get; set; }
        public virtual DbSet<CategoryBannerImagesMapping> CategoryBannerImagesMapping { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplate { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttribute { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValue { get; set; }
        public virtual DbSet<ClientClaims> ClientClaims { get; set; }
        public virtual DbSet<ClientCorsOrigins> ClientCorsOrigins { get; set; }
        public virtual DbSet<ClientGrantTypes> ClientGrantTypes { get; set; }
        public virtual DbSet<ClientIdPrestrictions> ClientIdPrestrictions { get; set; }
        public virtual DbSet<ClientPostLogoutRedirectUris> ClientPostLogoutRedirectUris { get; set; }
        public virtual DbSet<ClientProperties> ClientProperties { get; set; }
        public virtual DbSet<ClientRedirectUris> ClientRedirectUris { get; set; }
        public virtual DbSet<ClientScopes> ClientScopes { get; set; }
        public virtual DbSet<ClientSecrets> ClientSecrets { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<CombinationMaster> CombinationMaster { get; set; }
        public virtual DbSet<Composition> Composition { get; set; }
        public virtual DbSet<CompositionTemplate> CompositionTemplate { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProduct { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttribute { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValue { get; set; }
        public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMapping { get; set; }
        public virtual DbSet<CustomerDeviceIdMapping> CustomerDeviceIdMapping { get; set; }
        public virtual DbSet<CustomerPassword> CustomerPassword { get; set; }
        public virtual DbSet<CustomerRole> CustomerRole { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDate { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<DiscountAppliedToCategories> DiscountAppliedToCategories { get; set; }
        public virtual DbSet<DiscountAppliedToCompositions> DiscountAppliedToCompositions { get; set; }
        public virtual DbSet<DiscountAppliedToCustomers> DiscountAppliedToCustomers { get; set; }
        public virtual DbSet<DiscountAppliedToHealthIssues> DiscountAppliedToHealthIssues { get; set; }
        public virtual DbSet<DiscountAppliedToManufacturers> DiscountAppliedToManufacturers { get; set; }
        public virtual DbSet<DiscountAppliedToPharmacies> DiscountAppliedToPharmacies { get; set; }
        public virtual DbSet<DiscountAppliedToProducts> DiscountAppliedToProducts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirement { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistory { get; set; }
        public virtual DbSet<Download> Download { get; set; }
        public virtual DbSet<EmailAccount> EmailAccount { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        public virtual DbSet<FamilyMember> FamilyMember { get; set; }
        public virtual DbSet<ForumsForum> ForumsForum { get; set; }
        public virtual DbSet<ForumsGroup> ForumsGroup { get; set; }
        public virtual DbSet<ForumsPost> ForumsPost { get; set; }
        public virtual DbSet<ForumsPostVote> ForumsPostVote { get; set; }
        public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessage { get; set; }
        public virtual DbSet<ForumsSubscription> ForumsSubscription { get; set; }
        public virtual DbSet<ForumsTopic> ForumsTopic { get; set; }
        public virtual DbSet<ForwardOrderToPharmacy> ForwardOrderToPharmacy { get; set; }
        public virtual DbSet<GdprConsent> GdprConsent { get; set; }
        public virtual DbSet<GdprLog> GdprLog { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttribute { get; set; }
        public virtual DbSet<GenericCombinationMapping> GenericCombinationMapping { get; set; }
        public virtual DbSet<GenericMaster> GenericMaster { get; set; }
        public virtual DbSet<GiftCard> GiftCard { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistory { get; set; }
        public virtual DbSet<HealthArticle> HealthArticle { get; set; }
        public virtual DbSet<HealthIssue> HealthIssue { get; set; }
        public virtual DbSet<HealthIssueTemplate> HealthIssueTemplate { get; set; }
        public virtual DbSet<HealthLocators> HealthLocators { get; set; }
        public virtual DbSet<HealthLocatorsTypes> HealthLocatorsTypes { get; set; }
        public virtual DbSet<HealthLocatorsTypesMapping> HealthLocatorsTypesMapping { get; set; }
        public virtual DbSet<HealthRecord> HealthRecord { get; set; }
        public virtual DbSet<HealthRecordPictureMapping> HealthRecordPictureMapping { get; set; }
        public virtual DbSet<IdentityClaims> IdentityClaims { get; set; }
        public virtual DbSet<IdentityResources> IdentityResources { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResource { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperty { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplate { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimension { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeight { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplate { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComment { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscription { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderNote> OrderNote { get; set; }
        public virtual DbSet<OrderStatusLogs> OrderStatusLogs { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecord { get; set; }
        public virtual DbSet<PermissionRecordRoleMapping> PermissionRecordRoleMapping { get; set; }
        public virtual DbSet<PersistedGrants> PersistedGrants { get; set; }
        public virtual DbSet<PharmacyProductMapping> PharmacyProductMapping { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<PictureBinary> PictureBinary { get; set; }
        public virtual DbSet<PillReminder> PillReminder { get; set; }
        public virtual DbSet<PillReminderSlots> PillReminderSlots { get; set; }
        public virtual DbSet<PlantProductMapping> PlantProductMapping { get; set; }
        public virtual DbSet<Plants> Plants { get; set; }
        public virtual DbSet<Poll> Poll { get; set; }
        public virtual DbSet<PollAnswer> PollAnswer { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecord { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValue { get; set; }
        public virtual DbSet<Pro> Pro { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttribute { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombination { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValue { get; set; }
        public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRange { get; set; }
        public virtual DbSet<ProductCategoryMapping> ProductCategoryMapping { get; set; }
        public virtual DbSet<ProductCompositionMapping> ProductCompositionMapping { get; set; }
        public virtual DbSet<ProductHealthIssueMapping> ProductHealthIssueMapping { get; set; }
        public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMapping { get; set; }
        public virtual DbSet<ProductPictureMapping> ProductPictureMapping { get; set; }
        public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMapping { get; set; }
        public virtual DbSet<ProductProductTagMapping> ProductProductTagMapping { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulness { get; set; }
        public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMapping { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMapping { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplate { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventory { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Query> Query { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmail { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayment { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistory { get; set; }
        public virtual DbSet<ReferralCode> ReferralCode { get; set; }
        public virtual DbSet<ReferralCodeCustomer> ReferralCodeCustomer { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProduct { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequest { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestAction { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReason { get; set; }
        public virtual DbSet<ReviewType> ReviewType { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistory { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTask { get; set; }
        public virtual DbSet<SearchTerm> SearchTerm { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Sheet1> Sheet1 { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItem { get; set; }
        public virtual DbSet<ShippingChargesCategory> ShippingChargesCategory { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethod { get; set; }
        public virtual DbSet<ShippingMethodRestrictions> ShippingMethodRestrictions { get; set; }
        public virtual DbSet<ShopDeviceIdMapping> ShopDeviceIdMapping { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttribute { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOption { get; set; }
        public virtual DbSet<SsSlShop> SsSlShop { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<StockQuantityHistory> StockQuantityHistory { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreMapping> StoreMapping { get; set; }
        public virtual DbSet<SuggestedProducts> SuggestedProducts { get; set; }
        public virtual DbSet<TaxCategory> TaxCategory { get; set; }
        public virtual DbSet<TaxRate> TaxRate { get; set; }
        public virtual DbSet<TierPrice> TierPrice { get; set; }
        public virtual DbSet<TopBrands> TopBrands { get; set; }
        public virtual DbSet<TopCategories> TopCategories { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplate { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<UrlRecord> UrlRecord { get; set; }
        public virtual DbSet<UserArticlesMapping> UserArticlesMapping { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorAttribute> VendorAttribute { get; set; }
        public virtual DbSet<VendorAttributeValue> VendorAttributeValue { get; set; }
        public virtual DbSet<VendorNote> VendorNote { get; set; }
        public virtual DbSet<VersionControl> VersionControl { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WhoAtcdiseaseMapping> WhoAtcdiseaseMapping { get; set; }
        public virtual DbSet<_10001503> _10001503 { get; set; }
        public virtual DbSet<_10001503503Mixed> _10001503503Mixed { get; set; }
        public virtual DbSet<_10001503XlnmFilterDatabase> _10001503XlnmFilterDatabase { get; set; }
        public virtual DbSet<_15042013> _15042013 { get; set; }
        public virtual DbSet<_15042013513Mixed> _15042013513Mixed { get; set; }
        public virtual DbSet<_20142437> _20142437 { get; set; }
        public virtual DbSet<_20142437425Mixed> _20142437425Mixed { get; set; }
        public virtual DbSet<_20142437XlnmFilterDatabase> _20142437XlnmFilterDatabase { get; set; }
        public virtual DbSet<_24382548> _24382548 { get; set; }
        public virtual DbSet<_24382548112Branded1> _24382548112Branded1 { get; set; }
        public virtual DbSet<_24382548XlnmFilterDatabase> _24382548XlnmFilterDatabase { get; set; }
        public virtual DbSet<_25492866> _25492866 { get; set; }
        public virtual DbSet<_25492866318Branded2> _25492866318Branded2 { get; set; }
        public virtual DbSet<_25492866XlnmFilterDatabase> _25492866XlnmFilterDatabase { get; set; }
        public virtual DbSet<_28672898> _28672898 { get; set; }
        public virtual DbSet<_2867289833CosmeticTradMe> _2867289833CosmeticTradMe { get; set; }
        public virtual DbSet<_28993052> _28993052 { get; set; }
        public virtual DbSet<_28993052155Branded3> _28993052155Branded3 { get; set; }
        public virtual DbSet<_30533141> _30533141 { get; set; }
        public virtual DbSet<_3053314190RitemedPharex> _3053314190RitemedPharex { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=52.172.49.176;Database=AzistaEcomm;user id=HhcAdmin; password=Hetero@123456;Integrated Security=True;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AclRecord>(entity =>
            {
                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.AclRecord)
                    .HasForeignKey(d => d.CustomerRoleId);
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.EntityName).HasMaxLength(400);

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.ActivityLogTypeId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ActivityLogType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateProvinceId);
            });

            modelBuilder.Entity<AddressAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<AddressAttributeValue>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.AddressAttribute)
                    .WithMany(p => p.AddressAttributeValue)
                    .HasForeignKey(d => d.AddressAttributeId);
            });

            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Affiliate)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ApiClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiClaims)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ApiResources>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ApiScopeClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiScope)
                    .WithMany(p => p.ApiScopeClaims)
                    .HasForeignKey(d => d.ApiScopeId);
            });

            modelBuilder.Entity<ApiScopes>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiScopes)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ApiSecrets>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(2000);

                entity.HasOne(d => d.ApiResource)
                    .WithMany(p => p.ApiSecrets)
                    .HasForeignKey(d => d.ApiResourceId);
            });

            modelBuilder.Entity<ArticleComments>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.HealthArticle)
                    .WithMany(p => p.ArticleComments)
                    .HasForeignKey(d => d.HealthArticleId)
                    .HasConstraintName("FK_Comments_HealthArticles");
            });

            modelBuilder.Entity<ArticleLikes>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.HealthArticle)
                    .WithMany(p => p.ArticleLikes)
                    .HasForeignKey(d => d.HealthArticleId)
                    .HasConstraintName("FK_ArticleLikes_HealthArticles");
            });

            modelBuilder.Entity<BackInStockSubscription>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BackInStockSubscription)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BackInStockSubscription)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Batch1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH1$");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("  PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWithVatPerPc).HasColumnName("SRP WITH VAT (PER PC)");

                entity.Property(e => e.SrpWithoutVatPerPc).HasColumnName("SRP WITHOUT VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1Id)
                    .HasColumnName("SUB CATEGORY 1 ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch1Complete1137Done>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'BATCH 1 (COMPLETE 1-137) DONE$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("  PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWithVatPerPc).HasColumnName("SRP WITH VAT (PER PC)");

                entity.Property(e => e.SrpWithoutVatPerPc).HasColumnName("SRP WITHOUT VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1Id)
                    .HasColumnName("SUB CATEGORY 1 ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH2$");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasColumnName("INDICATION");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#no");

                entity.Property(e => e.SrpWithVatPerPc).HasColumnName("SRP WITH VAT(PER PC)");

                entity.Property(e => e.SrpWithoutVatPerPc).HasColumnName("SRP WITHOUT VAT (PER PC)");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch2Complete138238Done>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'BATCH 2 (COMPLETE 138-238) DONE$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasColumnName("INDICATION");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#no");

                entity.Property(e => e.SrpWithVatPerPc).HasColumnName("SRP WITH VAT(PER PC)");

                entity.Property(e => e.SrpWithoutVatPerPc).HasColumnName("SRP WITHOUT VAT (PER PC)");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch2XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH2$_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasColumnName("INDICATION");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#no");

                entity.Property(e => e.SrpWithVatPerPc).HasColumnName("SRP WITH VAT(PER PC)");

                entity.Property(e => e.SrpWithoutVatPerPc).HasColumnName("SRP WITHOUT VAT (PER PC)");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH3$");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("  PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("s#no");

                entity.Property(e => e.SrpPerPc).HasColumnName("SRP (PER PC)");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Supplier)
                    .HasColumnName("SUPPLIER")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch3239383Done>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'BATCH 3 (239-383) DONE$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("  PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("s#no");

                entity.Property(e => e.SrpPerPc).HasColumnName("SRP (PER PC)");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Supplier)
                    .HasColumnName("SUPPLIER")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch3XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH3$_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("  PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("s#no");

                entity.Property(e => e.SrpPerPc).HasColumnName("SRP (PER PC)");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Supplier)
                    .HasColumnName("SUPPLIER")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH4$");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.F42).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S NO");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SrpWVatPerPc).HasColumnName("SRP W/ VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1 ")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch4Branded384554Done>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'BATCH 4 BRANDED (384-554) DONE$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S NO");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SrpWVatPerPc).HasColumnName("SRP W/ VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1 ")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch4XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH4$_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S NO");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SrpWVatPerPc).HasColumnName("SRP W/ VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1 ")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch4Z3e37a1edCb8d481e92dc65adcadbe026WvuFilterData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH4$Z_3E37A1ED_CB8D_481E_92DC_65ADCADBE026_#wvu#FilterData");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S NO");

                entity.Property(e => e.SrpWOVatPerPc).HasColumnName("SRP w/o VAT (PER PC)");

                entity.Property(e => e.SrpWVatPerPc).HasColumnName("SRP W/ VAT (PER PC)");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1 ")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH5$");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.FormulationName)
                    .HasColumnName("FORMULATION NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch5Mixed555868Done>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'BATCH 5 MIXED (555-868) DONE$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.FormulationName)
                    .HasColumnName("FORMULATION NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch5XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH5$_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.FormulationName)
                    .HasColumnName("FORMULATION NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch5Z3e37a1edCb8d481e92dc65adcadbe026WvuFilterData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH5$Z_3E37A1ED_CB8D_481E_92DC_65ADCADBE026_#wvu#FilterData");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.FormulationName)
                    .HasColumnName("FORMULATION NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH6$");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("s#no");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategory)
                    .HasColumnName("SUB CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch6PersonalCare8691000>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'BATCH 6 PERSONAL CARE (869-1000$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("s#no");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategory)
                    .HasColumnName("SUB CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Batch6XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH6$_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("s#no");

                entity.Property(e => e.SrpWithVat).HasColumnName("SRP WITH VAT");

                entity.Property(e => e.SrpWithoutVat).HasColumnName("SRP WITHOUT VAT");

                entity.Property(e => e.SubCategory)
                    .HasColumnName("SUB CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BestSellingProducts>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BestSellingProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_BestSellingProducts_Product_Product_Id");
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.BlogPostId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.BlogPost)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Book$");

                entity.Property(e => e.AvailabilityPackage)
                    .HasColumnName("availability/package")
                    .HasMaxLength(255);

                entity.Property(e => e.BrandName)
                    .HasColumnName("Brand name")
                    .HasMaxLength(255);

                entity.Property(e => e.Caution).HasMaxLength(255);

                entity.Property(e => e.Classification)
                    .HasColumnName("CLASSIFICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Contraindication).HasMaxLength(255);

                entity.Property(e => e.DescriptionOfTheProduct)
                    .HasColumnName("Description of the product")
                    .HasMaxLength(255);

                entity.Property(e => e.DosageAdministrationForAdult)
                    .HasColumnName("Dosage / Administration for adult")
                    .HasMaxLength(255);

                entity.Property(e => e.DosageAdministrationForChildren).HasColumnName("Dosage / Administration for Children");

                entity.Property(e => e.DrivingAlert)
                    .HasColumnName("Driving Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.DrugInteractions)
                    .HasColumnName("Drug Interactions")
                    .HasMaxLength(255);

                entity.Property(e => e.FormulationId).HasColumnName("Formulation id");

                entity.Property(e => e.FormulationName)
                    .HasColumnName("Formulation name")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericCode)
                    .HasColumnName("Generic Code")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericId).HasColumnName("Generic ID");

                entity.Property(e => e.GenericName)
                    .HasColumnName("Generic name")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("Group id");

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group Name")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("Health Issues")
                    .HasMaxLength(255);

                entity.Property(e => e.Image)
                    .HasColumnName("Image ")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasMaxLength(255);

                entity.Property(e => e.KidneyAlert)
                    .HasColumnName("Kidney Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.LactationAlert)
                    .HasColumnName("Lactation Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.LiverAlert)
                    .HasColumnName("Liver alert")
                    .HasMaxLength(255);

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer  Id");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("Manufacturer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PrecautionWarning).HasColumnName("Precaution/Warning");

                entity.Property(e => e.PregnancyAlert)
                    .HasColumnName("Pregnancy Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.RecommendedDosageAdult)
                    .HasColumnName("Recommended dosage - adult")
                    .HasMaxLength(255);

                entity.Property(e => e.RecommendedDosageChildren)
                    .HasColumnName("Recommended dosage - Children")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#no");

                entity.Property(e => e.SideEffectsAdverseEffects)
                    .HasColumnName("Side effects/Adverse effects")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWOutVat).HasColumnName("SRP  W/ OUT VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP  W/ VAT");

                entity.Property(e => e.StorageConditions)
                    .HasColumnName("storage conditions")
                    .HasMaxLength(255);

                entity.Property(e => e.SubGroup1Id).HasColumnName("sub group 1 id");

                entity.Property(e => e.SubGroupId2).HasColumnName("SubGroupID2");

                entity.Property(e => e.SubGroupNameI)
                    .HasColumnName("sub group Name I")
                    .HasMaxLength(255);

                entity.Property(e => e.SubGroupNameIi)
                    .HasColumnName("sub group Name II")
                    .HasMaxLength(255);

                entity.Property(e => e.SubGroupNameIiDescription)
                    .HasColumnName("Sub group Name II description")
                    .HasMaxLength(255);

                entity.Property(e => e.SymtomsAndTreatmentForOverdosage)
                    .HasColumnName("symtoms and treatment for Overdosage")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UniformProductCode).HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Book2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Book2$");

                entity.Property(e => e.AvailabilityPackage)
                    .HasColumnName("availability/package")
                    .HasMaxLength(255);

                entity.Property(e => e.BrandName)
                    .HasColumnName("Brand name")
                    .HasMaxLength(255);

                entity.Property(e => e.Caution).HasMaxLength(255);

                entity.Property(e => e.Classification)
                    .HasColumnName("CLASSIFICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Contraindication).HasMaxLength(255);

                entity.Property(e => e.DescriptionOfTheProduct)
                    .HasColumnName("Description of the product")
                    .HasMaxLength(255);

                entity.Property(e => e.DosageAdministrationForAdult)
                    .HasColumnName("Dosage / Administration for adult")
                    .HasMaxLength(255);

                entity.Property(e => e.DosageAdministrationForChildren)
                    .HasColumnName("Dosage / Administration for Children")
                    .HasMaxLength(255);

                entity.Property(e => e.DrivingAlert)
                    .HasColumnName("Driving Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.DrugInteractions)
                    .HasColumnName("Drug Interactions")
                    .HasMaxLength(255);

                entity.Property(e => e.FormulationId)
                    .HasColumnName("Formulation id")
                    .HasMaxLength(255);

                entity.Property(e => e.FormulationName)
                    .HasColumnName("Formulation name")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericCode)
                    .HasColumnName("Generic Code")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericId)
                    .HasColumnName("Generic ID")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("Generic name")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("Group id");

                entity.Property(e => e.GroupName)
                    .HasColumnName("Group Name")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("Health Issues")
                    .HasMaxLength(255);

                entity.Property(e => e.Image)
                    .HasColumnName("Image ")
                    .HasMaxLength(255);

                entity.Property(e => e.KidneyAlert)
                    .HasColumnName("Kidney Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.LactationAlert)
                    .HasColumnName("Lactation Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.LiverAlert)
                    .HasColumnName("Liver alert")
                    .HasMaxLength(255);

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer  Id");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("Manufacturer Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PrecautionWarning)
                    .HasColumnName("Precaution/Warning")
                    .HasMaxLength(255);

                entity.Property(e => e.PregnancyAlert)
                    .HasColumnName("Pregnancy Alert")
                    .HasMaxLength(255);

                entity.Property(e => e.RecommendedDosageAdult)
                    .HasColumnName("Recommended dosage - adult")
                    .HasMaxLength(255);

                entity.Property(e => e.RecommendedDosageChildren)
                    .HasColumnName("Recommended dosage - Children")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#no");

                entity.Property(e => e.SideEffectsAdverseEffects)
                    .HasColumnName("Side effects/Adverse effects")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWOutVat).HasColumnName("SRP  W/ OUT VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP  W/ VAT");

                entity.Property(e => e.StorageConditions)
                    .HasColumnName("storage conditions")
                    .HasMaxLength(255);

                entity.Property(e => e.SubGroup1Id).HasColumnName("sub group 1 id");

                entity.Property(e => e.SubGroupId2).HasColumnName("SubGroupID2");

                entity.Property(e => e.SubGroupNameI)
                    .HasColumnName("sub group Name I")
                    .HasMaxLength(255);

                entity.Property(e => e.SubGroupNameIi)
                    .HasColumnName("sub group Name II")
                    .HasMaxLength(255);

                entity.Property(e => e.SubGroupNameIiDescription)
                    .HasColumnName("Sub group Name II description")
                    .HasMaxLength(255);

                entity.Property(e => e.SymtomsAndTreatmentForOverdosage)
                    .HasColumnName("symtoms and treatment for Overdosage")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UniformProductCode).HasMaxLength(255);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<CategoriesReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'Categories Reference$'");

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.Subcategory)
                    .HasColumnName("SUBCATEGORY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.F1)
                    .HasColumnName("f1")
                    .HasMaxLength(10);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<CategoryArticlesMapping>(entity =>
            {
                entity.HasOne(d => d.HealthArticle)
                    .WithMany(p => p.CategoryArticlesMapping)
                    .HasForeignKey(d => d.HealthArticleId)
                    .HasConstraintName("FK_CategoryArticlesMapping_HealthArticles");
            });

            modelBuilder.Entity<CategoryBannerImagesMapping>(entity =>
            {
                entity.ToTable("Category_BannerImages_Mapping");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryBannerImagesMapping)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.CategoryBannerImagesMapping)
                    .HasForeignKey(d => d.PictureId);
            });

            modelBuilder.Entity<CategoryTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttributeValue>(entity =>
            {
                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CheckoutAttribute)
                    .WithMany(p => p.CheckoutAttributeValue)
                    .HasForeignKey(d => d.CheckoutAttributeId);
            });

            modelBuilder.Entity<ClientClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientClaims)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientCorsOrigins>(entity =>
            {
                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientCorsOrigins)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientGrantTypes>(entity =>
            {
                entity.Property(e => e.GrantType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientGrantTypes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientIdPrestrictions>(entity =>
            {
                entity.ToTable("ClientIdPRestrictions");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientIdPrestrictions)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientPostLogoutRedirectUris>(entity =>
            {
                entity.Property(e => e.PostLogoutRedirectUri)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPostLogoutRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientProperties>(entity =>
            {
                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProperties)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientRedirectUris>(entity =>
            {
                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientRedirectUris)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientScopes>(entity =>
            {
                entity.Property(e => e.Scope)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientScopes)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<ClientSecrets>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSecrets)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.Property(e => e.BackChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.ClientClaimsPrefix).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClientName).HasMaxLength(200);

                entity.Property(e => e.ClientUri).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FrontChannelLogoutUri).HasMaxLength(2000);

                entity.Property(e => e.LogoUri).HasMaxLength(2000);

                entity.Property(e => e.PairWiseSubjectSalt).HasMaxLength(200);

                entity.Property(e => e.ProtocolType)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Composition>(entity =>
            {
                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<CompositionTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.EmailToRevalidate).HasMaxLength(1000);

                entity.Property(e => e.Phcdocument).HasColumnName("PHCDocument");

                entity.Property(e => e.Phcnumber).HasColumnName("PHCNumber");

                entity.Property(e => e.Phcverified).HasColumnName("PHCVerified");

                entity.Property(e => e.Scnumber).HasColumnName("SCNumber");

                entity.Property(e => e.Scproof).HasColumnName("SCProof");

                entity.Property(e => e.Scverified).HasColumnName("SCVerified");

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.Username).HasMaxLength(1000);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.CustomerBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId);

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.CustomerShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId);
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId });

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CustomerAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CustomerAttributeValue>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerAttributeValue)
                    .HasForeignKey(d => d.CustomerAttributeId);
            });

            modelBuilder.Entity<CustomerCustomerRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId });

                entity.ToTable("Customer_CustomerRole_Mapping");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCustomerRoleMapping)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMapping)
                    .HasForeignKey(d => d.CustomerRoleId);
            });

            modelBuilder.Entity<CustomerDeviceIdMapping>(entity =>
            {
                entity.ToTable("Customer_DeviceId_Mapping");
            });

            modelBuilder.Entity<CustomerPassword>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPassword)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CustomerRole>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            modelBuilder.Entity<DeliveryDate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MaximumDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MinOrderTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PictureUrl).IsRequired();
            });

            modelBuilder.Entity<DiscountAppliedToCategories>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.CategoryId });

                entity.ToTable("Discount_AppliedToCategories");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.DiscountId);
            });

            modelBuilder.Entity<DiscountAppliedToCompositions>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.CompositionId });

                entity.ToTable("Discount_AppliedToCompositions");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.CompositionId).HasColumnName("Composition_Id");

                entity.HasOne(d => d.Composition)
                    .WithMany(p => p.DiscountAppliedToCompositions)
                    .HasForeignKey(d => d.CompositionId);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCompositions)
                    .HasForeignKey(d => d.DiscountId);
            });

            modelBuilder.Entity<DiscountAppliedToCustomers>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.CustomerId });

                entity.ToTable("Discount_AppliedToCustomers");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DiscountAppliedToCustomers)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCustomers)
                    .HasForeignKey(d => d.DiscountId);
            });

            modelBuilder.Entity<DiscountAppliedToHealthIssues>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.HealthIssueId });

                entity.ToTable("Discount_AppliedToHealthIssues");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.HealthIssueId).HasColumnName("HealthIssue_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToHealthIssues)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.HealthIssue)
                    .WithMany(p => p.DiscountAppliedToHealthIssues)
                    .HasForeignKey(d => d.HealthIssueId);
            });

            modelBuilder.Entity<DiscountAppliedToManufacturers>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ManufacturerId });

                entity.ToTable("Discount_AppliedToManufacturers");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.ManufacturerId);
            });

            modelBuilder.Entity<DiscountAppliedToPharmacies>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.SsSlShopId });

                entity.ToTable("Discount_AppliedToPharmacies");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.SsSlShopId).HasColumnName("SS_SL_Shop_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToPharmacies)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.SsSlShop)
                    .WithMany(p => p.DiscountAppliedToPharmacies)
                    .HasForeignKey(d => d.SsSlShopId);
            });

            modelBuilder.Entity<DiscountAppliedToProducts>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ProductId });

                entity.ToTable("Discount_AppliedToProducts");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<DiscountRequirement>(entity =>
            {
                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountRequirement)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<DiscountUsageHistory>(entity =>
            {
                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountUsageHistoryDiscount)
                    .HasForeignKey(d => d.DiscountId);

                entity.HasOne(d => d.DiscountId1Navigation)
                    .WithMany(p => p.DiscountUsageHistoryDiscountId1Navigation)
                    .HasForeignKey(d => d.DiscountId1);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DiscountUsageHistory)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
            {
                entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");

                entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalAuthenticationRecord)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<FamilyMember>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FamilyMember)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ForumsForum>(entity =>
            {
                entity.ToTable("Forums_Forum");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ForumGroup)
                    .WithMany(p => p.ForumsForum)
                    .HasForeignKey(d => d.ForumGroupId);
            });

            modelBuilder.Entity<ForumsGroup>(entity =>
            {
                entity.ToTable("Forums_Group");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ForumsPost>(entity =>
            {
                entity.ToTable("Forums_Post");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsPost)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ForumsPost)
                    .HasForeignKey(d => d.TopicId);
            });

            modelBuilder.Entity<ForumsPostVote>(entity =>
            {
                entity.ToTable("Forums_PostVote");

                entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumsPostVote)
                    .HasForeignKey(d => d.ForumPostId);
            });

            modelBuilder.Entity<ForumsPrivateMessage>(entity =>
            {
                entity.ToTable("Forums_PrivateMessage");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.FromCustomer)
                    .WithMany(p => p.ForumsPrivateMessageFromCustomer)
                    .HasForeignKey(d => d.FromCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ToCustomer)
                    .WithMany(p => p.ForumsPrivateMessageToCustomer)
                    .HasForeignKey(d => d.ToCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ForumsSubscription>(entity =>
            {
                entity.ToTable("Forums_Subscription");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsSubscription)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ForumsTopic>(entity =>
            {
                entity.ToTable("Forums_Topic");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsTopic)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsTopic)
                    .HasForeignKey(d => d.ForumId);
            });

            modelBuilder.Entity<ForwardOrderToPharmacy>(entity =>
            {
                entity.ToTable("Forward_Order_To_Pharmacy");
            });

            modelBuilder.Entity<GdprConsent>(entity =>
            {
                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<GenericAttribute>(entity =>
            {
                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<GenericCombinationMapping>(entity =>
            {
                entity.HasKey(e => new { e.CombinationMasterId, e.GenericMasterId });

                entity.ToTable("Generic_CombinationMapping");

                entity.HasOne(d => d.CombinationMaster)
                    .WithMany(p => p.GenericCombinationMapping)
                    .HasForeignKey(d => d.CombinationMasterId);

                entity.HasOne(d => d.GenericMaster)
                    .WithMany(p => p.GenericCombinationMapping)
                    .HasForeignKey(d => d.GenericMasterId);
            });

            modelBuilder.Entity<GiftCard>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.PurchasedWithOrderItem)
                    .WithMany(p => p.GiftCard)
                    .HasForeignKey(d => d.PurchasedWithOrderItemId);
            });

            modelBuilder.Entity<GiftCardUsageHistory>(entity =>
            {
                entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.GiftCard)
                    .WithMany(p => p.GiftCardUsageHistory)
                    .HasForeignKey(d => d.GiftCardId);

                entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.GiftCardUsageHistory)
                    .HasForeignKey(d => d.UsedWithOrderId);
            });

            modelBuilder.Entity<HealthArticle>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HealthIssue>(entity =>
            {
                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<HealthIssueTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<HealthLocators>(entity =>
            {
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HealthLocatorsTypes>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<HealthLocatorsTypesMapping>(entity =>
            {
                entity.HasIndex(e => e.HealthLocatorsId);

                entity.HasIndex(e => e.HealthLocatorsTypesId);

                entity.HasOne(d => d.HealthLocators)
                    .WithMany(p => p.HealthLocatorsTypesMapping)
                    .HasForeignKey(d => d.HealthLocatorsId)
                    .HasConstraintName("FK_HealthLocatorsTypesMapping_HealthLocators");

                entity.HasOne(d => d.HealthLocatorsTypes)
                    .WithMany(p => p.HealthLocatorsTypesMapping)
                    .HasForeignKey(d => d.HealthLocatorsTypesId)
                    .HasConstraintName("FK_HealthLocatorsTypesMapping_HealthLocatorsTypes");
            });

            modelBuilder.Entity<HealthRecordPictureMapping>(entity =>
            {
                entity.ToTable("HealthRecord_Picture_Mapping");

                entity.HasOne(d => d.HealthRecord)
                    .WithMany(p => p.HealthRecordPictureMapping)
                    .HasForeignKey(d => d.HealthRecordId);
            });

            modelBuilder.Entity<IdentityClaims>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdentityResource)
                    .WithMany(p => p.IdentityClaims)
                    .HasForeignKey(d => d.IdentityResourceId);
            });

            modelBuilder.Entity<IdentityResources>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResource)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<LocalizedProperty>(entity =>
            {
                entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperty)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.ShortMessage).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<ManufacturerTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<MeasureDimension>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MeasureWeight>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Full).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Short).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.NewsComment)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.NewsItem)
                    .WithMany(p => p.NewsComment)
                    .HasForeignKey(d => d.NewsItemId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.NewsComment)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<NewsLetterSubscription>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Age).HasMaxLength(100);

                entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 8)");

                entity.Property(e => e.CustomOrderNumber).IsRequired();

                entity.Property(e => e.DeliveryFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OrderTotalScorPhcdiscount)
                    .HasColumnName("OrderTotalSCorPHCDiscount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PackageCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PictureId).HasMaxLength(200);

                entity.Property(e => e.PrescriptionId).HasMaxLength(50);

                entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServiceCharge).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrderBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.PickupAddress)
                    .WithMany(p => p.OrderPickupAddress)
                    .HasForeignKey(d => d.PickupAddressId);

                entity.HasOne(d => d.RewardPointsHistoryEntry)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.RewardPointsHistoryEntryId);

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrderShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ScorPhcdiscount)
                    .HasColumnName("SCorPHCDiscount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SeniorCitizenPwddiscount)
                    .HasColumnName("SeniorCitizenPWDDiscount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<OrderNote>(entity =>
            {
                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderNote)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<OrderStatusLogs>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderStatusLogs)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<PermissionRecord>(entity =>
            {
                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PermissionRecordRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId });

                entity.ToTable("PermissionRecord_Role_Mapping");

                entity.Property(e => e.PermissionRecordId).HasColumnName("PermissionRecord_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.PermissionRecordRoleMapping)
                    .HasForeignKey(d => d.CustomerRoleId);

                entity.HasOne(d => d.PermissionRecord)
                    .WithMany(p => p.PermissionRecordRoleMapping)
                    .HasForeignKey(d => d.PermissionRecordId);
            });

            modelBuilder.Entity<PersistedGrants>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.Property(e => e.Key).HasMaxLength(200);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.SubjectId).HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PharmacyProductMapping>(entity =>
            {
                entity.ToTable("Pharmacy_Product_Mapping");

                entity.HasOne(d => d.Pharmacy)
                    .WithMany(p => p.PharmacyProductMapping)
                    .HasForeignKey(d => d.PharmacyId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PharmacyProductMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<PictureBinary>(entity =>
            {
                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.PictureBinary)
                    .HasForeignKey(d => d.PictureId);
            });

            modelBuilder.Entity<PillReminder>(entity =>
            {
                entity.Property(e => e.ColorCode).HasMaxLength(50);

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Dosage).HasMaxLength(50);

                entity.Property(e => e.DoseTimes).HasMaxLength(50);

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.PillType).HasMaxLength(100);

                entity.Property(e => e.ShapeType).HasMaxLength(50);
            });

            modelBuilder.Entity<PillReminderSlots>(entity =>
            {
                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.PillReminder)
                    .WithMany(p => p.PillReminderSlots)
                    .HasForeignKey(d => d.PillReminderId)
                    .HasConstraintName("FK_PillReminderSlots_PillReminder");
            });

            modelBuilder.Entity<PlantProductMapping>(entity =>
            {
                entity.ToTable("Plant_Product_Mapping");

                entity.Property(e => e.Active).HasMaxLength(5);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PlantProductMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Plants>(entity =>
            {
                entity.Property(e => e.Active).HasMaxLength(5);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PlantName).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasMaxLength(500);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Plants)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plants_StateProvince");
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Poll)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<PollAnswer>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollAnswer)
                    .HasForeignKey(d => d.PollId);
            });

            modelBuilder.Entity<PollVotingRecord>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PollVotingRecord)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.PollAnswer)
                    .WithMany(p => p.PollVotingRecord)
                    .HasForeignKey(d => d.PollAnswerId);
            });

            modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.PredefinedProductAttributeValue)
                    .HasForeignKey(d => d.ProductAttributeId);
            });

            modelBuilder.Entity<Pro>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Pro__B40CC6CD41E10B01");

                entity.Property(e => e.ProductName).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                entity.Property(e => e.BasepriceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BasepriceBaseAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.EmedBrandId).HasColumnName("EMedBrandId");

                entity.Property(e => e.F1)
                    .HasColumnName("f1")
                    .HasMaxLength(10);

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.OverriddenGiftCardAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PricePerUnit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductAttributeCombination>(entity =>
            {
                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeCombination)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductAttributeMapping)
                    .WithMany(p => p.ProductAttributeValue)
                    .HasForeignKey(d => d.ProductAttributeMappingId);
            });

            modelBuilder.Entity<ProductAvailabilityRange>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductCategoryMapping>(entity =>
            {
                entity.ToTable("Product_Category_Mapping");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMapping)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductCompositionMapping>(entity =>
            {
                entity.ToTable("Product_Composition_Mapping");

                entity.HasOne(d => d.Composition)
                    .WithMany(p => p.ProductCompositionMapping)
                    .HasForeignKey(d => d.CompositionId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCompositionMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductHealthIssueMapping>(entity =>
            {
                entity.ToTable("Product_HealthIssue_Mapping");

                entity.HasOne(d => d.HealthIssue)
                    .WithMany(p => p.ProductHealthIssueMapping)
                    .HasForeignKey(d => d.HealthIssueId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductHealthIssueMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductManufacturerMapping>(entity =>
            {
                entity.ToTable("Product_Manufacturer_Mapping");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ProductManufacturerMapping)
                    .HasForeignKey(d => d.ManufacturerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductManufacturerMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                entity.ToTable("Product_Picture_Mapping");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMapping)
                    .HasForeignKey(d => d.PictureId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
            {
                entity.ToTable("Product_ProductAttribute_Mapping");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductProductAttributeMapping)
                    .HasForeignKey(d => d.ProductAttributeId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductAttributeMapping)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<ProductProductTagMapping>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductTagId });

                entity.ToTable("Product_ProductTag_Mapping");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductTagMapping)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductProductTagMapping)
                    .HasForeignKey(d => d.ProductTagId);
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulness)
                    .HasForeignKey(d => d.ProductReviewId);
            });

            modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
            {
                entity.ToTable("ProductReview_ReviewType_Mapping");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewReviewTypeMapping)
                    .HasForeignKey(d => d.ProductReviewId);

                entity.HasOne(d => d.ReviewType)
                    .WithMany(p => p.ProductReviewReviewTypeMapping)
                    .HasForeignKey(d => d.ReviewTypeId);
            });

            modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
            {
                entity.ToTable("Product_SpecificationAttribute_Mapping");

                entity.Property(e => e.CustomValue).HasMaxLength(4000);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecificationAttributeMapping)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.SpecificationAttributeOption)
                    .WithMany(p => p.ProductSpecificationAttributeMapping)
                    .HasForeignKey(d => d.SpecificationAttributeOptionId);
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductWarehouseInventory>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductWarehouseInventory)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductWarehouseInventory)
                    .HasForeignKey(d => d.WarehouseId);
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<QueuedEmail>(entity =>
            {
                entity.Property(e => e.Bcc).HasMaxLength(500);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(500);

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FromName).HasMaxLength(500);

                entity.Property(e => e.ReplyTo).HasMaxLength(500);

                entity.Property(e => e.ReplyToName).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(1000);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ToName).HasMaxLength(500);

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.QueuedEmail)
                    .HasForeignKey(d => d.EmailAccountId);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.Rating1).HasColumnName("Rating");
            });

            modelBuilder.Entity<RecurringPayment>(entity =>
            {
                entity.HasOne(d => d.InitialOrder)
                    .WithMany(p => p.RecurringPayment)
                    .HasForeignKey(d => d.InitialOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RecurringPaymentHistory>(entity =>
            {
                entity.HasOne(d => d.RecurringPayment)
                    .WithMany(p => p.RecurringPaymentHistory)
                    .HasForeignKey(d => d.RecurringPaymentId);
            });

            modelBuilder.Entity<ReferralCode>(entity =>
            {
                entity.Property(e => e.IossignInCount).HasColumnName("IOSSignInCount");

                entity.Property(e => e.IossignUpCount).HasColumnName("IOSSignUpCount");

                entity.Property(e => e.Referralcode1).HasColumnName("Referralcode");
            });

            modelBuilder.Entity<ReferralCodeCustomer>(entity =>
            {
                entity.ToTable("ReferralCode_Customer");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReferralCodeCustomer)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Referral)
                    .WithMany(p => p.ReferralCodeCustomer)
                    .HasForeignKey(d => d.ReferralId);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReturnRequest>(entity =>
            {
                entity.Property(e => e.ReasonForReturn).IsRequired();

                entity.Property(e => e.RequestedAction).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReturnRequest)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ReturnRequestAction>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReturnRequestReason>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReviewType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<RewardPointsHistory>(entity =>
            {
                entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RewardPointsHistory)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ScheduleTask>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.Subcategory)
                    .HasColumnName("SUBCATEGORY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipment)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItem)
                    .HasForeignKey(d => d.ShipmentId);
            });

            modelBuilder.Entity<ShippingChargesCategory>(entity =>
            {
                entity.Property(e => e.Active).HasMaxLength(5);

                entity.Property(e => e.ActiveStatus).HasMaxLength(5);

                entity.Property(e => e.ChargeBy).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethodRestrictions>(entity =>
            {
                entity.HasKey(e => new { e.ShippingMethodId, e.CountryId });

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethod_Id");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.ShippingMethodId);
            });

            modelBuilder.Entity<ShopDeviceIdMapping>(entity =>
            {
                entity.ToTable("Shop_DeviceId_Mapping");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<SpecificationAttribute>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SpecificationAttributeOption>(entity =>
            {
                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.SpecificationAttribute)
                    .WithMany(p => p.SpecificationAttributeOption)
                    .HasForeignKey(d => d.SpecificationAttributeId);
            });

            modelBuilder.Entity<SsSlShop>(entity =>
            {
                entity.ToTable("SS_SL_Shop");

                entity.Property(e => e.AdminRating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerRating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ServiceCharge).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.Property(e => e.Abbreviation).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<StockQuantityHistory>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockQuantityHistory)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.CompanyAddress).HasMaxLength(1000);

                entity.Property(e => e.CompanyName).HasMaxLength(1000);

                entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.CompanyVat).HasMaxLength(1000);

                entity.Property(e => e.Hosts).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.SecureUrl).HasMaxLength(400);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<StoreMapping>(entity =>
            {
                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreMapping)
                    .HasForeignKey(d => d.StoreId);
            });

            modelBuilder.Entity<SuggestedProducts>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Pharmacy)
                    .WithMany(p => p.SuggestedProducts)
                    .HasForeignKey(d => d.PharmacyId);
            });

            modelBuilder.Entity<TaxCategory>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TierPrice>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.TierPrice)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TierPrice)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<TopBrands>(entity =>
            {
                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.TopBrands)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_TopBrands_MAnufacturer_Manufacturere_Id");
            });

            modelBuilder.Entity<TopCategories>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TopCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_TopCategories_Category_Category_Id");
            });

            modelBuilder.Entity<TopicTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.Property(e => e.ResponseCode).HasMaxLength(100);

                entity.Property(e => e.TransactionId).IsRequired();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Transaction_History_CustomerId");
            });

            modelBuilder.Entity<UrlRecord>(entity =>
            {
                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<UserArticlesMapping>(entity =>
            {
                entity.HasOne(d => d.HealthArticle)
                    .WithMany(p => p.UserArticlesMapping)
                    .HasForeignKey(d => d.HealthArticleId)
                    .HasConstraintName("FK_UserArticleMapping_HealthArticles");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            });

            modelBuilder.Entity<VendorAttribute>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<VendorAttributeValue>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.VendorAttribute)
                    .WithMany(p => p.VendorAttributeValue)
                    .HasForeignKey(d => d.VendorAttributeId);
            });

            modelBuilder.Entity<VendorNote>(entity =>
            {
                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorNote)
                    .HasForeignKey(d => d.VendorId);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<WhoAtcdiseaseMapping>(entity =>
            {
                entity.ToTable("WhoATCDiseaseMapping");

                entity.Property(e => e.Amg).HasColumnName("AMG");

                entity.Property(e => e.Amgdescription).HasColumnName("AMGDescription");

                entity.Property(e => e.Csg).HasColumnName("CSG");

                entity.Property(e => e.Csgdescription).HasColumnName("CSGDescription");

                entity.Property(e => e.Psg).HasColumnName("PSG");

                entity.Property(e => e.Psgdescription).HasColumnName("PSGDescription");

                entity.Property(e => e.Tscode).HasColumnName("TSCode");

                entity.Property(e => e.TscodeDescription).HasColumnName("TSCodeDescription");
            });

            modelBuilder.Entity<_10001503>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'1000-1503$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.F42).HasMaxLength(255);

                entity.Property(e => e.F43).HasMaxLength(255);

                entity.Property(e => e.F44).HasMaxLength(255);

                entity.Property(e => e.F45).HasMaxLength(255);

                entity.Property(e => e.F46).HasMaxLength(255);

                entity.Property(e => e.F47).HasMaxLength(255);

                entity.Property(e => e.F48).HasMaxLength(255);

                entity.Property(e => e.F49).HasMaxLength(255);

                entity.Property(e => e.F50).HasMaxLength(255);

                entity.Property(e => e.F51).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("SUB CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10001503503Mixed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'1000-1503 (503) MIXED$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("SUB CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_10001503XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'1000-1503$'_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.F42).HasMaxLength(255);

                entity.Property(e => e.F43).HasMaxLength(255);

                entity.Property(e => e.F44).HasMaxLength(255);

                entity.Property(e => e.F45).HasMaxLength(255);

                entity.Property(e => e.F46).HasMaxLength(255);

                entity.Property(e => e.F47).HasMaxLength(255);

                entity.Property(e => e.F48).HasMaxLength(255);

                entity.Property(e => e.F49).HasMaxLength(255);

                entity.Property(e => e.F50).HasMaxLength(255);

                entity.Property(e => e.F51).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory)
                    .HasColumnName("SUB CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_15042013>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'1504-2013$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.F42).HasMaxLength(255);

                entity.Property(e => e.F43).HasMaxLength(255);

                entity.Property(e => e.F44).HasMaxLength(255);

                entity.Property(e => e.F45).HasMaxLength(255);

                entity.Property(e => e.F46).HasMaxLength(255);

                entity.Property(e => e.F47).HasMaxLength(255);

                entity.Property(e => e.F48).HasMaxLength(255);

                entity.Property(e => e.F49).HasMaxLength(255);

                entity.Property(e => e.F50).HasMaxLength(255);

                entity.Property(e => e.F51).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_15042013513Mixed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'1504-2013 (513) MIXED$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_20142437>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2014-2437$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.F42).HasMaxLength(255);

                entity.Property(e => e.F43).HasMaxLength(255);

                entity.Property(e => e.F44).HasMaxLength(255);

                entity.Property(e => e.F45).HasMaxLength(255);

                entity.Property(e => e.F46).HasMaxLength(255);

                entity.Property(e => e.F47).HasMaxLength(255);

                entity.Property(e => e.F48).HasMaxLength(255);

                entity.Property(e => e.F49).HasMaxLength(255);

                entity.Property(e => e.F50).HasMaxLength(255);

                entity.Property(e => e.F51).HasMaxLength(255);

                entity.Property(e => e.F52).HasMaxLength(255);

                entity.Property(e => e.F53).HasMaxLength(255);

                entity.Property(e => e.F54).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_20142437425Mixed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2014-2437 (425) MIXED$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_20142437XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2014-2437$'_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F36).HasMaxLength(255);

                entity.Property(e => e.F37).HasMaxLength(255);

                entity.Property(e => e.F38).HasMaxLength(255);

                entity.Property(e => e.F39).HasMaxLength(255);

                entity.Property(e => e.F40).HasMaxLength(255);

                entity.Property(e => e.F41).HasMaxLength(255);

                entity.Property(e => e.F42).HasMaxLength(255);

                entity.Property(e => e.F43).HasMaxLength(255);

                entity.Property(e => e.F44).HasMaxLength(255);

                entity.Property(e => e.F45).HasMaxLength(255);

                entity.Property(e => e.F46).HasMaxLength(255);

                entity.Property(e => e.F47).HasMaxLength(255);

                entity.Property(e => e.F48).HasMaxLength(255);

                entity.Property(e => e.F49).HasMaxLength(255);

                entity.Property(e => e.F50).HasMaxLength(255);

                entity.Property(e => e.F51).HasMaxLength(255);

                entity.Property(e => e.F52).HasMaxLength(255);

                entity.Property(e => e.F53).HasMaxLength(255);

                entity.Property(e => e.F54).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId).HasColumnName("SUB CATEGORY ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_24382548>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2438-2548$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasColumnName("INDICATION");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_24382548112Branded1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2438-2548 (112) BRANDED 1$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasColumnName("INDICATION");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_24382548XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2438-2548$'_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication).HasColumnName("INDICATION");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat)
                    .HasColumnName("SRP W/VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryId)
                    .HasColumnName("SUB CATEGORY ID")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_25492866>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2549-2866$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.CategoryId1)
                    .HasColumnName("CATEGORY ID1")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("CATEGORY NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_25492866318Branded2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2549-2866 (318) BRANDED 2$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.CategoryId1)
                    .HasColumnName("CATEGORY ID1")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("CATEGORY NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_25492866XlnmFilterDatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2549-2866$'_xlnm#_FilterDatabase");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.CategoryId1)
                    .HasColumnName("CATEGORY ID1")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("CATEGORY NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_28672898>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2867-2898$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1Id).HasColumnName("SUB CATEGORY 1 ID");

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_2867289833CosmeticTradMe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2867-2898 (33) COSMETIC&TRAD ME$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F17).HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategory1Id).HasColumnName("SUB CATEGORY 1 ID");

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_28993052>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2899-3052$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indications)
                    .HasColumnName("INDICATIONS")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.Subcategory1Id).HasColumnName("SUBCATEGORY 1 ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasurement)
                    .HasColumnName("UNIT OF MEASUREMENT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_28993052155Branded3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'2899-3052 (155) BRANDED 3$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indications)
                    .HasColumnName("INDICATIONS")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat)
                    .HasColumnName("SRP W/O VAT")
                    .HasMaxLength(255);

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.Subcategory1)
                    .HasColumnName("SUBCATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.Subcategory1Id).HasColumnName("SUBCATEGORY 1 ID");

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasurement)
                    .HasColumnName("UNIT OF MEASUREMENT")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_30533141>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'3053-3141$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.F33).HasMaxLength(255);

                entity.Property(e => e.F34).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssues)
                    .HasColumnName("HEALTH ISSUES")
                    .HasMaxLength(255);

                entity.Property(e => e.HealthIssuesId)
                    .HasColumnName("HEALTH ISSUES ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.PcBottle).HasColumnName("PC / BOTTLE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_3053314190RitemedPharex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'3053-3141 (90) RITEMED&PHAREX$'");

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY ID");

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.F19).HasMaxLength(255);

                entity.Property(e => e.F20).HasMaxLength(255);

                entity.Property(e => e.F21).HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.F24).HasMaxLength(255);

                entity.Property(e => e.F25).HasMaxLength(255);

                entity.Property(e => e.F26).HasMaxLength(255);

                entity.Property(e => e.F27).HasMaxLength(255);

                entity.Property(e => e.F28).HasMaxLength(255);

                entity.Property(e => e.F29).HasMaxLength(255);

                entity.Property(e => e.F30).HasMaxLength(255);

                entity.Property(e => e.F31).HasMaxLength(255);

                entity.Property(e => e.F32).HasMaxLength(255);

                entity.Property(e => e.Formulation)
                    .HasColumnName("FORMULATION")
                    .HasMaxLength(255);

                entity.Property(e => e.GenericName)
                    .HasColumnName("GENERIC NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnName("GROUP ID");

                entity.Property(e => e.GroupName)
                    .HasColumnName("GROUP NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(255);

                entity.Property(e => e.PcBottle).HasColumnName("PC / BOTTLE");

                entity.Property(e => e.PictureLink)
                    .HasColumnName("PICTURE LINK")
                    .HasMaxLength(255);

                entity.Property(e => e.Prescription)
                    .HasColumnName("PRESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.SNo).HasColumnName("S#No");

                entity.Property(e => e.SrpWOVat).HasColumnName("SRP W/O VAT");

                entity.Property(e => e.SrpWVat).HasColumnName("SRP W/ VAT");

                entity.Property(e => e.SubCategory1)
                    .HasColumnName("SUB CATEGORY 1")
                    .HasMaxLength(255);

                entity.Property(e => e.TherapeuticUse)
                    .HasColumnName("THERAPEUTIC USE")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitOfMeasure)
                    .HasColumnName("UNIT OF MEASURE")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
