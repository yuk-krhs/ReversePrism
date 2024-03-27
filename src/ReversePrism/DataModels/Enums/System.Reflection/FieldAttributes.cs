using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FieldAttributes
    {
        FieldAccessMask,
        PrivateScope,
        Private,
        FamANDAssem,
        Assembly,
        Family,
        FamORAssem,
        Public,
        Static,
        InitOnly,
        Literal,
        NotSerialized,
        SpecialName,
        PinvokeImpl,
        RTSpecialName,
        HasFieldMarshal,
        HasDefault,
        HasFieldRVA,
        ReservedMask,
    }
}
