using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace FifaSharp.Api.Models;

/// <summary>
/// The complete response from the FUT store purchase-group endpoint.
/// Unknown fields are retained through extension data so new EA fields remain
/// available without making an older client unable to read the store.
/// </summary>
public sealed class StorePurchaseGroups
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("purchase")]
    public List<StorePurchase> Purchases { get; set; } = [];

    [JsonPropertyName("packOddsAvailabilityState")]
    public string? PackOddsAvailabilityState { get; set; }

    [JsonPropertyName("previewEnabled")]
    public bool PreviewEnabled { get; set; }

    [JsonPropertyName("duplicatesEnabled")]
    public bool DuplicatesEnabled { get; set; }

    [JsonPropertyName("storeRecommendations")]
    public StoreRecommendations? StoreRecommendations { get; set; }

    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalFields { get; set; }
}

public sealed class StorePurchase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("assetId")]
    public int AssetId { get; set; }

    [JsonPropertyName("nameLoc")]
    public string? Name { get; set; }

    [JsonPropertyName("descriptionLoc")]
    public string? LocalizedDescription { get; set; }

    [JsonPropertyName("coins")]
    public long? Coins { get; set; }

    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("metadataQuantity")]
    public int MetadataQuantity { get; set; }

    [JsonPropertyName("points")]
    public long? Points { get; set; }

    [JsonPropertyName("bonus")]
    public long? Bonus { get; set; }

    [JsonPropertyName("currencies")]
    public List<StoreCurrency> Currencies { get; set; } = [];

    [JsonPropertyName("categoryList")]
    public List<StoreCategory> Categories { get; set; } = [];

    [JsonPropertyName("saleType")]
    public string? SaleType { get; set; }

    [JsonPropertyName("dealType")]
    public string? DealType { get; set; }

    [JsonPropertyName("customAttribute")]
    public string? CustomAttribute { get; set; }

    [JsonPropertyName("saleId")]
    public long SaleId { get; set; }

    [JsonPropertyName("displayGroup")]
    public StoreDisplayGroup? DisplayGroup { get; set; }

    [JsonPropertyName("sortPriority")]
    public int SortPriority { get; set; }

    [JsonPropertyName("purchaseLimit")]
    public int PurchaseLimit { get; set; }

    [JsonPropertyName("purchaseCount")]
    public int PurchaseCount { get; set; }

    [JsonPropertyName("isPremium")]
    public bool IsPremium { get; set; }

    [JsonPropertyName("isSeasonTicketDiscount")]
    public bool IsSeasonTicketDiscount { get; set; }

    [JsonPropertyName("isPurchaseUsingFCPointsOptionRestricted")]
    public bool IsPurchaseUsingFcPointsOptionRestricted { get; set; }

    [JsonPropertyName("isSegmented")]
    public bool IsSegmented { get; set; }

    [JsonPropertyName("visible")]
    public int Visible { get; set; }

    [JsonPropertyName("useDefaultImage")]
    public bool UseDefaultImage { get; set; }

    [JsonPropertyName("purchaseMethod")]
    public string? PurchaseMethod { get; set; }

    [JsonPropertyName("displayGroupAssetId")]
    public int DisplayGroupAssetId { get; set; }

    [JsonPropertyName("lastPurchasedTime")]
    public long LastPurchasedTime { get; set; }

    [JsonPropertyName("displayGroupUseDefaultImage")]
    public bool DisplayGroupUseDefaultImage { get; set; }

    [JsonPropertyName("unopened")]
    public bool Unopened { get; set; }

    [JsonPropertyName("packType")]
    public string? PackType { get; set; }

    [JsonPropertyName("packContentInfo")]
    public StorePackContentInfo? PackContentInfo { get; set; }

    [JsonPropertyName("packOdds")]
    public List<StorePackOdd> PackOdds { get; set; } = [];

    [JsonPropertyName("globalAvailableQuantity")]
    public long? GlobalAvailableQuantity { get; set; }

    [JsonPropertyName("untradeable")]
    public bool Untradeable { get; set; }

    [JsonPropertyName("subArticleId")]
    public int SubArticleId { get; set; }

    [JsonPropertyName("isPreviewable")]
    public bool IsPreviewable { get; set; }

    [JsonPropertyName("isPlayerPickPack")]
    public bool IsPlayerPickPack { get; set; }

    [JsonPropertyName("guidAssetId")]
    public string? GuidAssetId { get; set; }

    [JsonPropertyName("fcCashPrice")]
    public long? FcCashPrice { get; set; }

    [JsonPropertyName("firstPartyStoreId")]
    public long? FirstPartyStoreId { get; set; }

    [JsonPropertyName("halId")]
    public int? HalId { get; set; }

    [JsonPropertyName("extPrice")]
    public StoreExternalPrice? ExternalPrice { get; set; }

    [JsonPropertyName("start")]
    public long? Start { get; set; }

    [JsonPropertyName("end")]
    public long? End { get; set; }

    [JsonPropertyName("secondsUntilStart")]
    public long? SecondsUntilStart { get; set; }

    [JsonPropertyName("secondsUntilEnd")]
    public long? SecondsUntilEnd { get; set; }

    [JsonPropertyName("duration")]
    public long? Duration { get; set; }

    [JsonPropertyName("remaining")]
    public long? Remaining { get; set; }

    [JsonPropertyName("availableQuantity")]
    public long? AvailableQuantity { get; set; }

    [JsonPropertyName("bundleItems")]
    public List<StoreBundleItem> BundleItems { get; set; } = [];

    [JsonPropertyName("eventTokenPrice")]
    public long? EventTokenPrice { get; set; }

    [JsonPropertyName("eventTokenBundleItemInfo")]
    public JsonElement? EventTokenBundleItemInfo { get; set; }

    // Keep newly introduced EA fields available without making this model depend on them.
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalFields { get; set; }
}

