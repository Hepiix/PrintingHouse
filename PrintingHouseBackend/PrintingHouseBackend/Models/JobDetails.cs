namespace PrintingHouseBackend.Models;

public class JobDetails
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Pattern { get; set; }
}
