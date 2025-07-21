using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Width                                    ModelPrimitiveType int int int Int32
    // 014 Height                                   ModelPrimitiveType int int int Int32
    // 018 MsaaSamples                              ModelPrimitiveType int int int Int32
    // 01C VolumeDepth                              ModelPrimitiveType int int int Int32
    // 020 MipCount                                 ModelPrimitiveType int int int Int32
    // 024 GraphicsFormat                           ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 028 StencilFormat                            ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 02C DepthStencilFormat                       ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 030 Dimension                                ModelEnumType TextureDimension TextureDimension TextureDimension Int32
    // 034 ShadowSamplingMode                       ModelEnumType ShadowSamplingMode ShadowSamplingMode ShadowSamplingMode Int32
    // 038 VrUsage                                  ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32
    // 03C Flags                                    ModelEnumType RenderTextureCreationFlags RenderTextureCreationFlags RenderTextureCreationFlags Int32
    // 040 Memoryless                               ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32
    public partial class RenderTextureDescriptor : DataModel
    {
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }
        public int                                      MsaaSamples                             { get; set; }
        public int                                      VolumeDepth                             { get; set; }
        public int                                      MipCount                                { get; set; }
        public GraphicsFormat                           GraphicsFormat                          { get; set; }
        public GraphicsFormat                           StencilFormat                           { get; set; }
        public GraphicsFormat                           DepthStencilFormat                      { get; set; }
        public TextureDimension                         Dimension                               { get; set; }
        public ShadowSamplingMode                       ShadowSamplingMode                      { get; set; }
        public VRTextureUsage                           VrUsage                                 { get; set; }
        public RenderTextureCreationFlags               Flags                                   { get; set; }
        public RenderTextureMemoryless                  Memoryless                              { get; set; }

        public static RenderTextureDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderTextureDescriptor() { Pointer= p0 };

            value.Width                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Height                      ( ModelPrimitiveType int int int Int32 )
            value.MsaaSamples                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 MsaaSamples                 ( ModelPrimitiveType int int int Int32 )
            value.VolumeDepth                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C VolumeDepth                 ( ModelPrimitiveType int int int Int32 )
            value.MipCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 MipCount                    ( ModelPrimitiveType int int int Int32 )
            value.GraphicsFormat                            = (GraphicsFormat)GetInt32(new IntPtr(p + 0x024)); // 0x24 GraphicsFormat              ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.StencilFormat                             = (GraphicsFormat)GetInt32(new IntPtr(p + 0x028)); // 0x28 StencilFormat               ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.DepthStencilFormat                        = (GraphicsFormat)GetInt32(new IntPtr(p + 0x02C)); // 0x2C DepthStencilFormat          ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.Dimension                                 = (TextureDimension)GetInt32(new IntPtr(p + 0x030)); // 0x30 Dimension                   ( ModelEnumType TextureDimension TextureDimension TextureDimension Int32 )
            value.ShadowSamplingMode                        = (ShadowSamplingMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 ShadowSamplingMode          ( ModelEnumType ShadowSamplingMode ShadowSamplingMode ShadowSamplingMode Int32 )
            value.VrUsage                                   = (VRTextureUsage)GetInt32(new IntPtr(p + 0x038)); // 0x38 VrUsage                     ( ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32 )
            value.Flags                                     = (RenderTextureCreationFlags)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Flags                       ( ModelEnumType RenderTextureCreationFlags RenderTextureCreationFlags RenderTextureCreationFlags Int32 )
            value.Memoryless                                = (RenderTextureMemoryless)GetInt32(new IntPtr(p + 0x040)); // 0x40 Memoryless                  ( ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32 )

            return value;
        }
    }
}
