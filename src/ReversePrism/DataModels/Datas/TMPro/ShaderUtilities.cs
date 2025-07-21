using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ID_MainTex                               int IL2CPP_TYPE_I4
    // 004 ID_FaceTex                               int IL2CPP_TYPE_I4
    // 008 ID_FaceColor                             int IL2CPP_TYPE_I4
    // 00C ID_FaceDilate                            int IL2CPP_TYPE_I4
    // 010 ID_Shininess                             ModelPrimitiveType int int int Int32
    // 014 ID_UnderlayColor                         ModelPrimitiveType int int int Int32
    // 018 ID_UnderlayOffsetX                       ModelPrimitiveType int int int Int32
    // 01C ID_UnderlayOffsetY                       ModelPrimitiveType int int int Int32
    // 020 ID_UnderlayDilate                        ModelPrimitiveType int int int Int32
    // 024 ID_UnderlaySoftness                      ModelPrimitiveType int int int Int32
    // 028 ID_UnderlayOffset                        ModelPrimitiveType int int int Int32
    // 02C ID_UnderlayIsoPerimeter                  ModelPrimitiveType int int int Int32
    // 030 ID_WeightNormal                          ModelPrimitiveType int int int Int32
    // 034 ID_WeightBold                            ModelPrimitiveType int int int Int32
    // 038 ID_OutlineTex                            ModelPrimitiveType int int int Int32
    // 03C ID_OutlineWidth                          ModelPrimitiveType int int int Int32
    // 040 ID_OutlineSoftness                       ModelPrimitiveType int int int Int32
    // 044 ID_OutlineColor                          ModelPrimitiveType int int int Int32
    // 048 ID_Outline2Color                         ModelPrimitiveType int int int Int32
    // 04C ID_Outline2Width                         ModelPrimitiveType int int int Int32
    // 050 ID_Padding                               ModelPrimitiveType int int int Int32
    // 054 ID_GradientScale                         ModelPrimitiveType int int int Int32
    // 058 ID_ScaleX                                ModelPrimitiveType int int int Int32
    // 05C ID_ScaleY                                ModelPrimitiveType int int int Int32
    // 060 ID_PerspectiveFilter                     ModelPrimitiveType int int int Int32
    // 064 ID_Sharpness                             ModelPrimitiveType int int int Int32
    // 068 ID_TextureWidth                          ModelPrimitiveType int int int Int32
    // 06C ID_TextureHeight                         ModelPrimitiveType int int int Int32
    // 070 ID_BevelAmount                           ModelPrimitiveType int int int Int32
    // 074 ID_GlowColor                             ModelPrimitiveType int int int Int32
    // 078 ID_GlowOffset                            ModelPrimitiveType int int int Int32
    // 07C ID_GlowPower                             ModelPrimitiveType int int int Int32
    // 080 ID_GlowOuter                             ModelPrimitiveType int int int Int32
    // 084 ID_GlowInner                             ModelPrimitiveType int int int Int32
    // 088 ID_LightAngle                            ModelPrimitiveType int int int Int32
    // 08C ID_EnvMap                                ModelPrimitiveType int int int Int32
    // 090 ID_EnvMatrix                             ModelPrimitiveType int int int Int32
    // 094 ID_EnvMatrixRotation                     ModelPrimitiveType int int int Int32
    // 098 ID_MaskCoord                             ModelPrimitiveType int int int Int32
    // 09C ID_ClipRect                              ModelPrimitiveType int int int Int32
    // 0A0 ID_MaskSoftnessX                         ModelPrimitiveType int int int Int32
    // 0A4 ID_MaskSoftnessY                         ModelPrimitiveType int int int Int32
    // 0A8 ID_VertexOffsetX                         ModelPrimitiveType int int int Int32
    // 0AC ID_VertexOffsetY                         ModelPrimitiveType int int int Int32
    // 0B0 ID_UseClipRect                           ModelPrimitiveType int int int Int32
    // 0B4 ID_StencilID                             ModelPrimitiveType int int int Int32
    // 0B8 ID_StencilOp                             ModelPrimitiveType int int int Int32
    // 0BC ID_StencilComp                           ModelPrimitiveType int int int Int32
    // 0C0 ID_StencilReadMask                       ModelPrimitiveType int int int Int32
    // 0C4 ID_StencilWriteMask                      ModelPrimitiveType int int int Int32
    // 0C8 ID_ShaderFlags                           ModelPrimitiveType int int int Int32
    // 0CC ID_ScaleRatio_A                          ModelPrimitiveType int int int Int32
    // 0D0 ID_ScaleRatio_B                          ModelPrimitiveType int int int Int32
    // 0D4 ID_ScaleRatio_C                          ModelPrimitiveType int int int Int32
    // 0D8 Keyword_Bevel                            ModelPrimitiveType string string string String
    // 0E0 Keyword_Glow                             ModelPrimitiveType string string string String
    // 0E8 Keyword_Underlay                         ModelPrimitiveType string string string String
    // 0F0 Keyword_Ratios                           ModelPrimitiveType string string string String
    // 0F8 Keyword_MASK_SOFT                        ModelPrimitiveType string string string String
    // 100 Keyword_MASK_HARD                        ModelPrimitiveType string string string String
    // 108 Keyword_MASK_TEX                         ModelPrimitiveType string string string String
    // 110 Keyword_Outline                          ModelPrimitiveType string string string String
    // 118 ShaderTag_ZTestMode                      ModelPrimitiveType string string string String
    // 120 ShaderTag_CullMode                       ModelPrimitiveType string string string String
    // 128 M_clamp                                  ModelPrimitiveType float float float Single
    // 12C IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 130 K_ShaderRef_MobileSDF                    ModelClassType Shader Shader Shader Pointer
    // 138 K_ShaderRef_MobileBitmap                 ModelClassType Shader Shader Shader Pointer
    public partial class ShaderUtilities : DataModel
    {
        public int                                      ID_Shininess                            { get; set; }
        public int                                      ID_UnderlayColor                        { get; set; }
        public int                                      ID_UnderlayOffsetX                      { get; set; }
        public int                                      ID_UnderlayOffsetY                      { get; set; }
        public int                                      ID_UnderlayDilate                       { get; set; }
        public int                                      ID_UnderlaySoftness                     { get; set; }
        public int                                      ID_UnderlayOffset                       { get; set; }
        public int                                      ID_UnderlayIsoPerimeter                 { get; set; }
        public int                                      ID_WeightNormal                         { get; set; }
        public int                                      ID_WeightBold                           { get; set; }
        public int                                      ID_OutlineTex                           { get; set; }
        public int                                      ID_OutlineWidth                         { get; set; }
        public int                                      ID_OutlineSoftness                      { get; set; }
        public int                                      ID_OutlineColor                         { get; set; }
        public int                                      ID_Outline2Color                        { get; set; }
        public int                                      ID_Outline2Width                        { get; set; }
        public int                                      ID_Padding                              { get; set; }
        public int                                      ID_GradientScale                        { get; set; }
        public int                                      ID_ScaleX                               { get; set; }
        public int                                      ID_ScaleY                               { get; set; }
        public int                                      ID_PerspectiveFilter                    { get; set; }
        public int                                      ID_Sharpness                            { get; set; }
        public int                                      ID_TextureWidth                         { get; set; }
        public int                                      ID_TextureHeight                        { get; set; }
        public int                                      ID_BevelAmount                          { get; set; }
        public int                                      ID_GlowColor                            { get; set; }
        public int                                      ID_GlowOffset                           { get; set; }
        public int                                      ID_GlowPower                            { get; set; }
        public int                                      ID_GlowOuter                            { get; set; }
        public int                                      ID_GlowInner                            { get; set; }
        public int                                      ID_LightAngle                           { get; set; }
        public int                                      ID_EnvMap                               { get; set; }
        public int                                      ID_EnvMatrix                            { get; set; }
        public int                                      ID_EnvMatrixRotation                    { get; set; }
        public int                                      ID_MaskCoord                            { get; set; }
        public int                                      ID_ClipRect                             { get; set; }
        public int                                      ID_MaskSoftnessX                        { get; set; }
        public int                                      ID_MaskSoftnessY                        { get; set; }
        public int                                      ID_VertexOffsetX                        { get; set; }
        public int                                      ID_VertexOffsetY                        { get; set; }
        public int                                      ID_UseClipRect                          { get; set; }
        public int                                      ID_StencilID                            { get; set; }
        public int                                      ID_StencilOp                            { get; set; }
        public int                                      ID_StencilComp                          { get; set; }
        public int                                      ID_StencilReadMask                      { get; set; }
        public int                                      ID_StencilWriteMask                     { get; set; }
        public int                                      ID_ShaderFlags                          { get; set; }
        public int                                      ID_ScaleRatio_A                         { get; set; }
        public int                                      ID_ScaleRatio_B                         { get; set; }
        public int                                      ID_ScaleRatio_C                         { get; set; }
        public string                                   Keyword_Bevel                           { get; set; }
        public string                                   Keyword_Glow                            { get; set; }
        public string                                   Keyword_Underlay                        { get; set; }
        public string                                   Keyword_Ratios                          { get; set; }
        public string                                   Keyword_MASK_SOFT                       { get; set; }
        public string                                   Keyword_MASK_HARD                       { get; set; }
        public string                                   Keyword_MASK_TEX                        { get; set; }
        public string                                   Keyword_Outline                         { get; set; }
        public string                                   ShaderTag_ZTestMode                     { get; set; }
        public string                                   ShaderTag_CullMode                      { get; set; }
        public float                                    M_clamp                                 { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public Shader?                                  K_ShaderRef_MobileSDF                   { get; set; }
        public Shader?                                  K_ShaderRef_MobileBitmap                { get; set; }

        public static ShaderUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderUtilities() { Pointer= p0 };

            value.ID_Shininess                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 ID_Shininess                ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayColor                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 ID_UnderlayColor            ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayOffsetX                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 ID_UnderlayOffsetX          ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayOffsetY                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ID_UnderlayOffsetY          ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayDilate                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 ID_UnderlayDilate           ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlaySoftness                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 ID_UnderlaySoftness         ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayOffset                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 ID_UnderlayOffset           ( ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayIsoPerimeter                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C ID_UnderlayIsoPerimeter     ( ModelPrimitiveType int int int Int32 )
            value.ID_WeightNormal                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 ID_WeightNormal             ( ModelPrimitiveType int int int Int32 )
            value.ID_WeightBold                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 ID_WeightBold               ( ModelPrimitiveType int int int Int32 )
            value.ID_OutlineTex                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 ID_OutlineTex               ( ModelPrimitiveType int int int Int32 )
            value.ID_OutlineWidth                           = GetInt32(new IntPtr(p + 0x03C)); // 0x3C ID_OutlineWidth             ( ModelPrimitiveType int int int Int32 )
            value.ID_OutlineSoftness                        = GetInt32(new IntPtr(p + 0x040)); // 0x40 ID_OutlineSoftness          ( ModelPrimitiveType int int int Int32 )
            value.ID_OutlineColor                           = GetInt32(new IntPtr(p + 0x044)); // 0x44 ID_OutlineColor             ( ModelPrimitiveType int int int Int32 )
            value.ID_Outline2Color                          = GetInt32(new IntPtr(p + 0x048)); // 0x48 ID_Outline2Color            ( ModelPrimitiveType int int int Int32 )
            value.ID_Outline2Width                          = GetInt32(new IntPtr(p + 0x04C)); // 0x4C ID_Outline2Width            ( ModelPrimitiveType int int int Int32 )
            value.ID_Padding                                = GetInt32(new IntPtr(p + 0x050)); // 0x50 ID_Padding                  ( ModelPrimitiveType int int int Int32 )
            value.ID_GradientScale                          = GetInt32(new IntPtr(p + 0x054)); // 0x54 ID_GradientScale            ( ModelPrimitiveType int int int Int32 )
            value.ID_ScaleX                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 ID_ScaleX                   ( ModelPrimitiveType int int int Int32 )
            value.ID_ScaleY                                 = GetInt32(new IntPtr(p + 0x05C)); // 0x5C ID_ScaleY                   ( ModelPrimitiveType int int int Int32 )
            value.ID_PerspectiveFilter                      = GetInt32(new IntPtr(p + 0x060)); // 0x60 ID_PerspectiveFilter        ( ModelPrimitiveType int int int Int32 )
            value.ID_Sharpness                              = GetInt32(new IntPtr(p + 0x064)); // 0x64 ID_Sharpness                ( ModelPrimitiveType int int int Int32 )
            value.ID_TextureWidth                           = GetInt32(new IntPtr(p + 0x068)); // 0x68 ID_TextureWidth             ( ModelPrimitiveType int int int Int32 )
            value.ID_TextureHeight                          = GetInt32(new IntPtr(p + 0x06C)); // 0x6C ID_TextureHeight            ( ModelPrimitiveType int int int Int32 )
            value.ID_BevelAmount                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 ID_BevelAmount              ( ModelPrimitiveType int int int Int32 )
            value.ID_GlowColor                              = GetInt32(new IntPtr(p + 0x074)); // 0x74 ID_GlowColor                ( ModelPrimitiveType int int int Int32 )
            value.ID_GlowOffset                             = GetInt32(new IntPtr(p + 0x078)); // 0x78 ID_GlowOffset               ( ModelPrimitiveType int int int Int32 )
            value.ID_GlowPower                              = GetInt32(new IntPtr(p + 0x07C)); // 0x7C ID_GlowPower                ( ModelPrimitiveType int int int Int32 )
            value.ID_GlowOuter                              = GetInt32(new IntPtr(p + 0x080)); // 0x80 ID_GlowOuter                ( ModelPrimitiveType int int int Int32 )
            value.ID_GlowInner                              = GetInt32(new IntPtr(p + 0x084)); // 0x84 ID_GlowInner                ( ModelPrimitiveType int int int Int32 )
            value.ID_LightAngle                             = GetInt32(new IntPtr(p + 0x088)); // 0x88 ID_LightAngle               ( ModelPrimitiveType int int int Int32 )
            value.ID_EnvMap                                 = GetInt32(new IntPtr(p + 0x08C)); // 0x8C ID_EnvMap                   ( ModelPrimitiveType int int int Int32 )
            value.ID_EnvMatrix                              = GetInt32(new IntPtr(p + 0x090)); // 0x90 ID_EnvMatrix                ( ModelPrimitiveType int int int Int32 )
            value.ID_EnvMatrixRotation                      = GetInt32(new IntPtr(p + 0x094)); // 0x94 ID_EnvMatrixRotation        ( ModelPrimitiveType int int int Int32 )
            value.ID_MaskCoord                              = GetInt32(new IntPtr(p + 0x098)); // 0x98 ID_MaskCoord                ( ModelPrimitiveType int int int Int32 )
            value.ID_ClipRect                               = GetInt32(new IntPtr(p + 0x09C)); // 0x9C ID_ClipRect                 ( ModelPrimitiveType int int int Int32 )
            value.ID_MaskSoftnessX                          = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ID_MaskSoftnessX            ( ModelPrimitiveType int int int Int32 )
            value.ID_MaskSoftnessY                          = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 ID_MaskSoftnessY            ( ModelPrimitiveType int int int Int32 )
            value.ID_VertexOffsetX                          = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 ID_VertexOffsetX            ( ModelPrimitiveType int int int Int32 )
            value.ID_VertexOffsetY                          = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC ID_VertexOffsetY            ( ModelPrimitiveType int int int Int32 )
            value.ID_UseClipRect                            = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ID_UseClipRect              ( ModelPrimitiveType int int int Int32 )
            value.ID_StencilID                              = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 ID_StencilID                ( ModelPrimitiveType int int int Int32 )
            value.ID_StencilOp                              = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 ID_StencilOp                ( ModelPrimitiveType int int int Int32 )
            value.ID_StencilComp                            = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC ID_StencilComp              ( ModelPrimitiveType int int int Int32 )
            value.ID_StencilReadMask                        = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 ID_StencilReadMask          ( ModelPrimitiveType int int int Int32 )
            value.ID_StencilWriteMask                       = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 ID_StencilWriteMask         ( ModelPrimitiveType int int int Int32 )
            value.ID_ShaderFlags                            = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 ID_ShaderFlags              ( ModelPrimitiveType int int int Int32 )
            value.ID_ScaleRatio_A                           = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC ID_ScaleRatio_A             ( ModelPrimitiveType int int int Int32 )
            value.ID_ScaleRatio_B                           = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 ID_ScaleRatio_B             ( ModelPrimitiveType int int int Int32 )
            value.ID_ScaleRatio_C                           = GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 ID_ScaleRatio_C             ( ModelPrimitiveType int int int Int32 )
            value.Keyword_Bevel                             = GetString(new IntPtr(p + 0x0D8)); // 0xD8 Keyword_Bevel               ( ModelPrimitiveType string string string String )
            value.Keyword_Glow                              = GetString(new IntPtr(p + 0x0E0)); // 0xE0 Keyword_Glow                ( ModelPrimitiveType string string string String )
            value.Keyword_Underlay                          = GetString(new IntPtr(p + 0x0E8)); // 0xE8 Keyword_Underlay            ( ModelPrimitiveType string string string String )
            value.Keyword_Ratios                            = GetString(new IntPtr(p + 0x0F0)); // 0xF0 Keyword_Ratios              ( ModelPrimitiveType string string string String )
            value.Keyword_MASK_SOFT                         = GetString(new IntPtr(p + 0x0F8)); // 0xF8 Keyword_MASK_SOFT           ( ModelPrimitiveType string string string String )
            value.Keyword_MASK_HARD                         = GetString(new IntPtr(p + 0x100)); // 0x100 Keyword_MASK_HARD           ( ModelPrimitiveType string string string String )
            value.Keyword_MASK_TEX                          = GetString(new IntPtr(p + 0x108)); // 0x108 Keyword_MASK_TEX            ( ModelPrimitiveType string string string String )
            value.Keyword_Outline                           = GetString(new IntPtr(p + 0x110)); // 0x110 Keyword_Outline             ( ModelPrimitiveType string string string String )
            value.ShaderTag_ZTestMode                       = GetString(new IntPtr(p + 0x118)); // 0x118 ShaderTag_ZTestMode         ( ModelPrimitiveType string string string String )
            value.ShaderTag_CullMode                        = GetString(new IntPtr(p + 0x120)); // 0x120 ShaderTag_CullMode          ( ModelPrimitiveType string string string String )
            value.M_clamp                                   = GetSingle(new IntPtr(p + 0x128)); // 0x128 M_clamp                     ( ModelPrimitiveType float float float Single )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x12C)); // 0x12C IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.K_ShaderRef_MobileSDF                     = GetObject<Shader>(new IntPtr(p + 0x130), ReversePrism.DataModels.Shader.FromPointer); // 0x130 K_ShaderRef_MobileSDF       ( ModelClassType Shader Shader Shader Pointer )
            value.K_ShaderRef_MobileBitmap                  = GetObject<Shader>(new IntPtr(p + 0x138), ReversePrism.DataModels.Shader.FromPointer); // 0x138 K_ShaderRef_MobileBitmap    ( ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
