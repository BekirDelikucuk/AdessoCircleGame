using AdessoCircleGame.Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdessoCircleGame.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult CalculateGameWinner(int size)
        {

            if (size<1)
            {
                return BadRequest(error:"Lütfen oyuncusu sayısını 1 den büyük giriniz ");
            }

            return Ok(_gameService.CalculateGameWinner(size));
        }
    }
}
