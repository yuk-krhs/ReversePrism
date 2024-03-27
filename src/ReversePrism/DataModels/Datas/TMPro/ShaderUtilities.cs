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
    // 010 ID_Shininess                             0001865F4040 ModelPrimitiveType int int int Int32
    // 014 ID_UnderlayColor                         0001865F4040 ModelPrimitiveType int int int Int32
    // 018 ID_UnderlayOffsetX                       0001865F4040 ModelPrimitiveType int int int Int32
    // 01C ID_UnderlayOffsetY                       0001865F4040 ModelPrimitiveType int int int Int32
    // 020 ID_UnderlayDilate                        0001865F4040 ModelPrimitiveType int int int Int32
    // 024 ID_UnderlaySoftness                      0001865F4040 ModelPrimitiveType int int int Int32
    // 028 ID_UnderlayOffset                        0001865F4040 ModelPrimitiveType int int int Int32
    // 02C ID_UnderlayIsoPerimeter                  0001865F4040 ModelPrimitiveType int int int Int32
    // 030 ID_WeightNormal                          0001865F4040 ModelPrimitiveType int int int Int32
    // 034 ID_WeightBold                            0001865F4040 ModelPrimitiveType int int int Int32
    // 038 ID_OutlineTex                            0001865F4040 ModelPrimitiveType int int int Int32
    // 03C ID_OutlineWidth                          0001865F4040 ModelPrimitiveType int int int Int32
    // 040 ID_OutlineSoftness                       0001865F4040 ModelPrimitiveType int int int Int32
    // 044 ID_OutlineColor                          0001865F4040 ModelPrimitiveType int int int Int32
    // 048 ID_Outline2Color                         0001865F4040 ModelPrimitiveType int int int Int32
    // 04C ID_Outline2Width                         0001865F4040 ModelPrimitiveType int int int Int32
    // 050 ID_Padding                               0001865F4040 ModelPrimitiveType int int int Int32
    // 054 ID_GradientScale                         0001865F4040 ModelPrimitiveType int int int Int32
    // 058 ID_ScaleX                                0001865F4040 ModelPrimitiveType int int int Int32
    // 05C ID_ScaleY                                0001865F4040 ModelPrimitiveType int int int Int32
    // 060 ID_PerspectiveFilter                     0001865F4040 ModelPrimitiveType int int int Int32
    // 064 ID_Sharpness                             0001865F4040 ModelPrimitiveType int int int Int32
    // 068 ID_TextureWidth                          0001865F4040 ModelPrimitiveType int int int Int32
    // 06C ID_TextureHeight                         0001865F4040 ModelPrimitiveType int int int Int32
    // 070 ID_BevelAmount                           0001865F4040 ModelPrimitiveType int int int Int32
    // 074 ID_GlowColor                             0001865F4040 ModelPrimitiveType int int int Int32
    // 078 ID_GlowOffset                            0001865F4040 ModelPrimitiveType int int int Int32
    // 07C ID_GlowPower                             0001865F4040 ModelPrimitiveType int int int Int32
    // 080 ID_GlowOuter                             0001865F4040 ModelPrimitiveType int int int Int32
    // 084 ID_GlowInner                             0001865F4040 ModelPrimitiveType int int int Int32
    // 088 ID_LightAngle                            0001865F4040 ModelPrimitiveType int int int Int32
    // 08C ID_EnvMap                                0001865F4040 ModelPrimitiveType int int int Int32
    // 090 ID_EnvMatrix                             0001865F4040 ModelPrimitiveType int int int Int32
    // 094 ID_EnvMatrixRotation                     0001865F4040 ModelPrimitiveType int int int Int32
    // 098 ID_MaskCoord                             0001865F4040 ModelPrimitiveType int int int Int32
    // 09C ID_ClipRect                              0001865F4040 ModelPrimitiveType int int int Int32
    // 0A0 ID_MaskSoftnessX                         0001865F4040 ModelPrimitiveType int int int Int32
    // 0A4 ID_MaskSoftnessY                         0001865F4040 ModelPrimitiveType int int int Int32
    // 0A8 ID_VertexOffsetX                         0001865F4040 ModelPrimitiveType int int int Int32
    // 0AC ID_VertexOffsetY                         0001865F4040 ModelPrimitiveType int int int Int32
    // 0B0 ID_UseClipRect                           0001865F4040 ModelPrimitiveType int int int Int32
    // 0B4 ID_StencilID                             0001865F4040 ModelPrimitiveType int int int Int32
    // 0B8 ID_StencilOp                             0001865F4040 ModelPrimitiveType int int int Int32
    // 0BC ID_StencilComp                           0001865F4040 ModelPrimitiveType int int int Int32
    // 0C0 ID_StencilReadMask                       0001865F4040 ModelPrimitiveType int int int Int32
    // 0C4 ID_StencilWriteMask                      0001865F4040 ModelPrimitiveType int int int Int32
    // 0C8 ID_ShaderFlags                           0001865F4040 ModelPrimitiveType int int int Int32
    // 0CC ID_ScaleRatio_A                          0001865F4040 ModelPrimitiveType int int int Int32
    // 0D0 ID_ScaleRatio_B                          0001865F4040 ModelPrimitiveType int int int Int32
    // 0D4 ID_ScaleRatio_C                          0001865F4040 ModelPrimitiveType int int int Int32
    // 0D8 Keyword_Bevel                            000186672D00 ModelPrimitiveType string string string String
    // 0E0 Keyword_Glow                             000186672D00 ModelPrimitiveType string string string String
    // 0E8 Keyword_Underlay                         000186672D00 ModelPrimitiveType string string string String
    // 0F0 Keyword_Ratios                           000186672D00 ModelPrimitiveType string string string String
    // 0F8 Keyword_MASK_SOFT                        000186672D00 ModelPrimitiveType string string string String
    // 100 Keyword_MASK_HARD                        000186672D00 ModelPrimitiveType string string string String
    // 108 Keyword_MASK_TEX                         000186672D00 ModelPrimitiveType string string string String
    // 110 Keyword_Outline                          000186672D00 ModelPrimitiveType string string string String
    // 118 ShaderTag_ZTestMode                      000186672D00 ModelPrimitiveType string string string String
    // 120 ShaderTag_CullMode                       000186672D00 ModelPrimitiveType string string string String
    // 128 M_clamp                                  000186666300 ModelPrimitiveType float float float Single
    // 12C IsInitialized                            000186596380 ModelPrimitiveType bool bool bool Bool
    // 130 K_ShaderRef_MobileSDF                    00018674CE60 ModelClassType Shader Shader Shader Pointer
    // 138 K_ShaderRef_MobileBitmap                 00018674CE60 ModelClassType Shader Shader Shader Pointer
    public partial class ShaderUtilities
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
            var value   = new ShaderUtilities();

            value.ID_Shininess                              = GetInt32(new IntPtr(p + 0x010)); // 027003A10778 0x10 ID_Shininess                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayColor                          = GetInt32(new IntPtr(p + 0x014)); // 027003A10798 0x14 ID_UnderlayColor            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayOffsetX                        = GetInt32(new IntPtr(p + 0x018)); // 027003A107B8 0x18 ID_UnderlayOffsetX          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayOffsetY                        = GetInt32(new IntPtr(p + 0x01C)); // 027003A107D8 0x1C ID_UnderlayOffsetY          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayDilate                         = GetInt32(new IntPtr(p + 0x020)); // 027003A107F8 0x20 ID_UnderlayDilate           ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlaySoftness                       = GetInt32(new IntPtr(p + 0x024)); // 027003A10818 0x24 ID_UnderlaySoftness         ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayOffset                         = GetInt32(new IntPtr(p + 0x028)); // 027003A10838 0x28 ID_UnderlayOffset           ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UnderlayIsoPerimeter                   = GetInt32(new IntPtr(p + 0x02C)); // 027003A10858 0x2C ID_UnderlayIsoPerimeter     ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_WeightNormal                           = GetInt32(new IntPtr(p + 0x030)); // 027003A10878 0x30 ID_WeightNormal             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_WeightBold                             = GetInt32(new IntPtr(p + 0x034)); // 027003A10898 0x34 ID_WeightBold               ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_OutlineTex                             = GetInt32(new IntPtr(p + 0x038)); // 027003A108B8 0x38 ID_OutlineTex               ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_OutlineWidth                           = GetInt32(new IntPtr(p + 0x03C)); // 027003A108D8 0x3C ID_OutlineWidth             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_OutlineSoftness                        = GetInt32(new IntPtr(p + 0x040)); // 027003A108F8 0x40 ID_OutlineSoftness          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_OutlineColor                           = GetInt32(new IntPtr(p + 0x044)); // 027003A10918 0x44 ID_OutlineColor             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_Outline2Color                          = GetInt32(new IntPtr(p + 0x048)); // 027003A10938 0x48 ID_Outline2Color            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_Outline2Width                          = GetInt32(new IntPtr(p + 0x04C)); // 027003A10958 0x4C ID_Outline2Width            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_Padding                                = GetInt32(new IntPtr(p + 0x050)); // 027003A10978 0x50 ID_Padding                  ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_GradientScale                          = GetInt32(new IntPtr(p + 0x054)); // 027003A10998 0x54 ID_GradientScale            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ScaleX                                 = GetInt32(new IntPtr(p + 0x058)); // 027003A109B8 0x58 ID_ScaleX                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ScaleY                                 = GetInt32(new IntPtr(p + 0x05C)); // 027003A109D8 0x5C ID_ScaleY                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_PerspectiveFilter                      = GetInt32(new IntPtr(p + 0x060)); // 027003A109F8 0x60 ID_PerspectiveFilter        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_Sharpness                              = GetInt32(new IntPtr(p + 0x064)); // 027003A10A18 0x64 ID_Sharpness                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_TextureWidth                           = GetInt32(new IntPtr(p + 0x068)); // 027003A10A38 0x68 ID_TextureWidth             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_TextureHeight                          = GetInt32(new IntPtr(p + 0x06C)); // 027003A10A58 0x6C ID_TextureHeight            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_BevelAmount                            = GetInt32(new IntPtr(p + 0x070)); // 027003A10A78 0x70 ID_BevelAmount              ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_GlowColor                              = GetInt32(new IntPtr(p + 0x074)); // 027003A10A98 0x74 ID_GlowColor                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_GlowOffset                             = GetInt32(new IntPtr(p + 0x078)); // 027003A10AB8 0x78 ID_GlowOffset               ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_GlowPower                              = GetInt32(new IntPtr(p + 0x07C)); // 027003A10AD8 0x7C ID_GlowPower                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_GlowOuter                              = GetInt32(new IntPtr(p + 0x080)); // 027003A10AF8 0x80 ID_GlowOuter                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_GlowInner                              = GetInt32(new IntPtr(p + 0x084)); // 027003A10B18 0x84 ID_GlowInner                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_LightAngle                             = GetInt32(new IntPtr(p + 0x088)); // 027003A10B38 0x88 ID_LightAngle               ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_EnvMap                                 = GetInt32(new IntPtr(p + 0x08C)); // 027003A10B58 0x8C ID_EnvMap                   ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_EnvMatrix                              = GetInt32(new IntPtr(p + 0x090)); // 027003A10B78 0x90 ID_EnvMatrix                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_EnvMatrixRotation                      = GetInt32(new IntPtr(p + 0x094)); // 027003A10B98 0x94 ID_EnvMatrixRotation        ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_MaskCoord                              = GetInt32(new IntPtr(p + 0x098)); // 027003A10BB8 0x98 ID_MaskCoord                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ClipRect                               = GetInt32(new IntPtr(p + 0x09C)); // 027003A10BD8 0x9C ID_ClipRect                 ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_MaskSoftnessX                          = GetInt32(new IntPtr(p + 0x0A0)); // 027003A10BF8 0xA0 ID_MaskSoftnessX            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_MaskSoftnessY                          = GetInt32(new IntPtr(p + 0x0A4)); // 027003A10C18 0xA4 ID_MaskSoftnessY            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_VertexOffsetX                          = GetInt32(new IntPtr(p + 0x0A8)); // 027003A10C38 0xA8 ID_VertexOffsetX            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_VertexOffsetY                          = GetInt32(new IntPtr(p + 0x0AC)); // 027003A10C58 0xAC ID_VertexOffsetY            ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_UseClipRect                            = GetInt32(new IntPtr(p + 0x0B0)); // 027003A10C78 0xB0 ID_UseClipRect              ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_StencilID                              = GetInt32(new IntPtr(p + 0x0B4)); // 027003A10C98 0xB4 ID_StencilID                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_StencilOp                              = GetInt32(new IntPtr(p + 0x0B8)); // 027003A10CB8 0xB8 ID_StencilOp                ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_StencilComp                            = GetInt32(new IntPtr(p + 0x0BC)); // 027003A10CD8 0xBC ID_StencilComp              ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_StencilReadMask                        = GetInt32(new IntPtr(p + 0x0C0)); // 027003A10CF8 0xC0 ID_StencilReadMask          ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_StencilWriteMask                       = GetInt32(new IntPtr(p + 0x0C4)); // 027003A10D18 0xC4 ID_StencilWriteMask         ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ShaderFlags                            = GetInt32(new IntPtr(p + 0x0C8)); // 027003A10D38 0xC8 ID_ShaderFlags              ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ScaleRatio_A                           = GetInt32(new IntPtr(p + 0x0CC)); // 027003A10D58 0xCC ID_ScaleRatio_A             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ScaleRatio_B                           = GetInt32(new IntPtr(p + 0x0D0)); // 027003A10D78 0xD0 ID_ScaleRatio_B             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.ID_ScaleRatio_C                           = GetInt32(new IntPtr(p + 0x0D4)); // 027003A10D98 0xD4 ID_ScaleRatio_C             ( 0001865F4040 ModelPrimitiveType int int int Int32 )
            value.Keyword_Bevel                             = GetString(new IntPtr(p + 0x0D8)); // 027003A10DB8 0xD8 Keyword_Bevel               ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_Glow                              = GetString(new IntPtr(p + 0x0E0)); // 027003A10DD8 0xE0 Keyword_Glow                ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_Underlay                          = GetString(new IntPtr(p + 0x0E8)); // 027003A10DF8 0xE8 Keyword_Underlay            ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_Ratios                            = GetString(new IntPtr(p + 0x0F0)); // 027003A10E18 0xF0 Keyword_Ratios              ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_MASK_SOFT                         = GetString(new IntPtr(p + 0x0F8)); // 027003A10E38 0xF8 Keyword_MASK_SOFT           ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_MASK_HARD                         = GetString(new IntPtr(p + 0x100)); // 027003A10E58 0x100 Keyword_MASK_HARD           ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_MASK_TEX                          = GetString(new IntPtr(p + 0x108)); // 027003A10E78 0x108 Keyword_MASK_TEX            ( 000186672D00 ModelPrimitiveType string string string String )
            value.Keyword_Outline                           = GetString(new IntPtr(p + 0x110)); // 027003A10E98 0x110 Keyword_Outline             ( 000186672D00 ModelPrimitiveType string string string String )
            value.ShaderTag_ZTestMode                       = GetString(new IntPtr(p + 0x118)); // 027003A10EB8 0x118 ShaderTag_ZTestMode         ( 000186672D00 ModelPrimitiveType string string string String )
            value.ShaderTag_CullMode                        = GetString(new IntPtr(p + 0x120)); // 027003A10ED8 0x120 ShaderTag_CullMode          ( 000186672D00 ModelPrimitiveType string string string String )
            value.M_clamp                                   = GetSingle(new IntPtr(p + 0x128)); // 027003A10EF8 0x128 M_clamp                     ( 000186666300 ModelPrimitiveType float float float Single )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x12C)); // 027003A10F18 0x12C IsInitialized               ( 000186596380 ModelPrimitiveType bool bool bool Bool )
            value.K_ShaderRef_MobileSDF                     = GetObject<Shader>(new IntPtr(p + 0x130), ReversePrism.DataModels.Shader.FromPointer); // 027003A10F38 0x130 K_ShaderRef_MobileSDF       ( 00018674CE60 ModelClassType Shader Shader Shader Pointer )
            value.K_ShaderRef_MobileBitmap                  = GetObject<Shader>(new IntPtr(p + 0x138), ReversePrism.DataModels.Shader.FromPointer); // 027003A10F58 0x138 K_ShaderRef_MobileBitmap    ( 00018674CE60 ModelClassType Shader Shader Shader Pointer )

            return value;
        }
    }
}
