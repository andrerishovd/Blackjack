using Blackjack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
	public class GameHandler {
		bool YourTurn = true;
		bool BetsPlaced = false;
		int DealerStands = 17;
		int BlackJack = 21;
		double Balance = 100;
		double Multiplier = 2.5;

		List<Card> YourCards = [];
		List<Card> DealersCards = [];
		List<List<Card>> Players = [];
		
		Stack<Card> CurrentDeck = new();

		CardHandler CardHandler = new();
		BettingHandler BettingHandler = new();


		public void BlackJackGame() {
			CurrentDeck = CardHandler.ShuffleDeck(CardHandler.GenerateOrderedDeck());
			BettingHandler.Balance = Balance;
			
			
			//while(YourCards.get
		}

		public void BlackJackRound() {
			PlaceBet();
			CurrentDeck = CardHandler.ShuffleDeck(CurrentDeck);

		}

		public void DealCards() {
			foreach(List<List<Card>> player in Players) {
				Card newCard = CardHandler.DrawCard(CurrentDeck);
				player.Add(newCard);
			}
		}

		public void PlaceBet() {
			int HardBet = 50;
            Console.WriteLine("Placing bets");
			Thread.Sleep(3000);
			Bet ThisRoundBet = BettingHandler.NewBet(Balance, HardBet, Multiplier);
            Console.WriteLine(ThisRoundBet.PotentialPayout);
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
