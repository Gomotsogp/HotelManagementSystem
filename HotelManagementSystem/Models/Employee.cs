using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }
        public string Province { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
