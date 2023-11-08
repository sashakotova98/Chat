using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }

        public string? Chat_Name { get; set; }
    }
}
