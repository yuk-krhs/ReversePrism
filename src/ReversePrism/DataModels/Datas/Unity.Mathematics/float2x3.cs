using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C5E10 ModelEnumType float2 float2 float2 Int32
    // 018 C1                                       0001866C5E10 ModelEnumType float2 float2 float2 Int32
    // 020 C2                                       0001866C5E10 ModelEnumType float2 float2 float2 Int32
    // 000 zero                                     float2x3 IL2CPP_TYPE_VALUETYPE
    public partial class float2x3 : DataModel
    {
        public float2                                   C0                                      { get; set; }
        public float2                                   C1                                      { get; set; }
        public float2                                   C2                                      { get; set; }

        public static float2x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float2x3() { Pointer= p0 };

            value.C0                                        = (float2)GetInt32(new IntPtr(p + 0x010)); // 024667EC0FD0 0x10 C0                          ( 0001866C5E10 ModelEnumType float2 float2 float2 Int32 )
            value.C1                                        = (float2)GetInt32(new IntPtr(p + 0x018)); // 024667EC0FF0 0x18 C1                          ( 0001866C5E10 ModelEnumType float2 float2 float2 Int32 )
            value.C2                                        = (float2)GetInt32(new IntPtr(p + 0x020)); // 024667EC1010 0x20 C2                          ( 0001866C5E10 ModelEnumType float2 float2 float2 Int32 )

            return value;
        }
    }
}
