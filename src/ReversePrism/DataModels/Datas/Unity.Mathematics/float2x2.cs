using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType float2 float2 float2 Int32
    // 018 C1                                       ModelEnumType float2 float2 float2 Int32
    // 000 identity                                 float2x2 IL2CPP_TYPE_VALUETYPE
    // 010 Zero                                     ModelEnumType float2x2 float2x2 float2x2 Int32
    public partial class float2x2 : DataModel
    {
        public float2                                   C0                                      { get; set; }
        public float2                                   C1                                      { get; set; }
        public float2x2                                 Zero                                    { get; set; }

        public static float2x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float2x2() { Pointer= p0 };

            value.C0                                        = (float2)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType float2 float2 float2 Int32 )
            value.C1                                        = (float2)GetInt32(new IntPtr(p + 0x018)); // 0x18 C1                          ( ModelEnumType float2 float2 float2 Int32 )
            value.Zero                                      = (float2x2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Zero                        ( ModelEnumType float2x2 float2x2 float2x2 Int32 )

            return value;
        }
    }
}
