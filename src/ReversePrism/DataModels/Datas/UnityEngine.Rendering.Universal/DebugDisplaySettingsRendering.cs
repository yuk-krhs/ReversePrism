using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WireframeMode                          ModelEnumType DebugWireframeMode DebugWireframeMode DebugWireframeMode Int32
    // 014 M_Overdraw                               ModelPrimitiveType bool bool bool Bool
    // 018 M_OverdrawMode                           ModelEnumType DebugOverdrawMode DebugOverdrawMode DebugOverdrawMode Int32
    // 01C MaxOverdrawCount                         ModelPrimitiveType int int int Int32
    // 020 FullScreenDebugMode                      ModelEnumType DebugFullScreenMode DebugFullScreenMode DebugFullScreenMode Int32
    // 024 FullScreenDebugModeOutputSizeScreenPercent ModelPrimitiveType int int int Int32
    // 028 SceneOverrideMode                        ModelEnumType DebugSceneOverrideMode DebugSceneOverrideMode DebugSceneOverrideMode Int32
    // 02C MipInfoMode                              ModelEnumType DebugMipInfoMode DebugMipInfoMode DebugMipInfoMode Int32
    // 030 PostProcessingDebugMode                  ModelEnumType DebugPostProcessingMode DebugPostProcessingMode DebugPostProcessingMode Int32
    // 034 EnableMsaa                               ModelPrimitiveType bool bool bool Bool
    // 035 EnableHDR                                ModelPrimitiveType bool bool bool Bool
    // 038 TaaDebugMode                             ModelEnumType TaaDebugMode TaaDebugMode TaaDebugMode Int32
    // 03C ValidationMode                           ModelEnumType DebugValidationMode DebugValidationMode DebugValidationMode Int32
    // 040 ValidationChannels                       ModelEnumType PixelValidationChannels PixelValidationChannels PixelValidationChannels Int32
    // 044 ValidationRangeMin                       ModelPrimitiveType float float float Single
    // 048 ValidationRangeMax                       ModelPrimitiveType float float float Single
    public partial class DebugDisplaySettingsRendering : DataModel
    {
        public DebugWireframeMode                       M_WireframeMode                         { get; set; }
        public bool                                     M_Overdraw                              { get; set; }
        public DebugOverdrawMode                        M_OverdrawMode                          { get; set; }
        public int                                      MaxOverdrawCount                        { get; set; }
        public DebugFullScreenMode                      FullScreenDebugMode                     { get; set; }
        public int                                      FullScreenDebugModeOutputSizeScreenPercent { get; set; }
        public DebugSceneOverrideMode                   SceneOverrideMode                       { get; set; }
        public DebugMipInfoMode                         MipInfoMode                             { get; set; }
        public DebugPostProcessingMode                  PostProcessingDebugMode                 { get; set; }
        public bool                                     EnableMsaa                              { get; set; }
        public bool                                     EnableHDR                               { get; set; }
        public TaaDebugMode                             TaaDebugMode                            { get; set; }
        public DebugValidationMode                      ValidationMode                          { get; set; }
        public PixelValidationChannels                  ValidationChannels                      { get; set; }
        public float                                    ValidationRangeMin                      { get; set; }
        public float                                    ValidationRangeMax                      { get; set; }

        public static DebugDisplaySettingsRendering? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplaySettingsRendering() { Pointer= p0 };

            value.M_WireframeMode                           = (DebugWireframeMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_WireframeMode             ( ModelEnumType DebugWireframeMode DebugWireframeMode DebugWireframeMode Int32 )
            value.M_Overdraw                                = GetBool(new IntPtr(p + 0x014)); // 0x14 M_Overdraw                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_OverdrawMode                            = (DebugOverdrawMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_OverdrawMode              ( ModelEnumType DebugOverdrawMode DebugOverdrawMode DebugOverdrawMode Int32 )
            value.MaxOverdrawCount                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaxOverdrawCount            ( ModelPrimitiveType int int int Int32 )
            value.FullScreenDebugMode                       = (DebugFullScreenMode)GetInt32(new IntPtr(p + 0x020)); // 0x20 FullScreenDebugMode         ( ModelEnumType DebugFullScreenMode DebugFullScreenMode DebugFullScreenMode Int32 )
            value.FullScreenDebugModeOutputSizeScreenPercent = GetInt32(new IntPtr(p + 0x024)); // 0x24 FullScreenDebugModeOutputSizeScreenPercent ( ModelPrimitiveType int int int Int32 )
            value.SceneOverrideMode                         = (DebugSceneOverrideMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 SceneOverrideMode           ( ModelEnumType DebugSceneOverrideMode DebugSceneOverrideMode DebugSceneOverrideMode Int32 )
            value.MipInfoMode                               = (DebugMipInfoMode)GetInt32(new IntPtr(p + 0x02C)); // 0x2C MipInfoMode                 ( ModelEnumType DebugMipInfoMode DebugMipInfoMode DebugMipInfoMode Int32 )
            value.PostProcessingDebugMode                   = (DebugPostProcessingMode)GetInt32(new IntPtr(p + 0x030)); // 0x30 PostProcessingDebugMode     ( ModelEnumType DebugPostProcessingMode DebugPostProcessingMode DebugPostProcessingMode Int32 )
            value.EnableMsaa                                = GetBool(new IntPtr(p + 0x034)); // 0x34 EnableMsaa                  ( ModelPrimitiveType bool bool bool Bool )
            value.EnableHDR                                 = GetBool(new IntPtr(p + 0x035)); // 0x35 EnableHDR                   ( ModelPrimitiveType bool bool bool Bool )
            value.TaaDebugMode                              = (TaaDebugMode)GetInt32(new IntPtr(p + 0x038)); // 0x38 TaaDebugMode                ( ModelEnumType TaaDebugMode TaaDebugMode TaaDebugMode Int32 )
            value.ValidationMode                            = (DebugValidationMode)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ValidationMode              ( ModelEnumType DebugValidationMode DebugValidationMode DebugValidationMode Int32 )
            value.ValidationChannels                        = (PixelValidationChannels)GetInt32(new IntPtr(p + 0x040)); // 0x40 ValidationChannels          ( ModelEnumType PixelValidationChannels PixelValidationChannels PixelValidationChannels Int32 )
            value.ValidationRangeMin                        = GetSingle(new IntPtr(p + 0x044)); // 0x44 ValidationRangeMin          ( ModelPrimitiveType float float float Single )
            value.ValidationRangeMax                        = GetSingle(new IntPtr(p + 0x048)); // 0x48 ValidationRangeMax          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
