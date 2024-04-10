using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C7C90 ModelEnumType float4 float4 float4 Int32
    // 020 C1                                       0001866C7C90 ModelEnumType float4 float4 float4 Int32
    // 030 C2                                       0001866C7C90 ModelEnumType float4 float4 float4 Int32
    // 000 zero                                     float4x3 IL2CPP_TYPE_VALUETYPE
    public partial class float4x3 : DataModel
    {
        public float4                                   C0                                      { get; set; }
        public float4                                   C1                                      { get; set; }
        public float4                                   C2                                      { get; set; }

        public static float4x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float4x3() { Pointer= p0 };

            value.C0                                        = (float4)GetInt32(new IntPtr(p + 0x010)); // 024667F09F70 0x10 C0                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )
            value.C1                                        = (float4)GetInt32(new IntPtr(p + 0x020)); // 024667F09F90 0x20 C1                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )
            value.C2                                        = (float4)GetInt32(new IntPtr(p + 0x030)); // 024667F09FB0 0x30 C2                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
