using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ValueType
    {
        Unspecified,
        Bool,
        Int64,
        Double,
        String,
        Distribution,
        Money,
    }
}
