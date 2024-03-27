using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum JsonToken
    {
        None,
        StartObject,
        StartArray,
        StartConstructor,
        PropertyName,
        Comment,
        Raw,
        Integer,
        Float,
        String,
        Boolean,
        Null,
        Undefined,
        EndObject,
        EndArray,
        EndConstructor,
        Date,
        Bytes,
    }
}
