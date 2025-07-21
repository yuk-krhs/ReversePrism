using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ShowAlpha                                ModelPrimitiveType bool bool bool Bool
    // 011 Hdr                                      ModelPrimitiveType bool bool bool Bool
    // 014 MinBrightness                            ModelPrimitiveType float float float Single
    // 018 MaxBrightness                            ModelPrimitiveType float float float Single
    // 01C MinExposureValue                         ModelPrimitiveType float float float Single
    // 020 MaxExposureValue                         ModelPrimitiveType float float float Single
    public partial class ColorUsageAttribute : DataModel
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
            var value   = new ColorUsageAttribute() { Pointer= p0 };

            value.ShowAlpha                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 ShowAlpha                   ( ModelPrimitiveType bool bool bool Bool )
            value.Hdr                                       = GetBool(new IntPtr(p + 0x011)); // 0x11 Hdr                         ( ModelPrimitiveType bool bool bool Bool )
            value.MinBrightness                             = GetSingle(new IntPtr(p + 0x014)); // 0x14 MinBrightness               ( ModelPrimitiveType float float float Single )
            value.MaxBrightness                             = GetSingle(new IntPtr(p + 0x018)); // 0x18 MaxBrightness               ( ModelPrimitiveType float float float Single )
            value.MinExposureValue                          = GetSingle(new IntPtr(p + 0x01C)); // 0x1C MinExposureValue            ( ModelPrimitiveType float float float Single )
            value.MaxExposureValue                          = GetSingle(new IntPtr(p + 0x020)); // 0x20 MaxExposureValue            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
