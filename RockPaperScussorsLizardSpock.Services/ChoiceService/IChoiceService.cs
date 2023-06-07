using RockPaperScissorsLizardSpock.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScussorsLizardSpock.Services.ChoiceService
{
    public interface IChoiceService
    {
        public ChoiceViewModel Choice();

        public List<ChoiceViewModel> ChoiceList();
    }
}
