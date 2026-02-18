using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Flow.Domain.Domain
{
    public class Cards
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ListId { get; set; }

        public DateTime? DueDate { get; set; }

        public int Position { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

    }

}
