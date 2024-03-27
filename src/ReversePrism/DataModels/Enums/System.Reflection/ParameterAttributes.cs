using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ParameterAttributes
    {
        None,
        In,
        Out,
        Lcid,
        Retval,
        Optional,
        HasDefault,
        HasFieldMarshal,
        Reserved3,
        Reserved4,
        ReservedMask,
    }
}
