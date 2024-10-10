using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Objects
{
    public class Bet
    {
        public int BetAmount { get; set; }
        public double Multiplier { get; set; }
        public double PotentialPayout { get; set; }

        public Bet(int bet, double multiplier)
        {
            BetAmount = bet;
            Multiplier = multiplier;
            PotentialPayout = bet * multiplier;
        }
    }
}
