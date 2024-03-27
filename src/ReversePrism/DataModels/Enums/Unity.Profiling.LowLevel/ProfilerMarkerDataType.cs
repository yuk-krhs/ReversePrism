using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProfilerMarkerDataType
    {
        InstanceId,
        Int32,
        UInt32,
        Int64,
        UInt64,
        Float,
        Double,
        String16,
        Blob8,
        GfxResourceId,
    }
}
