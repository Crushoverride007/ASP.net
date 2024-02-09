using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace WebApplication1.Models
{
    [Index("Email",IsUnique = true)]
    public class PasswordReset
    {
        public int Id { get; set;}
        public string Email { get; set; } = "";
        public string Token { get; set;} = "";
        public DateTime CreatedAt { get; set;} = DateTime.Now;

    }
}
