using System;

namespace Blackjack {
  class Program {
    static void Main(string[] args) {
      var a = new Deck(2);
      a.Shuffle();
      var i = a.Draw();
      var x = new Player(new Card(Suit.Clubs, Face.Ace), new Card(Suit.Clubs, Face.Ace));
      var v = x.GetValue();
    }
  }
}
