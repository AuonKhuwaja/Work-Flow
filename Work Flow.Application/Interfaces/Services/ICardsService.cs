using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;

namespace Work_Flow.Application.Interfaces.Services
{
    public interface ICardsService
    {
        Task<Cards> CreateCard(Cards card);
        Task DeleteCard(int cardId);
        Task<Cards> EditCard(int cardId, Cards updatedCard);
        Task<List<Cards>> GetCardsByListId(int listId);
        Task MoveCard(MoveCardDto dto);
    }
}
