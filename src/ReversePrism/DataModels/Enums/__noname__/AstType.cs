using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AstType
    {
        Axis,
        Operator,
        Filter,
        ConstantOperand,
        Function,
        Group,
        Root,
        Variable,
        Error,
    }
}
