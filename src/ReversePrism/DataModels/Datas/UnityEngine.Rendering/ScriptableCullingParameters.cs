using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsOrthographic                         ModelPrimitiveType int int int Int32
    // 014 M_LODParameters                          ModelEnumType LODParameters LODParameters LODParameters Int32
    // 000 k_MaximumCullingPlaneCount               int IL2CPP_TYPE_I4
    // 000 maximumCullingPlaneCount                 int IL2CPP_TYPE_I4
    // 030 M_CullingPlanes                          ModelEnumType <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer Int32
    // 0D0 M_CullingPlaneCount                      ModelPrimitiveType int int int Int32
    // 0D4 M_CullingMask                            ModelPrimitiveType uint uint uint UInt32
    // 0D8 M_SceneMask                              ModelPrimitiveType ulong ulong ulong UInt64
    // 0E0 M_ViewID                                 ModelPrimitiveType ulong ulong ulong UInt64
    // 000 k_LayerCount                             int IL2CPP_TYPE_I4
    // 004 layerCount                               int IL2CPP_TYPE_I4
    // 0E8 M_LayerFarCullDistances                  ModelEnumType <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer Int32
    // 168 M_LayerCull                              ModelPrimitiveType int int int Int32
    // 16C M_CullingMatrix                          ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 1AC M_Origin                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1B8 M_ShadowDistance                         ModelPrimitiveType float float float Single
    // 1BC M_ShadowNearPlaneOffset                  ModelPrimitiveType float float float Single
    // 1C0 M_CullingOptions                         ModelEnumType CullingOptions CullingOptions CullingOptions Int32
    // 1C4 M_ReflectionProbeSortingCriteria         ModelEnumType ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria Int32
    // 1C8 M_CameraProperties                       ModelEnumType CameraProperties CameraProperties CameraProperties Int32
    // 5A8 M_AccurateOcclusionThreshold             ModelPrimitiveType float float float Single
    // 5AC M_MaximumPortalCullingJobs               ModelPrimitiveType int int int Int32
    // 000 k_CullingJobCountLowerLimit              int IL2CPP_TYPE_I4
    // 000 k_CullingJobCountUpperLimit              int IL2CPP_TYPE_I4
    // 5B0 M_StereoViewMatrix                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 5F0 M_StereoProjectionMatrix                 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 630 M_StereoSeparationDistance               ModelPrimitiveType float float float Single
    // 634 M_maximumVisibleLights                   ModelPrimitiveType int int int Int32
    // 638 M_ConservativeEnclosingSphere            ModelPrimitiveType bool bool bool Bool
    // 63C M_NumIterationsEnclosingSphere           ModelPrimitiveType int int int Int32
    public partial class ScriptableCullingParameters : DataModel
    {
        public int                                      M_IsOrthographic                        { get; set; }
        public LODParameters                            M_LODParameters                         { get; set; }
        public <m_CullingPlanes>e__FixedBuffer          M_CullingPlanes                         { get; set; }
        public int                                      M_CullingPlaneCount                     { get; set; }
        public uint                                     M_CullingMask                           { get; set; }
        public ulong                                    M_SceneMask                             { get; set; }
        public ulong                                    M_ViewID                                { get; set; }
        public <m_LayerFarCullDistances>e__FixedBuffer  M_LayerFarCullDistances                 { get; set; }
        public int                                      M_LayerCull                             { get; set; }
        public Matrix4x4                                M_CullingMatrix                         { get; set; }
        public Vector3                                  M_Origin                                { get; set; }
        public float                                    M_ShadowDistance                        { get; set; }
        public float                                    M_ShadowNearPlaneOffset                 { get; set; }
        public CullingOptions                           M_CullingOptions                        { get; set; }
        public ReflectionProbeSortingCriteria           M_ReflectionProbeSortingCriteria        { get; set; }
        public CameraProperties                         M_CameraProperties                      { get; set; }
        public float                                    M_AccurateOcclusionThreshold            { get; set; }
        public int                                      M_MaximumPortalCullingJobs              { get; set; }
        public Matrix4x4                                M_StereoViewMatrix                      { get; set; }
        public Matrix4x4                                M_StereoProjectionMatrix                { get; set; }
        public float                                    M_StereoSeparationDistance              { get; set; }
        public int                                      M_maximumVisibleLights                  { get; set; }
        public bool                                     M_ConservativeEnclosingSphere           { get; set; }
        public int                                      M_NumIterationsEnclosingSphere          { get; set; }

        public static ScriptableCullingParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptableCullingParameters() { Pointer= p0 };

            value.M_IsOrthographic                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_IsOrthographic            ( ModelPrimitiveType int int int Int32 )
            value.M_LODParameters                           = (LODParameters)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_LODParameters             ( ModelEnumType LODParameters LODParameters LODParameters Int32 )
            value.M_CullingPlanes                           = (<m_CullingPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_CullingPlanes             ( ModelEnumType <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer Int32 )
            value.M_CullingPlaneCount                       = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_CullingPlaneCount         ( ModelPrimitiveType int int int Int32 )
            value.M_CullingMask                             = GetUInt32(new IntPtr(p + 0x0D4)); // 0xD4 M_CullingMask               ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_SceneMask                               = GetUInt64(new IntPtr(p + 0x0D8)); // 0xD8 M_SceneMask                 ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_ViewID                                  = GetUInt64(new IntPtr(p + 0x0E0)); // 0xE0 M_ViewID                    ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_LayerFarCullDistances                   = (<m_LayerFarCullDistances>e__FixedBuffer)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_LayerFarCullDistances     ( ModelEnumType <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer Int32 )
            value.M_LayerCull                               = GetInt32(new IntPtr(p + 0x168)); // 0x168 M_LayerCull                 ( ModelPrimitiveType int int int Int32 )
            value.M_CullingMatrix                           = (Matrix4x4)GetInt32(new IntPtr(p + 0x16C)); // 0x16C M_CullingMatrix             ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_Origin                                  = (Vector3)GetInt32(new IntPtr(p + 0x1AC)); // 0x1AC M_Origin                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_ShadowDistance                          = GetSingle(new IntPtr(p + 0x1B8)); // 0x1B8 M_ShadowDistance            ( ModelPrimitiveType float float float Single )
            value.M_ShadowNearPlaneOffset                   = GetSingle(new IntPtr(p + 0x1BC)); // 0x1BC M_ShadowNearPlaneOffset     ( ModelPrimitiveType float float float Single )
            value.M_CullingOptions                          = (CullingOptions)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 M_CullingOptions            ( ModelEnumType CullingOptions CullingOptions CullingOptions Int32 )
            value.M_ReflectionProbeSortingCriteria          = (ReflectionProbeSortingCriteria)GetInt32(new IntPtr(p + 0x1C4)); // 0x1C4 M_ReflectionProbeSortingCriteria ( ModelEnumType ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria Int32 )
            value.M_CameraProperties                        = (CameraProperties)GetInt32(new IntPtr(p + 0x1C8)); // 0x1C8 M_CameraProperties          ( ModelEnumType CameraProperties CameraProperties CameraProperties Int32 )
            value.M_AccurateOcclusionThreshold              = GetSingle(new IntPtr(p + 0x5A8)); // 0x5A8 M_AccurateOcclusionThreshold ( ModelPrimitiveType float float float Single )
            value.M_MaximumPortalCullingJobs                = GetInt32(new IntPtr(p + 0x5AC)); // 0x5AC M_MaximumPortalCullingJobs  ( ModelPrimitiveType int int int Int32 )
            value.M_StereoViewMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x5B0)); // 0x5B0 M_StereoViewMatrix          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_StereoProjectionMatrix                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x5F0)); // 0x5F0 M_StereoProjectionMatrix    ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_StereoSeparationDistance                = GetSingle(new IntPtr(p + 0x630)); // 0x630 M_StereoSeparationDistance  ( ModelPrimitiveType float float float Single )
            value.M_maximumVisibleLights                    = GetInt32(new IntPtr(p + 0x634)); // 0x634 M_maximumVisibleLights      ( ModelPrimitiveType int int int Int32 )
            value.M_ConservativeEnclosingSphere             = GetBool(new IntPtr(p + 0x638)); // 0x638 M_ConservativeEnclosingSphere ( ModelPrimitiveType bool bool bool Bool )
            value.M_NumIterationsEnclosingSphere            = GetInt32(new IntPtr(p + 0x63C)); // 0x63C M_NumIterationsEnclosingSphere ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
