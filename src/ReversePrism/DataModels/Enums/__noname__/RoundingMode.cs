using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RoundingMode
    {
        FROUND_TO_NEAREST_INT,
        FROUND_TO_NEG_INF,
        FROUND_TO_POS_INF,
        FROUND_TO_ZERO,
        FROUND_CUR_DIRECTION,
        FROUND_RAISE_EXC,
        FROUND_NO_EXC,
        FROUND_NINT,
        FROUND_FLOOR,
        FROUND_CEIL,
        FROUND_TRUNC,
        FROUND_RINT,
        FROUND_NEARBYINT,
        FROUND_NINT_NOEXC,
        FROUND_FLOOR_NOEXC,
        FROUND_CEIL_NOEXC,
        FROUND_TRUNC_NOEXC,
        FROUND_RINT_NOEXC,
    }
}
