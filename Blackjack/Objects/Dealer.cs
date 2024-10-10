using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Enums;
using Blackjack.Objects;

namespace Blackjack.Players {
    public class Dealer : Participant {
        public Dealer(String name, List<Card> cards) : base(name, cards) {
        }

		public override string? ToString() {
			return $"Dealer: {Name} Card(s): {Cards.ToString}";
		}
	}
}
