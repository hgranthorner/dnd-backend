using System;
namespace api.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int PlayerId { get; set; }
        public int RoomId { get; set; }
        public bool IsDead { get; set; }
    }
}
