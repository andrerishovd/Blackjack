using Blackjack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
	public class CardHandler {

		public List<Card> GenerateOrderedDeck() {
			List<Card> OrderedDeck = new();

			foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
				foreach (CardNumber number in Enum.GetValues(typeof(CardNumber))) {
					OrderedDeck.Add(new Card(suit, number));
				}
			}
			return OrderedDeck;
		}

		public List<Card> ShuffleDeck(List<Card> cards) {
			List<Card> ShuffledDeck = new();
			Random rng = new();

			while(cards.Count > 0) {
				int index = rng.Next(0, cards.Count);
				ShuffledDeck.Add(cards[index]);
				cards.RemoveAt(index);
			}
			return ShuffledDeck;
		}

		public void DisplayDeck(List<Card> cards) {
			foreach(Card card in cards) {
                Console.WriteLine(card);
			}
		}
	}
}
