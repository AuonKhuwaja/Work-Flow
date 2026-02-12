using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Application.Interfaces.Repositories;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public interface IAccountRepo
    {
        Task<Users> LoginAccountAsync();
    }

}
