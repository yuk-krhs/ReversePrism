using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_value                                  0001865C2950 ModelPrimitiveType double double double Double
    // 000 Null                                     SqlDouble IL2CPP_TYPE_VALUETYPE
    // 010 Zero                                     000186557AB0 ModelEnumType SqlDouble SqlDouble SqlDouble Int32
    // 020 MinValue                                 000186557AB0 ModelEnumType SqlDouble SqlDouble SqlDouble Int32
    // 030 MaxValue                                 000186557AB0 ModelEnumType SqlDouble SqlDouble SqlDouble Int32
    public partial class SqlDouble
    {
        public bool                                     M_fNotNull                              { get; set; }
        public double                                   M_value                                 { get; set; }
        public SqlDouble                                Zero                                    { get; set; }
        public SqlDouble                                MinValue                                { get; set; }
        public SqlDouble                                MaxValue                                { get; set; }

        public static SqlDouble? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDouble();

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0270D8982920 0x10 M_fNotNull                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetDouble(new IntPtr(p + 0x018)); // 0270D8982940 0x18 M_value                     ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.Zero                                      = (SqlDouble)GetInt32(new IntPtr(p + 0x010)); // 0270D8982980 0x10 Zero                        ( 000186557AB0 ModelEnumType SqlDouble SqlDouble SqlDouble Int32 )
            value.MinValue                                  = (SqlDouble)GetInt32(new IntPtr(p + 0x020)); // 0270D89829A0 0x20 MinValue                    ( 000186557AB0 ModelEnumType SqlDouble SqlDouble SqlDouble Int32 )
            value.MaxValue                                  = (SqlDouble)GetInt32(new IntPtr(p + 0x030)); // 0270D89829C0 0x30 MaxValue                    ( 000186557AB0 ModelEnumType SqlDouble SqlDouble SqlDouble Int32 )

            return value;
        }
    }
}
