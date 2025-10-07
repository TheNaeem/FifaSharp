using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaSharp.Api.Enums;

public enum FutItemType
{
    Player
}

public static class FutItemTypeExtensions
{
    public static string GetString(this FutItemType item)
        => item switch
        {
            FutItemType.Player => "player",
            _ => "player"
        };
}
