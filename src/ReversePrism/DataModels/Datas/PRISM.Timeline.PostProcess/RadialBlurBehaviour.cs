using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 QualityLevel                             ModelEnumType RadialBlurQuality RadialBlurQuality RadialBlurQuality Int32
    // 018 BlurRadius                               ModelPrimitiveType float float float Single
    // 01C RadialCenterX                            ModelPrimitiveType float float float Single
    // 020 RadialCenterY                            ModelPrimitiveType float float float Single
    // 024 RotateIntensity                          ModelPrimitiveType float float float Single
    public partial class RadialBlurBehaviour : DataModel
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
            var value   = new RadialBlurBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.QualityLevel                              = (RadialBlurQuality)GetInt32(new IntPtr(p + 0x014)); // 0x14 QualityLevel                ( ModelEnumType RadialBlurQuality RadialBlurQuality RadialBlurQuality Int32 )
            value.BlurRadius                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 BlurRadius                  ( ModelPrimitiveType float float float Single )
            value.RadialCenterX                             = GetSingle(new IntPtr(p + 0x01C)); // 0x1C RadialCenterX               ( ModelPrimitiveType float float float Single )
            value.RadialCenterY                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 RadialCenterY               ( ModelPrimitiveType float float float Single )
            value.RotateIntensity                           = GetSingle(new IntPtr(p + 0x024)); // 0x24 RotateIntensity             ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
