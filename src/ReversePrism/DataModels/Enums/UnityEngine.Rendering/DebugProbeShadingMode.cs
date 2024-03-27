using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DebugProbeShadingMode
    {
        SH,
        SHL0,
        SHL0L1,
        Validity,
        ValidityOverDilationThreshold,
        InvalidatedByTouchupVolumes,
        Size,
    }
}
