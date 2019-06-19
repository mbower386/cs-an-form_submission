using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength (3, ErrorMessage="First name must have at least 3 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MinLength (3, ErrorMessage="Last name must have at least 3 characters.")]
        public string LastName { get; set; }

        [Required]
        [Range (0, 999, ErrorMessage="Please enter a valid age.")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType (DataType.Password)]
        [MinLength (8, ErrorMessage="Password must have at least 8 characters.")]
        public string Password { get; set; }
    }
}