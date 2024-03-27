using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _Color                                   int IL2CPP_TYPE_I4
    // 004 _MainTex                                 int IL2CPP_TYPE_I4
    // 008 _MainTex_ST                              int IL2CPP_TYPE_I4
    // 00C _LightTex                                int IL2CPP_TYPE_I4
    // 010 AngelRingColor                           0001865F50A0 ModelPrimitiveType int int int Int32
    // 014 OutlineAdjust                            0001865F50A0 ModelPrimitiveType int int int Int32
    // 018 OutlineInclusive                         0001865F50A0 ModelPrimitiveType int int int Int32
    // 01C OutlineColorAdd                          0001865F50A0 ModelPrimitiveType int int int Int32
    // 020 ReferencePoint                           0001865F50A0 ModelPrimitiveType int int int Int32
    // 024 PlanePoint                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 028 PlaneNormal                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 02C CameraDir                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 030 PersonalLight                            0001865F50A0 ModelPrimitiveType int int int Int32
    // 034 ScaleZ                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 038 CenterPos                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 03C Radius                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 040 RingRotation                             0001865F50A0 ModelPrimitiveType int int int Int32
    // 044 RimPower                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 048 RimIntensity                             0001865F50A0 ModelPrimitiveType int int int Int32
    // 04C RimColor                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 050 RimLightDirection                        0001865F50A0 ModelPrimitiveType int int int Int32
    // 054 RimFeather                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 058 RimDiffuseRate                           0001865F50A0 ModelPrimitiveType int int int Int32
    // 05C ShadowDir                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 060 ShadowPoint                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 064 LightDir                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 068 FaceRadius                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 06C ZBias                                    0001865F50A0 ModelPrimitiveType int int int Int32
    // 070 ReflectionTex                            0001865F50A0 ModelPrimitiveType int int int Int32
    // 074 Mode                                     0001865F50A0 ModelPrimitiveType int int int Int32
    // 078 IrisUV                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 07C Flip                                     0001865F50A0 ModelPrimitiveType int int int Int32
    // 080 StencilRef                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 084 SrcBlend                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 088 DstBlend                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 08C Cull                                     0001865F50A0 ModelPrimitiveType int int int Int32
    // 090 ZWrite                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 094 Ratio                                    0001865F50A0 ModelPrimitiveType int int int Int32
    // 098 Aspect                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 09C UvParam                                  0001865F50A0 ModelPrimitiveType int int int Int32
    // 0A0 ShadeLight                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 0A4 BlurRatio                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0A8 LightTex_ST                              0001865F50A0 ModelPrimitiveType int int int Int32
    // 0AC DrawOffsetAngle                          0001865F50A0 ModelPrimitiveType int int int Int32
    // 0B0 FadeEffectTex_ST                         0001865F50A0 ModelPrimitiveType int int int Int32
    // 0B4 ZoomStart                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0B8 TimeRatio                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0BC NEGA                                     0001865F50A0 ModelPrimitiveType int int int Int32
    // 0C0 AlphaBias                                0001865F50A0 ModelPrimitiveType int int int Int32
    // 0C4 CullMode                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 0C8 Irogae                                   0001865F50A0 ModelPrimitiveType int int int Int32
    // 0CC GradeTex                                 0001865F50A0 ModelPrimitiveType int int int Int32
    // 0D0 LastScreen                               0001865F50A0 ModelPrimitiveType int int int Int32
    // 0D4 ShadeZOffset                             0001865F50A0 ModelPrimitiveType int int int Int32
    public partial class ShaderPropertyIDs
    {
        public int                                      AngelRingColor                          { get; set; }
        public int                                      OutlineAdjust                           { get; set; }
        public int                                      OutlineInclusive                        { get; set; }
        public int                                      OutlineColorAdd                         { get; set; }
        public int                                      ReferencePoint                          { get; set; }
        public int                                      PlanePoint                              { get; set; }
        public int                                      PlaneNormal                             { get; set; }
        public int                                      CameraDir                               { get; set; }
        public int                                      PersonalLight                           { get; set; }
        public int                                      ScaleZ                                  { get; set; }
        public int                                      CenterPos                               { get; set; }
        public int                                      Radius                                  { get; set; }
        public int                                      RingRotation                            { get; set; }
        public int                                      RimPower                                { get; set; }
        public int                                      RimIntensity                            { get; set; }
        public int                                      RimColor                                { get; set; }
        public int                                      RimLightDirection                       { get; set; }
        public int                                      RimFeather                              { get; set; }
        public int                                      RimDiffuseRate                          { get; set; }
        public int                                      ShadowDir                               { get; set; }
        public int                                      ShadowPoint                             { get; set; }
        public int                                      LightDir                                { get; set; }
        public int                                      FaceRadius                              { get; set; }
        public int                                      ZBias                                   { get; set; }
        public int                                      ReflectionTex                           { get; set; }
        public int                                      Mode                                    { get; set; }
        public int                                      IrisUV                                  { get; set; }
        public int                                      Flip                                    { get; set; }
        public int                                      StencilRef                              { get; set; }
        public int                                      SrcBlend                                { get; set; }
        public int                                      DstBlend                                { get; set; }
        public int                                      Cull                                    { get; set; }
        public int                                      ZWrite                                  { get; set; }
        public int                                      Ratio                                   { get; set; }
        public int                                      Aspect                                  { get; set; }
        public int                                      UvParam                                 { get; set; }
        public int                                      ShadeLight                              { get; set; }
        public int                                      BlurRatio                               { get; set; }
        public int                                      LightTex_ST                             { get; set; }
        public int                                      DrawOffsetAngle                         { get; set; }
        public int                                      FadeEffectTex_ST                        { get; set; }
        public int                                      ZoomStart                               { get; set; }
        public int                                      TimeRatio                               { get; set; }
        public int                                      NEGA                                    { get; set; }
        public int                                      AlphaBias                               { get; set; }
        public int                                      CullMode                                { get; set; }
        public int                                      Irogae                                  { get; set; }
        public int                                      GradeTex                                { get; set; }
        public int                                      LastScreen                              { get; set; }
        public int                                      ShadeZOffset                            { get; set; }

        public static ShaderPropertyIDs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderPropertyIDs();

            value.AngelRingColor                            = GetInt32(new IntPtr(p + 0x010)); // 0270D0E797A0 0x10 AngelRingColor              ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.OutlineAdjust                             = GetInt32(new IntPtr(p + 0x014)); // 0270D0E797C0 0x14 OutlineAdjust               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.OutlineInclusive                          = GetInt32(new IntPtr(p + 0x018)); // 0270D0E797E0 0x18 OutlineInclusive            ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.OutlineColorAdd                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D0E79800 0x1C OutlineColorAdd             ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ReferencePoint                            = GetInt32(new IntPtr(p + 0x020)); // 0270D0E79820 0x20 ReferencePoint              ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.PlanePoint                                = GetInt32(new IntPtr(p + 0x024)); // 0270D0E79840 0x24 PlanePoint                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.PlaneNormal                               = GetInt32(new IntPtr(p + 0x028)); // 0270D0E79860 0x28 PlaneNormal                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CameraDir                                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D0E79880 0x2C CameraDir                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.PersonalLight                             = GetInt32(new IntPtr(p + 0x030)); // 0270D0E798A0 0x30 PersonalLight               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ScaleZ                                    = GetInt32(new IntPtr(p + 0x034)); // 0270D0E798C0 0x34 ScaleZ                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CenterPos                                 = GetInt32(new IntPtr(p + 0x038)); // 0270D0E798E0 0x38 CenterPos                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Radius                                    = GetInt32(new IntPtr(p + 0x03C)); // 0270D0E79900 0x3C Radius                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RingRotation                              = GetInt32(new IntPtr(p + 0x040)); // 0270D0E79920 0x40 RingRotation                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RimPower                                  = GetInt32(new IntPtr(p + 0x044)); // 0270D0E79940 0x44 RimPower                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RimIntensity                              = GetInt32(new IntPtr(p + 0x048)); // 0270D0E79960 0x48 RimIntensity                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RimColor                                  = GetInt32(new IntPtr(p + 0x04C)); // 0270D0E79980 0x4C RimColor                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RimLightDirection                         = GetInt32(new IntPtr(p + 0x050)); // 0270D0E799A0 0x50 RimLightDirection           ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RimFeather                                = GetInt32(new IntPtr(p + 0x054)); // 0270D0E799C0 0x54 RimFeather                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.RimDiffuseRate                            = GetInt32(new IntPtr(p + 0x058)); // 0270D0E799E0 0x58 RimDiffuseRate              ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ShadowDir                                 = GetInt32(new IntPtr(p + 0x05C)); // 0270D0E79A00 0x5C ShadowDir                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ShadowPoint                               = GetInt32(new IntPtr(p + 0x060)); // 0270D0E79A20 0x60 ShadowPoint                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.LightDir                                  = GetInt32(new IntPtr(p + 0x064)); // 0270D0E79A40 0x64 LightDir                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.FaceRadius                                = GetInt32(new IntPtr(p + 0x068)); // 0270D0E79A60 0x68 FaceRadius                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ZBias                                     = GetInt32(new IntPtr(p + 0x06C)); // 0270D0E79A80 0x6C ZBias                       ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ReflectionTex                             = GetInt32(new IntPtr(p + 0x070)); // 0270D0E79AA0 0x70 ReflectionTex               ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Mode                                      = GetInt32(new IntPtr(p + 0x074)); // 0270D0E79AC0 0x74 Mode                        ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.IrisUV                                    = GetInt32(new IntPtr(p + 0x078)); // 0270D0E79AE0 0x78 IrisUV                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Flip                                      = GetInt32(new IntPtr(p + 0x07C)); // 0270D0E79B00 0x7C Flip                        ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.StencilRef                                = GetInt32(new IntPtr(p + 0x080)); // 0270D0E79B20 0x80 StencilRef                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.SrcBlend                                  = GetInt32(new IntPtr(p + 0x084)); // 0270D0E79B40 0x84 SrcBlend                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.DstBlend                                  = GetInt32(new IntPtr(p + 0x088)); // 0270D0E79B60 0x88 DstBlend                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Cull                                      = GetInt32(new IntPtr(p + 0x08C)); // 0270D0E79B80 0x8C Cull                        ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ZWrite                                    = GetInt32(new IntPtr(p + 0x090)); // 0270D0E79BA0 0x90 ZWrite                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Ratio                                     = GetInt32(new IntPtr(p + 0x094)); // 0270D0E79BC0 0x94 Ratio                       ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Aspect                                    = GetInt32(new IntPtr(p + 0x098)); // 0270D0E79BE0 0x98 Aspect                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.UvParam                                   = GetInt32(new IntPtr(p + 0x09C)); // 0270D0E79C00 0x9C UvParam                     ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ShadeLight                                = GetInt32(new IntPtr(p + 0x0A0)); // 0270D0E79C20 0xA0 ShadeLight                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.BlurRatio                                 = GetInt32(new IntPtr(p + 0x0A4)); // 0270D0E79C40 0xA4 BlurRatio                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.LightTex_ST                               = GetInt32(new IntPtr(p + 0x0A8)); // 0270D0E79C60 0xA8 LightTex_ST                 ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.DrawOffsetAngle                           = GetInt32(new IntPtr(p + 0x0AC)); // 0270D0E79C80 0xAC DrawOffsetAngle             ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.FadeEffectTex_ST                          = GetInt32(new IntPtr(p + 0x0B0)); // 0270D0E79CA0 0xB0 FadeEffectTex_ST            ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ZoomStart                                 = GetInt32(new IntPtr(p + 0x0B4)); // 0270D0E79CC0 0xB4 ZoomStart                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.TimeRatio                                 = GetInt32(new IntPtr(p + 0x0B8)); // 0270D0E79CE0 0xB8 TimeRatio                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.NEGA                                      = GetInt32(new IntPtr(p + 0x0BC)); // 0270D0E79D00 0xBC NEGA                        ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.AlphaBias                                 = GetInt32(new IntPtr(p + 0x0C0)); // 0270D0E79D20 0xC0 AlphaBias                   ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.CullMode                                  = GetInt32(new IntPtr(p + 0x0C4)); // 0270D0E79D40 0xC4 CullMode                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.Irogae                                    = GetInt32(new IntPtr(p + 0x0C8)); // 0270D0E79D60 0xC8 Irogae                      ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.GradeTex                                  = GetInt32(new IntPtr(p + 0x0CC)); // 0270D0E79D80 0xCC GradeTex                    ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.LastScreen                                = GetInt32(new IntPtr(p + 0x0D0)); // 0270D0E79DA0 0xD0 LastScreen                  ( 0001865F50A0 ModelPrimitiveType int int int Int32 )
            value.ShadeZOffset                              = GetInt32(new IntPtr(p + 0x0D4)); // 0270D0E79DC0 0xD4 ShadeZOffset                ( 0001865F50A0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
