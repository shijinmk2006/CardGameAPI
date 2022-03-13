using CardGameAPI.Controllers;
using CardGameAPI.Services.Implementation;
using CardGameAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace CardGameTest
{
    public class CardControllerTest
    {
        CardsController _controller;
        ICardService _service;

        public CardControllerTest()
        {
            _service = new CardService();
            _controller = new CardsController(_service);

        }
        [Fact]
        public void GetSortedCards_Sorted_Success()
        {
            var cardValues = "3C,JS,2D,PT,10H,KH,8S,4T,AC,4H,RT";
            var createdResponse = _controller.GetSortedCards(cardValues);
            Assert.IsType<OkObjectResult>(createdResponse);
            var list = createdResponse as OkObjectResult;

            Assert.IsType<List<string>>(list.Value);
            var listCards = list.Value as List<string>;
            Assert.Equal(listCards.Count,cardValues.Split(',').Length);
        }

        [Fact]
        public void GetSortedCards_Sorted_Failure_EmptyInput()
        {
            string cardValues = "";
            var createdResponse = _controller.GetSortedCards(cardValues);
            Assert.IsType<BadRequestObjectResult>(createdResponse);
            var response = createdResponse as BadRequestObjectResult;
            Assert.Matches("An error occured",response.Value.ToString());
        }
        [Fact]
        public void GetSortedCards_Sorted_Failure_NullInput()
        {
            string cardValues = null;
            var createdResponse = _controller.GetSortedCards(cardValues);
            Assert.IsType<BadRequestObjectResult>(createdResponse);
            var response = createdResponse as BadRequestObjectResult;
            Assert.Matches("An error occured",response.Value.ToString());
        }
        [Fact]
        public void GetSortedCards_Sorted_Failure_InvalidInput()
        {
            var cardValues = "Invalid,JS,2D,PT,10H,KH,8S,4T,AC,4H,RT";
            var createdResponse = _controller.GetSortedCards(cardValues);
            Assert.IsType<BadRequestObjectResult>(createdResponse);
            var response = createdResponse as BadRequestObjectResult;
            Assert.Contains("An error occured",response.Value.ToString());
        }
    }
}
