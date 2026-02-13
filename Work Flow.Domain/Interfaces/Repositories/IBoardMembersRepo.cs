using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;
using Work_Flow.Domain.Domain.Enums;

namespace Work_Flow.Domain.Interfaces.Repositories
{
    public interface IBoardMembersRepo
    {
        Task AddMemberAsync(BoardMembers board);

        Task<List<BoardMembers>> GetBoardMembersAsync(int boardid);
        Task DeleteMemberAsync(int userid, int boardid);
        Task UpdateRoleAsync(int boardid, int userId, string role);

    }
}
