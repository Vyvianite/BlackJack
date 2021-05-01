using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
  enum Move {
    Hit,
    Hold
  }

  class Dealer : Seat {
    public Dealer(Card first, Card second) {
      Hand = new() {
        first,
        second
      };
    }

    public Move Decide(int playerValue) {
      int value = GetValue();
      if (value < 17 || value < playerValue || highAces > 0) {
        return Move.Hit;
      }
      else {
        return Move.Hold;
      }
      
    }
  }
}
