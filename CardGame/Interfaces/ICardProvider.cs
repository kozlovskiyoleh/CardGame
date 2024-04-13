using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Interfaces
{
    internal interface ICardProvider
    {
        string Name { get;}
        Suits Suits { get; set; }
        bool Trump { get; }
        SignificanceValuesForCard Significance { get; }
    }
}
