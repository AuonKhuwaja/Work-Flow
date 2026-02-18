using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Domain;

namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardListController : ControllerBase
    {
        private readonly IBoardListService _boardListService;
        public BoardListController(IBoardListService boardListService)
        {
                _boardListService = boardListService;
        }

        [HttpGet ("GetBoardList")]
        public async Task<IActionResult> GetBoardListsById(int boardid)
        {
            var data = await _boardListService.GetBoardListsById(boardid);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost("Insert")]

        public async Task<IActionResult> Insert(BoardLists data)
        {
            await _boardListService.Insert(data);
            return Ok("Data inserted succesfully!");
               
        }  
        [HttpPut("Update")]

        public async Task<IActionResult> Update(int id, string name, int order)
        {
            await _boardListService.Update(id, name, order);
            return Ok("Data Updated succesfully!");
               
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _boardListService.Delete(id);
            return Ok("Data Deleted succesfully!");

        }


    }
}
