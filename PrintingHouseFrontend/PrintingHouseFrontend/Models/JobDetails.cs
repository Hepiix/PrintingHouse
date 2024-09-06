using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models;

public class JobDetails
{
    public int Id { get; set; }
    [Required]
    [StringLength(30)]
    public required string Name { get; set; }
    [Required]
    [StringLength(30)]
    public required string Pattern { get; set; }
}
