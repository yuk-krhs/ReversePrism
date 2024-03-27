using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RestrictionFlags
    {
        Length,
        MinLength,
        MaxLength,
        Pattern,
        Enumeration,
        WhiteSpace,
        MaxInclusive,
        MaxExclusive,
        MinInclusive,
        MinExclusive,
        TotalDigits,
        FractionDigits,
    }
}
