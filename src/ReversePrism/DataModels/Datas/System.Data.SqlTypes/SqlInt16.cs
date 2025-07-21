using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               ModelPrimitiveType bool bool bool Bool
    // 012 M_value                                  ModelPrimitiveType short short short Int16
    // 000 s_MASKI2                                 int IL2CPP_TYPE_I4
    // 004 Null                                     SqlInt16 IL2CPP_TYPE_VALUETYPE
    // 008 Zero                                     SqlInt16 IL2CPP_TYPE_VALUETYPE
    // 00C MinValue                                 SqlInt16 IL2CPP_TYPE_VALUETYPE
    // 010 MaxValue                                 ModelEnumType SqlInt16 SqlInt16 SqlInt16 Int32
    public partial class SqlInt16 : DataModel
    {
        public bool                                     M_fNotNull                              { get; set; }
        public short                                    M_value                                 { get; set; }
        public SqlInt16                                 MaxValue                                { get; set; }

        public static SqlInt16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt16() { Pointer= p0 };

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0x10 M_fNotNull                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetInt16(new IntPtr(p + 0x012)); // 0x12 M_value                     ( ModelPrimitiveType short short short Int16 )
            value.MaxValue                                  = (SqlInt16)GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxValue                    ( ModelEnumType SqlInt16 SqlInt16 SqlInt16 Int32 )

            return value;
        }
    }
}
