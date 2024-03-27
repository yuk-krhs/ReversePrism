using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 QualityLevel                             000186607E40 ModelEnumType RadialBlurQuality RadialBlurQuality RadialBlurQuality Int32
    // 018 BlurRadius                               000186666050 ModelPrimitiveType float float float Single
    // 01C RadialCenterX                            000186666050 ModelPrimitiveType float float float Single
    // 020 RadialCenterY                            000186666050 ModelPrimitiveType float float float Single
    // 024 RotateIntensity                          000186666050 ModelPrimitiveType float float float Single
    public partial class RadialBlurBehaviour
    {
        public bool                                     Enable                                  { get; set; }
        public RadialBlurQuality                        QualityLevel                            { get; set; }
        public float                                    BlurRadius                              { get; set; }
        public float                                    RadialCenterX                           { get; set; }
        public float                                    RadialCenterY                           { get; set; }
        public float                                    RotateIntensity                         { get; set; }

        public static RadialBlurBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RadialBlurBehaviour();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270D5075A88 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.QualityLevel                              = (RadialBlurQuality)GetInt32(new IntPtr(p + 0x014)); // 0270D5075AA8 0x14 QualityLevel                ( 000186607E40 ModelEnumType RadialBlurQuality RadialBlurQuality RadialBlurQuality Int32 )
            value.BlurRadius                                = GetSingle(new IntPtr(p + 0x018)); // 0270D5075AC8 0x18 BlurRadius                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.RadialCenterX                             = GetSingle(new IntPtr(p + 0x01C)); // 0270D5075AE8 0x1C RadialCenterX               ( 000186666050 ModelPrimitiveType float float float Single )
            value.RadialCenterY                             = GetSingle(new IntPtr(p + 0x020)); // 0270D5075B08 0x20 RadialCenterY               ( 000186666050 ModelPrimitiveType float float float Single )
            value.RotateIntensity                           = GetSingle(new IntPtr(p + 0x024)); // 0270D5075B28 0x24 RotateIntensity             ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
