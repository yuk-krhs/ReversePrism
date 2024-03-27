using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum JTokenType
    {
        None,
        Object,
        Array,
        Constructor,
        Property,
        Comment,
        Integer,
        Float,
        String,
        Boolean,
        Null,
        Undefined,
        Date,
        Raw,
        Bytes,
        Guid,
        Uri,
        TimeSpan,
    }
}
