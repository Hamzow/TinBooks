using System.ComponentModel.DataAnnotations;

namespace TinBooks.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Lösenord bör lagras som en hash

        public string Role { get; set; } // T.ex. "Admin" eller "User"
    }
}