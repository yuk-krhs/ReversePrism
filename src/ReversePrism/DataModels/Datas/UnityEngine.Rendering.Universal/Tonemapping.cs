using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Mode                                     ModelClassType TonemappingModeParameter TonemappingModeParameter TonemappingModeParameter Pointer
    // 040 NeutralHDRRangeReductionMode             ModelClassType NeutralRangeReductionModeParameter NeutralRangeReductionModeParameter NeutralRangeReductionModeParameter Pointer
    // 048 AcesPreset                               ModelClassType HDRACESPresetParameter HDRACESPresetParameter HDRACESPresetParameter Pointer
    // 050 HueShiftAmount                           ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 058 DetectPaperWhite                         ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 060 PaperWhite                               ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 068 DetectBrightnessLimits                   ModelClassType BoolParameter BoolParameter BoolParameter Pointer
    // 070 MinNits                                  ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 078 MaxNits                                  ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class Tonemapping : DataModel
    {
        public TonemappingModeParameter?                Mode                                    { get; set; }
        public NeutralRangeReductionModeParameter?      NeutralHDRRangeReductionMode            { get; set; }
        public HDRACESPresetParameter?                  AcesPreset                              { get; set; }
        public ClampedFloatParameter?                   HueShiftAmount                          { get; set; }
        public BoolParameter?                           DetectPaperWhite                        { get; set; }
        public ClampedFloatParameter?                   PaperWhite                              { get; set; }
        public BoolParameter?                           DetectBrightnessLimits                  { get; set; }
        public ClampedFloatParameter?                   MinNits                                 { get; set; }
        public ClampedFloatParameter?                   MaxNits                                 { get; set; }

        public static Tonemapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tonemapping() { Pointer= p0 };

            value.Mode                                      = GetObject<TonemappingModeParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.TonemappingModeParameter.FromPointer); // 0x38 Mode                        ( ModelClassType TonemappingModeParameter TonemappingModeParameter TonemappingModeParameter Pointer )
            value.NeutralHDRRangeReductionMode              = GetObject<NeutralRangeReductionModeParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.NeutralRangeReductionModeParameter.FromPointer); // 0x40 NeutralHDRRangeReductionMode ( ModelClassType NeutralRangeReductionModeParameter NeutralRangeReductionModeParameter NeutralRangeReductionModeParameter Pointer )
            value.AcesPreset                                = GetObject<HDRACESPresetParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.HDRACESPresetParameter.FromPointer); // 0x48 AcesPreset                  ( ModelClassType HDRACESPresetParameter HDRACESPresetParameter HDRACESPresetParameter Pointer )
            value.HueShiftAmount                            = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x50 HueShiftAmount              ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.DetectPaperWhite                          = GetObject<BoolParameter>(new IntPtr(p + 0x058), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x58 DetectPaperWhite            ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.PaperWhite                                = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x60 PaperWhite                  ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.DetectBrightnessLimits                    = GetObject<BoolParameter>(new IntPtr(p + 0x068), ReversePrism.DataModels.BoolParameter.FromPointer); // 0x68 DetectBrightnessLimits      ( ModelClassType BoolParameter BoolParameter BoolParameter Pointer )
            value.MinNits                                   = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x070), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x70 MinNits                     ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.MaxNits                                   = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x078), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x78 MaxNits                     ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
