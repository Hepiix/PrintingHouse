namespace PrintingHouseBackend.Models;

public class JobDetails
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Pattern { get; set; }
    public string? PaperType { get; set; }
    public string? Dimensions { get; set; }
    public string? ColorMode { get; set; }
    public string? PrintSides { get; set; } 
    public decimal UnitPrice { get; set; }
}