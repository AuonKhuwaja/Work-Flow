using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Domain.Interfaces.Repositories
{
    public interface IBoardRepo
    {
        Task AddAsync(int userid,Boards board);
        Task<List<Boards>> GetUserBoardsAsync(int userId);
        Task DeleteAsync(int boardId);
        Task UpdateAsync(int boardId, string name);
    }
}
