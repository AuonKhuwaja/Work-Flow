using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;


namespace Work_Flow.Domain.Interfaces.Repositories
{
    public interface ICardsRepo
    {
        Task<Cards> InsertCard(Cards card);
        Task RemoveCard(int cardId);
        Task<Cards> UpdateCard(int cardId, Cards updatedCard);
        Task<List<Cards>> GetCardsByListId(int listId);
        Task MoveCardAsync(MoveCardDto dto);
    }
}
