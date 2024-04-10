using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_MaxShadowDistanceMultiplier            float IL2CPP_TYPE_R4
    // 004 s_ShadowResolutionMultiplier             float IL2CPP_TYPE_R4
    // 008 s_RenderScaleMultiplier                  float IL2CPP_TYPE_R4
    // 00C s_DecalsMaxDistance                      float IL2CPP_TYPE_R4
    // 010 MainLightShadowCascadesCountBias         0001865F38E0 ModelPrimitiveType int int int Int32
    // 014 ShadowQualityBias                        0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 LutBias                                  000186666300 ModelPrimitiveType float float float Single
    // 01C AntiAliasingQualityBias                  0001865F38E0 ModelPrimitiveType int int int Int32
    // 020 SkipDynamicBatching                      000186595C30 ModelPrimitiveType bool bool bool Bool
    // 021 SkipFrontToBackSorting                   000186595C30 ModelPrimitiveType bool bool bool Bool
    // 022 SkipTransparentObjects                   000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class AdaptivePerformanceRenderSettings : DataModel
    {
        public int                                      MainLightShadowCascadesCountBias        { get; set; }
        public int                                      ShadowQualityBias                       { get; set; }
        public float                                    LutBias                                 { get; set; }
        public int                                      AntiAliasingQualityBias                 { get; set; }
        public bool                                     SkipDynamicBatching                     { get; set; }
        public bool                                     SkipFrontToBackSorting                  { get; set; }
        public bool                                     SkipTransparentObjects                  { get; set; }

        public static AdaptivePerformanceRenderSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceRenderSettings() { Pointer= p0 };

            value.MainLightShadowCascadesCountBias          = GetInt32(new IntPtr(p + 0x010)); // 02466B6F7B98 0x10 MainLightShadowCascadesCountBias ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.ShadowQualityBias                         = GetInt32(new IntPtr(p + 0x014)); // 02466B6F7BB8 0x14 ShadowQualityBias           ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.LutBias                                   = GetSingle(new IntPtr(p + 0x018)); // 02466B6F7BD8 0x18 LutBias                     ( 000186666300 ModelPrimitiveType float float float Single )
            value.AntiAliasingQualityBias                   = GetInt32(new IntPtr(p + 0x01C)); // 02466B6F7BF8 0x1C AntiAliasingQualityBias     ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.SkipDynamicBatching                       = GetBool(new IntPtr(p + 0x020)); // 02466B6F7C18 0x20 SkipDynamicBatching         ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.SkipFrontToBackSorting                    = GetBool(new IntPtr(p + 0x021)); // 02466B6F7C38 0x21 SkipFrontToBackSorting      ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.SkipTransparentObjects                    = GetBool(new IntPtr(p + 0x022)); // 02466B6F7C58 0x22 SkipTransparentObjects      ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
