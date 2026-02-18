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
    public class BoardListServices : IBoardListService
    {
        private readonly IBoardListRepo _boardListRepo;
        public BoardListServices(IBoardListRepo boardListRepo)
        {
            _boardListRepo = boardListRepo;
        }

        public async Task Insert(BoardLists board)
        {
               await _boardListRepo.AddBoardListAsync(board);

        }
        public async Task Update(int id, string name, int order)
        {
            await _boardListRepo.UpdateBoardlistAsync(id, name, order);
        }

        public async Task Delete(int id)
        {
           await _boardListRepo.DeleteBoardlistAsync(id);
        }

        public async Task<List<BoardLists>> GetBoardListsById(int boardid)
        {
          return await _boardListRepo.GetBoardlistAsync(boardid);
        }

      
    }
}
