using RockPaperScissorsLizardSpock.Models;
using RockPaperScissorsLizardSpock.Models.InputModels;
using RockPaperScissorsLizardSpock.Models.ViewModels;
using RockPaperScussorsLizardSpock.Services.ChoiceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScussorsLizardSpock.Services.PlayService
{
    public class PlayService : IPlayService
    {
        private readonly IChoiceService choiceService;

        public PlayService(IChoiceService choiceService)
        {
            this.choiceService = choiceService;
        }

        public PlayResultViewModel PlayAgainstBot(ChoiceInputModel choiceInput)
        {
            var listChoices = choiceService.ChoiceList();

            var botInput = listChoices[new Random().Next(listChoices.Count)];

            PlayResultViewModel result = new PlayResultViewModel()
            {
                Bot = botInput.ID,
                Player = choiceInput.Choice_ID
            };

            if(choiceInput.Choice_ID == botInput.ID)
                result.Results = results.TIE.ToString();
            else if(choiceInput.Choice_ID == (int)choices.ROCK)
            {
                if (botInput.ID == (int)choices.PAPER || botInput.ID == (int)choices.SPOCK)
                    result.Results = results.LOSE.ToString();
                else
                    result.Results = results.WIN.ToString();
            }
            else if(choiceInput.Choice_ID == (int)choices.PAPER)
            {
                if (botInput.ID == (int)choices.SCISSORS || botInput.ID == (int)choices.LIZARD)
                    result.Results = results.LOSE.ToString();
                else
                    result.Results = results.WIN.ToString();
            }
            else if (choiceInput.Choice_ID == (int)choices.SCISSORS)
            {
                if (botInput.ID == (int)choices.SPOCK || botInput.ID == (int)choices.ROCK)
                    result.Results = results.LOSE.ToString();
                else
                    result.Results = results.WIN.ToString();
            }
            else if (choiceInput.Choice_ID == (int)choices.LIZARD)
            {
                if (botInput.ID == (int)choices.SCISSORS || botInput.ID == (int)choices.ROCK)
                    result.Results = results.LOSE.ToString();
                else
                    result.Results = results.WIN.ToString();
            }
            else if (choiceInput.Choice_ID == (int)choices.SPOCK)
            {
                if (botInput.ID == (int)choices.LIZARD || botInput.ID == (int)choices.PAPER)
                    result.Results = results.LOSE.ToString();
                else
                    result.Results = results.WIN.ToString();
            }

            return result;
        }
    }
}
