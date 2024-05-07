using System.Text.Json.Serialization;

namespace FifaSharp.Api.Models;


public class IdentityWrapper
{
    [JsonPropertyName("pid")]
    public Identity Pid { get; set; } = default!;
}

public class Identity
{
    [JsonPropertyName("externalRefType")]
    public string ExternalRefType { get; set; } = default!;

    [JsonPropertyName("externalRefValue")]
    public string ExternalRefValue { get; set; } = default!;

    [JsonPropertyName("pidId")]
    public long PidId { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; } = default!;

    [JsonPropertyName("emailStatus")]
    public string EmailStatus { get; set; } = default!;

    [JsonPropertyName("strength")]
    public string Strength { get; set; } = default!;

    [JsonPropertyName("dob")]
    public string DateOfBirth { get; set; } = default!;

    [JsonPropertyName("country")]
    public string Country { get; set; } = default!;

    [JsonPropertyName("language")]
    public string Language { get; set; } = default!;

    [JsonPropertyName("locale")]
    public string Locale { get; set; } = default!;

    [JsonPropertyName("status")]
    public string Status { get; set; } = default!;

    [JsonPropertyName("reasonCode")]
    public string ReasonCode { get; set; } = default!;

    [JsonPropertyName("tosVersion")]
    public string TosVersion { get; set; } = default!;

    [JsonPropertyName("parentalEmail")]
    public string ParentalEmail { get; set; } = default!;

    [JsonPropertyName("thirdPartyOptin")]
    public string ThirdPartyOptin { get; set; } = default!;

    [JsonPropertyName("globalOptin")]
    public string GlobalOptIn { get; set; } = default!;

    [JsonPropertyName("dateCreated")]
    public string DateCreated { get; set; } = default!;

    [JsonPropertyName("dateModified")]
    public string DateModified { get; set; } = default!;

    [JsonPropertyName("lastAuthDate")]
    public string LastAuthDate { get; set; } = default!;

    [JsonPropertyName("registrationSource")]
    public string RegistrationSource { get; set; } = default!;

    [JsonPropertyName("authenticationSource")]
    public string AuthenticationSource { get; set; } = default!;

    [JsonPropertyName("showEmail")]
    public string ShowEmail { get; set; } = default!;

    [JsonPropertyName("discoverableEmail")]
    public string DiscoverableEmail { get; set; } = default!;

    [JsonPropertyName("anonymousPid")]
    public string AnonymousPid { get; set; } = default!;

    [JsonPropertyName("underagePid")]
    public string UnderagePid { get; set; } = default!;

    [JsonPropertyName("defaultBillingAddressUri")]
    public string DefaultBillingAddressUri { get; set; } = default!;

    [JsonPropertyName("defaultShippingAddressUri")]
    public string DefaultShippingAddressUri { get; set; } = default!;

    [JsonPropertyName("passwordSignature")]
    public int PasswordSignature { get; set; }
}