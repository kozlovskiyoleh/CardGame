using CardGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    internal class Ten:ICardProvider
    {
        public string Name => "Ten";
        public Suits Suits { get; set; }
        public bool Trump { get; set; }
        public SignificanceValuesForCard Significance { get; }

        public Ten(Suits suit, bool trump)
        {
            Suits = suit;
            Trump = trump;
            Significance = SignificanceValuesForCard.Ten;
        }
    }
}
