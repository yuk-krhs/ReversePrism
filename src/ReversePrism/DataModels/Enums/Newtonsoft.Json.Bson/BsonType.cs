using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum BsonType
    {
        Number,
        String,
        Object,
        Array,
        Binary,
        Undefined,
        Oid,
        Boolean,
        Date,
        Null,
        Regex,
        Reference,
        Code,
        Symbol,
        CodeWScope,
        Integer,
        TimeStamp,
        Long,
        MinKey,
        MaxKey,
    }
}
