using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum JsonContractType
    {
        None,
        Object,
        Array,
        Primitive,
        String,
        Dictionary,
        Dynamic,
        Serializable,
        Linq,
    }
}
