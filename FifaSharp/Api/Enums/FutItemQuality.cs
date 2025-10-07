using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaSharp.Api.Enums;

public enum FutItemQuality
{
    Bronze,
    Silver,
    Gold,
    Special
}

public static class FutItemQualityExtensions
{
    public static string GetString(this FutItemQuality? quality)
       => quality is null ? FutItemQuality.Gold.GetString() : ((FutItemQuality)quality).GetString();

    public static string GetString(this FutItemQuality quality)
        => quality switch
        {
            FutItemQuality.Bronze => "bronze",
            FutItemQuality.Silver => "silver",
            FutItemQuality.Gold => "gold",
            FutItemQuality.Special => "SP",
            _ => "gold"
       };
}
