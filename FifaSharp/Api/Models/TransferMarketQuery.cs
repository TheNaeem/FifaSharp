using FifaSharp.Api.Enums;

namespace FifaSharp.Api.Models;

public class TransferMarketQuery
{
    /// <summary>
    /// Max bid amount.
    /// </summary>
    public int? MaxBid { get; set; }

    /// <summary>
    /// Min bid amount.
    /// </summary>
    public int? MinBid { get; set; }

    /// <summary>
    /// Max buy now amount.
    /// </summary>
    public int? MaxBuyNow { get; set; }

    /// <summary>
    /// Minimum buy now amount.
    /// </summary>
    public int? MinBuyNow { get; set; }

    /// <summary>
    /// Card quality
    /// </summary>
    public string? Quality { get; set; }

    public string? Zone { get; set; }

    public int? Nationality { get; set; }
    public int? League { get; set; }
    public int? Club { get; set; }

    public int? ItemId { get; set; }

    public string? Position { get; set; }

    /// <summary>
    /// Id of the rarity you're searching for. String support in the future.
    /// </summary>
    public int? RarityId { get; set; }

    /// <summary>
    /// From the results, this dictates where it will start. Used for displaying multiple pages of transfers.
    /// </summary>
    public int? ResultsStart { get; set; } = 0;

    /// <summary>
    /// The max amount of results to be shown.
    /// </summary>
    public int ResultsNum { get; set; } = 21;

    /// <summary>
    /// The type of item you're searching for.
    /// </summary>
    public FutItemType ItemType = FutItemType.Player;
}
