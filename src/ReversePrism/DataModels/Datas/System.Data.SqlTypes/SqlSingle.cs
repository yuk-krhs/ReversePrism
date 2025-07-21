using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FNotNull                                 ModelPrimitiveType bool bool bool Bool
    // 014 Value                                    ModelPrimitiveType float float float Single
    // 000 Null                                     SqlSingle IL2CPP_TYPE_VALUETYPE
    // 008 Zero                                     SqlSingle IL2CPP_TYPE_VALUETYPE
    // 010 MinValue                                 ModelEnumType SqlSingle SqlSingle SqlSingle Int32
    // 018 MaxValue                                 ModelEnumType SqlSingle SqlSingle SqlSingle Int32
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

            value.FNotNull                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 FNotNull                    ( ModelPrimitiveType bool bool bool Bool )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 0x14 Value                       ( ModelPrimitiveType float float float Single )
            value.MinValue                                  = (SqlSingle)GetInt32(new IntPtr(p + 0x010)); // 0x10 MinValue                    ( ModelEnumType SqlSingle SqlSingle SqlSingle Int32 )
            value.MaxValue                                  = (SqlSingle)GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxValue                    ( ModelEnumType SqlSingle SqlSingle SqlSingle Int32 )

            return value;
        }
    }
}
