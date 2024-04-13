using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    internal class Eight:ICardProvider
    {
        public string Name => "Eight";
        public Suits Suits { get; set; }
        public bool Trump { get; set; }
        public SignificanceValuesForCard Significance { get; }

        public Eight(Suits suit, bool trump)
        {
            Suits = suit;
            Trump = trump;
            Significance = SignificanceValuesForCard.Eight;
        }
    }
}
