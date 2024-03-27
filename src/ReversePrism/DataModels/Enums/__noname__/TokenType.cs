using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TokenType
    {
        Null,
        False,
        True,
        StringValue,
        Number,
        Name,
        StartObject,
        EndObject,
        StartArray,
        EndArray,
        EndDocument,
    }
}
