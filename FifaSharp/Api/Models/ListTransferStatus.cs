using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShadeSniper.FifaSharp.FifaSharp.Api.Models;

public class ListTransferStatus
{
    public ListTransferStatus() { }

    public ListTransferStatus(HttpStatusCode statusCode)
    {
        this.StatusCode = statusCode;
    }

    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("idStr")]
    public string IdString { get; set; } = default!;

    [JsonPropertyName("dynamicObjectivesUpdates")]
    public ObjectiveUpdates DynamicObjectivesUpdates { get; set; } = default!;

    public class ObjectiveUpdates
    {
        [JsonPropertyName("needsGroupsRefresh")]
        public bool NeedsGroupsRefresh { get; set; }

        [JsonPropertyName("needsAutoClaim")]
        public bool NeedsAutoClaim { get; set; }

        [JsonPropertyName("needsMilestonesAutoClaim")]
        public bool NeedsMilestonesAutoClaim { get; set; }
    }
}
