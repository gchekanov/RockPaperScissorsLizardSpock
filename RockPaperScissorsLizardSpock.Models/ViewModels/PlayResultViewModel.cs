using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock.Models.ViewModels
{
    public class PlayResultViewModel
    {
        public string Results { get; set; }

        public int Player { get; set; }

        public int Bot { get; set; }
    }
}
