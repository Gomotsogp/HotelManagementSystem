using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Customer
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
        [ForeignKey("FK_PaymentId")]
        public int PaymentId { get; set; }
        [ForeignKey("FK_BookingId")]
        public int BookingId { get; set; }
        public Payment Payment { get; set; }
        public Booking Booking { get; set; }
    }
}
