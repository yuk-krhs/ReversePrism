using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum JsonValueType
    {
        None,
        Bool,
        Real,
        Integer,
        String,
        Array,
        Object,
        Any,
    }
}
