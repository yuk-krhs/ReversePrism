using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum HDRRangeReduction
    {
        None,
        Reinhard,
        BT2390,
        ACES1000Nits,
        ACES2000Nits,
        ACES4000Nits,
    }
}
