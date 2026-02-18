using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Work_Flow.Domain.Domain
{
    public class BoardLists
    {
        [Key]
        public int Id { get; set; }

        public int BoardId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // ensure EF maps to the DB column named "Order"
        [Column("Order")]
        public int Order { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        // made nullable because your SQL didn't include these columns
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
