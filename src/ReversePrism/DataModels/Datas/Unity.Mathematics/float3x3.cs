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
    // 000 identity                                 float3x3 IL2CPP_TYPE_VALUETYPE
    // 024 Zero                                     0001865EC880 ModelEnumType float3x3 float3x3 float3x3 Int32
    public partial class float3x3
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
            var value   = new float3x3();

            value.C0                                        = (float3)GetInt32(new IntPtr(p + 0x010)); // 02700158CD60 0x10 C0                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C1                                        = (float3)GetInt32(new IntPtr(p + 0x01C)); // 02700158CD80 0x1C C1                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.C2                                        = (float3)GetInt32(new IntPtr(p + 0x028)); // 02700158CDA0 0x28 C2                          ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.Zero                                      = (float3x3)GetInt32(new IntPtr(p + 0x024)); // 02700158CDE0 0x24 Zero                        ( 0001865EC880 ModelEnumType float3x3 float3x3 float3x3 Int32 )

            return value;
        }
    }
}
