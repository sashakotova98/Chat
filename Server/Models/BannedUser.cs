using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class BannedUser
    {
        public int Id { get; set; }
        public int BannedUserId { get; set; }

        [ForeignKey("BannedUserId")]

        public User BanUser { get; set; } = null!;

    }
}
