using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum StyleSelectorType
    {
        Unknown,
        Wildcard,
        Type,
        Class,
        PseudoClass,
        RecursivePseudoClass,
        ID,
        Predicate,
    }
}
