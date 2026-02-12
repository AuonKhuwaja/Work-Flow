using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Application.Interfaces.Repositories
{
    public interface IAccountRepo
    {
        public Users LoginAccount();

    }
}
