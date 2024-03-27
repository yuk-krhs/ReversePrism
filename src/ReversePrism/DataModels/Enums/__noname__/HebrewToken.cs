using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HebrewToken
    {
        Invalid,
        Digit400,
        Digit200_300,
        Digit100,
        Digit10,
        Digit1,
        Digit6_7,
        Digit7,
        Digit9,
        SingleQuote,
        DoubleQuote,
    }
}
