using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    // 01C C1                                       0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    // 028 C2                                       0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    // 034 C3                                       0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    // 000 zero                                     float3x4 IL2CPP_TYPE_VALUETYPE
    public partial class float3x4
    {
        public float3                                   C0                                      { get; set; }
        public float3                                   C1                                      { get; set; }
        public float3                                   C2                                      { get; set; }
        public float3                                   C3                                      { get; set; }

        public static float3x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float3x4();

            value.C0                                        = (float3)GetInt32(new IntPtr(p + 0x010)); // 0270D7E7DE98 0x10 C0                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C1                                        = (float3)GetInt32(new IntPtr(p + 0x01C)); // 0270D7E7DEB8 0x1C C1                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C2                                        = (float3)GetInt32(new IntPtr(p + 0x028)); // 0270D7E7DED8 0x28 C2                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C3                                        = (float3)GetInt32(new IntPtr(p + 0x034)); // 0270D7E7DEF8 0x34 C3                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
