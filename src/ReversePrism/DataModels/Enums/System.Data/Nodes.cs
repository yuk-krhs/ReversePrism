using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Nodes
    {
        Noop,
        Unop,
        UnopSpec,
        Binop,
        BinopSpec,
        Zop,
        Call,
        Const,
        Name,
        Paren,
        Conv,
    }
}
