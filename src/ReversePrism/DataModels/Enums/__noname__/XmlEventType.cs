using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum XmlEventType
    {
        Unknown,
        DocType,
        StartElem,
        StartAttr,
        EndAttr,
        CData,
        Comment,
        PI,
        Whitespace,
        String,
        Raw,
        EntRef,
        CharEnt,
        SurrCharEnt,
        Base64,
        BinHex,
        XmlDecl1,
        XmlDecl2,
        StartContent,
        EndElem,
        FullEndElem,
        Nmsp,
        EndBase64,
        Close,
        Flush,
        Dispose,
    }
}
