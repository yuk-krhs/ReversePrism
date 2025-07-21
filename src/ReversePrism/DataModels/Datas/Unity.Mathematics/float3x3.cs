using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType float3 float3 float3 Int32
    // 01C C1                                       ModelEnumType float3 float3 float3 Int32
    // 028 C2                                       ModelEnumType float3 float3 float3 Int32
    // 000 identity                                 float3x3 IL2CPP_TYPE_VALUETYPE
    // 024 Zero                                     ModelEnumType float3x3 float3x3 float3x3 Int32
    public partial class float3x3 : DataModel
    {
        public float3                                   C0                                      { get; set; }
        public float3                                   C1                                      { get; set; }
        public float3                                   C2                                      { get; set; }
        public float3x3                                 Zero                                    { get; set; }

        public static float3x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float3x3() { Pointer= p0 };

            value.C0                                        = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType float3 float3 float3 Int32 )
            value.C1                                        = (float3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C C1                          ( ModelEnumType float3 float3 float3 Int32 )
            value.C2                                        = (float3)GetInt32(new IntPtr(p + 0x028)); // 0x28 C2                          ( ModelEnumType float3 float3 float3 Int32 )
            value.Zero                                      = (float3x3)GetInt32(new IntPtr(p + 0x024)); // 0x24 Zero                        ( ModelEnumType float3x3 float3x3 float3x3 Int32 )

            return value;
        }
    }
}
