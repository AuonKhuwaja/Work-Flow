using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;
using Work_Flow.Domain.Interfaces.Repositories;
using Work_Flow.Infrastructure.Data;

namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public class BoardRepo : IBoardRepo
    {
        private readonly AppDbContext _dbContext;
        public BoardRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(int userid, Boards board)
        {
            if (board == null) throw new ArgumentNullException(nameof(board));

            var entity = new Boards
            {
                Name = board.Name,
                CreatedById = userid,
                CreatedAt = DateTime.UtcNow
                
               
            };

            await _dbContext.Boards.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int boardid)
        {
            var boards = await _dbContext.Boards
                .Where(x => x.Id == boardid)
                .FirstOrDefaultAsync();

            if (boards == null) return;

            boards.IsDeleted = true;
            _dbContext.Boards.Update(boards);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Boards>> GetUserBoardsAsync(int userId)
        {
            return await _dbContext.Boards
                .Where(x => x.CreatedById == userId && !x.IsDeleted)
                .ToListAsync();
        }

        public async Task UpdateAsync(int boardId, string name)
        {
            var userboard = await _dbContext.Boards
                .Where(x => x.Id == boardId)
                .FirstOrDefaultAsync();

            if (userboard == null) return;

            userboard.Name = name;
            _dbContext.Boards.Update(userboard);
            await _dbContext.SaveChangesAsync();
        }
    }
}
