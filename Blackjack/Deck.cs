using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack {
  class Deck {
    public Deck(int decks = 1) {
      deck = new Card[decks * PACKSIZE];

      int fillIndex = 0;
      var loopSuit = Enum.GetValues(typeof(Suit)).Cast<Suit>();
      var loopFace = Enum.GetValues(typeof(Face)).Cast<Face>();

      for (int shoe = 1; shoe <= decks; shoe++)
        foreach (Suit suit in loopSuit) {
          foreach (Face face in loopFace) {
            deck[fillIndex] = new Card(suit, face);
            fillIndex++;
          }
        }
    }

    private static readonly Random rng = new Random();
    const int PACKSIZE = 52;
    readonly Card[] deck;
    int index = 0;

    public Card Draw() {
      if (index > deck.Length - 1) {
        return null;
      }
      var card = deck[index];
      index++;
      return card;
    }

    //Basic Fisher-Yates shuffle
    public void Shuffle() {
      index = 0;
      int count = deck.Length;
      while (count > 1) {
        count--;
        int next = rng.Next(count + 1);
        Card value = deck[next];
        deck[next] = deck[count];
        deck[count] = value;
      }
    }
  }
}
