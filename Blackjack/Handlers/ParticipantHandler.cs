using Blackjack.Objects;
using Blackjack.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Handler {
    public class ParticipantHandler {
        
        public List<Participant> CreateParticipants() {
            List<Participant> participants = [];
			List<Card> cards = [];
			participants.AddRange(new List<Participant> {

				new Player(
					"Miller",
					cards,
					200
				),
				/*
				new Player(
					"Wolfgang",
					cards,
					400
				),
				*/
				new Dealer(
					"Wilfred",
					cards
				)
			});

            return participants;
        }


    }
}
