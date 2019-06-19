using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength (3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength (3)]
        public string LastName { get; set; }

        [Required]
        [Range (0, 99)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType (DataType.Password)]
        [MinLength (8)]
        public string Password { get; set; }

        public User (string firstName, string lastName, int age, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Password = password;
        }
    }
}