using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum XmlNodeType
    {
        None,
        Element,
        Attribute,
        Text,
        CDATA,
        EntityReference,
        Entity,
        ProcessingInstruction,
        Comment,
        Document,
        DocumentType,
        DocumentFragment,
        Notation,
        Whitespace,
        SignificantWhitespace,
        EndElement,
        EndEntity,
        XmlDeclaration,
    }
}
