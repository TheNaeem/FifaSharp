using FifaSharp.Api.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaSharp.Api.Models;

public class ConceptsQuery
{
    public string? Position { get; set; }

    /// <summary>
    /// Set to "asc" to sort by ascending.
    /// </summary>
    public string Sort { get; set; } = "desc";
    public FutItemType Type { get; set; } = FutItemType.Player;
    public int Count { get; set; } = 50;
    public int Start { get; set; } = 0;
    public string? ItemId { get; set; }
    public int[]? RarityIds { get; set; }
    public FutItemQuality? Quality { get; set; }
    public int? NationId { get; set; }
    public int? LeagueId { get; set; }
    public int? TeamId { get; set; }

    public string BuildQuery()
    {
        var ret = new StringBuilder();

        ret.Append($"num={Count}&start={Start}&type={Type.GetString()}&sort={Sort}");

        if (!string.IsNullOrEmpty(Position))
            ret.Append($"&pos={Position}");

        if (!string.IsNullOrEmpty(ItemId))
            ret.Append($"&defId={ItemId}");

        if (NationId is not null)
            ret.Append($"&nation={NationId}");

        if (RarityIds is not null)
            ret.Append($"&rarityIds={string.Join(',', RarityIds)}");

        if (Quality is not null)
            if (Quality == FutItemQuality.Special)
                ret.Append($"&rare={Quality.GetString()}");
            else ret.Append($"&level={Quality.GetString()}");

        if (LeagueId is not null)
            ret.Append($"&league={LeagueId}");

        if (TeamId is not null)
            ret.Append($"&team={TeamId}");

        return ret.ToString();
    }
}
