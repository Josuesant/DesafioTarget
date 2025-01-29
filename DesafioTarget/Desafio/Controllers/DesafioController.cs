using Desafio.Application;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("Challenge/")]
    public class DesafioController : ControllerBase
    {
        [HttpGet]
        [Route("One")]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult GetChallengeOne()
        {
            var challenge = new Challenge();
            var result = challenge.ChallengeOne();
            return Ok(result.ToString());
        }

        [HttpPost]
        [Route("Two")]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult PostChallengeTwo(int number)
        {
            var challenge = new Challenge();
            var resut = challenge.ChallengeTwo(number);
            return Ok(resut);
        }

        [HttpGet]
        [Route("Three")]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult GetChallengeThree()
        {
            var challenge = new Challenge();
            var resut = challenge.ChallengeThree();
            return Ok(resut);
        }

        [HttpGet]
        [Route("Four")]
        [ProducesResponseType<List<string>>(StatusCodes.Status200OK)]
        public IActionResult GetChallengeFour()
        {
            var challenge = new Challenge();
            var resut = challenge.ChallengeFour();
            return Ok(resut);
        }

        [HttpPost]
        [Route("Five")]
        [ProducesResponseType<string>(StatusCodes.Status200OK)]
        public IActionResult PostChallengeFive(string str)
        {
            var challenge = new Challenge();
            var resut = challenge.ChallengeFive(str);
            return Ok(resut);
        }

    }
}
