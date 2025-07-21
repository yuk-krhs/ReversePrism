using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DefaultSortingOrder                    int IL2CPP_TYPE_I4
    // 000 k_DefaultScaleValue                      float IL2CPP_TYPE_R4
    // 000 k_DefaultStyleSheetPath                  string IL2CPP_TYPE_STRING
    // 018 ThemeUss                                 ModelClassType ThemeStyleSheet ThemeStyleSheet ThemeStyleSheet Pointer
    // 020 M_TargetTexture                          ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 028 M_ScaleMode                              ModelEnumType PanelScaleMode PanelScaleMode PanelScaleMode Int32
    // 02C M_ReferenceSpritePixelsPerUnit           ModelPrimitiveType float float float Single
    // 030 M_Scale                                  ModelPrimitiveType float float float Single
    // 000 DefaultDpi                               float IL2CPP_TYPE_R4
    // 034 M_ReferenceDpi                           ModelPrimitiveType float float float Single
    // 038 M_FallbackDpi                            ModelPrimitiveType float float float Single
    // 03C M_ReferenceResolution                    ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 044 M_ScreenMatchMode                        ModelEnumType PanelScreenMatchMode PanelScreenMatchMode PanelScreenMatchMode Int32
    // 048 M_Match                                  ModelPrimitiveType float float float Single
    // 04C M_SortingOrder                           ModelPrimitiveType float float float Single
    // 050 M_TargetDisplay                          ModelPrimitiveType int int int Int32
    // 054 M_ClearDepthStencil                      ModelPrimitiveType bool bool bool Bool
    // 055 M_ClearColor                             ModelPrimitiveType bool bool bool Bool
    // 058 M_ColorClearValue                        ModelEnumType Color Color Color Int32
    // 068 M_PanelAccess                            ModelClassType RuntimePanelAccess RuntimePanelAccess RuntimePanelAccess Pointer
    // 070 M_AttachedUIDocumentsList                ModelClassType UIDocumentList UIDocumentList UIDocumentList Pointer
    // 078 M_DynamicAtlasSettings                   ModelClassType DynamicAtlasSettings DynamicAtlasSettings DynamicAtlasSettings Pointer
    // 080 M_AtlasBlitShader                        ModelClassType Shader Shader Shader Pointer
    // 088 M_RuntimeShader                          ModelClassType Shader Shader Shader Pointer
    // 090 M_RuntimeWorldShader                     ModelClassType Shader Shader Shader Pointer
    // 098 TextSettings                             ModelClassType PanelTextSettings PanelTextSettings PanelTextSettings Pointer
    // 0A0 M_TargetRect                             ModelEnumType Rect Rect Rect Int32
    // 0B0 M_ResolvedScale                          ModelPrimitiveType float float float Single
    // 0B8 M_OldThemeUss                            ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 0C0 ScreenDPI                                ModelPrimitiveType float float float Single
    // 0C8 m_AssignedScreenToPanel                  Func`2<Vector2, Vector2> IL2CPP_TYPE_GENERICINST
    public partial class PanelSettings : DataModel
    {
        public ThemeStyleSheet?                         ThemeUss                                { get; set; }
        public RenderTexture?                           M_TargetTexture                         { get; set; }
        public PanelScaleMode                           M_ScaleMode                             { get; set; }
        public float                                    M_ReferenceSpritePixelsPerUnit          { get; set; }
        public float                                    M_Scale                                 { get; set; }
        public float                                    M_ReferenceDpi                          { get; set; }
        public float                                    M_FallbackDpi                           { get; set; }
        public Vector2Int                               M_ReferenceResolution                   { get; set; }
        public PanelScreenMatchMode                     M_ScreenMatchMode                       { get; set; }
        public float                                    M_Match                                 { get; set; }
        public float                                    M_SortingOrder                          { get; set; }
        public int                                      M_TargetDisplay                         { get; set; }
        public bool                                     M_ClearDepthStencil                     { get; set; }
        public bool                                     M_ClearColor                            { get; set; }
        public Color                                    M_ColorClearValue                       { get; set; }
        public RuntimePanelAccess?                      M_PanelAccess                           { get; set; }
        public UIDocumentList?                          M_AttachedUIDocumentsList               { get; set; }
        public DynamicAtlasSettings?                    M_DynamicAtlasSettings                  { get; set; }
        public Shader?                                  M_AtlasBlitShader                       { get; set; }
        public Shader?                                  M_RuntimeShader                         { get; set; }
        public Shader?                                  M_RuntimeWorldShader                    { get; set; }
        public PanelTextSettings?                       TextSettings                            { get; set; }
        public Rect                                     M_TargetRect                            { get; set; }
        public float                                    M_ResolvedScale                         { get; set; }
        public StyleSheet?                              M_OldThemeUss                           { get; set; }
        public float                                    ScreenDPI                               { get; set; }

        public static PanelSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PanelSettings() { Pointer= p0 };

            value.ThemeUss                                  = GetObject<ThemeStyleSheet>(new IntPtr(p + 0x018), ReversePrism.DataModels.ThemeStyleSheet.FromPointer); // 0x18 ThemeUss                    ( ModelClassType ThemeStyleSheet ThemeStyleSheet ThemeStyleSheet Pointer )
            value.M_TargetTexture                           = GetObject<RenderTexture>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x20 M_TargetTexture             ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_ScaleMode                               = (PanelScaleMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_ScaleMode                 ( ModelEnumType PanelScaleMode PanelScaleMode PanelScaleMode Int32 )
            value.M_ReferenceSpritePixelsPerUnit            = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_ReferenceSpritePixelsPerUnit ( ModelPrimitiveType float float float Single )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_Scale                     ( ModelPrimitiveType float float float Single )
            value.M_ReferenceDpi                            = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_ReferenceDpi              ( ModelPrimitiveType float float float Single )
            value.M_FallbackDpi                             = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_FallbackDpi               ( ModelPrimitiveType float float float Single )
            value.M_ReferenceResolution                     = (Vector2Int)GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_ReferenceResolution       ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_ScreenMatchMode                         = (PanelScreenMatchMode)GetInt32(new IntPtr(p + 0x044)); // 0x44 M_ScreenMatchMode           ( ModelEnumType PanelScreenMatchMode PanelScreenMatchMode PanelScreenMatchMode Int32 )
            value.M_Match                                   = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_Match                     ( ModelPrimitiveType float float float Single )
            value.M_SortingOrder                            = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_SortingOrder              ( ModelPrimitiveType float float float Single )
            value.M_TargetDisplay                           = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_TargetDisplay             ( ModelPrimitiveType int int int Int32 )
            value.M_ClearDepthStencil                       = GetBool(new IntPtr(p + 0x054)); // 0x54 M_ClearDepthStencil         ( ModelPrimitiveType bool bool bool Bool )
            value.M_ClearColor                              = GetBool(new IntPtr(p + 0x055)); // 0x55 M_ClearColor                ( ModelPrimitiveType bool bool bool Bool )
            value.M_ColorClearValue                         = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_ColorClearValue           ( ModelEnumType Color Color Color Int32 )
            value.M_PanelAccess                             = GetObject<RuntimePanelAccess>(new IntPtr(p + 0x068), ReversePrism.DataModels.RuntimePanelAccess.FromPointer); // 0x68 M_PanelAccess               ( ModelClassType RuntimePanelAccess RuntimePanelAccess RuntimePanelAccess Pointer )
            value.M_AttachedUIDocumentsList                 = GetObject<UIDocumentList>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIDocumentList.FromPointer); // 0x70 M_AttachedUIDocumentsList   ( ModelClassType UIDocumentList UIDocumentList UIDocumentList Pointer )
            value.M_DynamicAtlasSettings                    = GetObject<DynamicAtlasSettings>(new IntPtr(p + 0x078), ReversePrism.DataModels.DynamicAtlasSettings.FromPointer); // 0x78 M_DynamicAtlasSettings      ( ModelClassType DynamicAtlasSettings DynamicAtlasSettings DynamicAtlasSettings Pointer )
            value.M_AtlasBlitShader                         = GetObject<Shader>(new IntPtr(p + 0x080), ReversePrism.DataModels.Shader.FromPointer); // 0x80 M_AtlasBlitShader           ( ModelClassType Shader Shader Shader Pointer )
            value.M_RuntimeShader                           = GetObject<Shader>(new IntPtr(p + 0x088), ReversePrism.DataModels.Shader.FromPointer); // 0x88 M_RuntimeShader             ( ModelClassType Shader Shader Shader Pointer )
            value.M_RuntimeWorldShader                      = GetObject<Shader>(new IntPtr(p + 0x090), ReversePrism.DataModels.Shader.FromPointer); // 0x90 M_RuntimeWorldShader        ( ModelClassType Shader Shader Shader Pointer )
            value.TextSettings                              = GetObject<PanelTextSettings>(new IntPtr(p + 0x098), ReversePrism.DataModels.PanelTextSettings.FromPointer); // 0x98 TextSettings                ( ModelClassType PanelTextSettings PanelTextSettings PanelTextSettings Pointer )
            value.M_TargetRect                              = (Rect)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_TargetRect                ( ModelEnumType Rect Rect Rect Int32 )
            value.M_ResolvedScale                           = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 M_ResolvedScale             ( ModelPrimitiveType float float float Single )
            value.M_OldThemeUss                             = GetObject<StyleSheet>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.StyleSheet.FromPointer); // 0xB8 M_OldThemeUss               ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.ScreenDPI                                 = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 ScreenDPI                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
