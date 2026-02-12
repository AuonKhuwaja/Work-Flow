using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Domain;

namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {

        private IBoardService _boardService;
        public BoardController(IBoardService boardService)
        {

            _boardService = boardService;
        }

        [HttpPost("createBoard")]
        
        public async Task<IActionResult> CreateBoard(int userid, Boards boards)
        {
            await _boardService.CreateAsync(userid, boards);
            return Ok();
        }

        [HttpPost("update")]
        public async Task<ActionResult> UpdateBoard(Boards board)
        {
            await _boardService.RenameAsync(board.Id, board.Name);
            return Ok();
        }
        [HttpGet("GetAllBoards")]
        public async Task<ActionResult> GetAllBoards(int userid)
        {
           var result =  await _boardService.GetMyBoardsAsync(userid);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int boardId)
        {

            await _boardService.DeleteAsync(boardId);
            return Ok();
        }

    }
}
