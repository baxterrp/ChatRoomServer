using System;
using System.ComponentModel.DataAnnotations;

namespace Chatroom.Server.Models
{
    public class Room
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int MaxAllowedGuests { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public string OwnerId { get; set; }
    }
}
