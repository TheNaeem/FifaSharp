using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadeSniper.FifaSharp.FifaSharp.Api.Schema;


public class ListItemBody
{
    public int buyNowPrice { get; set; }
    public int duration { get; set; }
    public ItemData itemData { get; set; }
    public int startingBid { get; set; }

    public class ItemData
    {
        public long id { get; set; }
    }
}

