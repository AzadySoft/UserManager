using System;

namespace AzadiSoft.UserManager.WebUI.Models
{
    
    
    public class ProductModel
    {
        public int ReservedQuantity { get; set; }

        public object[] ProductAttributeCombinationModels { get; set; }

        public int ProductGroupId { get; set; }

        public object[] ProductGroupListItems { get; set; }

        public int Id { get; set; }

        public string PictureThumbnailUrl { get; set; }

        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public int AssociatedToProductId { get; set; }

        public object AssociatedToProductName { get; set; }

        public bool VisibleIndividually { get; set; }

        public int ProductTemplateId { get; set; }

        public object[] AvailableProductTemplates { get; set; }

        public string Name { get; set; }

        public object ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public object AdminComment { get; set; }

        public bool ShowOnHomePage { get; set; }

        public object MetaKeywords { get; set; }

        public object MetaDescription { get; set; }

        public object MetaTitle { get; set; }

        public string SeName { get; set; }

        public bool AllowCustomerReviews { get; set; }

        public object ProductTags { get; set; }

        public string Sku { get; set; }

        public object ManufacturerPartNumber { get; set; }

        public object Gtin { get; set; }

        public bool IsGiftCard { get; set; }

        public int GiftCardTypeId { get; set; }

        public object OverriddenGiftCardAmount { get; set; }

        public bool RequireOtherProducts { get; set; }

        public object RequiredProductIds { get; set; }

        public bool AutomaticallyAddRequiredProducts { get; set; }

        public bool IsDownload { get; set; }

        public int DownloadId { get; set; }

        public bool UnlimitedDownloads { get; set; }

        public int MaxNumberOfDownloads { get; set; }

        public object DownloadExpirationDays { get; set; }

        public int DownloadActivationTypeId { get; set; }

        public bool HasSampleDownload { get; set; }

        public int SampleDownloadId { get; set; }

        public bool HasUserAgreement { get; set; }

        public object UserAgreementText { get; set; }

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

        public float AdditionalShippingCharge { get; set; }

        public int DeliveryDateId { get; set; }

        public object[] AvailableDeliveryDates { get; set; }

        public bool IsTaxExempt { get; set; }

        public int TaxCategoryId { get; set; }

        public object[] AvailableTaxCategories { get; set; }

        public bool IsTelecommunicationsOrBroadcastingOrElectronicServices { get; set; }

        public int ManageInventoryMethodId { get; set; }


        public bool UseMultipleWarehouses { get; set; }

        public int WarehouseId { get; set; }

        public object[] AvailableWarehouses { get; set; }

        public int StockQuantity { get; set; }

        public int LastStockQuantity { get; set; }

        public string StockQuantityStr { get; set; }

        public bool DisplayStockAvailability { get; set; }

        public bool DisplayStockQuantity { get; set; }

        public int MinStockQuantity { get; set; }

        public int LowStockActivityId { get; set; }

        public int NotifyAdminForQuantityBelow { get; set; }

        public int BackorderModeId { get; set; }

        public bool AllowBackInStockSubscriptions { get; set; }

        public int OrderMinimumQuantity { get; set; }

        public int OrderMaximumQuantity { get; set; }

        public object AllowedQuantities { get; set; }

        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }

        public bool NotReturnable { get; set; }

        public bool DisableBuyButton { get; set; }

        public bool DisableWishlistButton { get; set; }

        public bool AvailableForPreOrder { get; set; }

        public object PreOrderAvailabilityStartDateTimeUtc { get; set; }

        public bool CallForPrice { get; set; }

        public float Price { get; set; }

        public float OldPrice { get; set; }

        public float ProductCost { get; set; }

        public float? SpecialPrice { get; set; }

        public string SpecialPriceStartDateTimeUtc { get; set; }

        public string SpecialPriceEndDateTimeUtc { get; set; }

        public bool CustomerEntersPrice { get; set; }

        public float MinimumCustomerEnteredPrice { get; set; }

        public float MaximumCustomerEnteredPrice { get; set; }

        public bool BasepriceEnabled { get; set; }

        public float BasepriceAmount { get; set; }

        public int BasepriceUnitId { get; set; }

        public object[] AvailableBasepriceUnits { get; set; }

        public float BasepriceBaseAmount { get; set; }

        public int BasepriceBaseUnitId { get; set; }

        public object[] AvailableBasepriceBaseUnits { get; set; }

        public bool MarkAsNew { get; set; }

        public object MarkAsNewStartDateTimeUtc { get; set; }

        public object MarkAsNewEndDateTimeUtc { get; set; }

        public float Weight { get; set; }

