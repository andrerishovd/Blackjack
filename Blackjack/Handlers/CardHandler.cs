using Blackjack.Enums;
using Blackjack.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Handlers
{
    public class CardHandler
    {

        public Stack<Card> GenerateOrderedDeck()
        {
            Stack<Card> OrderedDeck = new();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardNumber number in Enum.GetValues(typeof(CardNumber)))
                {
                    OrderedDeck.Push(new Card(suit, number));
                }
            }
            return OrderedDeck;
        }

        public Stack<Card> ShuffleDeck(Stack<Card> cardStack)
        {
            List<Card> cards = cardStack.ToList();
            Stack<Card> ShuffledDeck = new();
            Random rng = new();

            while (cards.Count > 0)
            {
                int index = rng.Next(0, cards.Count);
                ShuffledDeck.Push(cards[index]);
                cards.RemoveAt(index);
            }
            return ShuffledDeck;
        }

        public Card DrawCard(Stack<Card> cards)
        {
            return cards.Pop();
        }

        public void DisplayDeck(Stack<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
