using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum StyleSyntaxTokenType
    {
        Unknown,
        String,
        Number,
        Space,
        SingleBar,
        DoubleBar,
        DoubleAmpersand,
        Comma,
        SingleQuote,
        Asterisk,
        Plus,
        QuestionMark,
        HashMark,
        ExclamationPoint,
        OpenBracket,
        CloseBracket,
        OpenBrace,
        CloseBrace,
        LessThan,
        GreaterThan,
        End,
    }
}
