using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum XmlSchemaDerivationMethod
    {
        Empty,
        Substitution,
        Extension,
        Restriction,
        List,
        Union,
        All,
        None,
    }
}
