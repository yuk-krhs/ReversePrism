using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum NumberStyles
    {
        None,
        AllowLeadingWhite,
        AllowTrailingWhite,
        AllowLeadingSign,
        AllowTrailingSign,
        AllowParentheses,
        AllowDecimalPoint,
        AllowThousands,
        AllowExponent,
        AllowCurrencySymbol,
        AllowHexSpecifier,
        Integer,
        HexNumber,
        Number,
        Float,
        Currency,
        Any,
    }
}
