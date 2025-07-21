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
    // 000 zero                                     float3x2 IL2CPP_TYPE_VALUETYPE
    public partial class float3x2 : DataModel
    {
        public float3                                   C0                                      { get; set; }
        public float3                                   C1                                      { get; set; }

        public static float3x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float3x2() { Pointer= p0 };

            value.C0                                        = (float3)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType float3 float3 float3 Int32 )
            value.C1                                        = (float3)GetInt32(new IntPtr(p + 0x01C)); // 0x1C C1                          ( ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
