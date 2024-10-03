namespace PrintingHouseFrontend.Models;

public class JobOrderViewModel
{
    public int Id { get; set; }
    public required string CustomerName { get; set; }
    public required string JobName { get; set; }
    public DateOnly OrderDate { get; set; }
    public string? Status { get; set; }
    public string? DeliveryMethod { get; set; }
}
