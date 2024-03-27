using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ElementProperties
    {
        DEFAULT,
        URI_PARENT,
        BOOL_PARENT,
        NAME_PARENT,
        EMPTY,
        NO_ENTITIES,
        HEAD,
        BLOCK_WS,
        HAS_NS,
    }
}
