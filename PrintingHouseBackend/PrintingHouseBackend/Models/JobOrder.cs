namespace PrintingHouseBackend.Models;

public class JobOrder
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public int JobDetailsId { get; set; }
    public JobDetails? JobDetails { get; set; }
    public DateOnly OrderDate { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public string? Status { get; set; } = "Pending";
    public string? DeliveryMethod { get; set; } = "Courier";
    public string CustomerNote { get; set; }
}