using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Suburbs { get; set; }
        public string PostCode { get; set; }
        public string Province { get; set; }
        public int ManagerId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
