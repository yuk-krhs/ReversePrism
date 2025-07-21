using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_AdditionalShadowsBufferId              int IL2CPP_TYPE_I4
    // 004 m_AdditionalShadowsIndicesId             int IL2CPP_TYPE_I4
    // 008 c_DefaultShadowParams                    Vector4 IL2CPP_TYPE_VALUETYPE
    // 018 M_AdditionalLightsWorldToShadow_SSBO     ModelPrimitiveType int int int Int32
    // 01C M_AdditionalShadowParams_SSBO            ModelPrimitiveType int int int Int32
    // 0E0 M_UseStructuredBuffer                    ModelPrimitiveType bool bool bool Bool
    // 000 k_ShadowmapBufferBits                    int IL2CPP_TYPE_I4
    // 0E4 M_AdditionalLightsShadowmapID            ModelPrimitiveType int int int Int32
    // 0E8 M_AdditionalLightsShadowmapHandle        ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F0 M_MaxShadowDistanceSq                    ModelPrimitiveType float float float Single
    // 0F4 M_CascadeBorder                          ModelPrimitiveType float float float Single
    // 0F8 M_AdditionalLightsShadowSlices           ModelEnumListType ShadowSliceData[] ShadowSliceData[] List<ShadowSliceData> Pointer
    // 100 M_VisibleLightIndexToAdditionalLightIndex ModelPrimitiveListType int[] int[] List<int> Pointer
    // 108 M_AdditionalLightIndexToVisibleLightIndex ModelPrimitiveListType int[] int[] List<int> Pointer
    // 110 M_ShadowSliceToAdditionalLightIndex      ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 118 M_GlobalShadowSliceIndexToPerLightShadowSliceIndex ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 120 M_AdditionalLightIndexToShadowParams     ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 128 M_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 130 M_ShadowResolutionRequests               ModelEnumListType List`1<ShadowResolutionRequest> List`1<ShadowResolutionRequest> List<ShadowResolutionRequest> Pointer
    // 138 M_VisibleLightIndexToCameraSquareDistance ModelPrimitiveListType float[] float[] List<float> Pointer
    // 140 M_SortedShadowResolutionRequests         ModelEnumListType ShadowResolutionRequest[] ShadowResolutionRequest[] List<ShadowResolutionRequest> Pointer
    // 148 M_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex ModelPrimitiveListType int[] int[] List<int> Pointer
    // 150 M_UnusedAtlasSquareAreas                 ModelEnumListType List`1<RectInt> List`1<RectInt> List<RectInt> Pointer
    // 158 M_CreateEmptyShadowmap                   ModelPrimitiveType bool bool bool Bool
    // 15C RenderTargetWidth                        ModelPrimitiveType int int int Int32
    // 160 RenderTargetHeight                       ModelPrimitiveType int int int Int32
    // 168 M_ProfilingSetupSampler                  ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 000 LightTypeIdentifierInShadowParams_Spot   float IL2CPP_TYPE_R4
    // 000 LightTypeIdentifierInShadowParams_Point  float IL2CPP_TYPE_R4
    // 000 kMinimumPunctualLightHardShadowResolution int IL2CPP_TYPE_I4
    // 000 kMinimumPunctualLightSoftShadowResolution int IL2CPP_TYPE_I4
    // 170 m_ShadowRequestsHashes                   Dictionary`2<int, ulong> IL2CPP_TYPE_GENERICINST
    public partial class AdditionalLightsShadowCasterPass : DataModel
    {
        public int                                      M_AdditionalLightsWorldToShadow_SSBO    { get; set; }
        public int                                      M_AdditionalShadowParams_SSBO           { get; set; }
        public bool                                     M_UseStructuredBuffer                   { get; set; }
        public int                                      M_AdditionalLightsShadowmapID           { get; set; }
        public RTHandle?                                M_AdditionalLightsShadowmapHandle       { get; set; }
        public float                                    M_MaxShadowDistanceSq                   { get; set; }
        public float                                    M_CascadeBorder                         { get; set; }
        public List<ShadowSliceData>?                   M_AdditionalLightsShadowSlices          { get; set; }
        public List<int>?                               M_VisibleLightIndexToAdditionalLightIndex { get; set; }
        public List<int>?                               M_AdditionalLightIndexToVisibleLightIndex { get; set; }
        public List<int>?                               M_ShadowSliceToAdditionalLightIndex     { get; set; }
        public List<int>?                               M_GlobalShadowSliceIndexToPerLightShadowSliceIndex { get; set; }
        public List<Vector4>?                           M_AdditionalLightIndexToShadowParams    { get; set; }
        public List<Matrix4x4>?                         M_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix { get; set; }
        public List<ShadowResolutionRequest>?           M_ShadowResolutionRequests              { get; set; }
        public List<float>?                             M_VisibleLightIndexToCameraSquareDistance { get; set; }
        public List<ShadowResolutionRequest>?           M_SortedShadowResolutionRequests        { get; set; }
        public List<int>?                               M_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex { get; set; }
        public List<RectInt>?                           M_UnusedAtlasSquareAreas                { get; set; }
        public bool                                     M_CreateEmptyShadowmap                  { get; set; }
        public int                                      RenderTargetWidth                       { get; set; }
        public int                                      RenderTargetHeight                      { get; set; }
        public ProfilingSampler?                        M_ProfilingSetupSampler                 { get; set; }

        public static AdditionalLightsShadowCasterPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdditionalLightsShadowCasterPass() { Pointer= p0 };

            value.M_AdditionalLightsWorldToShadow_SSBO      = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_AdditionalLightsWorldToShadow_SSBO ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalShadowParams_SSBO             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_AdditionalShadowParams_SSBO ( ModelPrimitiveType int int int Int32 )
            value.M_UseStructuredBuffer                     = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 M_UseStructuredBuffer       ( ModelPrimitiveType bool bool bool Bool )
            value.M_AdditionalLightsShadowmapID             = GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 M_AdditionalLightsShadowmapID ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalLightsShadowmapHandle         = GetObject<RTHandle>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE8 M_AdditionalLightsShadowmapHandle ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_MaxShadowDistanceSq                     = GetSingle(new IntPtr(p + 0x0F0)); // 0xF0 M_MaxShadowDistanceSq       ( ModelPrimitiveType float float float Single )
            value.M_CascadeBorder                           = GetSingle(new IntPtr(p + 0x0F4)); // 0xF4 M_CascadeBorder             ( ModelPrimitiveType float float float Single )
            value.M_AdditionalLightsShadowSlices            = GetEnumList<ShadowSliceData>(new IntPtr(p + 0x0F8)); // 0xF8 M_AdditionalLightsShadowSlices ( ModelEnumListType ShadowSliceData[] ShadowSliceData[] List<ShadowSliceData> Pointer )
            value.M_VisibleLightIndexToAdditionalLightIndex = GetInt32List(new IntPtr(p + 0x100)); // 0x100 M_VisibleLightIndexToAdditionalLightIndex ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_AdditionalLightIndexToVisibleLightIndex = GetInt32List(new IntPtr(p + 0x108)); // 0x108 M_AdditionalLightIndexToVisibleLightIndex ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_ShadowSliceToAdditionalLightIndex       = GetInt32List(new IntPtr(p + 0x110)); // 0x110 M_ShadowSliceToAdditionalLightIndex ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_GlobalShadowSliceIndexToPerLightShadowSliceIndex = GetInt32List(new IntPtr(p + 0x118)); // 0x118 M_GlobalShadowSliceIndexToPerLightShadowSliceIndex ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.M_AdditionalLightIndexToShadowParams      = GetEnumList<Vector4>(new IntPtr(p + 0x120)); // 0x120 M_AdditionalLightIndexToShadowParams ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix = GetEnumList<Matrix4x4>(new IntPtr(p + 0x128)); // 0x128 M_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.M_ShadowResolutionRequests                = GetEnumList<ShadowResolutionRequest>(new IntPtr(p + 0x130)); // 0x130 M_ShadowResolutionRequests  ( ModelEnumListType List`1<ShadowResolutionRequest> List`1<ShadowResolutionRequest> List<ShadowResolutionRequest> Pointer )
            value.M_VisibleLightIndexToCameraSquareDistance = GetSingleList(new IntPtr(p + 0x138)); // 0x138 M_VisibleLightIndexToCameraSquareDistance ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_SortedShadowResolutionRequests          = GetEnumList<ShadowResolutionRequest>(new IntPtr(p + 0x140)); // 0x140 M_SortedShadowResolutionRequests ( ModelEnumListType ShadowResolutionRequest[] ShadowResolutionRequest[] List<ShadowResolutionRequest> Pointer )
            value.M_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex = GetInt32List(new IntPtr(p + 0x148)); // 0x148 M_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_UnusedAtlasSquareAreas                  = GetEnumList<RectInt>(new IntPtr(p + 0x150)); // 0x150 M_UnusedAtlasSquareAreas    ( ModelEnumListType List`1<RectInt> List`1<RectInt> List<RectInt> Pointer )
            value.M_CreateEmptyShadowmap                    = GetBool(new IntPtr(p + 0x158)); // 0x158 M_CreateEmptyShadowmap      ( ModelPrimitiveType bool bool bool Bool )
            value.RenderTargetWidth                         = GetInt32(new IntPtr(p + 0x15C)); // 0x15C RenderTargetWidth           ( ModelPrimitiveType int int int Int32 )
            value.RenderTargetHeight                        = GetInt32(new IntPtr(p + 0x160)); // 0x160 RenderTargetHeight          ( ModelPrimitiveType int int int Int32 )
            value.M_ProfilingSetupSampler                   = GetObject<ProfilingSampler>(new IntPtr(p + 0x168), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x168 M_ProfilingSetupSampler     ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )

            return value;
        }
    }
}
