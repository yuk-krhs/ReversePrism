using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DataType
    {
        Vector3,
        ByteArray,
        IntArray,
        FloatArray,
        Bool,
        Byte,
        Int,
        Float,
        Long,
        String,
        Null,
        Quaternion,
        StringArray,
        End,
    }
}
