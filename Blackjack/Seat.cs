using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
  abstract class Seat {
    public List<Card> Hand { get; protected set; }
    public int Score { get; private set; }
    protected int highAces;
    const int TARGET = 21;

    public int GetValue() {
      int accumulator = 0;
      List<Card> Aces = new();

      foreach (Card card in Hand) {
        if (card.Face == Face.Ace) {
          Aces.Add(card);
        }
        else {
          accumulator += (int)card.Face;
        }
      }

      foreach (var ace in Aces) {
        if (TARGET - accumulator >= 11) {
          accumulator += 11;
          highAces++;
        }
        else {
          accumulator += 1;
        }
      }

      return accumulator;
    }

    public void Hit(Card card) {
      Hand.Add(card);
    }

    public void Clear() {
      Hand.Clear();
    }

    public void AddPoint() {
      Score++;
    }
  }
}
