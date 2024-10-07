using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models;

public class JobDetails
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(30, ErrorMessage = "Name cannot exceed 30 characters.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Pattern is required.")]
    [StringLength(30, ErrorMessage = "Pattern cannot exceed 30 characters.")]
    public required string Pattern { get; set; }

    [Required(ErrorMessage = "Paper Type is required.")]
    public required string PaperType { get; set; }

    [Required(ErrorMessage = "Dimensions are required.")]
    public required string Dimensions { get; set; }

    [Required(ErrorMessage = "Color Mode is required.")]
    public required string ColorMode { get; set; }

    [Required(ErrorMessage = "Print Sides are required.")]
    public required string PrintSides { get; set; }

    [Required(ErrorMessage = "Unit Price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Unit Price must be greater than zero.")]
    public required decimal UnitPrice { get; set; }
}
