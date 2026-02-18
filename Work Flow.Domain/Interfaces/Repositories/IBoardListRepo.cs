using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Domain.Interfaces.Repositories
{
    public interface IBoardListRepo
    {

        Task AddBoardListAsync(BoardLists board);

        Task<List<BoardLists>> GetBoardlistAsync(int boardid);
        Task DeleteBoardlistAsync(int id);
        Task UpdateBoardlistAsync(int id, string name, int order);
    }
}
