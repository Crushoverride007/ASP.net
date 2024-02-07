using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = ""; // unique in the database
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
