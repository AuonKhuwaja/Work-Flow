using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Flow.Domain.Domain
{
    public class MoveCardDto
    {
        public int CardId { get; set; }
        public int TargetListId { get; set; }
        public int TargetPosition { get; set; }
    }
}
