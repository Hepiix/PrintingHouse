using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models;

public class Customer
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(30, ErrorMessage = "Name cannot exceed 30 characters.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Surname is required.")]
    [StringLength(50, ErrorMessage = "Surname cannot exceed 50 characters.")]
    public required string Surname { get; set; }

    [Required(ErrorMessage = "Company is required.")]
    [StringLength(100, ErrorMessage = "Company cannot exceed 100 characters.")]
    public required string Company { get; set; }

    [Required(ErrorMessage = "Phone Number is required.")]
    [StringLength(30, ErrorMessage = "Phone Number cannot exceed 30 characters.")]
    [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "Phone Number must be a valid number.")]
    public required string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Street Address is required.")]
    public required string StreetAddress { get; set; }

    [Required(ErrorMessage = "City is required.")]
    public required string City { get; set; }

    [Required(ErrorMessage = "State is required.")]
    public required string State { get; set; }

    [Required(ErrorMessage = "Postal Code is required.")]
    [StringLength(20, ErrorMessage = "Postal Code cannot exceed 20 characters.")]
    public required string PostalCode { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    public required string Country { get; set; }
}
