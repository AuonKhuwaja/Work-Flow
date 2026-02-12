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
    public class BoardService : IBoardService
    {
        private IBoardRepo _boardRepo;
        public BoardService(IBoardRepo boardRepo)
        {
            _boardRepo = boardRepo; 
            
            
        }
        public async Task CreateAsync(int userId, Boards dto)
        {
             await _boardRepo.AddAsync(userId,dto);


        }

        public async Task DeleteAsync(int boardId)
        {
            await _boardRepo.DeleteAsync(boardId);
        }

        public async Task<List<Boards>> GetMyBoardsAsync(int userId)
        {
            return await _boardRepo.GetUserBoardsAsync(userId);
        }

        public async Task RenameAsync(int boardId, string name)
        {
           await _boardRepo.UpdateAsync(boardId,name);
        }
    }
}
