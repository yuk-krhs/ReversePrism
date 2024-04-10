using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_value                                  0001865F7700 ModelPrimitiveType long long long Int64
    // 000 s_lLowIntMask                            long IL2CPP_TYPE_I8
    // 008 s_lHighIntMask                           long IL2CPP_TYPE_I8
    // 010 Null                                     0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    // 020 Zero                                     0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    // 030 MinValue                                 0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
    // 040 MaxValue                                 0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32
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

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0246689EC478 0x10 M_fNotNull                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetInt64(new IntPtr(p + 0x018)); // 0246689EC498 0x18 M_value                     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Null                                      = (SqlInt64)GetInt32(new IntPtr(p + 0x010)); // 0246689EC4F8 0x10 Null                        ( 0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )
            value.Zero                                      = (SqlInt64)GetInt32(new IntPtr(p + 0x020)); // 0246689EC518 0x20 Zero                        ( 0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )
            value.MinValue                                  = (SqlInt64)GetInt32(new IntPtr(p + 0x030)); // 0246689EC538 0x30 MinValue                    ( 0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )
            value.MaxValue                                  = (SqlInt64)GetInt32(new IntPtr(p + 0x040)); // 0246689EC558 0x40 MaxValue                    ( 0001865593B0 ModelEnumType SqlInt64 SqlInt64 SqlInt64 Int32 )

            return value;
        }
    }
}
