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
    // 018 CurrentWidth                             ModelPrimitiveType int int int Int32
    // 01C CurrentHeight                            ModelPrimitiveType int int int Int32
    // 020 RenderTargetBuffer                       ModelEnumType RenderTargetBuffer RenderTargetBuffer RenderTargetBuffer Int32
    // 030 ColorBufferSystem                        ModelClassType RenderTargetBufferSystem RenderTargetBufferSystem RenderTargetBufferSystem Pointer
    // 038 RenderPipelineAsset                      ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer
    // 040 cameraComparison                         Comparison`1<Camera> IL2CPP_TYPE_GENERICINST
    // 048 RenderTargetIdentifiers                  ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 050 PrevUpdateDraw3DFlag                     ModelPrimitiveType bool bool bool Bool
    // 058 DepthOnlyPass                            ModelClassType DepthOnlyPass DepthOnlyPass DepthOnlyPass Pointer
    // 060 DrawOpaqueBeforeCharacterPass            ModelClassType DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass Pointer
    // 068 DrawOpaqueCharacterPass                  ModelClassType DrawOpaqueCharacterPass DrawOpaqueCharacterPass DrawOpaqueCharacterPass Pointer
    // 070 DrawOpaqueAfterCharacterPass             ModelClassType DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass Pointer
    // 078 DrawPostProcessingPass                   ModelClassType DrawPostProcessingPass DrawPostProcessingPass DrawPostProcessingPass Pointer
    // 080 DrawShadowPass                           ModelClassType DrawShadowPass DrawShadowPass DrawShadowPass Pointer
    // 088 DrawSkyBoxPass                           ModelClassType DrawSkyBoxPass DrawSkyBoxPass DrawSkyBoxPass Pointer
    // 090 DrawTransparentPass                      ModelClassType DrawTransparentPass DrawTransparentPass DrawTransparentPass Pointer
    // 098 DrawUIPass                               ModelClassType DrawUIPass DrawUIPass DrawUIPass Pointer
    // 0A0 DrawUnsupportedPass                      ModelClassType DrawUnsupportedPass DrawUnsupportedPass DrawUnsupportedPass Pointer
    // 0A8 DrawBloomPass                            ModelClassType DrawBloomPass DrawBloomPass DrawBloomPass Pointer
    public partial class PrismRenderPipeline : DataModel
    {
        public int                                      CurrentWidth                            { get; set; }
        public int                                      CurrentHeight                           { get; set; }
        public RenderTargetBuffer                       RenderTargetBuffer                      { get; set; }
        public RenderTargetBufferSystem?                ColorBufferSystem                       { get; set; }
        public PrismRenderPipelineAsset?                RenderPipelineAsset                     { get; set; }
        public List<RenderTargetIdentifier>?            RenderTargetIdentifiers                 { get; set; }
        public bool                                     PrevUpdateDraw3DFlag                    { get; set; }
        public DepthOnlyPass?                           DepthOnlyPass                           { get; set; }
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

            value.CurrentWidth                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentWidth                ( ModelPrimitiveType int int int Int32 )
            value.CurrentHeight                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurrentHeight               ( ModelPrimitiveType int int int Int32 )
            value.RenderTargetBuffer                        = (RenderTargetBuffer)GetInt32(new IntPtr(p + 0x020)); // 0x20 RenderTargetBuffer          ( ModelEnumType RenderTargetBuffer RenderTargetBuffer RenderTargetBuffer Int32 )
            value.ColorBufferSystem                         = GetObject<RenderTargetBufferSystem>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTargetBufferSystem.FromPointer); // 0x30 ColorBufferSystem           ( ModelClassType RenderTargetBufferSystem RenderTargetBufferSystem RenderTargetBufferSystem Pointer )
            value.RenderPipelineAsset                       = GetObject<PrismRenderPipelineAsset>(new IntPtr(p + 0x038), ReversePrism.DataModels.PrismRenderPipelineAsset.FromPointer); // 0x38 RenderPipelineAsset         ( ModelClassType PrismRenderPipelineAsset PrismRenderPipelineAsset PrismRenderPipelineAsset Pointer )
            value.RenderTargetIdentifiers                   = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x048)); // 0x48 RenderTargetIdentifiers     ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.PrevUpdateDraw3DFlag                      = GetBool(new IntPtr(p + 0x050)); // 0x50 PrevUpdateDraw3DFlag        ( ModelPrimitiveType bool bool bool Bool )
            value.DepthOnlyPass                             = GetObject<DepthOnlyPass>(new IntPtr(p + 0x058), ReversePrism.DataModels.DepthOnlyPass.FromPointer); // 0x58 DepthOnlyPass               ( ModelClassType DepthOnlyPass DepthOnlyPass DepthOnlyPass Pointer )
            value.DrawOpaqueBeforeCharacterPass             = GetObject<DrawOpaqueBeforeCharacterPass>(new IntPtr(p + 0x060), ReversePrism.DataModels.DrawOpaqueBeforeCharacterPass.FromPointer); // 0x60 DrawOpaqueBeforeCharacterPass ( ModelClassType DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass DrawOpaqueBeforeCharacterPass Pointer )
            value.DrawOpaqueCharacterPass                   = GetObject<DrawOpaqueCharacterPass>(new IntPtr(p + 0x068), ReversePrism.DataModels.DrawOpaqueCharacterPass.FromPointer); // 0x68 DrawOpaqueCharacterPass     ( ModelClassType DrawOpaqueCharacterPass DrawOpaqueCharacterPass DrawOpaqueCharacterPass Pointer )
            value.DrawOpaqueAfterCharacterPass              = GetObject<DrawOpaqueAfterCharacterPass>(new IntPtr(p + 0x070), ReversePrism.DataModels.DrawOpaqueAfterCharacterPass.FromPointer); // 0x70 DrawOpaqueAfterCharacterPass ( ModelClassType DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass DrawOpaqueAfterCharacterPass Pointer )
            value.DrawPostProcessingPass                    = GetObject<DrawPostProcessingPass>(new IntPtr(p + 0x078), ReversePrism.DataModels.DrawPostProcessingPass.FromPointer); // 0x78 DrawPostProcessingPass      ( ModelClassType DrawPostProcessingPass DrawPostProcessingPass DrawPostProcessingPass Pointer )
            value.DrawShadowPass                            = GetObject<DrawShadowPass>(new IntPtr(p + 0x080), ReversePrism.DataModels.DrawShadowPass.FromPointer); // 0x80 DrawShadowPass              ( ModelClassType DrawShadowPass DrawShadowPass DrawShadowPass Pointer )
            value.DrawSkyBoxPass                            = GetObject<DrawSkyBoxPass>(new IntPtr(p + 0x088), ReversePrism.DataModels.DrawSkyBoxPass.FromPointer); // 0x88 DrawSkyBoxPass              ( ModelClassType DrawSkyBoxPass DrawSkyBoxPass DrawSkyBoxPass Pointer )
            value.DrawTransparentPass                       = GetObject<DrawTransparentPass>(new IntPtr(p + 0x090), ReversePrism.DataModels.DrawTransparentPass.FromPointer); // 0x90 DrawTransparentPass         ( ModelClassType DrawTransparentPass DrawTransparentPass DrawTransparentPass Pointer )
            value.DrawUIPass                                = GetObject<DrawUIPass>(new IntPtr(p + 0x098), ReversePrism.DataModels.DrawUIPass.FromPointer); // 0x98 DrawUIPass                  ( ModelClassType DrawUIPass DrawUIPass DrawUIPass Pointer )
            value.DrawUnsupportedPass                       = GetObject<DrawUnsupportedPass>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DrawUnsupportedPass.FromPointer); // 0xA0 DrawUnsupportedPass         ( ModelClassType DrawUnsupportedPass DrawUnsupportedPass DrawUnsupportedPass Pointer )
            value.DrawBloomPass                             = GetObject<DrawBloomPass>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DrawBloomPass.FromPointer); // 0xA8 DrawBloomPass               ( ModelClassType DrawBloomPass DrawBloomPass DrawBloomPass Pointer )

            return value;
        }
    }
}
