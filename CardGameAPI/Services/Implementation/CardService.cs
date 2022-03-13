using CardGameAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CardGameAPI.EnumModel.EnumValues;

namespace CardGameAPI.Services.Implementation
{
    public class CardService : ICardService
    {
        public List<string> GetSortedCards(string cardValues)
        {
            List<String> list = cardValues.Split(',').ToList();
            return list.OrderBy(r => (int)Enum.Parse(typeof(Cards), $"_{r}")).ToList();
        }
    }
}
