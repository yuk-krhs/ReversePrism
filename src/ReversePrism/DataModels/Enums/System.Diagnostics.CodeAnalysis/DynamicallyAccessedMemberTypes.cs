using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum DynamicallyAccessedMemberTypes
    {
        None,
        PublicParameterlessConstructor,
        PublicConstructors,
        NonPublicConstructors,
        PublicMethods,
        NonPublicMethods,
        PublicFields,
        NonPublicFields,
        PublicNestedTypes,
        NonPublicNestedTypes,
        PublicProperties,
        NonPublicProperties,
        PublicEvents,
        NonPublicEvents,
        All,
    }
}
