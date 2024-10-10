using Blackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
	static void Main(string[] args) {
		CardHandler ch = new CardHandler();

		ch.DisplayDeck(ch.ShuffleDeck(ch.GenerateOrderedDeck()));

	}
}
