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
    public partial class SqlSingle : DataModel
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
            var value   = new SqlSingle() { Pointer= p0 };

            value.FNotNull                                  = GetBool(new IntPtr(p + 0x010)); // 024668A0EC10 0x10 FNotNull                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 024668A0EC30 0x14 Value                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MinValue                                  = (SqlSingle)GetInt32(new IntPtr(p + 0x010)); // 024668A0EC90 0x10 MinValue                    ( 00018655A210 ModelEnumType SqlSingle SqlSingle SqlSingle Int32 )
            value.MaxValue                                  = (SqlSingle)GetInt32(new IntPtr(p + 0x018)); // 024668A0ECB0 0x18 MaxValue                    ( 00018655A210 ModelEnumType SqlSingle SqlSingle SqlSingle Int32 )

            return value;
        }
    }
}
