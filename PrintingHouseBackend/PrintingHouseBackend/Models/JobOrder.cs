namespace PrintingHouseBackend.Models;

public class JobOrder
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public int JobDetailsId { get; set; }
    public JobDetails? JobDetails { get; set; }
    public DateOnly OrderDate { get; set; }
    public bool Status { get; set; }
}
