using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MainTex                                  int IL2CPP_TYPE_I4
    // 004 SMAA_Flip                                int IL2CPP_TYPE_I4
    // 008 SMAA_Flop                                int IL2CPP_TYPE_I4
    // 00C DepthOfFieldTemp                         int IL2CPP_TYPE_I4
    // 010 DepthOfFieldTex                          ModelPrimitiveType int int int Int32
    // 014 Distance                                 ModelPrimitiveType int int int Int32
    // 018 LensCoeff                                ModelPrimitiveType int int int Int32
    // 01C MaxCoC                                   ModelPrimitiveType int int int Int32
    // 020 RcpMaxCoC                                ModelPrimitiveType int int int Int32
    // 024 RcpAspect                                ModelPrimitiveType int int int Int32
    // 028 CoCTex                                   ModelPrimitiveType int int int Int32
    // 02C AutoExposureTex                          ModelPrimitiveType int int int Int32
    // 030 Params                                   ModelPrimitiveType int int int Int32
    // 034 Glitch_ScanLineJitter                    ModelPrimitiveType int int int Int32
    // 038 Glitch_VerticalJump                      ModelPrimitiveType int int int Int32
    // 03C Glitch_HorizontalShake                   ModelPrimitiveType int int int Int32
    // 040 Glitch_ColorDrift                        ModelPrimitiveType int int int Int32
    // 044 SoftOverlay_Weight                       ModelPrimitiveType int int int Int32
    // 048 SoftOverlay_SampleScale                  ModelPrimitiveType int int int Int32
    // 04C ScalingWeight                            ModelPrimitiveType int int int Int32
    // 050 SoftOverlayTex                           ModelPrimitiveType int int int Int32
    // 054 ColorArray                               ModelPrimitiveType int int int Int32
    // 058 LdrBloomTex                              ModelPrimitiveType int int int Int32
    // 05C LdrBloom_DirtTex                         ModelPrimitiveType int int int Int32
    // 060 LdrBloom_Settings                        ModelPrimitiveType int int int Int32
    // 064 LdrBloom_Color                           ModelPrimitiveType int int int Int32
    // 068 LdrBloom_DirtTileOffset                  ModelPrimitiveType int int int Int32
    // 06C BloomTex                                 ModelPrimitiveType int int int Int32
    // 070 SampleScale                              ModelPrimitiveType int int int Int32
    // 074 Threshold                                ModelPrimitiveType int int int Int32
    // 078 ColorIntensity                           ModelPrimitiveType int int int Int32
    // 07C Bloom_DirtTex                            ModelPrimitiveType int int int Int32
    // 080 Bloom_Settings                           ModelPrimitiveType int int int Int32
    // 084 Bloom_Color                              ModelPrimitiveType int int int Int32
    // 088 Bloom_DirtTileOffset                     ModelPrimitiveType int int int Int32
    // 08C ChromaticAberration_Amount               ModelPrimitiveType int int int Int32
    // 090 ChromaticAberration_SpectralLut          ModelPrimitiveType int int int Int32
    // 094 Distortion_CenterScale                   ModelPrimitiveType int int int Int32
    // 098 Distortion_Amount                        ModelPrimitiveType int int int Int32
    // 09C Lut2D                                    ModelPrimitiveType int int int Int32
    // 0A0 Lut3D                                    ModelPrimitiveType int int int Int32
    // 0A4 Lut3D_Params                             ModelPrimitiveType int int int Int32
    // 0A8 Lut2D_Params                             ModelPrimitiveType int int int Int32
    // 0AC UserLut2D_Params                         ModelPrimitiveType int int int Int32
    // 0B0 PostExposure                             ModelPrimitiveType int int int Int32
    // 0B4 ColorFilter                              ModelPrimitiveType int int int Int32
    // 0B8 HueSatCon                                ModelPrimitiveType int int int Int32
    // 0BC Brightness                               ModelPrimitiveType int int int Int32
    // 0C0 Lift                                     ModelPrimitiveType int int int Int32
    // 0C4 InvGamma                                 ModelPrimitiveType int int int Int32
    // 0C8 Gain                                     ModelPrimitiveType int int int Int32
    // 0CC Curves                                   ModelPrimitiveType int int int Int32
    // 0D0 CustomToneCurve                          ModelPrimitiveType int int int Int32
    // 0D4 ToeSegmentA                              ModelPrimitiveType int int int Int32
    // 0D8 ToeSegmentB                              ModelPrimitiveType int int int Int32
    // 0DC MidSegmentA                              ModelPrimitiveType int int int Int32
    // 0E0 MidSegmentB                              ModelPrimitiveType int int int Int32
    // 0E4 ShoSegmentA                              ModelPrimitiveType int int int Int32
    // 0E8 ShoSegmentB                              ModelPrimitiveType int int int Int32
    // 0EC Vignette_Color                           ModelPrimitiveType int int int Int32
    // 0F0 Vignette_Center                          ModelPrimitiveType int int int Int32
    // 0F4 Vignette_Settings                        ModelPrimitiveType int int int Int32
    // 0F8 Vignette_Mask                            ModelPrimitiveType int int int Int32
    // 0FC Vignette_Opacity                         ModelPrimitiveType int int int Int32
    // 100 Vignette_Mode                            ModelPrimitiveType int int int Int32
    // 104 Grain_Params1                            ModelPrimitiveType int int int Int32
    // 108 Grain_Params2                            ModelPrimitiveType int int int Int32
    // 10C GrainTex                                 ModelPrimitiveType int int int Int32
    // 110 Phase                                    ModelPrimitiveType int int int Int32
    // 114 GrainNoiseParameters                     ModelPrimitiveType int int int Int32
    // 118 LumaInAlpha                              ModelPrimitiveType int int int Int32
    // 11C To                                       ModelPrimitiveType int int int Int32
    // 120 Interp                                   ModelPrimitiveType int int int Int32
    // 124 TargetColor                              ModelPrimitiveType int int int Int32
    // 128 RenderViewportScaleFactor                ModelPrimitiveType int int int Int32
    // 12C UVTransform                              ModelPrimitiveType int int int Int32
    // 130 DepthSlice                               ModelPrimitiveType int int int Int32
    // 134 UVScaleOffset                            ModelPrimitiveType int int int Int32
    // 138 PosScaleOffset                           ModelPrimitiveType int int int Int32
    public partial class ShaderIDs : DataModel
    {
        public int                                      DepthOfFieldTex                         { get; set; }
        public int                                      Distance                                { get; set; }
        public int                                      LensCoeff                               { get; set; }
        public int                                      MaxCoC                                  { get; set; }
        public int                                      RcpMaxCoC                               { get; set; }
        public int                                      RcpAspect                               { get; set; }
        public int                                      CoCTex                                  { get; set; }
        public int                                      AutoExposureTex                         { get; set; }
        public int                                      Params                                  { get; set; }
        public int                                      Glitch_ScanLineJitter                   { get; set; }
        public int                                      Glitch_VerticalJump                     { get; set; }
        public int                                      Glitch_HorizontalShake                  { get; set; }
        public int                                      Glitch_ColorDrift                       { get; set; }
        public int                                      SoftOverlay_Weight                      { get; set; }
        public int                                      SoftOverlay_SampleScale                 { get; set; }
        public int                                      ScalingWeight                           { get; set; }
        public int                                      SoftOverlayTex                          { get; set; }
        public int                                      ColorArray                              { get; set; }
        public int                                      LdrBloomTex                             { get; set; }
        public int                                      LdrBloom_DirtTex                        { get; set; }
        public int                                      LdrBloom_Settings                       { get; set; }
        public int                                      LdrBloom_Color                          { get; set; }
        public int                                      LdrBloom_DirtTileOffset                 { get; set; }
        public int                                      BloomTex                                { get; set; }
        public int                                      SampleScale                             { get; set; }
        public int                                      Threshold                               { get; set; }
        public int                                      ColorIntensity                          { get; set; }
        public int                                      Bloom_DirtTex                           { get; set; }
        public int                                      Bloom_Settings                          { get; set; }
        public int                                      Bloom_Color                             { get; set; }
        public int                                      Bloom_DirtTileOffset                    { get; set; }
        public int                                      ChromaticAberration_Amount              { get; set; }
        public int                                      ChromaticAberration_SpectralLut         { get; set; }
        public int                                      Distortion_CenterScale                  { get; set; }
        public int                                      Distortion_Amount                       { get; set; }
        public int                                      Lut2D                                   { get; set; }
        public int                                      Lut3D                                   { get; set; }
        public int                                      Lut3D_Params                            { get; set; }
        public int                                      Lut2D_Params                            { get; set; }
        public int                                      UserLut2D_Params                        { get; set; }
        public int                                      PostExposure                            { get; set; }
        public int                                      ColorFilter                             { get; set; }
        public int                                      HueSatCon                               { get; set; }
        public int                                      Brightness                              { get; set; }
        public int                                      Lift                                    { get; set; }
        public int                                      InvGamma                                { get; set; }
        public int                                      Gain                                    { get; set; }
        public int                                      Curves                                  { get; set; }
        public int                                      CustomToneCurve                         { get; set; }
        public int                                      ToeSegmentA                             { get; set; }
        public int                                      ToeSegmentB                             { get; set; }
        public int                                      MidSegmentA                             { get; set; }
        public int                                      MidSegmentB                             { get; set; }
        public int                                      ShoSegmentA                             { get; set; }
        public int                                      ShoSegmentB                             { get; set; }
        public int                                      Vignette_Color                          { get; set; }
        public int                                      Vignette_Center                         { get; set; }
        public int                                      Vignette_Settings                       { get; set; }
        public int                                      Vignette_Mask                           { get; set; }
        public int                                      Vignette_Opacity                        { get; set; }
        public int                                      Vignette_Mode                           { get; set; }
        public int                                      Grain_Params1                           { get; set; }
        public int                                      Grain_Params2                           { get; set; }
        public int                                      GrainTex                                { get; set; }
        public int                                      Phase                                   { get; set; }
        public int                                      GrainNoiseParameters                    { get; set; }
        public int                                      LumaInAlpha                             { get; set; }
        public int                                      To                                      { get; set; }
        public int                                      Interp                                  { get; set; }
        public int                                      TargetColor                             { get; set; }
        public int                                      RenderViewportScaleFactor               { get; set; }
        public int                                      UVTransform                             { get; set; }
        public int                                      DepthSlice                              { get; set; }
        public int                                      UVScaleOffset                           { get; set; }
        public int                                      PosScaleOffset                          { get; set; }

        public static ShaderIDs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderIDs() { Pointer= p0 };

            value.DepthOfFieldTex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 DepthOfFieldTex             ( ModelPrimitiveType int int int Int32 )
            value.Distance                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 Distance                    ( ModelPrimitiveType int int int Int32 )
            value.LensCoeff                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 LensCoeff                   ( ModelPrimitiveType int int int Int32 )
            value.MaxCoC                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MaxCoC                      ( ModelPrimitiveType int int int Int32 )
            value.RcpMaxCoC                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 RcpMaxCoC                   ( ModelPrimitiveType int int int Int32 )
            value.RcpAspect                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 RcpAspect                   ( ModelPrimitiveType int int int Int32 )
            value.CoCTex                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 CoCTex                      ( ModelPrimitiveType int int int Int32 )
            value.AutoExposureTex                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C AutoExposureTex             ( ModelPrimitiveType int int int Int32 )
            value.Params                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 Params                      ( ModelPrimitiveType int int int Int32 )
            value.Glitch_ScanLineJitter                     = GetInt32(new IntPtr(p + 0x034)); // 0x34 Glitch_ScanLineJitter       ( ModelPrimitiveType int int int Int32 )
            value.Glitch_VerticalJump                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 Glitch_VerticalJump         ( ModelPrimitiveType int int int Int32 )
            value.Glitch_HorizontalShake                    = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Glitch_HorizontalShake      ( ModelPrimitiveType int int int Int32 )
            value.Glitch_ColorDrift                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 Glitch_ColorDrift           ( ModelPrimitiveType int int int Int32 )
            value.SoftOverlay_Weight                        = GetInt32(new IntPtr(p + 0x044)); // 0x44 SoftOverlay_Weight          ( ModelPrimitiveType int int int Int32 )
            value.SoftOverlay_SampleScale                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 SoftOverlay_SampleScale     ( ModelPrimitiveType int int int Int32 )
            value.ScalingWeight                             = GetInt32(new IntPtr(p + 0x04C)); // 0x4C ScalingWeight               ( ModelPrimitiveType int int int Int32 )
            value.SoftOverlayTex                            = GetInt32(new IntPtr(p + 0x050)); // 0x50 SoftOverlayTex              ( ModelPrimitiveType int int int Int32 )
            value.ColorArray                                = GetInt32(new IntPtr(p + 0x054)); // 0x54 ColorArray                  ( ModelPrimitiveType int int int Int32 )
            value.LdrBloomTex                               = GetInt32(new IntPtr(p + 0x058)); // 0x58 LdrBloomTex                 ( ModelPrimitiveType int int int Int32 )
            value.LdrBloom_DirtTex                          = GetInt32(new IntPtr(p + 0x05C)); // 0x5C LdrBloom_DirtTex            ( ModelPrimitiveType int int int Int32 )
            value.LdrBloom_Settings                         = GetInt32(new IntPtr(p + 0x060)); // 0x60 LdrBloom_Settings           ( ModelPrimitiveType int int int Int32 )
            value.LdrBloom_Color                            = GetInt32(new IntPtr(p + 0x064)); // 0x64 LdrBloom_Color              ( ModelPrimitiveType int int int Int32 )
            value.LdrBloom_DirtTileOffset                   = GetInt32(new IntPtr(p + 0x068)); // 0x68 LdrBloom_DirtTileOffset     ( ModelPrimitiveType int int int Int32 )
            value.BloomTex                                  = GetInt32(new IntPtr(p + 0x06C)); // 0x6C BloomTex                    ( ModelPrimitiveType int int int Int32 )
            value.SampleScale                               = GetInt32(new IntPtr(p + 0x070)); // 0x70 SampleScale                 ( ModelPrimitiveType int int int Int32 )
            value.Threshold                                 = GetInt32(new IntPtr(p + 0x074)); // 0x74 Threshold                   ( ModelPrimitiveType int int int Int32 )
            value.ColorIntensity                            = GetInt32(new IntPtr(p + 0x078)); // 0x78 ColorIntensity              ( ModelPrimitiveType int int int Int32 )
            value.Bloom_DirtTex                             = GetInt32(new IntPtr(p + 0x07C)); // 0x7C Bloom_DirtTex               ( ModelPrimitiveType int int int Int32 )
            value.Bloom_Settings                            = GetInt32(new IntPtr(p + 0x080)); // 0x80 Bloom_Settings              ( ModelPrimitiveType int int int Int32 )
            value.Bloom_Color                               = GetInt32(new IntPtr(p + 0x084)); // 0x84 Bloom_Color                 ( ModelPrimitiveType int int int Int32 )
            value.Bloom_DirtTileOffset                      = GetInt32(new IntPtr(p + 0x088)); // 0x88 Bloom_DirtTileOffset        ( ModelPrimitiveType int int int Int32 )
            value.ChromaticAberration_Amount                = GetInt32(new IntPtr(p + 0x08C)); // 0x8C ChromaticAberration_Amount  ( ModelPrimitiveType int int int Int32 )
            value.ChromaticAberration_SpectralLut           = GetInt32(new IntPtr(p + 0x090)); // 0x90 ChromaticAberration_SpectralLut ( ModelPrimitiveType int int int Int32 )
            value.Distortion_CenterScale                    = GetInt32(new IntPtr(p + 0x094)); // 0x94 Distortion_CenterScale      ( ModelPrimitiveType int int int Int32 )
            value.Distortion_Amount                         = GetInt32(new IntPtr(p + 0x098)); // 0x98 Distortion_Amount           ( ModelPrimitiveType int int int Int32 )
            value.Lut2D                                     = GetInt32(new IntPtr(p + 0x09C)); // 0x9C Lut2D                       ( ModelPrimitiveType int int int Int32 )
            value.Lut3D                                     = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Lut3D                       ( ModelPrimitiveType int int int Int32 )
            value.Lut3D_Params                              = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 Lut3D_Params                ( ModelPrimitiveType int int int Int32 )
            value.Lut2D_Params                              = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Lut2D_Params                ( ModelPrimitiveType int int int Int32 )
            value.UserLut2D_Params                          = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC UserLut2D_Params            ( ModelPrimitiveType int int int Int32 )
            value.PostExposure                              = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 PostExposure                ( ModelPrimitiveType int int int Int32 )
            value.ColorFilter                               = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 ColorFilter                 ( ModelPrimitiveType int int int Int32 )
            value.HueSatCon                                 = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 HueSatCon                   ( ModelPrimitiveType int int int Int32 )
            value.Brightness                                = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC Brightness                  ( ModelPrimitiveType int int int Int32 )
            value.Lift                                      = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 Lift                        ( ModelPrimitiveType int int int Int32 )
            value.InvGamma                                  = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 InvGamma                    ( ModelPrimitiveType int int int Int32 )
            value.Gain                                      = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 Gain                        ( ModelPrimitiveType int int int Int32 )
            value.Curves                                    = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC Curves                      ( ModelPrimitiveType int int int Int32 )
            value.CustomToneCurve                           = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 CustomToneCurve             ( ModelPrimitiveType int int int Int32 )
            value.ToeSegmentA                               = GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 ToeSegmentA                 ( ModelPrimitiveType int int int Int32 )
            value.ToeSegmentB                               = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 ToeSegmentB                 ( ModelPrimitiveType int int int Int32 )
            value.MidSegmentA                               = GetInt32(new IntPtr(p + 0x0DC)); // 0xDC MidSegmentA                 ( ModelPrimitiveType int int int Int32 )
            value.MidSegmentB                               = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 MidSegmentB                 ( ModelPrimitiveType int int int Int32 )
            value.ShoSegmentA                               = GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 ShoSegmentA                 ( ModelPrimitiveType int int int Int32 )
            value.ShoSegmentB                               = GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 ShoSegmentB                 ( ModelPrimitiveType int int int Int32 )
            value.Vignette_Color                            = GetInt32(new IntPtr(p + 0x0EC)); // 0xEC Vignette_Color              ( ModelPrimitiveType int int int Int32 )
            value.Vignette_Center                           = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 Vignette_Center             ( ModelPrimitiveType int int int Int32 )
            value.Vignette_Settings                         = GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 Vignette_Settings           ( ModelPrimitiveType int int int Int32 )
            value.Vignette_Mask                             = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 Vignette_Mask               ( ModelPrimitiveType int int int Int32 )
            value.Vignette_Opacity                          = GetInt32(new IntPtr(p + 0x0FC)); // 0xFC Vignette_Opacity            ( ModelPrimitiveType int int int Int32 )
            value.Vignette_Mode                             = GetInt32(new IntPtr(p + 0x100)); // 0x100 Vignette_Mode               ( ModelPrimitiveType int int int Int32 )
            value.Grain_Params1                             = GetInt32(new IntPtr(p + 0x104)); // 0x104 Grain_Params1               ( ModelPrimitiveType int int int Int32 )
            value.Grain_Params2                             = GetInt32(new IntPtr(p + 0x108)); // 0x108 Grain_Params2               ( ModelPrimitiveType int int int Int32 )
            value.GrainTex                                  = GetInt32(new IntPtr(p + 0x10C)); // 0x10C GrainTex                    ( ModelPrimitiveType int int int Int32 )
            value.Phase                                     = GetInt32(new IntPtr(p + 0x110)); // 0x110 Phase                       ( ModelPrimitiveType int int int Int32 )
            value.GrainNoiseParameters                      = GetInt32(new IntPtr(p + 0x114)); // 0x114 GrainNoiseParameters        ( ModelPrimitiveType int int int Int32 )
            value.LumaInAlpha                               = GetInt32(new IntPtr(p + 0x118)); // 0x118 LumaInAlpha                 ( ModelPrimitiveType int int int Int32 )
            value.To                                        = GetInt32(new IntPtr(p + 0x11C)); // 0x11C To                          ( ModelPrimitiveType int int int Int32 )
            value.Interp                                    = GetInt32(new IntPtr(p + 0x120)); // 0x120 Interp                      ( ModelPrimitiveType int int int Int32 )
            value.TargetColor                               = GetInt32(new IntPtr(p + 0x124)); // 0x124 TargetColor                 ( ModelPrimitiveType int int int Int32 )
            value.RenderViewportScaleFactor                 = GetInt32(new IntPtr(p + 0x128)); // 0x128 RenderViewportScaleFactor   ( ModelPrimitiveType int int int Int32 )
            value.UVTransform                               = GetInt32(new IntPtr(p + 0x12C)); // 0x12C UVTransform                 ( ModelPrimitiveType int int int Int32 )
            value.DepthSlice                                = GetInt32(new IntPtr(p + 0x130)); // 0x130 DepthSlice                  ( ModelPrimitiveType int int int Int32 )
            value.UVScaleOffset                             = GetInt32(new IntPtr(p + 0x134)); // 0x134 UVScaleOffset               ( ModelPrimitiveType int int int Int32 )
            value.PosScaleOffset                            = GetInt32(new IntPtr(p + 0x138)); // 0x138 PosScaleOffset              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
