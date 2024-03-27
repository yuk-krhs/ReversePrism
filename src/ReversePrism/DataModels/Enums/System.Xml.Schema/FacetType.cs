using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FacetType
    {
        None,
        Length,
        MinLength,
        MaxLength,
        Pattern,
        Whitespace,
        Enumeration,
        MinExclusive,
        MinInclusive,
        MaxExclusive,
        MaxInclusive,
        TotalDigits,
        FractionDigits,
    }
}
