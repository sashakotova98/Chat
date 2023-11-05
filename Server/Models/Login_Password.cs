using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class LoginPassword
    {
        [Key]
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
