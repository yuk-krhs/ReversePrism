using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum AttributeTargets
    {
        Assembly,
        Module,
        Class,
        Struct,
        Enum,
        Constructor,
        Method,
        Property,
        Field,
        Event,
        Interface,
        Parameter,
        Delegate,
        ReturnValue,
        GenericParameter,
        All,
    }
}
