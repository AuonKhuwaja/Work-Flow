using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Flow.Domain.Domain
{
    public class Users
    {
        [Key]
        public int User_ID { get; set; }
        public string username { get; set; } = "";
      
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        //public string PhoneNumber { get; set; } = "";
        //public DateTime? CreatedAt { get; set; }
        //public DateTime? UpdatedAt { get; set; }
        //public bool? flgActive { get; set; }

        //public bool? flgDelete { get; set; }
    }
}
