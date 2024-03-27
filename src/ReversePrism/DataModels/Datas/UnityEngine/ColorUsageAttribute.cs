using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShowAlpha                                000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 011 Hdr                                      000186596AF0 ModelPrimitiveType bool bool bool Bool
    // 014 MinBrightness                            000186666F40 ModelPrimitiveType float float float Single
    // 018 MaxBrightness                            000186666F40 ModelPrimitiveType float float float Single
    // 01C MinExposureValue                         000186666F40 ModelPrimitiveType float float float Single
    // 020 MaxExposureValue                         000186666F40 ModelPrimitiveType float float float Single
    public partial class ColorUsageAttribute
    {
        public bool                                     ShowAlpha                               { get; set; }
        public bool                                     Hdr                                     { get; set; }
        public float                                    MinBrightness                           { get; set; }
        public float                                    MaxBrightness                           { get; set; }
        public float                                    MinExposureValue                        { get; set; }
        public float                                    MaxExposureValue                        { get; set; }

        public static ColorUsageAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorUsageAttribute();

            value.ShowAlpha                                 = GetBool(new IntPtr(p + 0x010)); // 0270068B85C0 0x10 ShowAlpha                   ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.Hdr                                       = GetBool(new IntPtr(p + 0x011)); // 0270068B85E0 0x11 Hdr                         ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )
            value.MinBrightness                             = GetSingle(new IntPtr(p + 0x014)); // 0270068B8600 0x14 MinBrightness               ( 000186666F40 ModelPrimitiveType float float float Single )
            value.MaxBrightness                             = GetSingle(new IntPtr(p + 0x018)); // 0270068B8620 0x18 MaxBrightness               ( 000186666F40 ModelPrimitiveType float float float Single )
            value.MinExposureValue                          = GetSingle(new IntPtr(p + 0x01C)); // 0270068B8640 0x1C MinExposureValue            ( 000186666F40 ModelPrimitiveType float float float Single )
            value.MaxExposureValue                          = GetSingle(new IntPtr(p + 0x020)); // 0270068B8660 0x20 MaxExposureValue            ( 000186666F40 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
