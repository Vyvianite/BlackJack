using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
  enum Winner {
    Dealer,
    Player
  }

  class BlackJack {
    public BlackJack(int decks = 1) {
      deck = new(decks);
      dealer = new(deck.Draw(), deck.Draw());

    }
    bool turnOne = true;

    Deck deck;
    Dealer dealer;
    Player player;


    Winner Score() {
      int valDealer = dealer.GetValue();
      int valPlayer = player.GetValue();

      if (turnOne && valDealer == 21) {
        return Winner.Dealer;
      }
      else {
        //Player input
      }
    }
  }
}
