using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock.Models
{
    public enum choices
    {
        ROCK        = 1,
        PAPER       = 2,
        SCISSORS    = 3,
        LIZARD      = 4, 
        SPOCK       = 5
    }

    public enum results
    {
        TIE     = 1,
        WIN     = 2,
        LOSE    = 3
    }
}
