using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 glossyEnvironmentColor                   int IL2CPP_TYPE_I4
    // 004 subtractiveShadowColor                   int IL2CPP_TYPE_I4
    // 008 glossyEnvironmentCubeMap                 int IL2CPP_TYPE_I4
    // 00C glossyEnvironmentCubeMapHDR              int IL2CPP_TYPE_I4
    // 010 AmbientSkyColor                          ModelPrimitiveType int int int Int32
    // 014 AmbientEquatorColor                      ModelPrimitiveType int int int Int32
    // 018 AmbientGroundColor                       ModelPrimitiveType int int int Int32
    // 01C Time                                     ModelPrimitiveType int int int Int32
    // 020 SinTime                                  ModelPrimitiveType int int int Int32
    // 024 CosTime                                  ModelPrimitiveType int int int Int32
    // 028 DeltaTime                                ModelPrimitiveType int int int Int32
    // 02C TimeParameters                           ModelPrimitiveType int int int Int32
    // 030 ScaledScreenParams                       ModelPrimitiveType int int int Int32
    // 034 WorldSpaceCameraPos                      ModelPrimitiveType int int int Int32
    // 038 ScreenParams                             ModelPrimitiveType int int int Int32
    // 03C AlphaToMaskAvailable                     ModelPrimitiveType int int int Int32
    // 040 ProjectionParams                         ModelPrimitiveType int int int Int32
    // 044 ZBufferParams                            ModelPrimitiveType int int int Int32
    // 048 OrthoParams                              ModelPrimitiveType int int int Int32
    // 04C GlobalMipBias                            ModelPrimitiveType int int int Int32
    // 050 ScreenSize                               ModelPrimitiveType int int int Int32
    // 054 ScreenCoordScaleBias                     ModelPrimitiveType int int int Int32
    // 058 ScreenSizeOverride                       ModelPrimitiveType int int int Int32
    // 05C ViewMatrix                               ModelPrimitiveType int int int Int32
    // 060 ProjectionMatrix                         ModelPrimitiveType int int int Int32
    // 064 ViewAndProjectionMatrix                  ModelPrimitiveType int int int Int32
    // 068 InverseViewMatrix                        ModelPrimitiveType int int int Int32
    // 06C InverseProjectionMatrix                  ModelPrimitiveType int int int Int32
    // 070 InverseViewAndProjectionMatrix           ModelPrimitiveType int int int Int32
    // 074 CameraProjectionMatrix                   ModelPrimitiveType int int int Int32
    // 078 InverseCameraProjectionMatrix            ModelPrimitiveType int int int Int32
    // 07C WorldToCameraMatrix                      ModelPrimitiveType int int int Int32
    // 080 CameraToWorldMatrix                      ModelPrimitiveType int int int Int32
    // 084 CameraWorldClipPlanes                    ModelPrimitiveType int int int Int32
    // 088 BillboardNormal                          ModelPrimitiveType int int int Int32
    // 08C BillboardTangent                         ModelPrimitiveType int int int Int32
    // 090 BillboardCameraParams                    ModelPrimitiveType int int int Int32
    // 094 BlitTexture                              ModelPrimitiveType int int int Int32
    // 098 BlitScaleBias                            ModelPrimitiveType int int int Int32
    // 09C SourceTex                                ModelPrimitiveType int int int Int32
    // 0A0 ScaleBias                                ModelPrimitiveType int int int Int32
    // 0A4 ScaleBiasRt                              ModelPrimitiveType int int int Int32
    // 0A8 RendererColor                            ModelPrimitiveType int int int Int32
    // 0AC DitheringTexture                         ModelPrimitiveType int int int Int32
    // 0B0 DitheringTextureInvSize                  ModelPrimitiveType int int int Int32
    // 0B4 RenderingLayerMaxInt                     ModelPrimitiveType int int int Int32
    // 0B8 RenderingLayerRcpMaxInt                  ModelPrimitiveType int int int Int32
    // 0BC OverlayUITexture                         ModelPrimitiveType int int int Int32
    // 0C0 HdrOutputLuminanceParams                 ModelPrimitiveType int int int Int32
    // 0C4 HdrOutputGradingParams                   ModelPrimitiveType int int int Int32
    public partial class ShaderPropertyId : DataModel
    {
        public int                                      AmbientSkyColor                         { get; set; }
        public int                                      AmbientEquatorColor                     { get; set; }
        public int                                      AmbientGroundColor                      { get; set; }
        public int                                      Time                                    { get; set; }
        public int                                      SinTime                                 { get; set; }
        public int                                      CosTime                                 { get; set; }
        public int                                      DeltaTime                               { get; set; }
        public int                                      TimeParameters                          { get; set; }
        public int                                      ScaledScreenParams                      { get; set; }
        public int                                      WorldSpaceCameraPos                     { get; set; }
        public int                                      ScreenParams                            { get; set; }
        public int                                      AlphaToMaskAvailable                    { get; set; }
        public int                                      ProjectionParams                        { get; set; }
        public int                                      ZBufferParams                           { get; set; }
        public int                                      OrthoParams                             { get; set; }
        public int                                      GlobalMipBias                           { get; set; }
        public int                                      ScreenSize                              { get; set; }
        public int                                      ScreenCoordScaleBias                    { get; set; }
        public int                                      ScreenSizeOverride                      { get; set; }
        public int                                      ViewMatrix                              { get; set; }
        public int                                      ProjectionMatrix                        { get; set; }
        public int                                      ViewAndProjectionMatrix                 { get; set; }
        public int                                      InverseViewMatrix                       { get; set; }
        public int                                      InverseProjectionMatrix                 { get; set; }
        public int                                      InverseViewAndProjectionMatrix          { get; set; }
        public int                                      CameraProjectionMatrix                  { get; set; }
        public int                                      InverseCameraProjectionMatrix           { get; set; }
        public int                                      WorldToCameraMatrix                     { get; set; }
        public int                                      CameraToWorldMatrix                     { get; set; }
        public int                                      CameraWorldClipPlanes                   { get; set; }
        public int                                      BillboardNormal                         { get; set; }
        public int                                      BillboardTangent                        { get; set; }
        public int                                      BillboardCameraParams                   { get; set; }
        public int                                      BlitTexture                             { get; set; }
        public int                                      BlitScaleBias                           { get; set; }
        public int                                      SourceTex                               { get; set; }
        public int                                      ScaleBias                               { get; set; }
        public int                                      ScaleBiasRt                             { get; set; }
        public int                                      RendererColor                           { get; set; }
        public int                                      DitheringTexture                        { get; set; }
        public int                                      DitheringTextureInvSize                 { get; set; }
        public int                                      RenderingLayerMaxInt                    { get; set; }
        public int                                      RenderingLayerRcpMaxInt                 { get; set; }
        public int                                      OverlayUITexture                        { get; set; }
        public int                                      HdrOutputLuminanceParams                { get; set; }
        public int                                      HdrOutputGradingParams                  { get; set; }

        public static ShaderPropertyId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderPropertyId() { Pointer= p0 };

            value.AmbientSkyColor                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 AmbientSkyColor             ( ModelPrimitiveType int int int Int32 )
            value.AmbientEquatorColor                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 AmbientEquatorColor         ( ModelPrimitiveType int int int Int32 )
            value.AmbientGroundColor                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 AmbientGroundColor          ( ModelPrimitiveType int int int Int32 )
            value.Time                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Time                        ( ModelPrimitiveType int int int Int32 )
            value.SinTime                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 SinTime                     ( ModelPrimitiveType int int int Int32 )
            value.CosTime                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 CosTime                     ( ModelPrimitiveType int int int Int32 )
            value.DeltaTime                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 DeltaTime                   ( ModelPrimitiveType int int int Int32 )
            value.TimeParameters                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C TimeParameters              ( ModelPrimitiveType int int int Int32 )
            value.ScaledScreenParams                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 ScaledScreenParams          ( ModelPrimitiveType int int int Int32 )
            value.WorldSpaceCameraPos                       = GetInt32(new IntPtr(p + 0x034)); // 0x34 WorldSpaceCameraPos         ( ModelPrimitiveType int int int Int32 )
            value.ScreenParams                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 ScreenParams                ( ModelPrimitiveType int int int Int32 )
            value.AlphaToMaskAvailable                      = GetInt32(new IntPtr(p + 0x03C)); // 0x3C AlphaToMaskAvailable        ( ModelPrimitiveType int int int Int32 )
            value.ProjectionParams                          = GetInt32(new IntPtr(p + 0x040)); // 0x40 ProjectionParams            ( ModelPrimitiveType int int int Int32 )
            value.ZBufferParams                             = GetInt32(new IntPtr(p + 0x044)); // 0x44 ZBufferParams               ( ModelPrimitiveType int int int Int32 )
            value.OrthoParams                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 OrthoParams                 ( ModelPrimitiveType int int int Int32 )
            value.GlobalMipBias                             = GetInt32(new IntPtr(p + 0x04C)); // 0x4C GlobalMipBias               ( ModelPrimitiveType int int int Int32 )
            value.ScreenSize                                = GetInt32(new IntPtr(p + 0x050)); // 0x50 ScreenSize                  ( ModelPrimitiveType int int int Int32 )
            value.ScreenCoordScaleBias                      = GetInt32(new IntPtr(p + 0x054)); // 0x54 ScreenCoordScaleBias        ( ModelPrimitiveType int int int Int32 )
            value.ScreenSizeOverride                        = GetInt32(new IntPtr(p + 0x058)); // 0x58 ScreenSizeOverride          ( ModelPrimitiveType int int int Int32 )
            value.ViewMatrix                                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C ViewMatrix                  ( ModelPrimitiveType int int int Int32 )
            value.ProjectionMatrix                          = GetInt32(new IntPtr(p + 0x060)); // 0x60 ProjectionMatrix            ( ModelPrimitiveType int int int Int32 )
            value.ViewAndProjectionMatrix                   = GetInt32(new IntPtr(p + 0x064)); // 0x64 ViewAndProjectionMatrix     ( ModelPrimitiveType int int int Int32 )
            value.InverseViewMatrix                         = GetInt32(new IntPtr(p + 0x068)); // 0x68 InverseViewMatrix           ( ModelPrimitiveType int int int Int32 )
            value.InverseProjectionMatrix                   = GetInt32(new IntPtr(p + 0x06C)); // 0x6C InverseProjectionMatrix     ( ModelPrimitiveType int int int Int32 )
            value.InverseViewAndProjectionMatrix            = GetInt32(new IntPtr(p + 0x070)); // 0x70 InverseViewAndProjectionMatrix ( ModelPrimitiveType int int int Int32 )
            value.CameraProjectionMatrix                    = GetInt32(new IntPtr(p + 0x074)); // 0x74 CameraProjectionMatrix      ( ModelPrimitiveType int int int Int32 )
            value.InverseCameraProjectionMatrix             = GetInt32(new IntPtr(p + 0x078)); // 0x78 InverseCameraProjectionMatrix ( ModelPrimitiveType int int int Int32 )
            value.WorldToCameraMatrix                       = GetInt32(new IntPtr(p + 0x07C)); // 0x7C WorldToCameraMatrix         ( ModelPrimitiveType int int int Int32 )
            value.CameraToWorldMatrix                       = GetInt32(new IntPtr(p + 0x080)); // 0x80 CameraToWorldMatrix         ( ModelPrimitiveType int int int Int32 )
            value.CameraWorldClipPlanes                     = GetInt32(new IntPtr(p + 0x084)); // 0x84 CameraWorldClipPlanes       ( ModelPrimitiveType int int int Int32 )
            value.BillboardNormal                           = GetInt32(new IntPtr(p + 0x088)); // 0x88 BillboardNormal             ( ModelPrimitiveType int int int Int32 )
            value.BillboardTangent                          = GetInt32(new IntPtr(p + 0x08C)); // 0x8C BillboardTangent            ( ModelPrimitiveType int int int Int32 )
            value.BillboardCameraParams                     = GetInt32(new IntPtr(p + 0x090)); // 0x90 BillboardCameraParams       ( ModelPrimitiveType int int int Int32 )
            value.BlitTexture                               = GetInt32(new IntPtr(p + 0x094)); // 0x94 BlitTexture                 ( ModelPrimitiveType int int int Int32 )
            value.BlitScaleBias                             = GetInt32(new IntPtr(p + 0x098)); // 0x98 BlitScaleBias               ( ModelPrimitiveType int int int Int32 )
            value.SourceTex                                 = GetInt32(new IntPtr(p + 0x09C)); // 0x9C SourceTex                   ( ModelPrimitiveType int int int Int32 )
            value.ScaleBias                                 = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ScaleBias                   ( ModelPrimitiveType int int int Int32 )
            value.ScaleBiasRt                               = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 ScaleBiasRt                 ( ModelPrimitiveType int int int Int32 )
            value.RendererColor                             = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 RendererColor               ( ModelPrimitiveType int int int Int32 )
            value.DitheringTexture                          = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC DitheringTexture            ( ModelPrimitiveType int int int Int32 )
            value.DitheringTextureInvSize                   = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 DitheringTextureInvSize     ( ModelPrimitiveType int int int Int32 )
            value.RenderingLayerMaxInt                      = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 RenderingLayerMaxInt        ( ModelPrimitiveType int int int Int32 )
            value.RenderingLayerRcpMaxInt                   = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 RenderingLayerRcpMaxInt     ( ModelPrimitiveType int int int Int32 )
            value.OverlayUITexture                          = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC OverlayUITexture            ( ModelPrimitiveType int int int Int32 )
            value.HdrOutputLuminanceParams                  = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 HdrOutputLuminanceParams    ( ModelPrimitiveType int int int Int32 )
            value.HdrOutputGradingParams                    = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 HdrOutputGradingParams      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
