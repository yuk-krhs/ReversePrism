using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShAr                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 ShAg                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 ShAb                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 000 zero                                     SphericalHarmonicsL1 IL2CPP_TYPE_VALUETYPE
    public partial class SphericalHarmonicsL1
    {
        public Vector4                                  ShAr                                    { get; set; }
        public Vector4                                  ShAg                                    { get; set; }
        public Vector4                                  ShAb                                    { get; set; }

        public static SphericalHarmonicsL1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SphericalHarmonicsL1();

            value.ShAr                                      = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0270D9252F00 0x10 ShAr                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ShAg                                      = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0270D9252F20 0x20 ShAg                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ShAb                                      = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0270D9252F40 0x30 ShAb                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
