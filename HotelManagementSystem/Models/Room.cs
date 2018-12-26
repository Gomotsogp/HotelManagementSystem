using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public RoomType RoomType { get; set; }
    }
}
