using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Application.Interfaces.Services
{
    public interface IBoardService
    {
        Task CreateAsync(int userId, Boards dto);
        Task<List<Boards>> GetMyBoardsAsync(int userId);
        Task RenameAsync(int boardId, string name);
        Task DeleteAsync(int boardId);

    }
}
