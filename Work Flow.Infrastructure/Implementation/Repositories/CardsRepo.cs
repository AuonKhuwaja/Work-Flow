using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Flow.Domain.Domain;
using Work_Flow.Domain.Interfaces.Repositories;
using Work_Flow.Infrastructure.Data;

namespace Work_Flow.Infrastructure.Implementation.Repositories
{
    public class CardsRepo: ICardsRepo
    {
        private readonly AppDbContext _dBContext;
        public CardsRepo(AppDbContext dBContext)
        {
            _dBContext = dBContext;
            
        }

        public  async  Task<Cards> InsertCard(Cards card )
        {
            var maxPosition = await  _dBContext.Cards
       .Where(x => x.ListId == card.ListId)
       .MaxAsync(x => (int?)x.Position) ?? 0;

            var newcard = new Cards
            {
                Title = card.Title,
                Description = card.Description,
                ListId = card.ListId,
                Position = maxPosition + 1,
                DueDate=card.DueDate,
                CreatedAt = DateTime.UtcNow,
                IsActive =true
            };
            _dBContext.Cards.Add(newcard);  
            _dBContext.SaveChanges();
            return newcard;

        }

        public async Task RemoveCard(int cardId)
        {
           var card=await  _dBContext.Cards.Where(x=>x.Id==cardId).FirstOrDefaultAsync();
            card.IsDeleted = true;
            card.IsActive = false;  
            _dBContext.Cards.Update(card);
            await _dBContext.SaveChangesAsync();    
        }

            public async Task<Cards> UpdateCard(int cardId, Cards updatedCard)
        {
           var card = await _dBContext.Cards.FirstOrDefaultAsync(x => x.Id == cardId);
           if (card == null)
               return null;
               card.Title = updatedCard.Title;
               card.Description = updatedCard.Description;

           if (updatedCard.ListId != 0 && updatedCard.ListId != card.ListId)
           {
               var maxPositionInDest = await _dBContext.Cards
                   .Where(x => x.ListId == updatedCard.ListId)
                   .MaxAsync(x => (int?)x.Position) ?? 0;

               card.ListId = updatedCard.ListId;
               card.Position = maxPositionInDest + 1;
           }
           else if (updatedCard.Position != 0 && updatedCard.Position != card.Position)
           {
               card.Position = updatedCard.Position;
           }

           _dBContext.Cards.Update(card);
           await _dBContext.SaveChangesAsync();
           return card;
        }
        public async Task<List<Cards>> GetCardsByListId(int listId)
        {
            return await _dBContext.Cards
                .Where(x => x.ListId == listId && x.IsActive && !x.IsDeleted)
                .OrderBy(x => x.Position)
                .ToListAsync();
        }
    }
}
