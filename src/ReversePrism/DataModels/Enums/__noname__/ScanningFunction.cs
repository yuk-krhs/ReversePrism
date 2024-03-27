using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ScanningFunction
    {
        SubsetContent,
        Name,
        QName,
        Nmtoken,
        Doctype1,
        Doctype2,
        Element1,
        Element2,
        Element3,
        Element4,
        Element5,
        Element6,
        Element7,
        Attlist1,
        Attlist2,
        Attlist3,
        Attlist4,
        Attlist5,
        Attlist6,
        Attlist7,
        Entity1,
        Entity2,
        Entity3,
        Notation1,
        CondSection1,
        CondSection2,
        CondSection3,
        Literal,
        SystemId,
        PublicId1,
        PublicId2,
        ClosingTag,
        ParamEntitySpace,
        None,
    }
}
