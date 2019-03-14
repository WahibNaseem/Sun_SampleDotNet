using System.ComponentModel.DataAnnotations;

namespace SampleDotNet.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 8, MinimumLength = 4, ErrorMessage = "Password Should be between 4 to 8 characters")]
        public string Password { get; set; }
    }
}