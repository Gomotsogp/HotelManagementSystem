using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNo { get; set; }
        public DateTime ExpireDate { get; set; }
       

    }
}
