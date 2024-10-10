using Blackjack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
	public class GameHandler {
		bool YourTurn = true;
		int DealerStands = 17;
		int BlackJack = 21;
		List<Card> YourCards = [];
		List<Card> DealersCards = [];
		CardHandler ch = new();
		Stack<Card> CurrentDeck = new();


		public void BlackJackGame() {
			CurrentDeck = ch.ShuffleDeck(ch.GenerateOrderedDeck());
			//while(YourCards.get
		}

		public void BlackJackRound() {
			CurrentDeck = ch.ShuffleDeck(CurrentDeck);
		}

		public int ReturnCurrentNumber(List<Card> cards) {
			int CurrentNumber = 0;
			foreach(Card card in cards) {
				CurrentNumber += (int)card.CardNumber;

			}
			return CurrentNumber;
		}
	}
}
