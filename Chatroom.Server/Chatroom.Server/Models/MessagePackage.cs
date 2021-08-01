using System;
using System.ComponentModel.DataAnnotations;

namespace Chatroom.Server.Models
{
    public class MessagePackage
    {
        [Key]
        public string Id { get; set; }
        public string SenderId { get; set; }
        public string RoomId { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
