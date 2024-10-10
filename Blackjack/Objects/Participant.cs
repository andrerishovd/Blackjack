using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blackjack.Objects;

namespace Blackjack.Players {
    public class Participant {
        public String Name { get; set; }
        public List<Card> Cards = [];

        public Participant(String name, List<Card> cards) {
            Name = name;
            Cards = cards;
        }
    }
}
