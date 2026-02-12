using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Application.Common.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Users user);
    }
}
