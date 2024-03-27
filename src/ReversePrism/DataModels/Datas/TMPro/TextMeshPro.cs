using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 6D0 SortingLayer                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 6D4 SortingLayerID                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 6D8 SortingOrder                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 6E0 OnPreRenderText                          Action`1<TMP_TextInfo> IL2CPP_TYPE_GENERICINST
    // 6E8 M_currentAutoSizeMode                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 6E9 M_hasFontAssetChanged                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 6EC M_previousLossyScaleY                    0001866656B0 ModelPrimitiveType float float float Single
    // 6F0 M_renderer                               00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 6F8 M_meshFilter                             000186601410 ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 700 M_isFirstAllocation                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 704 M_max_characters                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 708 M_max_numberOfLines                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 710 M_subTextObjects                         000185CA99C8 ModelClassListType TMP_SubMesh[] TMP_SubMesh[] List<TMP_SubMesh> Pointer
    // 718 M_maskType                               0001865D9490 ModelEnumType MaskingTypes MaskingTypes MaskingTypes Int32
    // 71C M_EnvMapMatrix                           00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 760 M_RectTransformCorners                   000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 768 M_isRegisteredForEvents                  0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 000 k_GenerateTextMarker                     ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 k_SetArraySizesMarker                    ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 K_GenerateTextPhaseIMarker               0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 K_ParseMarkupTextMarker                  0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_CharacterLookupMarker                  0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 K_HandleGPOSFeaturesMarker               0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 K_CalculateVerticesPositionMarker        0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 038 K_ComputeTextMetricsMarker               0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 040 K_HandleVisibleCharacterMarker           0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 048 K_HandleWhiteSpacesMarker                0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 050 K_HandleHorizontalLineBreakingMarker     0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 058 K_HandleVerticalLineBreakingMarker       0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 060 K_SaveGlyphVertexDataMarker              0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 068 K_ComputeCharacterAdvanceMarker          0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 070 K_HandleCarriageReturnMarker             0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 078 K_HandleLineTerminationMarker            0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 080 K_SavePageInfoMarker                     0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 088 K_SaveProcessingStatesMarker             0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 090 K_GenerateTextPhaseIIMarker              0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 098 K_GenerateTextPhaseIIIMarker             0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    public partial class TextMeshPro
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
            var value   = new TextMeshPro();

            value.SortingLayer                              = GetInt32(new IntPtr(p + 0x6D0)); // 0270DA60BE80 0x6D0 SortingLayer                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SortingLayerID                            = GetInt32(new IntPtr(p + 0x6D4)); // 0270DA60BEA0 0x6D4 SortingLayerID              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.SortingOrder                              = GetInt32(new IntPtr(p + 0x6D8)); // 0270DA60BEC0 0x6D8 SortingOrder                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_currentAutoSizeMode                     = GetBool(new IntPtr(p + 0x6E8)); // 0270DA60BF00 0x6E8 M_currentAutoSizeMode       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_hasFontAssetChanged                     = GetBool(new IntPtr(p + 0x6E9)); // 0270DA60BF20 0x6E9 M_hasFontAssetChanged       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_previousLossyScaleY                     = GetSingle(new IntPtr(p + 0x6EC)); // 0270DA60BF40 0x6EC M_previousLossyScaleY       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_renderer                                = GetObject<Renderer>(new IntPtr(p + 0x6F0), ReversePrism.DataModels.Renderer.FromPointer); // 0270DA60BF60 0x6F0 M_renderer                  ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.M_meshFilter                              = GetObject<MeshFilter>(new IntPtr(p + 0x6F8), ReversePrism.DataModels.MeshFilter.FromPointer); // 0270DA60BF80 0x6F8 M_meshFilter                ( 000186601410 ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.M_isFirstAllocation                       = GetBool(new IntPtr(p + 0x700)); // 0270DA60BFA0 0x700 M_isFirstAllocation         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_max_characters                          = GetInt32(new IntPtr(p + 0x704)); // 0270DA60BFC0 0x704 M_max_characters            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_max_numberOfLines                       = GetInt32(new IntPtr(p + 0x708)); // 0270DA60BFE0 0x708 M_max_numberOfLines         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_subTextObjects                          = GetObjectList<TMP_SubMesh>(new IntPtr(p + 0x710), ReversePrism.DataModels.TMP_SubMesh.FromPointer); // 0270DA60C000 0x710 M_subTextObjects            ( 000185CA99C8 ModelClassListType TMP_SubMesh[] TMP_SubMesh[] List<TMP_SubMesh> Pointer )
            value.M_maskType                                = (MaskingTypes)GetInt32(new IntPtr(p + 0x718)); // 0270DA60C020 0x718 M_maskType                  ( 0001865D9490 ModelEnumType MaskingTypes MaskingTypes MaskingTypes Int32 )
            value.M_EnvMapMatrix                            = (Matrix4x4)GetInt32(new IntPtr(p + 0x71C)); // 0270DA60C040 0x71C M_EnvMapMatrix              ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_RectTransformCorners                    = GetEnumList<Vector3>(new IntPtr(p + 0x760)); // 0270DA60C060 0x760 M_RectTransformCorners      ( 000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_isRegisteredForEvents                   = GetBool(new IntPtr(p + 0x768)); // 0270DA60C080 0x768 M_isRegisteredForEvents     ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.K_GenerateTextPhaseIMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0270DA60C0E0 0x10 K_GenerateTextPhaseIMarker  ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ParseMarkupTextMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0270DA60C100 0x18 K_ParseMarkupTextMarker     ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_CharacterLookupMarker                   = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0270DA60C120 0x20 K_CharacterLookupMarker     ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleGPOSFeaturesMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0270DA60C140 0x28 K_HandleGPOSFeaturesMarker  ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_CalculateVerticesPositionMarker         = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0270DA60C160 0x30 K_CalculateVerticesPositionMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ComputeTextMetricsMarker                = (ProfilerMarker)GetInt32(new IntPtr(p + 0x038)); // 0270DA60C180 0x38 K_ComputeTextMetricsMarker  ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleVisibleCharacterMarker            = (ProfilerMarker)GetInt32(new IntPtr(p + 0x040)); // 0270DA60C1A0 0x40 K_HandleVisibleCharacterMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleWhiteSpacesMarker                 = (ProfilerMarker)GetInt32(new IntPtr(p + 0x048)); // 0270DA60C1C0 0x48 K_HandleWhiteSpacesMarker   ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleHorizontalLineBreakingMarker      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x050)); // 0270DA60C1E0 0x50 K_HandleHorizontalLineBreakingMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleVerticalLineBreakingMarker        = (ProfilerMarker)GetInt32(new IntPtr(p + 0x058)); // 0270DA60C200 0x58 K_HandleVerticalLineBreakingMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_SaveGlyphVertexDataMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x060)); // 0270DA60C220 0x60 K_SaveGlyphVertexDataMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ComputeCharacterAdvanceMarker           = (ProfilerMarker)GetInt32(new IntPtr(p + 0x068)); // 0270DA60C240 0x68 K_ComputeCharacterAdvanceMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleCarriageReturnMarker              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x070)); // 0270DA60C260 0x70 K_HandleCarriageReturnMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_HandleLineTerminationMarker             = (ProfilerMarker)GetInt32(new IntPtr(p + 0x078)); // 0270DA60C280 0x78 K_HandleLineTerminationMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_SavePageInfoMarker                      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x080)); // 0270DA60C2A0 0x80 K_SavePageInfoMarker        ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_SaveProcessingStatesMarker              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x088)); // 0270DA60C2C0 0x88 K_SaveProcessingStatesMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_GenerateTextPhaseIIMarker               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x090)); // 0270DA60C2E0 0x90 K_GenerateTextPhaseIIMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_GenerateTextPhaseIIIMarker              = (ProfilerMarker)GetInt32(new IntPtr(p + 0x098)); // 0270DA60C300 0x98 K_GenerateTextPhaseIIIMarker ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )

            return value;
        }
    }
}
