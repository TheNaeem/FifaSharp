using FifaSharp.Api.Enums;

namespace FifaSharp.Api.Models;

public class EvoRequirement
{
    public AcademyEligibilityAttribute Attr { get; set; }
    public int Scope { get; set; }
    public int Value { get; set; }
}
