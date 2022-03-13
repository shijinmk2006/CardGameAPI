using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameAPI.Services.Interface
{
    public interface ICardService
    {
        List<string> GetSortedCards(string cardValues);
    }
}
