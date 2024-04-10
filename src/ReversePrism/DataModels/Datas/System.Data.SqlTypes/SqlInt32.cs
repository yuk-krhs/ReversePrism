using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 M_value                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 s_iIntMin                                long IL2CPP_TYPE_I8
    // 008 s_lBitNotIntMax                          long IL2CPP_TYPE_I8
    // 010 Null                                     000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32
    // 018 Zero                                     000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32
    // 020 MinValue                                 000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32
    // 028 MaxValue                                 000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32
    public partial class SqlInt32 : DataModel
    {
        public bool                                     M_fNotNull                              { get; set; }
        public int                                      M_value                                 { get; set; }
        public SqlInt32                                 Null                                    { get; set; }
        public SqlInt32                                 Zero                                    { get; set; }
        public SqlInt32                                 MinValue                                { get; set; }
        public SqlInt32                                 MaxValue                                { get; set; }

        public static SqlInt32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlInt32() { Pointer= p0 };

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 024668A0CB60 0x10 M_fNotNull                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetInt32(new IntPtr(p + 0x014)); // 024668A0CB80 0x14 M_value                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Null                                      = (SqlInt32)GetInt32(new IntPtr(p + 0x010)); // 024668A0CBE0 0x10 Null                        ( 000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32 )
            value.Zero                                      = (SqlInt32)GetInt32(new IntPtr(p + 0x018)); // 024668A0CC00 0x18 Zero                        ( 000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32 )
            value.MinValue                                  = (SqlInt32)GetInt32(new IntPtr(p + 0x020)); // 024668A0CC20 0x20 MinValue                    ( 000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32 )
            value.MaxValue                                  = (SqlInt32)GetInt32(new IntPtr(p + 0x028)); // 024668A0CC40 0x28 MaxValue                    ( 000186558D10 ModelEnumType SqlInt32 SqlInt32 SqlInt32 Int32 )

            return value;
        }
    }
}
