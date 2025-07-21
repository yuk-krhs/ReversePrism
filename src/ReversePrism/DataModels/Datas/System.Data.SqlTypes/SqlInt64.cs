using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               ModelPrimitiveType bool bool bool Bool
    // 018 M_value                                  ModelPrimitiveType long long long Int64
    // 000 s_lLowIntMask                            long IL2CPP_TYPE_I8
    // 008 s_lHighIntMask                           long IL2CPP_TYPE_I8
    // 010 Null                                     ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    // 020 Zero                                     ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    // 030 MinValue                                 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    // 040 MaxValue                                 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    public partial class SqlInt64 : DataModel
    {
        public bool                                     M_fNotNull                              { get; set; }
        public long                                     M_value                                 { get; set; }
        public SqlInt64                                 Null                                    { get; set; }
        public SqlInt64                                 Zero                                    { get; set; }
        public SqlInt64                                 MinValue                                { get; set; }
        public SqlInt64                                 MaxValue                                { get; set; }

        public static SqlInt64? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt64() { Pointer= p0 };

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0x10 M_fNotNull                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 M_value                     ( ModelPrimitiveType long long long Int64 )
            value.Null                                      = (SqlInt64)GetInt32(new IntPtr(p + 0x010)); // 0x10 Null                        ( ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )
            value.Zero                                      = (SqlInt64)GetInt32(new IntPtr(p + 0x020)); // 0x20 Zero                        ( ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )
            value.MinValue                                  = (SqlInt64)GetInt32(new IntPtr(p + 0x030)); // 0x30 MinValue                    ( ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )
            value.MaxValue                                  = (SqlInt64)GetInt32(new IntPtr(p + 0x040)); // 0x40 MaxValue                    ( ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )

            return value;
        }
    }
}
