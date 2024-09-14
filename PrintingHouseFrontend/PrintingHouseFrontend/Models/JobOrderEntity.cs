using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models;

public class JobOrderEntity
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Customer is required.")]
    public int CustomerId { get; set; }
    [Required(ErrorMessage = "Job details are required.")]
    public int JobDetailsId { get; set; }
    [Required(ErrorMessage = "Order date is required.")]
    public DateOnly OrderDate { get; set; }
    public bool Status { get; set; }
}
