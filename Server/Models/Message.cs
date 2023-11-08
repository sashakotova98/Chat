using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Message
    {
        public int Id { get; set; }

        public int? ChatId { get; set; }
        [ForeignKey("ChatId")]

        public Chat? Chats { get; set; } 

        

        public string Text{ get; set; }

        public DateTime SendDate { get; set; }

        public bool IsDelivered { get; set; }




        public int SenderUserId { get; set; }
        [ForeignKey("SenderUserId")]

        public User Sender { get; set; } = null!;



        public int ReciverUserId { get; set; }

        [ForeignKey("ReciverUserId")]

        public User Receiver { get; set; } = null!;


    }
}
