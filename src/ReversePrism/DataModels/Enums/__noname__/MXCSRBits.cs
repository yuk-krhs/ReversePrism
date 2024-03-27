using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MXCSRBits
    {
        FlushToZero,
        RoundingControlMask,
        RoundToNearest,
        RoundDown,
        RoundUp,
        RoundTowardZero,
        PrecisionMask,
        UnderflowMask,
        OverflowMask,
        DivideByZeroMask,
        DenormalOperationMask,
        InvalidOperationMask,
        ExceptionMask,
        DenormalsAreZeroes,
        PrecisionFlag,
        UnderflowFlag,
        OverflowFlag,
        DivideByZeroFlag,
        DenormalFlag,
        InvalidOperationFlag,
        FlagMask,
    }
}
