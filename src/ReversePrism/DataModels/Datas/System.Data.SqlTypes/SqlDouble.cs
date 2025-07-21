using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               ModelPrimitiveType bool bool bool Bool
    // 018 M_value                                  ModelPrimitiveType double double double Double
    // 000 Null                                     SqlDouble IL2CPP_TYPE_VALUETYPE
    // 010 Zero                                     ModelEnumType SqlDouble SqlDouble SqlDouble Int32
    // 020 MinValue                                 ModelEnumType SqlDouble SqlDouble SqlDouble Int32
    // 030 MaxValue                                 ModelEnumType SqlDouble SqlDouble SqlDouble Int32
    public partial class SqlDouble : DataModel
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
            var value   = new SqlDouble() { Pointer= p0 };

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0x10 M_fNotNull                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_value                                   = GetDouble(new IntPtr(p + 0x018)); // 0x18 M_value                     ( ModelPrimitiveType double double double Double )
            value.Zero                                      = (SqlDouble)GetInt32(new IntPtr(p + 0x010)); // 0x10 Zero                        ( ModelEnumType SqlDouble SqlDouble SqlDouble Int32 )
            value.MinValue                                  = (SqlDouble)GetInt32(new IntPtr(p + 0x020)); // 0x20 MinValue                    ( ModelEnumType SqlDouble SqlDouble SqlDouble Int32 )
            value.MaxValue                                  = (SqlDouble)GetInt32(new IntPtr(p + 0x030)); // 0x30 MaxValue                    ( ModelEnumType SqlDouble SqlDouble SqlDouble Int32 )

            return value;
        }
    }
}
