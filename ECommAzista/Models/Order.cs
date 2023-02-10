using System;
using System.Collections.Generic;

namespace ECommAzista.Models
{
    public partial class Order
    {
        public Order()
        {
            DiscountUsageHistory = new HashSet<DiscountUsageHistory>();
            GiftCardUsageHistory = new HashSet<GiftCardUsageHistory>();
            OrderItem = new HashSet<OrderItem>();
            OrderNote = new HashSet<OrderNote>();
            OrderStatusLogs = new HashSet<OrderStatusLogs>();
            RecurringPayment = new HashSet<RecurringPayment>();
            Shipment = new HashSet<Shipment>();
        }

        public int Id { get; set; }
        public Guid OrderGuid { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public int BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? PickupAddressId { get; set; }
        public bool PickUpInStore { get; set; }
        public int OrderStatusId { get; set; }
        public int ShippingStatusId { get; set; }
        public int PaymentStatusId { get; set; }
        public string PaymentMethodSystemName { get; set; }
        public string CustomerCurrencyCode { get; set; }
        public decimal CurrencyRate { get; set; }
        public int CustomerTaxDisplayTypeId { get; set; }
        public string VatNumber { get; set; }
        public decimal OrderSubtotalInclTax { get; set; }
        public decimal OrderSubtotalExclTax { get; set; }
        public decimal OrderSubTotalDiscountInclTax { get; set; }
        public decimal OrderSubTotalDiscountExclTax { get; set; }
        public decimal OrderShippingInclTax { get; set; }
        public decimal OrderShippingExclTax { get; set; }
        public decimal PaymentMethodAdditionalFeeInclTax { get; set; }
        public decimal PaymentMethodAdditionalFeeExclTax { get; set; }
        public string TaxRates { get; set; }
        public decimal OrderTax { get; set; }
        public decimal OrderDiscount { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal RefundedAmount { get; set; }
        public int? RewardPointsHistoryEntryId { get; set; }
        public string CheckoutAttributeDescription { get; set; }
        public string CheckoutAttributesXml { get; set; }
        public int CustomerLanguageId { get; set; }
        public int AffiliateId { get; set; }
        public string CustomerIp { get; set; }
        public bool AllowStoringCreditCardNumber { get; set; }
        public string CardType { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string MaskedCreditCardNumber { get; set; }
        public string CardCvv2 { get; set; }
        public string CardExpirationMonth { get; set; }
        public string CardExpirationYear { get; set; }
        public string AuthorizationTransactionId { get; set; }
        public string AuthorizationTransactionCode { get; set; }
        public string AuthorizationTransactionResult { get; set; }
        public string CaptureTransactionId { get; set; }
        public string CaptureTransactionResult { get; set; }
        public string SubscriptionTransactionId { get; set; }
        public DateTime? PaidDateUtc { get; set; }
        public string ShippingMethod { get; set; }
        public string ShippingRateComputationMethodSystemName { get; set; }
        public string CustomValuesXml { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CustomOrderNumber { get; set; }
        public int MinimumOrder { get; set; }
        public DateTime LastActivityTimeStamp { get; set; }
        public string PrescriptionId { get; set; }
        public string BillRequired { get; set; }
        public string DeviceType { get; set; }
        public string Version { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string AddressCategory { get; set; }
        public string PatientName { get; set; }
        public string CancelledBy { get; set; }
        public string CountryId { get; set; }
        public string FaxNumber { get; set; }
        public string StateProvinceId { get; set; }
        public string CustomAttributes { get; set; }
        public string PrescriptionUrl { get; set; }
        public bool HasPrescription { get; set; }
        public bool IsTest { get; set; }
        public string VendorName { get; set; }
        public string DoctorName { get; set; }
        public decimal PackageCharge { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal DeliveryFee { get; set; }
        public bool IsFeedback { get; set; }
        public string PictureId { get; set; }
        public bool IsOrderForOther { get; set; }
        public string Age { get; set; }
        public bool IsOrderForPhd { get; set; }
        public bool IsOrderForSeniorCitizen { get; set; }
        public decimal OrderTotalScorPhcdiscount { get; set; }
        public bool IsReturnOrder { get; set; }
        public bool IsPrescriptionApproved { get; set; }
        public bool IsPrescriptionRejected { get; set; }
        public int PaymentModeId { get; set; }

        public virtual Address BillingAddress { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Address PickupAddress { get; set; }
        public virtual RewardPointsHistory RewardPointsHistoryEntry { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual ICollection<DiscountUsageHistory> DiscountUsageHistory { get; set; }
        public virtual ICollection<GiftCardUsageHistory> GiftCardUsageHistory { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        public virtual ICollection<OrderNote> OrderNote { get; set; }
        public virtual ICollection<OrderStatusLogs> OrderStatusLogs { get; set; }
        public virtual ICollection<RecurringPayment> RecurringPayment { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
