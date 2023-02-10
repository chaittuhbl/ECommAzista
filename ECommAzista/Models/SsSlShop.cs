using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class SsSlShop
    {
        public SsSlShop()
        {
            DiscountAppliedToPharmacies = new HashSet<DiscountAppliedToPharmacies>();
            PharmacyProductMapping = new HashSet<PharmacyProductMapping>();
            SuggestedProducts = new HashSet<SuggestedProducts>();
        }

        public int Id { get; set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public bool ShowOnHomePage { get; set; }
        public string Tags { get; set; }
        public int DisplayOrder { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool LimitedToStores { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string LandMark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string Time { get; set; }
        public string MinOrder { get; set; }
        public string DeliveryFee { get; set; }
        public string UserName { get; set; }
        public string Discount { get; set; }
        public string AddressCategory { get; set; }
        public string PasswordSalt { get; set; }
        public string PassWord { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastActivity { get; set; }
        public int Accuracy { get; set; }
        public bool IsVerified { get; set; }
        public int PictureId { get; set; }
        public int LicenseId { get; set; }
        public bool IsActive { get; set; }
        public bool IsTest { get; set; }
        public decimal ServiceCharge { get; set; }
        public bool IsAdminRatingEnabled { get; set; }
        public decimal CustomerRating { get; set; }
        public decimal AdminRating { get; set; }
        public bool IsPhoneVerified { get; set; }
        public string CountryCode { get; set; }
        public string Licence { get; set; }
        public string ProfilePicture { get; set; }

        public virtual ICollection<DiscountAppliedToPharmacies> DiscountAppliedToPharmacies { get; set; }
        public virtual ICollection<PharmacyProductMapping> PharmacyProductMapping { get; set; }
        public virtual ICollection<SuggestedProducts> SuggestedProducts { get; set; }
    }
}
