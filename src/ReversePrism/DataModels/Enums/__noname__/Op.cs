using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Op
    {
        Add,
        Sub,
        Mul,
        Div,
        Mod,
        Neg,
        Pow,
        Sqrt,
        Sin,
        Cos,
        Tan,
        Floor,
        Ceil,
        Round,
        Rand,
        Linear,
    }
}
