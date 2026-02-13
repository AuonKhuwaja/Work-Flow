using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Application.Interfaces.Services
{
    
    public interface IBoardMemberServices
    {
        Task Insert(BoardMembers board);

        Task<List<BoardMembers>> GetBoardMemberByBoardID(int boardid);
        Task Delete(int userid, int boardid);
        Task Update(int boardid, int userId, string role);
    }
}
