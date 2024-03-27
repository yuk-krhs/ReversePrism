using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Tokens
    {
        None,
        Name,
        Numeric,
        Decimal,
        Float,
        BinaryConst,
        StringConst,
        Date,
        ListSeparator,
        LeftParen,
        RightParen,
        ZeroOp,
        UnaryOp,
        BinaryOp,
        Child,
        Parent,
        Dot,
        Unknown,
        EOS,
    }
}
