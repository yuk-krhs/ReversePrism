using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum UnmanagedType
    {
        Bool,
        I1,
        U1,
        I2,
        U2,
        I4,
        U4,
        I8,
        U8,
        R4,
        R8,
        Currency,
        BStr,
        LPStr,
        LPWStr,
        LPTStr,
        ByValTStr,
        IUnknown,
        IDispatch,
        Struct,
        Interface,
        SafeArray,
        ByValArray,
        SysInt,
        SysUInt,
        VBByRefStr,
        AnsiBStr,
        TBStr,
        VariantBool,
        FunctionPtr,
        AsAny,
        LPArray,
        LPStruct,
        CustomMarshaler,
        Error,
        IInspectable,
        HString,
        LPUTF8Str,
    }
}
