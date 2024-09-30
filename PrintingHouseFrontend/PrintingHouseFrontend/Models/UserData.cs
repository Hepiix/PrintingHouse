using System.ComponentModel.DataAnnotations;

namespace PrintingHouseFrontend.Models
{
    public class UserData
    {
        [Required(ErrorMessage = "email is required.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "password is required.")]
        public string? Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