        public float Length { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public object AvailableStartDateTimeUtc { get; set; }

        public object AvailableEndDateTimeUtc { get; set; }

        public int DisplayOrder { get; set; }

        public bool Published { get; set; }

        public object CreatedOn { get; set; }

        public object UpdatedOn { get; set; }

        public object PrimaryStoreCurrencyCode { get; set; }

        public object BaseDimensionIn { get; set; }

        public object BaseWeightIn { get; set; }

        public object[] Locales { get; set; }

        public object[] SelectedCustomerRoleIds { get; set; }

        public object[] AvailableCustomerRoles { get; set; }

        public object[] SelectedStoreIds { get; set; }

        public object[] AvailableStores { get; set; }

        public object[] SelectedCategoryIds { get; set; }

        public object[] AvailableCategories { get; set; }

        public object[] SelectedManufacturerIds { get; set; }

        public object[] AvailableManufacturers { get; set; }

        public int VendorId { get; set; }

        public object[] AvailableVendors { get; set; }

        public object[] SelectedDiscountIds { get; set; }

        public object[] AvailableDiscounts { get; set; }

        public bool IsLoggedInAsVendor { get; set; }

        public object[] AvailableProductAttributes { get; set; }

        public Addpicturemodel AddPictureModel { get; set; }

        public object[] ProductPictureModels { get; set; }

        public Addspecificationattributemodel AddSpecificationAttributeModel { get; set; }

        public object[] ProductWarehouseInventoryModels { get; set; }

        public Copyproductmodel CopyProductModel { get; set; }

        public Producteditorsettingsmodel ProductEditorSettingsModel { get; set; }

        public Customproperties4 CustomProperties { get; set; }
    }



    public class Addpicturemodel
    {
        public int ProductId { get; set; }
        public int PictureId { get; set; }
        public object PictureUrl { get; set; }
        public int DisplayOrder { get; set; }
        public object OverrideAltAttribute { get; set; }
        public object OverrideTitleAttribute { get; set; }
        public int Id { get; set; }
        public Customproperties CustomProperties { get; set; }
    }

    public class Customproperties
    {
    }

    public class Addspecificationattributemodel
    {
        public int SpecificationAttributeId { get; set; }
        public int AttributeTypeId { get; set; }
        public int SpecificationAttributeOptionId { get; set; }
        public object CustomValue { get; set; }
        public bool AllowFiltering { get; set; }
        public bool ShowOnProductPage { get; set; }
        public int DisplayOrder { get; set; }
        public object[] AvailableAttributes { get; set; }
        public object[] AvailableOptions { get; set; }
        public Customproperties1 CustomProperties { get; set; }
    }

    public class Customproperties1
    {
    }

    public class Copyproductmodel
    {
        public object Name { get; set; }
        public bool CopyImages { get; set; }
        public bool Published { get; set; }
        public int Id { get; set; }
        public Customproperties2 CustomProperties { get; set; }
    }

    public class Customproperties2
    {
    }

    public class Producteditorsettingsmodel
    {
        public bool ProductGroup { get; set; }
        public bool AttributeCombinations { get; set; }
        public bool Id { get; set; }
        public bool ProductType { get; set; }
        public bool VisibleIndividually { get; set; }
        public bool ProductTemplate { get; set; }
        public bool AdminComment { get; set; }
        public bool Vendor { get; set; }
        public bool Stores { get; set; }
        public bool ACL { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool DisplayOrder { get; set; }
        public bool AllowCustomerReviews { get; set; }
        public bool ProductTags { get; set; }
        public bool ManufacturerPartNumber { get; set; }
        public bool GTIN { get; set; }
        public bool ProductCost { get; set; }
        public bool SpecialPrice { get; set; }
        public bool SpecialPriceStartDate { get; set; }
        public bool SpecialPriceEndDate { get; set; }
        public bool TierPrices { get; set; }
        public bool Discounts { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool DisableWishlistButton { get; set; }
        public bool AvailableForPreOrder { get; set; }
        public bool CallForPrice { get; set; }
        public bool OldPrice { get; set; }
        public bool CustomerEntersPrice { get; set; }
        public bool PAngV { get; set; }
        public bool RequireOtherProductsAddedToTheCart { get; set; }
        public bool IsGiftCard { get; set; }
        public bool DownloadableProduct { get; set; }
        public bool RecurringProduct { get; set; }
        public bool IsRental { get; set; }
        public bool FreeShipping { get; set; }
        public bool ShipSeparately { get; set; }
        public bool AdditionalShippingCharge { get; set; }
        public bool DeliveryDate { get; set; }
        public bool TelecommunicationsBroadcastingElectronicServices { get; set; }
        public bool UseMultipleWarehouses { get; set; }
        public bool Warehouse { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public bool DisplayStockQuantity { get; set; }
        public bool MinimumStockQuantity { get; set; }
        public bool LowStockActivity { get; set; }
        public bool NotifyAdminForQuantityBelow { get; set; }
        public bool Backorders { get; set; }
        public bool AllowBackInStockSubscriptions { get; set; }
        public bool MinimumCartQuantity { get; set; }
        public bool MaximumCartQuantity { get; set; }
        public bool AllowedQuantities { get; set; }
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }
        public bool NotReturnable { get; set; }
        public bool Weight { get; set; }
        public bool Dimensions { get; set; }
        public bool AvailableStartDate { get; set; }
        public bool AvailableEndDate { get; set; }
        public bool MarkAsNew { get; set; }
        public bool MarkAsNewStartDate { get; set; }
        public bool MarkAsNewEndDate { get; set; }
        public bool Published { get; set; }
        public bool CreatedOn { get; set; }
        public bool UpdatedOn { get; set; }
        public bool RelatedProducts { get; set; }
        public bool CrossSellsProducts { get; set; }
        public bool Seo { get; set; }
        public bool PurchasedWithOrders { get; set; }
        public bool OneColumnProductPage { get; set; }
        public bool ProductAttributes { get; set; }
        public bool SpecificationAttributes { get; set; }
        public bool Manufacturers { get; set; }
        public Customproperties3 CustomProperties { get; set; }
    }

    public class Customproperties3
    {
    }

    public class Customproperties4
    {
    }

}