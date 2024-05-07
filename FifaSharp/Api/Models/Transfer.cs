using System.Text.Json.Serialization;
using static FifaSharp.Api.Models.TradePile;

namespace FifaSharp.Api.Models;

public class Transfer
{
    [JsonPropertyName("tradeId")]
    public long TradeId { get; set; }

    [JsonPropertyName("itemData")]
    public PlayerData ItemData { get; set; } = default!;

    [JsonPropertyName("tradeState")]
    public string TradeState { get; set; } = default!;

    [JsonPropertyName("buyNowPrice")]
    public int BuyNowPrice { get; set; }

    [JsonPropertyName("currentBid")]
    public int CurrentBid { get; set; }

    [JsonPropertyName("offers")]
    public int Offers { get; set; }

    [JsonPropertyName("watched")]
    public bool Watched { get; set; }

    [JsonPropertyName("bidState")]
    public string BidState { get; set; } = default!;

    [JsonPropertyName("startingBid")]
    public int StartingBid { get; set; }

    [JsonPropertyName("confidenceValue")]
    public int ConfidenceValue { get; set; }

    /// <summary>
    /// Seconds left until the listing expires.
    /// </summary>
    [JsonPropertyName("expires")]
    public int ExpiresIn { get; set; }

    [JsonPropertyName("sellerName")]
    public string SellerName { get; set; } = default!; 

    [JsonPropertyName("sellerEstablished")]
    public int SellerEstablished { get; set; }

    [JsonPropertyName("sellerId")]
    public int SellerId { get; set; }

    [JsonPropertyName("tradeOwner")]
    public bool? TradeOwner { get; set; }

    [JsonPropertyName("tradeIdStr")]
    public string TradeIdStr { get; set; } = default!;
}
