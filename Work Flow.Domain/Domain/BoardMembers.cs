using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Flow.Domain.Domain
{
    public class BoardMembers
    {
        [Key]
        public int BoardId { get; set; }

        public int UserId { get; set; }

        public string Role { get; set; } = "";

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }


    }

}