public sealed class StoreCurrency
{
    [JsonPropertyName("funds")]
    public long Funds { get; set; }

    [JsonPropertyName("finalFunds")]
    public long FinalFunds { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public sealed class StoreCategory
{
    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }

    [JsonPropertyName("orderInCategory")]
    public int OrderInCategory { get; set; }
}

public sealed class StoreDisplayGroup
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }
}

public sealed class StorePackContentInfo
{
    [JsonPropertyName("itemQuantity")]
    public int ItemQuantity { get; set; }

    [JsonPropertyName("goldQuantity")]
    public int GoldQuantity { get; set; }

    [JsonPropertyName("silverQuantity")]
    public int SilverQuantity { get; set; }

    [JsonPropertyName("bronzeQuantity")]
    public int BronzeQuantity { get; set; }

    [JsonPropertyName("rareQuantity")]
    public int RareQuantity { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }
}

public sealed class StorePackOdd
{
    [JsonPropertyName("packId")]
    public int PackId { get; set; }

    [JsonPropertyName("tierId")]
    public int TierId { get; set; }

    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }

    [JsonPropertyName("startTimeSec")]
    public long StartTimeSec { get; set; }

    [JsonPropertyName("oddsFormatted")]
    public string? OddsFormatted { get; set; }

    [JsonPropertyName("playerCount")]
    public int PlayerCount { get; set; }

    [JsonPropertyName("packOddsCategory")]
    public StorePackOddsCategory? Category { get; set; }
}

public sealed class StorePackOddsCategory
{
    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }

    [JsonPropertyName("tierId")]
    public int TierId { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("qualityId")]
    public int QualityId { get; set; }

    [JsonPropertyName("rarityAssetId")]
    public int? RarityAssetId { get; set; }

    [JsonPropertyName("packOddsRules")]
    public List<StorePackOddsRule> Rules { get; set; } = [];
}

public sealed class StorePackOddsRule
{
    [JsonPropertyName("tierId")]
    public int TierId { get; set; }

    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }

    [JsonPropertyName("ruleType")]
    public int RuleType { get; set; }

    [JsonPropertyName("ruleValue")]
    public int RuleValue { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}

public sealed class StoreBundleItem
{
    [JsonPropertyName("bundleItemType")]
    public string? BundleItemType { get; set; }

    [JsonPropertyName("amount")]
    public long? Amount { get; set; }

    [JsonPropertyName("itemData")]
    public JsonElement? ItemData { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("resourceId")]
    public long ResourceId { get; set; }

    [JsonPropertyName("assetId")]
    public long AssetId { get; set; }

    [JsonPropertyName("itemType")]
    public string? ItemType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public sealed class StoreExternalPrice
{
    [JsonPropertyName("originalPrice")]
    public StoreExternalPriceDetails? OriginalPrice { get; set; }

    [JsonPropertyName("finalPrice")]
    public StoreExternalPriceDetails? FinalPrice { get; set; }
}

public sealed class StoreExternalPriceDetails
{
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    [JsonPropertyName("externalPriceId")]
    public long? ExternalPriceId { get; set; }

    [JsonPropertyName("sony")]
    public long? Sony { get; set; }

    [JsonPropertyName("ms")]
    public long? Microsoft { get; set; }

    [JsonPropertyName("pc")]
    public long? Pc { get; set; }

    [JsonPropertyName("apple")]
    public long? Apple { get; set; }

    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    [JsonPropertyName("externalEntitlement")]
    public string? ExternalEntitlement { get; set; }
}

public sealed class StoreRecommendations
{
    [JsonPropertyName("recommendationList")]
    public List<StoreRecommendation> Recommendations { get; set; } = [];

    [JsonPropertyName("trackingTag")]
    public string? TrackingTag { get; set; }
}

public sealed class StoreRecommendation
{
    [JsonPropertyName("packId")]
    public int PackId { get; set; }

    [JsonPropertyName("subArticleId")]
    public int SubArticleId { get; set; }

    [JsonPropertyName("score")]
    public double Score { get; set; }
}
