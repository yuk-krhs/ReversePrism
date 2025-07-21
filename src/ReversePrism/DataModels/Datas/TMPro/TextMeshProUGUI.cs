using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 6D0 M_isRebuildingLayout                     ModelPrimitiveType bool bool bool Bool
    // 6D8 M_DelayedGraphicRebuild                  ModelClassType Coroutine Coroutine Coroutine Pointer
    // 6E0 M_DelayedMaterialRebuild                 ModelClassType Coroutine Coroutine Coroutine Pointer
    // 6E8 M_ClipRect                               ModelEnumType Rect Rect Rect Int32
    // 6F8 M_ValidRect                              ModelPrimitiveType bool bool bool Bool
    // 700 OnPreRenderText                          Action`1<TMP_TextInfo> IL2CPP_TYPE_GENERICINST
    // 708 M_hasFontAssetChanged                    ModelPrimitiveType bool bool bool Bool
    // 710 M_subTextObjects                         ModelClassListType TMP_SubMeshUI[] TMP_SubMeshUI[] List<TMP_SubMeshUI> Pointer
    // 718 M_previousLossyScaleY                    ModelPrimitiveType float float float Single
    // 720 M_RectTransformCorners                   ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 728 M_canvasRenderer                         ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer
    // 730 M_canvas                                 ModelClassType Canvas Canvas Canvas Pointer
    // 738 M_CanvasScaleFactor                      ModelPrimitiveType float float float Single
    // 73C M_isFirstAllocation                      ModelPrimitiveType bool bool bool Bool
    // 740 M_max_characters                         ModelPrimitiveType int int int Int32
    // 748 M_baseMaterial                           ModelClassType Material Material Material Pointer
    // 750 M_isScrollRegionSet                      ModelPrimitiveType bool bool bool Bool
    // 754 M_maskOffset                             ModelEnumType Vector4 Vector4 Vector4 Int32
    // 764 M_EnvMapMatrix                           ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 7A4 M_isRegisteredForEvents                  ModelPrimitiveType bool bool bool Bool
    // 000 k_GenerateTextMarker                     ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_SetArraySizesMarker                    ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_GenerateTextPhaseIMarker               ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_ParseMarkupTextMarker                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_CharacterLookupMarker                  ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_HandleGPOSFeaturesMarker               ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 K_CalculateVerticesPositionMarker        ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 K_ComputeTextMetricsMarker               ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 040 K_HandleVisibleCharacterMarker           ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 048 K_HandleWhiteSpacesMarker                ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 050 K_HandleHorizontalLineBreakingMarker     ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 058 K_HandleVerticalLineBreakingMarker       ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 060 K_SaveGlyphVertexDataMarker              ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 068 K_ComputeCharacterAdvanceMarker          ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 070 K_HandleCarriageReturnMarker             ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 078 K_HandleLineTerminationMarker            ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 080 K_SavePageInfoMarker                     ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 088 K_SaveProcessingStatesMarker             ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 090 K_GenerateTextPhaseIIMarker              ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 098 K_GenerateTextPhaseIIIMarker             ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    public partial class TextMeshProUGUI : DataModel
    {
        public bool                                     M_isRebuildingLayout                    { get; set; }
        public Coroutine?                               M_DelayedGraphicRebuild                 { get; set; }
        public Coroutine?                               M_DelayedMaterialRebuild                { get; set; }
        public Rect                                     M_ClipRect                              { get; set; }
        public bool                                     M_ValidRect                             { get; set; }
        public bool                                     M_hasFontAssetChanged                   { get; set; }
        public List<TMP_SubMeshUI>?                     M_subTextObjects                        { get; set; }
        public float                                    M_previousLossyScaleY                   { get; set; }
        public List<Vector3>?                           M_RectTransformCorners                  { get; set; }
        public CanvasRenderer?                          M_canvasRenderer                        { get; set; }
        public Canvas?                                  M_canvas                                { get; set; }
        public float                                    M_CanvasScaleFactor                     { get; set; }
        public bool                                     M_isFirstAllocation                     { get; set; }
        public int                                      M_max_characters                        { get; set; }
        public Material?                                M_baseMaterial                          { get; set; }
        public bool                                     M_isScrollRegionSet                     { get; set; }
        public Vector4                                  M_maskOffset                            { get; set; }
        public Matrix4x4                                M_EnvMapMatrix                          { get; set; }
        public bool                                     M_isRegisteredForEvents                 { get; set; }
        public ProfilerMarker                           K_GenerateTextPhaseIMarker              { get; set; }
        public ProfilerMarker                           K_ParseMarkupTextMarker                 { get; set; }
        public ProfilerMarker                           K_CharacterLookupMarker                 { get; set; }
        public ProfilerMarker                           K_HandleGPOSFeaturesMarker              { get; set; }
        public ProfilerMarker                           K_CalculateVerticesPositionMarker       { get; set; }
        public ProfilerMarker                           K_ComputeTextMetricsMarker              { get; set; }
        public ProfilerMarker                           K_HandleVisibleCharacterMarker          { get; set; }
        public ProfilerMarker                           K_HandleWhiteSpacesMarker               { get; set; }
        public ProfilerMarker                           K_HandleHorizontalLineBreakingMarker    { get; set; }
        public ProfilerMarker                           K_HandleVerticalLineBreakingMarker      { get; set; }
        public ProfilerMarker                           K_SaveGlyphVertexDataMarker             { get; set; }
        public ProfilerMarker                           K_ComputeCharacterAdvanceMarker         { get; set; }
        public ProfilerMarker                           K_HandleCarriageReturnMarker            { get; set; }
        public ProfilerMarker                           K_HandleLineTerminationMarker           { get; set; }
        public ProfilerMarker                           K_SavePageInfoMarker                    { get; set; }
        public ProfilerMarker                           K_SaveProcessingStatesMarker            { get; set; }
        public ProfilerMarker                           K_GenerateTextPhaseIIMarker             { get; set; }
        public ProfilerMarker                           K_GenerateTextPhaseIIIMarker            { get; set; }

        public static TextMeshProUGUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextMeshProUGUI() { Pointer= p0 };

            value.M_isRebuildingLayout                      = GetBool(new IntPtr(p + 0x6D0)); // 0x6D0 M_isRebuildingLayout        ( ModelPrimitiveType bool bool bool Bool )
            value.M_DelayedGraphicRebuild                   = GetObject<Coroutine>(new IntPtr(p + 0x6D8), ReversePrism.DataModels.Coroutine.FromPointer); // 0x6D8 M_DelayedGraphicRebuild     ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_DelayedMaterialRebuild                  = GetObject<Coroutine>(new IntPtr(p + 0x6E0), ReversePrism.DataModels.Coroutine.FromPointer); // 0x6E0 M_DelayedMaterialRebuild    ( ModelClassType Coroutine Coroutine Coroutine Pointer )
            value.M_ClipRect                                = (Rect)GetInt32(new IntPtr(p + 0x6E8)); // 0x6E8 M_ClipRect                  ( ModelEnumType Rect Rect Rect Int32 )
            value.M_ValidRect                               = GetBool(new IntPtr(p + 0x6F8)); // 0x6F8 M_ValidRect                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_hasFontAssetChanged                     = GetBool(new IntPtr(p + 0x708)); // 0x708 M_hasFontAssetChanged       ( ModelPrimitiveType bool bool bool Bool )
            value.M_subTextObjects                          = GetObjectList<TMP_SubMeshUI>(new IntPtr(p + 0x710), ReversePrism.DataModels.TMP_SubMeshUI.FromPointer); // 0x710 M_subTextObjects            ( ModelClassListType TMP_SubMeshUI[] TMP_SubMeshUI[] List<TMP_SubMeshUI> Pointer )
            value.M_previousLossyScaleY                     = GetSingle(new IntPtr(p + 0x718)); // 0x718 M_previousLossyScaleY       ( ModelPrimitiveType float float float Single )
            value.M_RectTransformCorners                    = GetEnumList<Vector3>(new IntPtr(p + 0x720)); // 0x720 M_RectTransformCorners      ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_canvasRenderer                          = GetObject<CanvasRenderer>(new IntPtr(p + 0x728), ReversePrism.DataModels.CanvasRenderer.FromPointer); // 0x728 M_canvasRenderer            ( ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer )
            value.M_canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x730), ReversePrism.DataModels.Canvas.FromPointer); // 0x730 M_canvas                    ( ModelClassType Canvas Canvas Canvas Pointer )
            value.M_CanvasScaleFactor                       = GetSingle(new IntPtr(p + 0x738)); // 0x738 M_CanvasScaleFactor         ( ModelPrimitiveType float float float Single )
            value.M_isFirstAllocation                       = GetBool(new IntPtr(p + 0x73C)); // 0x73C M_isFirstAllocation         ( ModelPrimitiveType bool bool bool Bool )
            value.M_max_characters                          = GetInt32(new IntPtr(p + 0x740)); // 0x740 M_max_characters            ( ModelPrimitiveType int int int Int32 )
            value.M_baseMaterial                            = GetObject<Material>(new IntPtr(p + 0x748), ReversePrism.DataModels.Material.FromPointer); // 0x748 M_baseMaterial              ( ModelClassType Material Material Material Pointer )
            value.M_isScrollRegionSet                       = GetBool(new IntPtr(p + 0x750)); // 0x750 M_isScrollRegionSet         ( ModelPrimitiveType bool bool bool Bool )
            value.M_maskOffset                              = (Vector4)GetInt32(new IntPtr(p + 0x754)); // 0x754 M_maskOffset                ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_EnvMapMatrix                            = (Matrix4x4)GetInt32(new IntPtr(p + 0x764)); // 0x764 M_EnvMapMatrix              ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x7A4)); // 0x7A4 M_isRegisteredForEvents     ( ModelPrimitiveType bool bool bool Bool )
            value.K_GenerateTextPhaseIMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_GenerateTextPhaseIMarker  ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ParseMarkupTextMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 K_ParseMarkupTextMarker     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_CharacterLookupMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0x20 K_CharacterLookupMarker     ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleGPOSFeaturesMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0x28 K_HandleGPOSFeaturesMarker  ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_CalculateVerticesPositionMarker         = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0x30 K_CalculateVerticesPositionMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ComputeTextMetricsMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x038)); // 0x38 K_ComputeTextMetricsMarker  ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleVisibleCharacterMarker            = (ProfilerMarker)GetInt32(new IntPtr(p + 0x040)); // 0x40 K_HandleVisibleCharacterMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleWhiteSpacesMarker                 = (ProfilerMarker)GetInt32(new IntPtr(p + 0x048)); // 0x48 K_HandleWhiteSpacesMarker   ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleHorizontalLineBreakingMarker      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x050)); // 0x50 K_HandleHorizontalLineBreakingMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleVerticalLineBreakingMarker        = (ProfilerMarker)GetInt32(new IntPtr(p + 0x058)); // 0x58 K_HandleVerticalLineBreakingMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_SaveGlyphVertexDataMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x060)); // 0x60 K_SaveGlyphVertexDataMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ComputeCharacterAdvanceMarker           = (ProfilerMarker)GetInt32(new IntPtr(p + 0x068)); // 0x68 K_ComputeCharacterAdvanceMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleCarriageReturnMarker              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x070)); // 0x70 K_HandleCarriageReturnMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleLineTerminationMarker             = (ProfilerMarker)GetInt32(new IntPtr(p + 0x078)); // 0x78 K_HandleLineTerminationMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_SavePageInfoMarker                      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x080)); // 0x80 K_SavePageInfoMarker        ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_SaveProcessingStatesMarker              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x088)); // 0x88 K_SaveProcessingStatesMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_GenerateTextPhaseIIMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x090)); // 0x90 K_GenerateTextPhaseIIMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_GenerateTextPhaseIIIMarker              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x098)); // 0x98 K_GenerateTextPhaseIIIMarker ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )

            return value;
        }
    }
}
