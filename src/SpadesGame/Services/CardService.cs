using SpadesGame.Models;
using SpadesGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Services
{
    public class CardService
    {
        private IGenericRepository _repo;

        //Get cards t deal
        public IList<Card> GetAllCards()
        {
            return _repo.Query<Card>().ToList();
        }

        //Player selects card to play
        public Card GetCardById(int id)
        {
            return _repo.Query<Card>().Where(c => c.Id == id).FirstOrDefault();
        }


    }
}
