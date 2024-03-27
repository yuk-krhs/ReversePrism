using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PropertyAttributes
    {
        None,
        SpecialName,
        RTSpecialName,
        HasDefault,
        Reserved2,
        Reserved3,
        Reserved4,
        ReservedMask,
    }
}
