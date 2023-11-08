using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public DateTime RegisteredDate { get; set; }

        public DateTime? BannedTo { get; set; }


        [ForeignKey(nameof(ChatId))]
        public Chat? Chat { get; set; }
        public int? ChatId { get; set; }


        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; } = null!;
        public int RoleId { get; set; }


        [ForeignKey(nameof(LoginUser))]
        public LoginPassword LoginPaasword { get; set; } = null!;
        public string LoginUser { get; set; } = null!;


    }
}
