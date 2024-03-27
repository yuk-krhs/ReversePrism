using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 V0                                       0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 V1                                       0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 V2                                       0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class Transform3x4
    {
        public Vector4                                  V0                                      { get; set; }
        public Vector4                                  V1                                      { get; set; }
        public Vector4                                  V2                                      { get; set; }

        public static Transform3x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Transform3x4();

            value.V0                                        = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0270068601D0 0x10 V0                          ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.V1                                        = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0270068601F0 0x20 V1                          ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.V2                                        = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 027006860210 0x30 V2                          ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
