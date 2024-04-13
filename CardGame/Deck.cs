using CardGame.Cards;
using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal static class Deck
    {
        public static List<ICardProvider> deck = new List<ICardProvider>();

        static Deck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                deck.Add(new Six(suit, false));
                deck.Add(new Seven(suit, false));
                deck.Add(new Eight(suit, false));
                deck.Add(new Nine(suit, false));
                deck.Add(new Ten(suit, false));
                deck.Add(new Jack(suit, false));
                deck.Add(new Queen(suit, false));
                deck.Add(new King(suit, false));
                deck.Add(new Ace(suit, false));
            }
        }

       
    }
}
