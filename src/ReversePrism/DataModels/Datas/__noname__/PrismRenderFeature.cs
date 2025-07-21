using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PrismRenderFrame                         ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer
    // 028 BeforeRenderingPass                      ModelClassType PrismBeforeRenderingPass PrismBeforeRenderingPass PrismBeforeRenderingPass Pointer
    // 030 PrismDepthOnlyRenderPass                 ModelClassType PrismDepthOnlyRenderPass PrismDepthOnlyRenderPass PrismDepthOnlyRenderPass Pointer
    // 038 PrismGetTemporaryPass                    ModelClassType PrismGetTemporaryPass PrismGetTemporaryPass PrismGetTemporaryPass Pointer
    // 040 PrismOpaqueRenderPass                    ModelClassType PrismOpaqueRenderPass PrismOpaqueRenderPass PrismOpaqueRenderPass Pointer
    // 048 PrismShadowRenderPass                    ModelClassType PrismShadowRenderPass PrismShadowRenderPass PrismShadowRenderPass Pointer
    // 050 PrismTransparentRenderPass               ModelClassType PrismTransparentRenderPass PrismTransparentRenderPass PrismTransparentRenderPass Pointer
    // 058 PrismLdrBloomPass                        ModelClassType PrismLdrBloomPass PrismLdrBloomPass PrismLdrBloomPass Pointer
    // 060 PostProcessingRenderPass                 ModelClassType PrismPostProcessingRenderPass PrismPostProcessingRenderPass PrismPostProcessingRenderPass Pointer
    // 068 ReservedPass                             ModelClassType PrismReservedPass PrismReservedPass PrismReservedPass Pointer
    // 070 ReleaseTemporaryPass                     ModelClassType PrismReleaseTemporaryPass PrismReleaseTemporaryPass PrismReleaseTemporaryPass Pointer
    // 078 SplitScreenPostProcessingApplyPass       ModelClassType SplitScreenPostProcessingApplyPass SplitScreenPostProcessingApplyPass SplitScreenPostProcessingApplyPass Pointer
    // 080 onEffectBufferFunc                       Func`1<ValueTuple`3<RenderTargetIdentifier, int, int>> IL2CPP_TYPE_GENERICINST
    // 088 onBeginFrameRendering                    Action`2<ScriptableRenderContext, Camera[]> IL2CPP_TYPE_GENERICINST
    public partial class PrismRenderFeature : DataModel
    {
        public PrismRenderFrame?                        PrismRenderFrame                        { get; set; }
        public PrismBeforeRenderingPass?                BeforeRenderingPass                     { get; set; }
        public PrismDepthOnlyRenderPass?                PrismDepthOnlyRenderPass                { get; set; }
        public PrismGetTemporaryPass?                   PrismGetTemporaryPass                   { get; set; }
        public PrismOpaqueRenderPass?                   PrismOpaqueRenderPass                   { get; set; }
        public PrismShadowRenderPass?                   PrismShadowRenderPass                   { get; set; }
        public PrismTransparentRenderPass?              PrismTransparentRenderPass              { get; set; }
        public PrismLdrBloomPass?                       PrismLdrBloomPass                       { get; set; }
        public PrismPostProcessingRenderPass?           PostProcessingRenderPass                { get; set; }
        public PrismReservedPass?                       ReservedPass                            { get; set; }
        public PrismReleaseTemporaryPass?               ReleaseTemporaryPass                    { get; set; }
        public SplitScreenPostProcessingApplyPass?      SplitScreenPostProcessingApplyPass      { get; set; }

        public static PrismRenderFeature? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderFeature() { Pointer= p0 };

            value.PrismRenderFrame                          = GetObject<PrismRenderFrame>(new IntPtr(p + 0x020), ReversePrism.DataModels.PrismRenderFrame.FromPointer); // 0x20 PrismRenderFrame            ( ModelClassType PrismRenderFrame PrismRenderFrame PrismRenderFrame Pointer )
            value.BeforeRenderingPass                       = GetObject<PrismBeforeRenderingPass>(new IntPtr(p + 0x028), ReversePrism.DataModels.PrismBeforeRenderingPass.FromPointer); // 0x28 BeforeRenderingPass         ( ModelClassType PrismBeforeRenderingPass PrismBeforeRenderingPass PrismBeforeRenderingPass Pointer )
            value.PrismDepthOnlyRenderPass                  = GetObject<PrismDepthOnlyRenderPass>(new IntPtr(p + 0x030), ReversePrism.DataModels.PrismDepthOnlyRenderPass.FromPointer); // 0x30 PrismDepthOnlyRenderPass    ( ModelClassType PrismDepthOnlyRenderPass PrismDepthOnlyRenderPass PrismDepthOnlyRenderPass Pointer )
            value.PrismGetTemporaryPass                     = GetObject<PrismGetTemporaryPass>(new IntPtr(p + 0x038), ReversePrism.DataModels.PrismGetTemporaryPass.FromPointer); // 0x38 PrismGetTemporaryPass       ( ModelClassType PrismGetTemporaryPass PrismGetTemporaryPass PrismGetTemporaryPass Pointer )
            value.PrismOpaqueRenderPass                     = GetObject<PrismOpaqueRenderPass>(new IntPtr(p + 0x040), ReversePrism.DataModels.PrismOpaqueRenderPass.FromPointer); // 0x40 PrismOpaqueRenderPass       ( ModelClassType PrismOpaqueRenderPass PrismOpaqueRenderPass PrismOpaqueRenderPass Pointer )
            value.PrismShadowRenderPass                     = GetObject<PrismShadowRenderPass>(new IntPtr(p + 0x048), ReversePrism.DataModels.PrismShadowRenderPass.FromPointer); // 0x48 PrismShadowRenderPass       ( ModelClassType PrismShadowRenderPass PrismShadowRenderPass PrismShadowRenderPass Pointer )
            value.PrismTransparentRenderPass                = GetObject<PrismTransparentRenderPass>(new IntPtr(p + 0x050), ReversePrism.DataModels.PrismTransparentRenderPass.FromPointer); // 0x50 PrismTransparentRenderPass  ( ModelClassType PrismTransparentRenderPass PrismTransparentRenderPass PrismTransparentRenderPass Pointer )
            value.PrismLdrBloomPass                         = GetObject<PrismLdrBloomPass>(new IntPtr(p + 0x058), ReversePrism.DataModels.PrismLdrBloomPass.FromPointer); // 0x58 PrismLdrBloomPass           ( ModelClassType PrismLdrBloomPass PrismLdrBloomPass PrismLdrBloomPass Pointer )
            value.PostProcessingRenderPass                  = GetObject<PrismPostProcessingRenderPass>(new IntPtr(p + 0x060), ReversePrism.DataModels.PrismPostProcessingRenderPass.FromPointer); // 0x60 PostProcessingRenderPass    ( ModelClassType PrismPostProcessingRenderPass PrismPostProcessingRenderPass PrismPostProcessingRenderPass Pointer )
            value.ReservedPass                              = GetObject<PrismReservedPass>(new IntPtr(p + 0x068), ReversePrism.DataModels.PrismReservedPass.FromPointer); // 0x68 ReservedPass                ( ModelClassType PrismReservedPass PrismReservedPass PrismReservedPass Pointer )
            value.ReleaseTemporaryPass                      = GetObject<PrismReleaseTemporaryPass>(new IntPtr(p + 0x070), ReversePrism.DataModels.PrismReleaseTemporaryPass.FromPointer); // 0x70 ReleaseTemporaryPass        ( ModelClassType PrismReleaseTemporaryPass PrismReleaseTemporaryPass PrismReleaseTemporaryPass Pointer )
            value.SplitScreenPostProcessingApplyPass        = GetObject<SplitScreenPostProcessingApplyPass>(new IntPtr(p + 0x078), ReversePrism.DataModels.SplitScreenPostProcessingApplyPass.FromPointer); // 0x78 SplitScreenPostProcessingApplyPass ( ModelClassType SplitScreenPostProcessingApplyPass SplitScreenPostProcessingApplyPass SplitScreenPostProcessingApplyPass Pointer )

            return value;
        }
    }
}
