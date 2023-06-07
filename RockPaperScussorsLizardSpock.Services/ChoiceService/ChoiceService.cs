using RockPaperScissorsLizardSpock.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScussorsLizardSpock.Services.ChoiceService
{
    public class ChoiceService : IChoiceService
    {
        public ChoiceViewModel Choice()
        {
            List<ChoiceViewModel> list = ChoiceList();
                        
            return list[new Random().Next(list.Count)];
        }

        public List<ChoiceViewModel> ChoiceList()
            => new List<ChoiceViewModel>()
            {
                new ChoiceViewModel(){ ID = 1, Choice = "rock" },
                new ChoiceViewModel(){ ID = 2, Choice = "paper" },
                new ChoiceViewModel(){ ID = 3, Choice = "scissors" },
                new ChoiceViewModel(){ ID = 4, Choice = "lizard" },
                new ChoiceViewModel(){ ID = 5, Choice = "spock" }
            };
    }
}
