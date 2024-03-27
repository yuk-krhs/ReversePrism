using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum LastLoginTimeType
    {
        Less60S,
        MoreThan60MLess60S,
        MoreThan60MLessThan24H,
        MoreThan24HLessThan7D,
        MoreThan7D,
    }
}
