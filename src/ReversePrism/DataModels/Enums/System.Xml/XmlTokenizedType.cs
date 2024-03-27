using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum XmlTokenizedType
    {
        CDATA,
        ID,
        IDREF,
        IDREFS,
        ENTITY,
        ENTITIES,
        NMTOKEN,
        NMTOKENS,
        NOTATION,
        ENUMERATION,
        QName,
        NCName,
        None,
    }
}
