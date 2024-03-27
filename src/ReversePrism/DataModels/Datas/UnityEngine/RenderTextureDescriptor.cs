using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Width                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Height                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MsaaSamples                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C VolumeDepth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 MipCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 GraphicsFormat                           000186696180 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 028 StencilFormat                            000186696180 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 02C DepthStencilFormat                       000186696180 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 030 Dimension                                000186651B30 ModelEnumType TextureDimension TextureDimension TextureDimension Int32
    // 034 ShadowSamplingMode                       0001867512C0 ModelEnumType ShadowSamplingMode ShadowSamplingMode ShadowSamplingMode Int32
    // 038 VrUsage                                  000186763CB0 ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32
    // 03C Flags                                    00018665BA80 ModelEnumType RenderTextureCreationFlags RenderTextureCreationFlags RenderTextureCreationFlags Int32
    // 040 Memoryless                               00018665CDF0 ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32
    public partial class RenderTextureDescriptor
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
            var value   = new RenderTextureDescriptor();

            value.Width                                     = GetInt32(new IntPtr(p + 0x010)); // 0270035D1460 0x10 Width                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x014)); // 0270035D1480 0x14 Height                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MsaaSamples                               = GetInt32(new IntPtr(p + 0x018)); // 0270035D14A0 0x18 MsaaSamples                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VolumeDepth                               = GetInt32(new IntPtr(p + 0x01C)); // 0270035D14C0 0x1C VolumeDepth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MipCount                                  = GetInt32(new IntPtr(p + 0x020)); // 0270035D14E0 0x20 MipCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GraphicsFormat                            = (GraphicsFormat)GetInt32(new IntPtr(p + 0x024)); // 0270035D1500 0x24 GraphicsFormat              ( 000186696180 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.StencilFormat                             = (GraphicsFormat)GetInt32(new IntPtr(p + 0x028)); // 0270035D1520 0x28 StencilFormat               ( 000186696180 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.DepthStencilFormat                        = (GraphicsFormat)GetInt32(new IntPtr(p + 0x02C)); // 0270035D1540 0x2C DepthStencilFormat          ( 000186696180 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.Dimension                                 = (TextureDimension)GetInt32(new IntPtr(p + 0x030)); // 0270035D1560 0x30 Dimension                   ( 000186651B30 ModelEnumType TextureDimension TextureDimension TextureDimension Int32 )
            value.ShadowSamplingMode                        = (ShadowSamplingMode)GetInt32(new IntPtr(p + 0x034)); // 0270035D1580 0x34 ShadowSamplingMode          ( 0001867512C0 ModelEnumType ShadowSamplingMode ShadowSamplingMode ShadowSamplingMode Int32 )
            value.VrUsage                                   = (VRTextureUsage)GetInt32(new IntPtr(p + 0x038)); // 0270035D15A0 0x38 VrUsage                     ( 000186763CB0 ModelEnumType VRTextureUsage VRTextureUsage VRTextureUsage Int32 )
            value.Flags                                     = (RenderTextureCreationFlags)GetInt32(new IntPtr(p + 0x03C)); // 0270035D15C0 0x3C Flags                       ( 00018665BA80 ModelEnumType RenderTextureCreationFlags RenderTextureCreationFlags RenderTextureCreationFlags Int32 )
            value.Memoryless                                = (RenderTextureMemoryless)GetInt32(new IntPtr(p + 0x040)); // 0270035D15E0 0x40 Memoryless                  ( 00018665CDF0 ModelEnumType RenderTextureMemoryless RenderTextureMemoryless RenderTextureMemoryless Int32 )

            return value;
        }
    }
}
