namespace PrintingHouseBackend.Dtos;

public record class JobOrderDto
{
    public string? CustomerName { get; set; }
    public string? JobName { get; set; }
    public DateOnly OrderDate { get; set; }
    public bool Status { get; set; }
}
