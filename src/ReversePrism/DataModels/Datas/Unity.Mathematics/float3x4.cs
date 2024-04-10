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
    public partial class float3x4 : DataModel
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
            var value   = new float3x4() { Pointer= p0 };

            value.C0                                        = (float3)GetInt32(new IntPtr(p + 0x010)); // 024667EE5E98 0x10 C0                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C1                                        = (float3)GetInt32(new IntPtr(p + 0x01C)); // 024667EE5EB8 0x1C C1                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C2                                        = (float3)GetInt32(new IntPtr(p + 0x028)); // 024667EE5ED8 0x28 C2                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C3                                        = (float3)GetInt32(new IntPtr(p + 0x034)); // 024667EE5EF8 0x34 C3                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
