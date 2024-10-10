using Blackjack.Enums;
using Blackjack.Handler;
using Blackjack.Objects;
using Blackjack.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Handlers
{
    public class GameHandler
    {
        public bool YourTurn = false;
        public bool BetsPlaced = false;
        public int DealerStands = 17;
        public int BlackJack = 21;
        public double Multiplier = 2.5;
        public int RoundNumber = 1;

        public List<Participant> Participants = [];

        public Stack<Card> CurrentDeck = new();

        public CardHandler CardHandler = new();
        public BettingHandler BettingHandler = new();
        public ParticipantHandler ParticipantHandler = new();


        public void BlackJackGame() {
            CurrentDeck = CardHandler.ShuffleDeck(CardHandler.GenerateOrderedDeck());
            CardHandler.DisplayDeck(CurrentDeck);
            Participants = ParticipantHandler.GenerateParticipants();
            BlackJackRound();
		}

        public void BlackJackRound() {
            Console.WriteLine($"\nStarting round {RoundNumber}");
			//PlaceBet(10);
			//CurrentDeck = CardHandler.ShuffleDeck(CurrentDeck);
			DealCards();
            
			//DealCards();
            RoundNumber++;
		}

        public void DealCards() {
            foreach (Participant participant in Participants) {
                Card newCard = CardHandler.DrawCard(CurrentDeck);
				participant.Cards.Add(newCard);
                participant.ToString();
            }
        }

        public void PlaceBet(int balance) {
            int HardBet = 50;
            Console.WriteLine("Placing bets");
            Thread.Sleep(3000);
            Bet ThisRoundBet = BettingHandler.NewBet(balance, HardBet, Multiplier);
            Console.WriteLine(ThisRoundBet.PotentialPayout);
        }

        public int ReturnCurrentNumber(List<Card> cards) {
            int CurrentSum = 0;
            foreach (Card card in cards) {
                CurrentSum += (int)card.CardNumber;
            }
            return CurrentSum;
        }
    }
}
