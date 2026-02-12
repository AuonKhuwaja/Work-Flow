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
            public int User_ID { get; set; } = 1;
            public string username { get; set; } = "Auon Khuwaja";
      
            public string Email { get; set; } = "aoun.khuwaja@hrsgonine.com";
            public string PasswordHash { get; set; } = "1234";
            public string Role { get; set; } = "Admin";
      
        }
}
