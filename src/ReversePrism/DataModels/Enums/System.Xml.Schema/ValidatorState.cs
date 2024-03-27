using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ValidatorState
    {
        None,
        Start,
        TopLevelAttribute,
        TopLevelTextOrWS,
        Element,
        Attribute,
        EndOfAttributes,
        Text,
        Whitespace,
        EndElement,
        SkipToEndElement,
        Finish,
    }
}
