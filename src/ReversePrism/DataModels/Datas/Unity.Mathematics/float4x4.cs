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
    // 040 C3                                       0001866C7C90 ModelEnumType float4 float4 float4 Int32
    // 000 identity                                 float4x4 IL2CPP_TYPE_VALUETYPE
    // 040 Zero                                     0001865EDB50 ModelEnumType float4x4 float4x4 float4x4 Int32
    public partial class float4x4
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
            var value   = new float4x4();

            value.C0                                        = (float4)GetInt32(new IntPtr(p + 0x010)); // 0270015965B0 0x10 C0                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )
            value.C1                                        = (float4)GetInt32(new IntPtr(p + 0x020)); // 0270015965D0 0x20 C1                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )
            value.C2                                        = (float4)GetInt32(new IntPtr(p + 0x030)); // 0270015965F0 0x30 C2                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )
            value.C3                                        = (float4)GetInt32(new IntPtr(p + 0x040)); // 027001596610 0x40 C3                          ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )
            value.Zero                                      = (float4x4)GetInt32(new IntPtr(p + 0x040)); // 027001596650 0x40 Zero                        ( 0001865EDB50 ModelEnumType float4x4 float4x4 float4x4 Int32 )

            return value;
        }
    }
}
