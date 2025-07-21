using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        ModelEnumType float2 float2 float2 Int32
    // 018 B                                        ModelEnumType float2 float2 float2 Int32
    // 020 Idx                                      ModelPrimitiveType int int int Int32
    // 024 Type                                     ModelPrimitiveType int int int Int32
    public partial class UEvent : DataModel
    {
        public float2                                   A                                       { get; set; }
        public float2                                   B                                       { get; set; }
        public int                                      Idx                                     { get; set; }
        public int                                      Type                                    { get; set; }

        public static UEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UEvent() { Pointer= p0 };

            value.A                                         = (float2)GetInt32(new IntPtr(p + 0x010)); // 0x10 A                           ( ModelEnumType float2 float2 float2 Int32 )
            value.B                                         = (float2)GetInt32(new IntPtr(p + 0x018)); // 0x18 B                           ( ModelEnumType float2 float2 float2 Int32 )
            value.Idx                                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 Idx                         ( ModelPrimitiveType int int int Int32 )
            value.Type                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Type                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
