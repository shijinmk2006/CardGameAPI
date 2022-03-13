using CardGameAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CardGameAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _ICardService;
        public CardsController(ICardService ICardService)
        {
            _ICardService = ICardService;
        }

        [HttpPost]
        [Route("SortedCards")]
        public IActionResult GetSortedCards([FromBody] string cardValues)
        {
            try
            {
                if (!string.IsNullOrEmpty(cardValues))
                {
                    var sortedList = _ICardService.GetSortedCards(cardValues);
                    return Ok(sortedList);
                }
                else
                {
                    return BadRequest("An error occured");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occured {ex.Message}");
            }
        }
    }
}
