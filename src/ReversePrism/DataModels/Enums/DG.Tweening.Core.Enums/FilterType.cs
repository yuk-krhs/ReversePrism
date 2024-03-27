using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FilterType
    {
        All,
        TargetOrId,
        TargetAndId,
        AllExceptTargetsOrIds,
        DOGetter,
    }
}
