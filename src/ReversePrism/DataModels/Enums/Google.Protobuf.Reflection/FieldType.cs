using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FieldType
    {
        Double,
        Float,
        Int64,
        UInt64,
        Int32,
        Fixed64,
        Fixed32,
        Bool,
        String,
        Group,
        Message,
        Bytes,
        UInt32,
        SFixed32,
        SFixed64,
        SInt32,
        SInt64,
        Enum,
    }
}
