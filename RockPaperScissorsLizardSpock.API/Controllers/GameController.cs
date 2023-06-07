using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsLizardSpock.Models.InputModels;
using RockPaperScissorsLizardSpock.Models.ViewModels;
using RockPaperScussorsLizardSpock.Services.ChoiceService;
using RockPaperScussorsLizardSpock.Services.PlayService;
using SimpleLog.Services.SimpLogServices;

namespace RockPaperScissorsLizardSpock.API.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class GameController : Controller
    {
        private readonly IChoiceService choiceService;
        private readonly IPlayService playService;
        private readonly ISimpLog simpLog;

        public GameController(
            IChoiceService choiceService, 
            IPlayService playService,
            ISimpLog simpLog)
        {
            this.choiceService  = choiceService;
            this.playService    = playService;
            this.simpLog        = simpLog;
        }

        [HttpGet("choice")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ChoiceViewModel))]
        [ProducesResponseType(438)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorViewModel))]
        public IActionResult Choice()
        {
            try
            {
                return Ok(choiceService.Choice());
            }
            catch (Exception ex)
            {
                simpLog.Error(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpGet("choices")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ChoiceViewModel>))]
        [ProducesResponseType(438)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorViewModel))]
        public IActionResult Choices()
        {
            try
            {
                return Ok(choiceService.ChoiceList());
            }
            catch(Exception ex)
            {
                simpLog.Error(ex.ToString());
                return StatusCode(500);
            }
        }

        [HttpPost("play")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlayResultViewModel))]
        [ProducesResponseType(438)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorViewModel))]
        public IActionResult Play(ChoiceInputModel choiceInput)
        {
            try
            {
                if(choiceInput == null || choiceInput.Choice_ID < (int)Models.choices.ROCK || choiceInput.Choice_ID > (int)Models.choices.SPOCK)
                    return StatusCode(438, new ErrorViewModel() { Error = "Please insert number between 1 and 5."});

                return Ok(playService.PlayAgainstBot(choiceInput));
            }
            catch (Exception ex)
            {
                simpLog.Error(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
