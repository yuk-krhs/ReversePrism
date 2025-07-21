using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BlitPS                                   ModelClassType Shader Shader Shader Pointer
    // 018 CopyDepthPS                              ModelClassType Shader Shader Shader Pointer
    // 020 ScreenSpaceShadowPS                      ModelClassType Shader Shader Shader Pointer
    // 028 SamplingPS                               ModelClassType Shader Shader Shader Pointer
    // 030 StencilDeferredPS                        ModelClassType Shader Shader Shader Pointer
    // 038 FallbackErrorPS                          ModelClassType Shader Shader Shader Pointer
    // 040 FallbackLoadingPS                        ModelClassType Shader Shader Shader Pointer
    // 048 MaterialErrorPS                          ModelClassType Shader Shader Shader Pointer
    // 050 CoreBlitPS                               ModelClassType Shader Shader Shader Pointer
    // 058 CoreBlitColorAndDepthPS                  ModelClassType Shader Shader Shader Pointer
    // 060 BlitHDROverlay                           ModelClassType Shader Shader Shader Pointer
    // 068 CameraMotionVector                       ModelClassType Shader Shader Shader Pointer
    // 070 ObjectMotionVector                       ModelClassType Shader Shader Shader Pointer
    // 078 DataDrivenLensFlare                      ModelClassType Shader Shader Shader Pointer
    public partial class ShaderResources : DataModel
    {
        public Shader?                                  BlitPS                                  { get; set; }
        public Shader?                                  CopyDepthPS                             { get; set; }
        public Shader?                                  ScreenSpaceShadowPS                     { get; set; }
        public Shader?                                  SamplingPS                              { get; set; }
        public Shader?                                  StencilDeferredPS                       { get; set; }
        public Shader?                                  FallbackErrorPS                         { get; set; }
        public Shader?                                  FallbackLoadingPS                       { get; set; }
        public Shader?                                  MaterialErrorPS                         { get; set; }
        public Shader?                                  CoreBlitPS                              { get; set; }
        public Shader?                                  CoreBlitColorAndDepthPS                 { get; set; }
        public Shader?                                  BlitHDROverlay                          { get; set; }
        public Shader?                                  CameraMotionVector                      { get; set; }
        public Shader?                                  ObjectMotionVector                      { get; set; }
        public Shader?                                  DataDrivenLensFlare                     { get; set; }

        public static ShaderResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderResources() { Pointer= p0 };

            value.BlitPS                                    = GetObject<Shader>(new IntPtr(p + 0x010), ReversePrism.DataModels.Shader.FromPointer); // 0x10 BlitPS                      ( ModelClassType Shader Shader Shader Pointer )
            value.CopyDepthPS                               = GetObject<Shader>(new IntPtr(p + 0x018), ReversePrism.DataModels.Shader.FromPointer); // 0x18 CopyDepthPS                 ( ModelClassType Shader Shader Shader Pointer )
            value.ScreenSpaceShadowPS                       = GetObject<Shader>(new IntPtr(p + 0x020), ReversePrism.DataModels.Shader.FromPointer); // 0x20 ScreenSpaceShadowPS         ( ModelClassType Shader Shader Shader Pointer )
            value.SamplingPS                                = GetObject<Shader>(new IntPtr(p + 0x028), ReversePrism.DataModels.Shader.FromPointer); // 0x28 SamplingPS                  ( ModelClassType Shader Shader Shader Pointer )
            value.StencilDeferredPS                         = GetObject<Shader>(new IntPtr(p + 0x030), ReversePrism.DataModels.Shader.FromPointer); // 0x30 StencilDeferredPS           ( ModelClassType Shader Shader Shader Pointer )
            value.FallbackErrorPS                           = GetObject<Shader>(new IntPtr(p + 0x038), ReversePrism.DataModels.Shader.FromPointer); // 0x38 FallbackErrorPS             ( ModelClassType Shader Shader Shader Pointer )
            value.FallbackLoadingPS                         = GetObject<Shader>(new IntPtr(p + 0x040), ReversePrism.DataModels.Shader.FromPointer); // 0x40 FallbackLoadingPS           ( ModelClassType Shader Shader Shader Pointer )
            value.MaterialErrorPS                           = GetObject<Shader>(new IntPtr(p + 0x048), ReversePrism.DataModels.Shader.FromPointer); // 0x48 MaterialErrorPS             ( ModelClassType Shader Shader Shader Pointer )
            value.CoreBlitPS                                = GetObject<Shader>(new IntPtr(p + 0x050), ReversePrism.DataModels.Shader.FromPointer); // 0x50 CoreBlitPS                  ( ModelClassType Shader Shader Shader Pointer )
            value.CoreBlitColorAndDepthPS                   = GetObject<Shader>(new IntPtr(p + 0x058), ReversePrism.DataModels.Shader.FromPointer); // 0x58 CoreBlitColorAndDepthPS     ( ModelClassType Shader Shader Shader Pointer )
            value.BlitHDROverlay                            = GetObject<Shader>(new IntPtr(p + 0x060), ReversePrism.DataModels.Shader.FromPointer); // 0x60 BlitHDROverlay              ( ModelClassType Shader Shader Shader Pointer )
            value.CameraMotionVector                        = GetObject<Shader>(new IntPtr(p + 0x068), ReversePrism.DataModels.Shader.FromPointer); // 0x68 CameraMotionVector          ( ModelClassType Shader Shader Shader Pointer )
            value.ObjectMotionVector                        = GetObject<Shader>(new IntPtr(p + 0x070), ReversePrism.DataModels.Shader.FromPointer); // 0x70 ObjectMotionVector          ( ModelClassType Shader Shader Shader Pointer )
            value.DataDrivenLensFlare                       = GetObject<Shader>(new IntPtr(p + 0x078), ReversePrism.DataModels.Shader.FromPointer); // 0x78 DataDrivenLensFlare         ( ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
