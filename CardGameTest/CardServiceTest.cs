using CardGameAPI.Services.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CardGameTest
{
    public class CardServiceTest
    {
        [Fact]
        public void GetSortedCards_Sorted_Success()
        {
            var mockInput = "3C,JS,2D,PT,10H,KH,8S,4T,AC,4H,RT";
            var mockResponse = new List<string> { "4T", "PT", "RT", "2D", "8S", "JS", "3C", "AC", "4H", "10H", "KH" };
            var cardService = new Mock<ICardService>();
            cardService.Setup(x => x.GetSortedCards(mockInput)).Returns(mockResponse);
            Assert.Equal(mockResponse, cardService.Object.GetSortedCards(mockInput));
        }        
    }
}
