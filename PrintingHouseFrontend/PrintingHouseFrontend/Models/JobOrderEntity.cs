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

    [Required(ErrorMessage = "Quantity is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
    public required int Quantity { get; set; }

    [Required(ErrorMessage = "Total Price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Total Price must be greater than zero.")]
    public required decimal TotalPrice { get; set; }

    [Required(ErrorMessage = "Status is required.")]
    public string? Status { get; set; }

    [Required(ErrorMessage = "Delivery Method is required.")]
    public string? DeliveryMethod { get; set; }

    public string CustomerNote { get; set; }
}
