namespace RazorLightDemo.Models;
public class CreateConciergeItemEmailModel
{
    public string MemberName { get; set; } = string.Empty;

    public DateTime DateCreated { get; set; }

    public string ClientName { get; set; } = string.Empty;

    public string ProgrammeName { get; set; } = string.Empty;

    public string ConciergeItemLink { get; set; } = string.Empty;

    public string SummaryLink { get; set; } = string.Empty;

    public string ConciergeItemDetails { get; set; } = string.Empty;

    public string SummaryNotes { get; set; } = string.Empty;
}
