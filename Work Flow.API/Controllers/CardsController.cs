using Microsoft.AspNetCore.Mvc;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Domain;

namespace Work_Flow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardsService _cardsService;

        public CardsController(ICardsService cardsService)
        {
            _cardsService = cardsService;
        }

       
        [HttpPost]
        public async Task<IActionResult> CreateCard([FromBody] Cards cards)
        {
            if (cards == null) return BadRequest();

            var response = await _cardsService.CreateCard(cards);
            if (response != null)
                return Ok(response);

            return BadRequest();
        }

      
        [HttpGet("list/{id}")]
        public async Task<IActionResult> GetCardsByListID(int id)
        {
            var res = await _cardsService.GetCardsByListId(id);
            if (res != null)
                return Ok(res);

            return NotFound();
        }

        // Update (full)
        [HttpPut("{id}")]
        public async Task<IActionResult> EditCard(int id, [FromBody] Cards updatedModel)
        {
            if (updatedModel == null) return BadRequest();

            var response = await _cardsService.EditCard(id, updatedModel);
            if (response != null)
                return Ok(response);

            return BadRequest();
        }

       
     
        // Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            await _cardsService.DeleteCard(id);
            return NoContent();
        }
    }
}