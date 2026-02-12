using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Flow.Domain.Domain
{
    public class Boards
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int CreatedById { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; } =true;

        public bool IsDeleted { get; set; } = false;
    }
}
