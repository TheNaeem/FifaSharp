using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;


public class TradePile
{
    /// <summary>
    /// Fifa Coins
    /// </summary>
    [JsonPropertyName("credits")]
    public int Credits { get; set; }

    [JsonPropertyName("auctionInfo")]
    public Transfer[] TransferList { get; set; } = default!;

    [JsonPropertyName("duplicateItemIdList")]
    public DuplicateItem[] Duplicates { get; set; } = default!;

    [JsonPropertyName("bidTokens")]
    public BidToken BidTokens { get; set; } = default!;

    public class BidToken // TODO:
    {
    }

    public class DuplicateItem
    {
        [JsonPropertyName("itemId")]
        public long ItemId { get; set; }
        [JsonPropertyName("duplicateItemId")]
        public long DuplicateItemId { get; set; }
    }
}
