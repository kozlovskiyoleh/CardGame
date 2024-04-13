using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    internal class Ace:ICardProvider
    {
        public string Name => "Ace";
        public Suits Suits { get; set; }
        public bool Trump { get; set; }
        public SignificanceValuesForCard Significance { get; }

        public Ace(Suits suit, bool trump)
        {
            Suits = suit;
            Trump = trump;
            Significance = SignificanceValuesForCard.Ace;
        }
    }
}
