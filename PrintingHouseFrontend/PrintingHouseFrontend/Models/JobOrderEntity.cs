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
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateOnly OrderDate { get; set; }

    [Required(ErrorMessage = "Status is required.")]
    public string? Status { get; set; }

    [Required(ErrorMessage = "Delivery Method is required.")]
    public string? DeliveryMethod { get; set; }
}
