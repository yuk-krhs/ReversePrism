using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxSingleValue                           sbyte IL2CPP_TYPE_U1
    // 000 MinSingleValue                           sbyte IL2CPP_TYPE_I1
    // 000 Byte                                     sbyte IL2CPP_TYPE_I1
    // 000 SByte                                    sbyte IL2CPP_TYPE_I1
    // 000 UInt16                                   sbyte IL2CPP_TYPE_I1
    // 000 Int16                                    sbyte IL2CPP_TYPE_I1
    // 000 UInt32                                   sbyte IL2CPP_TYPE_I1
    // 000 Int32                                    sbyte IL2CPP_TYPE_I1
    // 000 UInt64                                   sbyte IL2CPP_TYPE_I1
    // 000 Int64                                    sbyte IL2CPP_TYPE_I1
    public partial class VarIntCodes
    {

        public static VarIntCodes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VarIntCodes();


            return value;
        }
    }
}
