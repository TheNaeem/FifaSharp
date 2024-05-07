using System.Net;
using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;

public class BidResult
{
    public BidResult() { }

    public BidResult(HttpStatusCode statusCode)
    {
        this.StatusCode = statusCode;
    }
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

    [JsonPropertyName("credits")]
    public int Credits { get; set; }

    [JsonPropertyName("auctionInfo")]
    public Transfer[] Transfers { get; set; } = default!;

    [JsonPropertyName("bidTokens")]
    public object? BidTokens { get; set; } = default!;

    [JsonPropertyName("currencies")]
    public Currency[] Currencies { get; set; } = default!;

    [JsonPropertyName("dynamicObjectivesUpdates")]
    public ObjectiveStatuses DynamicObjectivesUpdates { get; set; } = default!;

    public class ObjectiveStatuses
    {
        [JsonPropertyName("needsGroupsRefresh")]
        public bool NeedsGroupsRefresh { get; set; }

        [JsonPropertyName("learningGroupProgressList")]
        public LearningGroupProgress[] LearningGroupProgressList { get; set; } = default!;

        [JsonPropertyName("needsAutoClaim")]
        public bool needsAutoClaim { get; set; }

        [JsonPropertyName("needsMilestonesAutoClaim")]
        public bool needsMilestonesAutoClaim { get; set; }
    }

    public class LearningGroupProgress
    {
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("scmpGroupProgressList")]
        public GroupProgress[] ScmpGroupProgressList { get; set; } = default!;
    }

    public class GroupProgress
    {
        [JsonPropertyName("groupId")]
        public int GroupId { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("objectiveProgressList")]
        public ObjectiveProgress[] ObjectiveProgressList { get; set; } = default!;

        [JsonPropertyName("groupType")]
        public int GroupType { get; set; }
    }

    public class ObjectiveProgress
    {
        [JsonPropertyName("objectiveId")]
        public int ObjectiveId { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("progressCount")]
        public int ProgressCount { get; set; }
    }


    public class Currency
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("funds")]
        public int Funds { get; set; }

        [JsonPropertyName("finalFunds")]
        public int FinalFunds { get; set; }
    }
}

