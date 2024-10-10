using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
	public class BettingHandler {
		public double Balance { get; set; }

		public Bet? NewBet(double balance, int bet, double multiplier) {
			if(balance - bet >= 0) {
				Bet Bet = new(bet, multiplier);
				return Bet;
			} else {
                Console.WriteLine("Balance to low.");
				return null;
			}
		}
	}
}
