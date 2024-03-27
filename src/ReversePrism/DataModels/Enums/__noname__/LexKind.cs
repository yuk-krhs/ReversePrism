using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LexKind
    {
        Comma,
        Slash,
        At,
        Dot,
        LParens,
        RParens,
        LBracket,
        RBracket,
        Star,
        Plus,
        Minus,
        Eq,
        Lt,
        Gt,
        Bang,
        Dollar,
        Apos,
        Quote,
        Union,
        Ne,
        Le,
        Ge,
        And,
        Or,
        DotDot,
        SlashSlash,
        Name,
        String,
        Number,
        Axe,
        Eof,
    }
}
