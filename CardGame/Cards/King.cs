using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    internal class King:ICardProvider
    {
        public string Name => "King";
        public Suits Suits { get; set; }
        public bool Trump { get; set; }
        public SignificanceValuesForCard Significance { get; }

        public King(Suits suit, bool trump)
        {
            Suits = suit;
            Trump = trump;
            Significance = SignificanceValuesForCard.King;
        }
    }
}
