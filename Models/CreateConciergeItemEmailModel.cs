namespace RazorLightDemo.Models;
public class CreateConciergeItemEmailModel
{
    public required int ConciergeItemId { get; set; } 
    public required string MemberName { get; set; } = string.Empty;

    public required DateTime DateCreated { get; set; }

    public required string ClientName { get; set; } = string.Empty;

    public required string ProgrammeName { get; set; } = string.Empty;

    public required string ConciergeItemLink { get; set; } = string.Empty;

    public required int SummaryID { get; set; }

    public required string SummaryLink { get; set; } = string.Empty;

    public required string ConciergeItemDetails { get; set; } = string.Empty;

    public required string SummaryNotes { get; set; } = string.Empty;
}
