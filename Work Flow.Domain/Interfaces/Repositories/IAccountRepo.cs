using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Flow.Application.Interfaces.Repositories
{
    public interface IAccountRepo
    {
        Task<Users> LoginAccountAsync();
    }
}
