using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum GuidStyles
    {
        None,
        AllowParenthesis,
        AllowBraces,
        AllowDashes,
        AllowHexPrefix,
        RequireParenthesis,
        RequireBraces,
        RequireDashes,
        RequireHexPrefix,
        HexFormat,
        NumberFormat,
        DigitFormat,
        BraceFormat,
        ParenthesisFormat,
        Any,
    }
}
