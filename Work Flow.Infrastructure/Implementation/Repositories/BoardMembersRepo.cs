using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;
using Work_Flow.Domain.Domain.Enums;
using Work_Flow.Domain.Interfaces.Repositories;
using Work_Flow.Infrastructure.Data;

namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public class BoardMembersRepo : IBoardMembersRepo
    {
        private readonly AppDbContext _dbContext;
        public BoardMembersRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddMemberAsync(BoardMembers board)
        {
           await _dbContext.AddAsync(board);
           await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteMemberAsync(int userid, int boardid)
        {
           var data = await   _dbContext.BoardMembers.Where (x => x.BoardId == boardid && x.UserId == userid).FirstOrDefaultAsync();
            data.IsActive = false;
            data.IsDeleted = true;
            data.UpdatedAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();
          }

        public async Task<List<BoardMembers>> GetBoardMembersAsync(int boardid)
        {
           
            return await _dbContext.BoardMembers.Where(x => x.BoardId == boardid
            && x.IsActive.Equals(true)
            && x.IsDeleted.Equals(false)).ToListAsync();
        }

        public async Task UpdateRoleAsync(int boardId, int userId, string role)
        {
            var member = await _dbContext.BoardMembers
                .FirstOrDefaultAsync(x => x.BoardId == boardId && x.UserId == userId);

            if (member == null)
                return;

            member.Role = Enum.Parse<BoardRoles>(role);

            await _dbContext.SaveChangesAsync();
        }


    }
}
