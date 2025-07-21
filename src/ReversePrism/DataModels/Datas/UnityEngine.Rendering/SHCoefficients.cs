using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SHAr                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 SHAg                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 030 SHAb                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 040 SHBr                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 SHBg                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 060 SHBb                                     ModelEnumType Vector4 Vector4 Vector4 Int32
    // 070 SHC                                      ModelEnumType Vector4 Vector4 Vector4 Int32
    // 080 ProbesOcclusion                          ModelEnumType Vector4 Vector4 Vector4 Int32
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

            value.SHAr                                      = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0x10 SHAr                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHAg                                      = (Vector4)GetInt32(new IntPtr(p + 0x020)); // 0x20 SHAg                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHAb                                      = (Vector4)GetInt32(new IntPtr(p + 0x030)); // 0x30 SHAb                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHBr                                      = (Vector4)GetInt32(new IntPtr(p + 0x040)); // 0x40 SHBr                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHBg                                      = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0x50 SHBg                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHBb                                      = (Vector4)GetInt32(new IntPtr(p + 0x060)); // 0x60 SHBb                        ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.SHC                                       = (Vector4)GetInt32(new IntPtr(p + 0x070)); // 0x70 SHC                         ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ProbesOcclusion                           = (Vector4)GetInt32(new IntPtr(p + 0x080)); // 0x80 ProbesOcclusion             ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
