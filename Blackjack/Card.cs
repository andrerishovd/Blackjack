using Blackjack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
	public class Card {
		private Suit Suit { get; set; }
		private CardNumber CardNumber { get; set; }

		public Card(Suit suit, CardNumber number) {
			Suit = suit;
			CardNumber = number;
		}

		public override string? ToString() {
			return CardNumber + " of " + Suit;
		}
	}
}
