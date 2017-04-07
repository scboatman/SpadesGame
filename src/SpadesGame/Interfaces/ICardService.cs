using System.Collections.Generic;
using SpadesGame.Models;

namespace SpadesGame.Services
{
    public interface ICardService
    {
        IList<Card> GetAllCards();
    }
}