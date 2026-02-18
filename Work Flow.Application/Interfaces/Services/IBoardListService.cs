using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Application.Interfaces.Services
{
    public interface IBoardListService
    {

        Task Insert(BoardLists board);

        Task<List<BoardLists>> GetBoardListsById(int boardid);
        Task Delete(int id);
        Task Update(int id, string name, int order);
    }
}
