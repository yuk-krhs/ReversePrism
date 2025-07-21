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
    // 010 AngelRingColor                           ModelPrimitiveType int int int Int32
    // 014 OutlineAdjust                            ModelPrimitiveType int int int Int32
    // 018 OutlineInclusive                         ModelPrimitiveType int int int Int32
    // 01C OutlineColorAdd                          ModelPrimitiveType int int int Int32
    // 020 ReferencePoint                           ModelPrimitiveType int int int Int32
    // 024 PlanePoint                               ModelPrimitiveType int int int Int32
    // 028 PlaneNormal                              ModelPrimitiveType int int int Int32
    // 02C CameraDir                                ModelPrimitiveType int int int Int32
    // 030 PersonalLight                            ModelPrimitiveType int int int Int32
    // 034 ScaleZ                                   ModelPrimitiveType int int int Int32
    // 038 CenterPos                                ModelPrimitiveType int int int Int32
    // 03C Radius                                   ModelPrimitiveType int int int Int32
    // 040 RingRotation                             ModelPrimitiveType int int int Int32
    // 044 RimPower                                 ModelPrimitiveType int int int Int32
    // 048 RimIntensity                             ModelPrimitiveType int int int Int32
    // 04C RimWidth                                 ModelPrimitiveType int int int Int32
    // 050 RimSpread                                ModelPrimitiveType int int int Int32
    // 054 RimColor                                 ModelPrimitiveType int int int Int32
    // 058 RimLightDirection                        ModelPrimitiveType int int int Int32
    // 05C RimFeather                               ModelPrimitiveType int int int Int32
    // 060 RimDiffuseRate                           ModelPrimitiveType int int int Int32
    // 064 GlobalCubeMap                            ModelPrimitiveType int int int Int32
    // 068 RimBorder                                ModelPrimitiveType int int int Int32
    // 06C RimBlur                                  ModelPrimitiveType int int int Int32
    // 070 RimAntiAlias                             ModelPrimitiveType int int int Int32
    // 074 SSSColor                                 ModelPrimitiveType int int int Int32
    // 078 ShadowDir                                ModelPrimitiveType int int int Int32
    // 07C ShadowPoint                              ModelPrimitiveType int int int Int32
    // 080 LightDir                                 ModelPrimitiveType int int int Int32
    // 084 FaceRadius                               ModelPrimitiveType int int int Int32
    // 088 ZBias                                    ModelPrimitiveType int int int Int32
    // 08C ReflectionTex                            ModelPrimitiveType int int int Int32
    // 090 IrisUV                                   ModelPrimitiveType int int int Int32
    // 094 Flip                                     ModelPrimitiveType int int int Int32
    // 098 HighlightShaking                         ModelPrimitiveType int int int Int32
    // 09C StencilRef                               ModelPrimitiveType int int int Int32
    // 0A0 SrcBlend                                 ModelPrimitiveType int int int Int32
    // 0A4 DstBlend                                 ModelPrimitiveType int int int Int32
    // 0A8 Cull                                     ModelPrimitiveType int int int Int32
    // 0AC ZWrite                                   ModelPrimitiveType int int int Int32
    // 0B0 Ratio                                    ModelPrimitiveType int int int Int32
    // 0B4 Aspect                                   ModelPrimitiveType int int int Int32
    // 0B8 UvParam                                  ModelPrimitiveType int int int Int32
    // 0BC BlurRatio                                ModelPrimitiveType int int int Int32
    // 0C0 LightTex_ST                              ModelPrimitiveType int int int Int32
    // 0C4 TimeRatio                                ModelPrimitiveType int int int Int32
    // 0C8 AlphaBias                                ModelPrimitiveType int int int Int32
    // 0CC CullMode                                 ModelPrimitiveType int int int Int32
    // 0D0 Irogae                                   ModelPrimitiveType int int int Int32
    // 0D4 GradeTex                                 ModelPrimitiveType int int int Int32
    // 0D8 LastScreen                               ModelPrimitiveType int int int Int32
    // 0DC ShadeZOffset                             ModelPrimitiveType int int int Int32
    public partial class ShaderPropertyIDs : DataModel
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
        public int                                      RimWidth                                { get; set; }
        public int                                      RimSpread                               { get; set; }
        public int                                      RimColor                                { get; set; }
        public int                                      RimLightDirection                       { get; set; }
        public int                                      RimFeather                              { get; set; }
        public int                                      RimDiffuseRate                          { get; set; }
        public int                                      GlobalCubeMap                           { get; set; }
        public int                                      RimBorder                               { get; set; }
        public int                                      RimBlur                                 { get; set; }
        public int                                      RimAntiAlias                            { get; set; }
        public int                                      SSSColor                                { get; set; }
        public int                                      ShadowDir                               { get; set; }
        public int                                      ShadowPoint                             { get; set; }
        public int                                      LightDir                                { get; set; }
        public int                                      FaceRadius                              { get; set; }
        public int                                      ZBias                                   { get; set; }
        public int                                      ReflectionTex                           { get; set; }
        public int                                      IrisUV                                  { get; set; }
        public int                                      Flip                                    { get; set; }
        public int                                      HighlightShaking                        { get; set; }
        public int                                      StencilRef                              { get; set; }
        public int                                      SrcBlend                                { get; set; }
        public int                                      DstBlend                                { get; set; }
        public int                                      Cull                                    { get; set; }
        public int                                      ZWrite                                  { get; set; }
        public int                                      Ratio                                   { get; set; }
        public int                                      Aspect                                  { get; set; }
        public int                                      UvParam                                 { get; set; }
        public int                                      BlurRatio                               { get; set; }
        public int                                      LightTex_ST                             { get; set; }
        public int                                      TimeRatio                               { get; set; }
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
            var value   = new ShaderPropertyIDs() { Pointer= p0 };

            value.AngelRingColor                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 AngelRingColor              ( ModelPrimitiveType int int int Int32 )
            value.OutlineAdjust                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 OutlineAdjust               ( ModelPrimitiveType int int int Int32 )
            value.OutlineInclusive                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 OutlineInclusive            ( ModelPrimitiveType int int int Int32 )
            value.OutlineColorAdd                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C OutlineColorAdd             ( ModelPrimitiveType int int int Int32 )
            value.ReferencePoint                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 ReferencePoint              ( ModelPrimitiveType int int int Int32 )
            value.PlanePoint                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 PlanePoint                  ( ModelPrimitiveType int int int Int32 )
            value.PlaneNormal                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 PlaneNormal                 ( ModelPrimitiveType int int int Int32 )
            value.CameraDir                                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C CameraDir                   ( ModelPrimitiveType int int int Int32 )
            value.PersonalLight                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 PersonalLight               ( ModelPrimitiveType int int int Int32 )
            value.ScaleZ                                    = GetInt32(new IntPtr(p + 0x034)); // 0x34 ScaleZ                      ( ModelPrimitiveType int int int Int32 )
            value.CenterPos                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 CenterPos                   ( ModelPrimitiveType int int int Int32 )
            value.Radius                                    = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Radius                      ( ModelPrimitiveType int int int Int32 )
            value.RingRotation                              = GetInt32(new IntPtr(p + 0x040)); // 0x40 RingRotation                ( ModelPrimitiveType int int int Int32 )
            value.RimPower                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 RimPower                    ( ModelPrimitiveType int int int Int32 )
            value.RimIntensity                              = GetInt32(new IntPtr(p + 0x048)); // 0x48 RimIntensity                ( ModelPrimitiveType int int int Int32 )
            value.RimWidth                                  = GetInt32(new IntPtr(p + 0x04C)); // 0x4C RimWidth                    ( ModelPrimitiveType int int int Int32 )
            value.RimSpread                                 = GetInt32(new IntPtr(p + 0x050)); // 0x50 RimSpread                   ( ModelPrimitiveType int int int Int32 )
            value.RimColor                                  = GetInt32(new IntPtr(p + 0x054)); // 0x54 RimColor                    ( ModelPrimitiveType int int int Int32 )
            value.RimLightDirection                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 RimLightDirection           ( ModelPrimitiveType int int int Int32 )
            value.RimFeather                                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C RimFeather                  ( ModelPrimitiveType int int int Int32 )
            value.RimDiffuseRate                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 RimDiffuseRate              ( ModelPrimitiveType int int int Int32 )
            value.GlobalCubeMap                             = GetInt32(new IntPtr(p + 0x064)); // 0x64 GlobalCubeMap               ( ModelPrimitiveType int int int Int32 )
            value.RimBorder                                 = GetInt32(new IntPtr(p + 0x068)); // 0x68 RimBorder                   ( ModelPrimitiveType int int int Int32 )
            value.RimBlur                                   = GetInt32(new IntPtr(p + 0x06C)); // 0x6C RimBlur                     ( ModelPrimitiveType int int int Int32 )
            value.RimAntiAlias                              = GetInt32(new IntPtr(p + 0x070)); // 0x70 RimAntiAlias                ( ModelPrimitiveType int int int Int32 )
            value.SSSColor                                  = GetInt32(new IntPtr(p + 0x074)); // 0x74 SSSColor                    ( ModelPrimitiveType int int int Int32 )
            value.ShadowDir                                 = GetInt32(new IntPtr(p + 0x078)); // 0x78 ShadowDir                   ( ModelPrimitiveType int int int Int32 )
            value.ShadowPoint                               = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ShadowPoint                 ( ModelPrimitiveType int int int Int32 )
            value.LightDir                                  = GetInt32(new IntPtr(p + 0x080)); // 0x80 LightDir                    ( ModelPrimitiveType int int int Int32 )
            value.FaceRadius                                = GetInt32(new IntPtr(p + 0x084)); // 0x84 FaceRadius                  ( ModelPrimitiveType int int int Int32 )
            value.ZBias                                     = GetInt32(new IntPtr(p + 0x088)); // 0x88 ZBias                       ( ModelPrimitiveType int int int Int32 )
            value.ReflectionTex                             = GetInt32(new IntPtr(p + 0x08C)); // 0x8C ReflectionTex               ( ModelPrimitiveType int int int Int32 )
            value.IrisUV                                    = GetInt32(new IntPtr(p + 0x090)); // 0x90 IrisUV                      ( ModelPrimitiveType int int int Int32 )
            value.Flip                                      = GetInt32(new IntPtr(p + 0x094)); // 0x94 Flip                        ( ModelPrimitiveType int int int Int32 )
            value.HighlightShaking                          = GetInt32(new IntPtr(p + 0x098)); // 0x98 HighlightShaking            ( ModelPrimitiveType int int int Int32 )
            value.StencilRef                                = GetInt32(new IntPtr(p + 0x09C)); // 0x9C StencilRef                  ( ModelPrimitiveType int int int Int32 )
            value.SrcBlend                                  = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 SrcBlend                    ( ModelPrimitiveType int int int Int32 )
            value.DstBlend                                  = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 DstBlend                    ( ModelPrimitiveType int int int Int32 )
            value.Cull                                      = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Cull                        ( ModelPrimitiveType int int int Int32 )
            value.ZWrite                                    = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC ZWrite                      ( ModelPrimitiveType int int int Int32 )
            value.Ratio                                     = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Ratio                       ( ModelPrimitiveType int int int Int32 )
            value.Aspect                                    = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 Aspect                      ( ModelPrimitiveType int int int Int32 )
            value.UvParam                                   = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 UvParam                     ( ModelPrimitiveType int int int Int32 )
            value.BlurRatio                                 = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC BlurRatio                   ( ModelPrimitiveType int int int Int32 )
            value.LightTex_ST                               = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 LightTex_ST                 ( ModelPrimitiveType int int int Int32 )
            value.TimeRatio                                 = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 TimeRatio                   ( ModelPrimitiveType int int int Int32 )
            value.AlphaBias                                 = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 AlphaBias                   ( ModelPrimitiveType int int int Int32 )
            value.CullMode                                  = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC CullMode                    ( ModelPrimitiveType int int int Int32 )
            value.Irogae                                    = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Irogae                      ( ModelPrimitiveType int int int Int32 )
            value.GradeTex                                  = GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 GradeTex                    ( ModelPrimitiveType int int int Int32 )
            value.LastScreen                                = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 LastScreen                  ( ModelPrimitiveType int int int Int32 )
            value.ShadeZOffset                              = GetInt32(new IntPtr(p + 0x0DC)); // 0xDC ShadeZOffset                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
