using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Domain;
using Work_Flow.Domain.Interfaces.Repositories;

namespace Work_Flow.Application.Implementation.Services
{
    public class BoardMemberServices : IBoardMemberServices
    {
        private readonly IBoardMembersRepo _boardMembersrepo;
        public BoardMemberServices(IBoardMembersRepo boardMembersrepo)
        {
            _boardMembersrepo = boardMembersrepo;  
                
        }
        public async Task Delete(int userid, int boardid)
        {
           await _boardMembersrepo.DeleteMemberAsync(userid, boardid);
        }

        public async Task<List<BoardMembers>> GetBoardMemberByBoardID(int boardid)
        {
           return await _boardMembersrepo.GetBoardMembersAsync(boardid);
        }

        public async Task Insert(BoardMembers board)
        {
           await _boardMembersrepo.AddMemberAsync(board);
        }

        public async Task Update(int boardid, int userId, string role)
        {
           await _boardMembersrepo.UpdateRoleAsync(boardid, userId, role);
        }
    }
}
