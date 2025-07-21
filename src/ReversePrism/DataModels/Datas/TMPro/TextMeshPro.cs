using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 6D0 SortingLayer                             ModelPrimitiveType int int int Int32
    // 6D4 SortingLayerID                           ModelPrimitiveType int int int Int32
    // 6D8 SortingOrder                             ModelPrimitiveType int int int Int32
    // 6E0 OnPreRenderText                          Action`1<TMP_TextInfo> IL2CPP_TYPE_GENERICINST
    // 6E8 M_currentAutoSizeMode                    ModelPrimitiveType bool bool bool Bool
    // 6E9 M_hasFontAssetChanged                    ModelPrimitiveType bool bool bool Bool
    // 6EC M_previousLossyScaleY                    ModelPrimitiveType float float float Single
    // 6F0 M_renderer                               ModelClassType Renderer Renderer Renderer Pointer
    // 6F8 M_meshFilter                             ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 700 M_isFirstAllocation                      ModelPrimitiveType bool bool bool Bool
    // 704 M_max_characters                         ModelPrimitiveType int int int Int32
    // 708 M_max_numberOfLines                      ModelPrimitiveType int int int Int32
    // 710 M_subTextObjects                         ModelClassListType TMP_SubMesh[] TMP_SubMesh[] List<TMP_SubMesh> Pointer
    // 718 M_maskType                               ModelEnumType MaskingTypes MaskingTypes MaskingTypes Int32
    // 71C M_EnvMapMatrix                           ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 760 M_RectTransformCorners                   ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 768 M_isRegisteredForEvents                  ModelPrimitiveType bool bool bool Bool
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
    public partial class TextMeshPro : DataModel
    {
        public int                                      SortingLayer                            { get; set; }
        public int                                      SortingLayerID                          { get; set; }
        public int                                      SortingOrder                            { get; set; }
        public bool                                     M_currentAutoSizeMode                   { get; set; }
        public bool                                     M_hasFontAssetChanged                   { get; set; }
        public float                                    M_previousLossyScaleY                   { get; set; }
        public Renderer?                                M_renderer                              { get; set; }
        public MeshFilter?                              M_meshFilter                            { get; set; }
        public bool                                     M_isFirstAllocation                     { get; set; }
        public int                                      M_max_characters                        { get; set; }
        public int                                      M_max_numberOfLines                     { get; set; }
        public List<TMP_SubMesh>?                       M_subTextObjects                        { get; set; }
        public MaskingTypes                             M_maskType                              { get; set; }
        public Matrix4x4                                M_EnvMapMatrix                          { get; set; }
        public List<Vector3>?                           M_RectTransformCorners                  { get; set; }
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

        public static TextMeshPro? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextMeshPro() { Pointer= p0 };

            value.SortingLayer                              = GetInt32(new IntPtr(p + 0x6D0)); // 0x6D0 SortingLayer                ( ModelPrimitiveType int int int Int32 )
            value.SortingLayerID                            = GetInt32(new IntPtr(p + 0x6D4)); // 0x6D4 SortingLayerID              ( ModelPrimitiveType int int int Int32 )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x6D8)); // 0x6D8 SortingOrder                ( ModelPrimitiveType int int int Int32 )
            value.M_currentAutoSizeMode                     = GetBool(new IntPtr(p + 0x6E8)); // 0x6E8 M_currentAutoSizeMode       ( ModelPrimitiveType bool bool bool Bool )
            value.M_hasFontAssetChanged                     = GetBool(new IntPtr(p + 0x6E9)); // 0x6E9 M_hasFontAssetChanged       ( ModelPrimitiveType bool bool bool Bool )
            value.M_previousLossyScaleY                     = GetSingle(new IntPtr(p + 0x6EC)); // 0x6EC M_previousLossyScaleY       ( ModelPrimitiveType float float float Single )
            value.M_renderer                                = GetObject<Renderer>(new IntPtr(p + 0x6F0), ReversePrism.DataModels.Renderer.FromPointer); // 0x6F0 M_renderer                  ( ModelClassType Renderer Renderer Renderer Pointer )
            value.M_meshFilter                              = GetObject<MeshFilter>(new IntPtr(p + 0x6F8), ReversePrism.DataModels.MeshFilter.FromPointer); // 0x6F8 M_meshFilter                ( ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.M_isFirstAllocation                       = GetBool(new IntPtr(p + 0x700)); // 0x700 M_isFirstAllocation         ( ModelPrimitiveType bool bool bool Bool )
            value.M_max_characters                          = GetInt32(new IntPtr(p + 0x704)); // 0x704 M_max_characters            ( ModelPrimitiveType int int int Int32 )
            value.M_max_numberOfLines                       = GetInt32(new IntPtr(p + 0x708)); // 0x708 M_max_numberOfLines         ( ModelPrimitiveType int int int Int32 )
            value.M_subTextObjects                          = GetObjectList<TMP_SubMesh>(new IntPtr(p + 0x710), ReversePrism.DataModels.TMP_SubMesh.FromPointer); // 0x710 M_subTextObjects            ( ModelClassListType TMP_SubMesh[] TMP_SubMesh[] List<TMP_SubMesh> Pointer )
            value.M_maskType                                = (MaskingTypes)GetInt32(new IntPtr(p + 0x718)); // 0x718 M_maskType                  ( ModelEnumType MaskingTypes MaskingTypes MaskingTypes Int32 )
            value.M_EnvMapMatrix                            = (Matrix4x4)GetInt32(new IntPtr(p + 0x71C)); // 0x71C M_EnvMapMatrix              ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_RectTransformCorners                    = GetEnumList<Vector3>(new IntPtr(p + 0x760)); // 0x760 M_RectTransformCorners      ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x768)); // 0x768 M_isRegisteredForEvents     ( ModelPrimitiveType bool bool bool Bool )
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
