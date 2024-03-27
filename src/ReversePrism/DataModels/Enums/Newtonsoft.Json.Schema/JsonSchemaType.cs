using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum JsonSchemaType
    {
        None,
        String,
        Float,
        Integer,
        Boolean,
        Object,
        Array,
        Null,
        Any,
    }
}
