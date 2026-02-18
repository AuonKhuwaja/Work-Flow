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
    public class CardsService: ICardsService
    {
        private readonly ICardsRepo _cardsRepo;
        public CardsService(ICardsRepo cardsRepo)
        {
                _cardsRepo = cardsRepo;
        }

        public async Task<Cards> CreateCard(Cards card)
        {
          return await _cardsRepo.InsertCard(card); 
        }

        public  async Task DeleteCard(int cardId)
        {
             await _cardsRepo.RemoveCard(cardId);
        }

        public async Task<Cards> EditCard(int cardId, Cards updatedCard)
        {
           return await _cardsRepo.UpdateCard(cardId, updatedCard);
        }

        public async Task<List<Cards>> GetCardsByListId(int listId)
        {   
           return await _cardsRepo.GetCardsByListId(listId);
        }
    }
}
