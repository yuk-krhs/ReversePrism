using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FNotNull                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 Value                                    0001866656B0 ModelPrimitiveType float float float Single
    // 000 Null                                     SqlSingle IL2CPP_TYPE_VALUETYPE
    // 008 Zero                                     SqlSingle IL2CPP_TYPE_VALUETYPE
    // 010 MinValue                                 00018655A210 ModelEnumType SqlSingle SqlSingle SqlSingle Int32
    // 018 MaxValue                                 00018655A210 ModelEnumType SqlSingle SqlSingle SqlSingle Int32
    public partial class SqlSingle
    {
        public bool                                     FNotNull                                { get; set; }
        public float                                    Value                                   { get; set; }
        public SqlSingle                                MinValue                                { get; set; }
        public SqlSingle                                MaxValue                                { get; set; }

        public static SqlSingle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlSingle();

            value.FNotNull                                  = GetBool(new IntPtr(p + 0x010)); // 0270D89A3CF8 0x10 FNotNull                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 0270D89A3D18 0x14 Value                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinValue                                  = (SqlSingle)GetInt32(new IntPtr(p + 0x010)); // 0270D89A3D78 0x10 MinValue                    ( 00018655A210 ModelEnumType SqlSingle SqlSingle SqlSingle Int32 )
            value.MaxValue                                  = (SqlSingle)GetInt32(new IntPtr(p + 0x018)); // 0270D89A3D98 0x18 MaxValue                    ( 00018655A210 ModelEnumType SqlSingle SqlSingle SqlSingle Int32 )

            return value;
        }
    }
}
