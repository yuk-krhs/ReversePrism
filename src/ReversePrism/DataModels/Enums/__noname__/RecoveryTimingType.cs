using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RecoveryTimingType
    {
        Recovery_60_51,
        Recovery_50_41,
        Recovery_40_31,
        Recovery_Under30,
    }
}
