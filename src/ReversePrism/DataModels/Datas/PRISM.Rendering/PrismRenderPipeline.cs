using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MainBuffer                               int IL2CPP_TYPE_I4
    // 004 ModelBuffer                              int IL2CPP_TYPE_I4
    // 008 DepthBuffer                              int IL2CPP_TYPE_I4
    // 00C ShadowBuffer                             int IL2CPP_TYPE_I4
    // 000 DefaultRenderingLayerMask                int IL2CPP_TYPE_I4
    // 018 RenderTargetBuffer                       00018665ABC0 ModelEnumType RenderTargetBuffer RenderTargetBuffer RenderTargetBuffer Int32
    // 028 ColorBufferSystem                        00018665B060 ModelClassType RenderTargetBufferSystem RenderTargetBufferSystem RenderTargetBufferSystem Pointer
    // 030 RenderPipelineAsset                      000186516AD0 ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 038 cameraComparison                         Comparison`1<Camera> IL2CPP_TYPE_GENERICINST
    // 040 RenderTargetIdentifiers                  000185CA0BA8 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 048 PrevUpdateDraw3DFlag                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 DepthOnlyPass                            0001866C3520 ModelClassType DepthOnlyPass DepthOnlyPass DepthOnlyPass Pointer
    // 058 DrawEffectBufferPass                     0001866F7400 ModelClassType DrawEffectBufferPass DrawEffectBufferPass DrawEffectBufferPass Pointer
    // 060 DrawOpaqueBeforeCharacterPass            0001866F87D0 ModelClassType DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass Pointer
    // 068 DrawOpaqueCharacterPass                  0001866F8CD0 ModelClassType DrawOpaqueCharacterPass DrawOpaqueCharacterPass DrawOpaqueCharacterPass Pointer
    // 070 DrawOpaqueAfterCharacterPass             0001866F82B0 ModelClassType DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass Pointer
    // 078 DrawPostProcessingPass                   0001866F9970 ModelClassType DrawPostProcessingPass DrawPostProcessingPass DrawPostProcessingPass Pointer
    // 080 DrawShadowPass                           0001866FA560 ModelClassType DrawShadowPass DrawShadowPass DrawShadowPass Pointer
    // 088 DrawSkyBoxPass                           0001866FAA30 ModelClassType DrawSkyBoxPass DrawSkyBoxPass DrawSkyBoxPass Pointer
    // 090 DrawTransparentPass                      0001866FAF50 ModelClassType DrawTransparentPass DrawTransparentPass DrawTransparentPass Pointer
    // 098 DrawUIPass                               0001866FB410 ModelClassType DrawUIPass DrawUIPass DrawUIPass Pointer
    // 0A0 DrawUnsupportedPass                      0001866FB8D0 ModelClassType DrawUnsupportedPass DrawUnsupportedPass DrawUnsupportedPass Pointer
    // 0A8 DrawBloomPass                            0001866F6E40 ModelClassType DrawBloomPass DrawBloomPass DrawBloomPass Pointer
    public partial class PrismRenderPipeline : DataModel
    {
        public RenderTargetBuffer                       RenderTargetBuffer                      { get; set; }
        public RenderTargetBufferSystem?                ColorBufferSystem                       { get; set; }
        public PrismRenderPipelineAsset?                RenderPipelineAsset                     { get; set; }
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }
        public bool                                     PrevUpdateDraw3DFlag                    { get; set; }
        public DepthOnlyPass?                           DepthOnlyPass                           { get; set; }
        public DrawEffectBufferPass?                    DrawEffectBufferPass                    { get; set; }
        public DrawOpaqueBeforeCharacterPass?           DrawOpaqueBeforeCharacterPass           { get; set; }
        public DrawOpaqueCharacterPass?                 DrawOpaqueCharacterPass                 { get; set; }
        public DrawOpaqueAfterCharacterPass?            DrawOpaqueAfterCharacterPass            { get; set; }
        public DrawPostProcessingPass?                  DrawPostProcessingPass                  { get; set; }
        public DrawShadowPass?                          DrawShadowPass                          { get; set; }
        public DrawSkyBoxPass?                          DrawSkyBoxPass                          { get; set; }
        public DrawTransparentPass?                     DrawTransparentPass                     { get; set; }
        public DrawUIPass?                              DrawUIPass                              { get; set; }
        public DrawUnsupportedPass?                     DrawUnsupportedPass                     { get; set; }
        public DrawBloomPass?                           DrawBloomPass                           { get; set; }

        public static PrismRenderPipeline? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderPipeline() { Pointer= p0 };

            value.RenderTargetBuffer                        = (RenderTargetBuffer)GetInt32(new IntPtr(p + 0x018)); // 024660AADDE8 0x18 RenderTargetBuffer          ( 00018665ABC0 ModelEnumType RenderTargetBuffer RenderTargetBuffer RenderTargetBuffer Int32 )
            value.ColorBufferSystem                         = GetObject<RenderTargetBufferSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderTargetBufferSystem.FromPointer); // 024660AADE08 0x28 ColorBufferSystem           ( 00018665B060 ModelClassType RenderTargetBufferSystem RenderTargetBufferSystem RenderTargetBufferSystem Pointer )
            value.RenderPipelineAsset                       = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 024660AADE28 0x30 RenderPipelineAsset         ( 000186516AD0 ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x040)); // 024660AADE68 0x40 RenderTargetIdentifiers     ( 000185CA0BA8 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.PrevUpdateDraw3DFlag                      = GetBool(new IntPtr(p + 0x048)); // 024660AADE88 0x48 PrevUpdateDraw3DFlag        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DepthOnlyPass                             = GetObject<DepthOnlyPass>(new IntPtr(p + 0x050), ReversePrism.DataModels.DepthOnlyPass.FromPointer); // 024660AADEA8 0x50 DepthOnlyPass               ( 0001866C3520 ModelClassType DepthOnlyPass DepthOnlyPass DepthOnlyPass Pointer )
            value.DrawEffectBufferPass                      = GetObject<DrawEffectBufferPass>(new IntPtr(p + 0x058), ReversePrism.DataModels.DrawEffectBufferPass.FromPointer); // 024660AADEC8 0x58 DrawEffectBufferPass        ( 0001866F7400 ModelClassType DrawEffectBufferPass DrawEffectBufferPass DrawEffectBufferPass Pointer )
            value.DrawOpaqueBeforeCharacterPass             = GetObject<DrawOpaqueBeforeCharacterPass>(new IntPtr(p + 0x060), ReversePrism.DataModels.DrawOpaqueBeforeCharacterPass.FromPointer); // 024660AADEE8 0x60 DrawOpaqueBeforeCharacterPass ( 0001866F87D0 ModelClassType DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass Pointer )
            value.DrawOpaqueCharacterPass                   = GetObject<DrawOpaqueCharacterPass>(new IntPtr(p + 0x068), ReversePrism.DataModels.DrawOpaqueCharacterPass.FromPointer); // 024660AADF08 0x68 DrawOpaqueCharacterPass     ( 0001866F8CD0 ModelClassType DrawOpaqueCharacterPass DrawOpaqueCharacterPass DrawOpaqueCharacterPass Pointer )
            value.DrawOpaqueAfterCharacterPass              = GetObject<DrawOpaqueAfterCharacterPass>(new IntPtr(p + 0x070), ReversePrism.DataModels.DrawOpaqueAfterCharacterPass.FromPointer); // 024660AADF28 0x70 DrawOpaqueAfterCharacterPass ( 0001866F82B0 ModelClassType DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass Pointer )
            value.DrawPostProcessingPass                    = GetObject<DrawPostProcessingPass>(new IntPtr(p + 0x078), ReversePrism.DataModels.DrawPostProcessingPass.FromPointer); // 024660AADF48 0x78 DrawPostProcessingPass      ( 0001866F9970 ModelClassType DrawPostProcessingPass DrawPostProcessingPass DrawPostProcessingPass Pointer )
            value.DrawShadowPass                            = GetObject<DrawShadowPass>(new IntPtr(p + 0x080), ReversePrism.DataModels.DrawShadowPass.FromPointer); // 024660AADF68 0x80 DrawShadowPass              ( 0001866FA560 ModelClassType DrawShadowPass DrawShadowPass DrawShadowPass Pointer )
            value.DrawSkyBoxPass                            = GetObject<DrawSkyBoxPass>(new IntPtr(p + 0x088), ReversePrism.DataModels.DrawSkyBoxPass.FromPointer); // 024660AADF88 0x88 DrawSkyBoxPass              ( 0001866FAA30 ModelClassType DrawSkyBoxPass DrawSkyBoxPass DrawSkyBoxPass Pointer )
            value.DrawTransparentPass                       = GetObject<DrawTransparentPass>(new IntPtr(p + 0x090), ReversePrism.DataModels.DrawTransparentPass.FromPointer); // 024660AADFA8 0x90 DrawTransparentPass         ( 0001866FAF50 ModelClassType DrawTransparentPass DrawTransparentPass DrawTransparentPass Pointer )
            value.DrawUIPass                                = GetObject<DrawUIPass>(new IntPtr(p + 0x098), ReversePrism.DataModels.DrawUIPass.FromPointer); // 024660AADFC8 0x98 DrawUIPass                  ( 0001866FB410 ModelClassType DrawUIPass DrawUIPass DrawUIPass Pointer )
            value.DrawUnsupportedPass                       = GetObject<DrawUnsupportedPass>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DrawUnsupportedPass.FromPointer); // 024660AADFE8 0xA0 DrawUnsupportedPass         ( 0001866FB8D0 ModelClassType DrawUnsupportedPass DrawUnsupportedPass DrawUnsupportedPass Pointer )
            value.DrawBloomPass                             = GetObject<DrawBloomPass>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DrawBloomPass.FromPointer); // 024660AAE008 0xA8 DrawBloomPass               ( 0001866F6E40 ModelClassType DrawBloomPass DrawBloomPass DrawBloomPass Pointer )

            return value;
        }
    }
}
