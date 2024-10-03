using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models
{
    public class UserData
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }
    }
}
