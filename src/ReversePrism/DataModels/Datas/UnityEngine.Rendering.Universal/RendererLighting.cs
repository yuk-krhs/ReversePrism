using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 k_NormalsRenderingPassName               ShaderTagId IL2CPP_TYPE_VALUETYPE
    // 00C k_NormalClearColor                       Color IL2CPP_TYPE_VALUETYPE
    // 020 K_SpriteLightKeyword                     ModelPrimitiveType string string string String
    // 028 K_UsePointLightCookiesKeyword            ModelPrimitiveType string string string String
    // 030 K_LightQualityFastKeyword                ModelPrimitiveType string string string String
    // 038 K_UseNormalMap                           ModelPrimitiveType string string string String
    // 040 K_UseAdditiveBlendingKeyword             ModelPrimitiveType string string string String
    // 048 K_UseBlendStyleKeywords                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 050 K_BlendFactorsPropIDs                    ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 K_MaskFilterPropIDs                      ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 K_InvertedFilterPropIDs                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 S_RenderTextureFormatToUse               ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 06C S_HasSetupRenderTextureFormatToUse       ModelPrimitiveType bool bool bool Bool
    // 070 K_SrcBlendID                             ModelPrimitiveType int int int Int32
    // 074 K_DstBlendID                             ModelPrimitiveType int int int Int32
    // 078 K_FalloffIntensityID                     ModelPrimitiveType int int int Int32
    // 07C K_FalloffDistanceID                      ModelPrimitiveType int int int Int32
    // 080 K_LightColorID                           ModelPrimitiveType int int int Int32
    // 084 K_VolumeOpacityID                        ModelPrimitiveType int int int Int32
    // 088 K_CookieTexID                            ModelPrimitiveType int int int Int32
    // 08C K_FalloffLookupID                        ModelPrimitiveType int int int Int32
    // 090 K_LightPositionID                        ModelPrimitiveType int int int Int32
    // 094 K_LightInvMatrixID                       ModelPrimitiveType int int int Int32
    // 098 K_InnerRadiusMultID                      ModelPrimitiveType int int int Int32
    // 09C K_OuterAngleID                           ModelPrimitiveType int int int Int32
    // 0A0 K_InnerAngleMultID                       ModelPrimitiveType int int int Int32
    // 0A4 K_LightLookupID                          ModelPrimitiveType int int int Int32
    // 0A8 K_IsFullSpotlightID                      ModelPrimitiveType int int int Int32
    // 0AC K_LightZDistanceID                       ModelPrimitiveType int int int Int32
    // 0B0 K_PointLightCookieTexID                  ModelPrimitiveType int int int Int32
    public partial class RendererLighting : DataModel
    {
        public string                                   K_SpriteLightKeyword                    { get; set; }
        public string                                   K_UsePointLightCookiesKeyword           { get; set; }
        public string                                   K_LightQualityFastKeyword               { get; set; }
        public string                                   K_UseNormalMap                          { get; set; }
        public string                                   K_UseAdditiveBlendingKeyword            { get; set; }
        public List<string>?                            K_UseBlendStyleKeywords                 { get; set; }
        public List<int>?                               K_BlendFactorsPropIDs                   { get; set; }
        public List<int>?                               K_MaskFilterPropIDs                     { get; set; }
        public List<int>?                               K_InvertedFilterPropIDs                 { get; set; }
        public GraphicsFormat                           S_RenderTextureFormatToUse              { get; set; }
        public bool                                     S_HasSetupRenderTextureFormatToUse      { get; set; }
        public int                                      K_SrcBlendID                            { get; set; }
        public int                                      K_DstBlendID                            { get; set; }
        public int                                      K_FalloffIntensityID                    { get; set; }
        public int                                      K_FalloffDistanceID                     { get; set; }
        public int                                      K_LightColorID                          { get; set; }
        public int                                      K_VolumeOpacityID                       { get; set; }
        public int                                      K_CookieTexID                           { get; set; }
        public int                                      K_FalloffLookupID                       { get; set; }
        public int                                      K_LightPositionID                       { get; set; }
        public int                                      K_LightInvMatrixID                      { get; set; }
        public int                                      K_InnerRadiusMultID                     { get; set; }
        public int                                      K_OuterAngleID                          { get; set; }
        public int                                      K_InnerAngleMultID                      { get; set; }
        public int                                      K_LightLookupID                         { get; set; }
        public int                                      K_IsFullSpotlightID                     { get; set; }
        public int                                      K_LightZDistanceID                      { get; set; }
        public int                                      K_PointLightCookieTexID                 { get; set; }

        public static RendererLighting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererLighting() { Pointer= p0 };

            value.K_SpriteLightKeyword                      = GetString(new IntPtr(p + 0x020)); // 0x20 K_SpriteLightKeyword        ( ModelPrimitiveType string string string String )
            value.K_UsePointLightCookiesKeyword             = GetString(new IntPtr(p + 0x028)); // 0x28 K_UsePointLightCookiesKeyword ( ModelPrimitiveType string string string String )
            value.K_LightQualityFastKeyword                 = GetString(new IntPtr(p + 0x030)); // 0x30 K_LightQualityFastKeyword   ( ModelPrimitiveType string string string String )
            value.K_UseNormalMap                            = GetString(new IntPtr(p + 0x038)); // 0x38 K_UseNormalMap              ( ModelPrimitiveType string string string String )
            value.K_UseAdditiveBlendingKeyword              = GetString(new IntPtr(p + 0x040)); // 0x40 K_UseAdditiveBlendingKeyword ( ModelPrimitiveType string string string String )
            value.K_UseBlendStyleKeywords                   = GetStringList(new IntPtr(p + 0x048)); // 0x48 K_UseBlendStyleKeywords     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.K_BlendFactorsPropIDs                     = GetInt32List(new IntPtr(p + 0x050)); // 0x50 K_BlendFactorsPropIDs       ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.K_MaskFilterPropIDs                       = GetInt32List(new IntPtr(p + 0x058)); // 0x58 K_MaskFilterPropIDs         ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.K_InvertedFilterPropIDs                   = GetInt32List(new IntPtr(p + 0x060)); // 0x60 K_InvertedFilterPropIDs     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_RenderTextureFormatToUse                = (GraphicsFormat)GetInt32(new IntPtr(p + 0x068)); // 0x68 S_RenderTextureFormatToUse  ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.S_HasSetupRenderTextureFormatToUse        = GetBool(new IntPtr(p + 0x06C)); // 0x6C S_HasSetupRenderTextureFormatToUse ( ModelPrimitiveType bool bool bool Bool )
            value.K_SrcBlendID                              = GetInt32(new IntPtr(p + 0x070)); // 0x70 K_SrcBlendID                ( ModelPrimitiveType int int int Int32 )
            value.K_DstBlendID                              = GetInt32(new IntPtr(p + 0x074)); // 0x74 K_DstBlendID                ( ModelPrimitiveType int int int Int32 )
            value.K_FalloffIntensityID                      = GetInt32(new IntPtr(p + 0x078)); // 0x78 K_FalloffIntensityID        ( ModelPrimitiveType int int int Int32 )
            value.K_FalloffDistanceID                       = GetInt32(new IntPtr(p + 0x07C)); // 0x7C K_FalloffDistanceID         ( ModelPrimitiveType int int int Int32 )
            value.K_LightColorID                            = GetInt32(new IntPtr(p + 0x080)); // 0x80 K_LightColorID              ( ModelPrimitiveType int int int Int32 )
            value.K_VolumeOpacityID                         = GetInt32(new IntPtr(p + 0x084)); // 0x84 K_VolumeOpacityID           ( ModelPrimitiveType int int int Int32 )
            value.K_CookieTexID                             = GetInt32(new IntPtr(p + 0x088)); // 0x88 K_CookieTexID               ( ModelPrimitiveType int int int Int32 )
            value.K_FalloffLookupID                         = GetInt32(new IntPtr(p + 0x08C)); // 0x8C K_FalloffLookupID           ( ModelPrimitiveType int int int Int32 )
            value.K_LightPositionID                         = GetInt32(new IntPtr(p + 0x090)); // 0x90 K_LightPositionID           ( ModelPrimitiveType int int int Int32 )
            value.K_LightInvMatrixID                        = GetInt32(new IntPtr(p + 0x094)); // 0x94 K_LightInvMatrixID          ( ModelPrimitiveType int int int Int32 )
            value.K_InnerRadiusMultID                       = GetInt32(new IntPtr(p + 0x098)); // 0x98 K_InnerRadiusMultID         ( ModelPrimitiveType int int int Int32 )
            value.K_OuterAngleID                            = GetInt32(new IntPtr(p + 0x09C)); // 0x9C K_OuterAngleID              ( ModelPrimitiveType int int int Int32 )
            value.K_InnerAngleMultID                        = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 K_InnerAngleMultID          ( ModelPrimitiveType int int int Int32 )
            value.K_LightLookupID                           = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 K_LightLookupID             ( ModelPrimitiveType int int int Int32 )
            value.K_IsFullSpotlightID                       = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 K_IsFullSpotlightID         ( ModelPrimitiveType int int int Int32 )
            value.K_LightZDistanceID                        = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC K_LightZDistanceID          ( ModelPrimitiveType int int int Int32 )
            value.K_PointLightCookieTexID                   = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 K_PointLightCookieTexID     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
