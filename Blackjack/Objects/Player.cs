using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Objects;

namespace Blackjack.Players
{
    public class Player : Participant {
        public double Balance { get; set; }

        public Player(String name, List<Card> cards, double balance) : base(name, cards) {
            Balance = balance;
        }

		public override string? ToString() {
			return $"Dealer: {Name} Card(s): {Cards.ToString} Balance: {Balance}";
		}


	}
}
