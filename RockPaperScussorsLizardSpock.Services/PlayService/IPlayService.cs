using RockPaperScissorsLizardSpock.Models.InputModels;
using RockPaperScissorsLizardSpock.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScussorsLizardSpock.Services.PlayService
{
    public interface IPlayService
    {
        public PlayResultViewModel PlayAgainstBot(ChoiceInputModel choiceInput);
    }
}
