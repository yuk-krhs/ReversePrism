using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               ModelPrimitiveType bool bool bool Bool
    // 011 M_value                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    // 000 s_iBitNotByteMax                         int IL2CPP_TYPE_I4
    // 004 Null                                     SqlByte IL2CPP_TYPE_VALUETYPE
    // 006 Zero                                     SqlByte IL2CPP_TYPE_VALUETYPE
    // 008 MinValue                                 SqlByte IL2CPP_TYPE_VALUETYPE
    // 00A MaxValue                                 SqlByte IL2CPP_TYPE_VALUETYPE
    public partial class SqlByte : DataModel
    {
        public bool                                     M_fNotNull                              { get; set; }
        public sbyte                                    M_value                                 { get; set; }

        public static SqlByte? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlByte() { Pointer= p0 };

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0x10 M_fNotNull                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_value                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
