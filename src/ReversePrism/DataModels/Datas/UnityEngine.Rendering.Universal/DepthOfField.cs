using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Mode                                     ModelClassType DepthOfFieldModeParameter DepthOfFieldModeParameter DepthOfFieldModeParameter Pointer
    // 040 GaussianStart                            ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 048 GaussianEnd                              ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 050 GaussianMaxRadius                        ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 058 HighQualitySampling                      ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 060 FocusDistance                            ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer
    // 068 Aperture                                 ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 070 FocalLength                              ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 078 BladeCount                               ModelClassType ClampedIntParameter ClampedIntParameter ClampedIntParameter Pointer
    // 080 BladeCurvature                           ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 088 BladeRotation                            ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class DepthOfField : DataModel
    {
        public DepthOfFieldModeParameter?               Mode                                    { get; set; }
        public MinFloatParameter?                       GaussianStart                           { get; set; }
        public MinFloatParameter?                       GaussianEnd                             { get; set; }
        public ClampedFloatParameter?                   GaussianMaxRadius                       { get; set; }
        public BoolParameter?                           HighQualitySampling                     { get; set; }
        public MinFloatParameter?                       FocusDistance                           { get; set; }
        public ClampedFloatParameter?                   Aperture                                { get; set; }
        public ClampedFloatParameter?                   FocalLength                             { get; set; }
        public ClampedIntParameter?                     BladeCount                              { get; set; }
        public ClampedFloatParameter?                   BladeCurvature                          { get; set; }
        public ClampedFloatParameter?                   BladeRotation                           { get; set; }

        public static DepthOfField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfField() { Pointer= p0 };

            value.Mode                                      = GetObject<DepthOfFieldModeParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.DepthOfFieldModeParameter.FromPointer); // 0x38 Mode                        ( ModelClassType DepthOfFieldModeParameter DepthOfFieldModeParameter DepthOfFieldModeParameter Pointer )
            value.GaussianStart                             = GetObject<MinFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x40 GaussianStart               ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.GaussianEnd                               = GetObject<MinFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x48 GaussianEnd                 ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.GaussianMaxRadius                         = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 GaussianMaxRadius           ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.HighQualitySampling                       = GetObject<BoolParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x58 HighQualitySampling         ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.FocusDistance                             = GetObject<MinFloatParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.MinFloatParameter.FromPointer); // 0x60 FocusDistance               ( ModelClassType MinFloatParameter MinFloatParameter MinFloatParameter Pointer )
            value.Aperture                                  = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x68 Aperture                    ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.FocalLength                               = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x70 FocalLength                 ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.BladeCount                                = GetObject<ClampedIntParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.ClampedIntParameter.FromPointer); // 0x78 BladeCount                  ( ModelClassType ClampedIntParameter ClampedIntParameter ClampedIntParameter Pointer )
            value.BladeCurvature                            = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x080), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x80 BladeCurvature              ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.BladeRotation                             = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x088), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x88 BladeRotation               ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
