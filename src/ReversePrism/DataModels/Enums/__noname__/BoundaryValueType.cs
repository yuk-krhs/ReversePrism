using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum BoundaryValueType
    {
        MaxHeightmapRes,
        MinDetailResPerPatch,
        MaxDetailResPerPatch,
        MaxDetailPatchCount,
        MaxCoveragePerRes,
        MinAlphamapRes,
        MaxAlphamapRes,
        MinBaseMapRes,
        MaxBaseMapRes,
    }
}
