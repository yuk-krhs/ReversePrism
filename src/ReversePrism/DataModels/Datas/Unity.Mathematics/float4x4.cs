using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType float4 float4 float4 Int32
    // 020 C1                                       ModelEnumType float4 float4 float4 Int32
    // 030 C2                                       ModelEnumType float4 float4 float4 Int32
    // 040 C3                                       ModelEnumType float4 float4 float4 Int32
    // 000 identity                                 float4x4 IL2CPP_TYPE_VALUETYPE
    // 040 Zero                                     ModelEnumType float4x4 float4x4 float4x4 Int32
    public partial class float4x4 : DataModel
    {
        public float4                                   C0                                      { get; set; }
        public float4                                   C1                                      { get; set; }
        public float4                                   C2                                      { get; set; }
        public float4                                   C3                                      { get; set; }
        public float4x4                                 Zero                                    { get; set; }

        public static float4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float4x4() { Pointer= p0 };

            value.C0                                        = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType float4 float4 float4 Int32 )
            value.C1                                        = (float4)GetInt32(new IntPtr(p + 0x020)); // 0x20 C1                          ( ModelEnumType float4 float4 float4 Int32 )
            value.C2                                        = (float4)GetInt32(new IntPtr(p + 0x030)); // 0x30 C2                          ( ModelEnumType float4 float4 float4 Int32 )
            value.C3                                        = (float4)GetInt32(new IntPtr(p + 0x040)); // 0x40 C3                          ( ModelEnumType float4 float4 float4 Int32 )
            value.Zero                                      = (float4x4)GetInt32(new IntPtr(p + 0x040)); // 0x40 Zero                        ( ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
