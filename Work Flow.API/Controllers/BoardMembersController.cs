using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Domain;

namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardMembersController : ControllerBase
    {
        private readonly IBoardMemberServices _boardMemberServices;
        public BoardMembersController(IBoardMemberServices boardMemberServices)
        {
                _boardMemberServices = boardMemberServices;
        }

        [HttpPost ("Create")]
        public async Task<IActionResult> Create(BoardMembers data)
        {
           await _boardMemberServices.Insert(data);
            return Ok("Data Inserted!");
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(int boardid, int userid, string role)
        {
            await _boardMemberServices.Update(boardid, userid, role);
            return Ok("Updated!");
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int userid, int boardid)
        {
           await _boardMemberServices.Delete(userid, boardid);
            return Ok("Deleted!");
        }

        [HttpGet ("GetMemberByBoardId")]
        public async Task<IActionResult> GetMemberByBoardId(int boardid)
        {
            var data = _boardMemberServices.GetBoardMemberByBoardID(boardid);
            if (data != null)
            {
                return Ok(data);

            }

            return BadRequest();
        }
    }
}
