using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models;

public class Customer
{
    public int Id { get; set; }
    [Required]
    [StringLength(30)]
    public required string Name { get; set; }
    [Required]
    [StringLength(50)]
    public required string Surname { get; set; }
    [Required]
    [StringLength(100)]
    public required string Company { get; set; }
    [Required]
    [StringLength(30)]
    public required string PhoneNumber { get; set; }
}
