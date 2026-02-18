using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Interfaces.Repositories;
using Work_Flow.Infrastructure.Data;
using Work_Flow.Domain.Domain;

using Microsoft.EntityFrameworkCore;


namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public class BoardListRepo : IBoardListRepo
    {

        private readonly AppDbContext _dbContext;

        public BoardListRepo(AppDbContext appDbContext)
        {
                _dbContext = appDbContext;
        }
        public async Task AddBoardListAsync(BoardLists board)
        {
           await  _dbContext.AddAsync(board);
          await  _dbContext.SaveChangesAsync();

        }


        public async Task DeleteBoardlistAsync(int id)
        {
            var data = await _dbContext.BoardList.Where(x => x.Id == id).FirstOrDefaultAsync();
            data.IsActive = false;
            data.IsDeleted = true;
            data.UpdatedAt = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<BoardLists>> GetBoardlistAsync(int boardid)
        {
            return await _dbContext.BoardList.Where(x => x.BoardId == boardid
                       && x.IsActive.Equals(true)
                       && x.IsDeleted.Equals(false)).ToListAsync();
        }
        public async Task UpdateBoardlistAsync(int id, string name, int order)
        {
             var data = await _dbContext.BoardList.Where(x => x.Id == id).FirstOrDefaultAsync();

        }
    }
}
