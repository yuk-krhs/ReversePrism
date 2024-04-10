using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SHAr                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 SHAg                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 SHAb                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 040 SHBr                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 SHBg                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 SHBb                                     0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 070 SHC                                      0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 080 ProbesOcclusion                          0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class SHCoefficients : DataModel
    {
        public Vector4                                  SHAr                                    { get; set; }
        public Vector4                                  SHAg                                    { get; set; }
        public Vector4                                  SHAb                                    { get; set; }
        public Vector4                                  SHBr                                    { get; set; }
        public Vector4                                  SHBg                                    { get; set; }
        public Vector4                                  SHBb                                    { get; set; }
        public Vector4                                  SHC                                     { get; set; }
        public Vector4                                  ProbesOcclusion                         { get; set; }

        public static SHCoefficients? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHCoefficients() { Pointer= p0 };

            value.SHAr                                      = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0246692FE2C8 0x10 SHAr                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHAg                                      = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0246692FE2E8 0x20 SHAg                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHAb                                      = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0246692FE308 0x30 SHAb                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHBr                                      = (Vector4)GetInt32(new IntPtr(p + 0x040)); // 0246692FE328 0x40 SHBr                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHBg                                      = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0246692FE348 0x50 SHBg                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHBb                                      = (Vector4)GetInt32(new IntPtr(p + 0x060)); // 0246692FE368 0x60 SHBb                        ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHC                                       = (Vector4)GetInt32(new IntPtr(p + 0x070)); // 0246692FE388 0x70 SHC                         ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ProbesOcclusion                           = (Vector4)GetInt32(new IntPtr(p + 0x080)); // 0246692FE3A8 0x80 ProbesOcclusion             ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
