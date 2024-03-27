using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Tag
    {
        kUnknown,
        kIntVal,
        kInt64Val,
        kUInt64Val,
        kDoubleVal,
        kBoolVal,
        kStringVal,
        kArrayVal,
        kMixedArrayVal,
        kMapVal,
        kMaxTags,
    }
}
