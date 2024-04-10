using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsOrthographic                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_LODParameters                          000186604C50 ModelEnumType LODParameters LODParameters LODParameters Int32
    // 000 maximumCullingPlaneCount                 int IL2CPP_TYPE_I4
    // 030 M_CullingPlanes                          000186737080 ModelEnumType <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer Int32
    // 0D0 M_CullingPlaneCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D4 M_CullingMask                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 0D8 M_SceneMask                              00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 0E0 M_ViewID                                 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 004 layerCount                               int IL2CPP_TYPE_I4
    // 0E8 M_LayerFarCullDistances                  000186737560 ModelEnumType <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer Int32
    // 168 M_LayerCull                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 16C M_CullingMatrix                          00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 1AC M_Origin                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1B8 M_ShadowDistance                         0001866656B0 ModelPrimitiveType float float float Single
    // 1BC M_ShadowNearPlaneOffset                  0001866656B0 ModelPrimitiveType float float float Single
    // 1C0 M_CullingOptions                         000186664F50 ModelEnumType CullingOptions CullingOptions CullingOptions Int32
    // 1C4 M_ReflectionProbeSortingCriteria         000186638710 ModelEnumType ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria Int32
    // 1C8 M_CameraProperties                       000186537B80 ModelEnumType CameraProperties CameraProperties CameraProperties Int32
    // 5A8 M_AccurateOcclusionThreshold             0001866656B0 ModelPrimitiveType float float float Single
    // 5AC M_MaximumPortalCullingJobs               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 5B0 M_StereoViewMatrix                       00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 5F0 M_StereoProjectionMatrix                 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 630 M_StereoSeparationDistance               0001866656B0 ModelPrimitiveType float float float Single
    // 634 M_maximumVisibleLights                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 638 M_ConservativeEnclosingSphere            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 63C M_NumIterationsEnclosingSphere           0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.M_IsOrthographic                          = GetInt32(new IntPtr(p + 0x010)); // 0245A24748E0 0x10 M_IsOrthographic            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_LODParameters                           = (LODParameters)GetInt32(new IntPtr(p + 0x014)); // 0245A2474900 0x14 M_LODParameters             ( 000186604C50 ModelEnumType LODParameters LODParameters LODParameters Int32 )
            value.M_CullingPlanes                           = (<m_CullingPlanes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0245A2474940 0x30 M_CullingPlanes             ( 000186737080 ModelEnumType <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer <m_CullingPlanes>e__FixedBuffer Int32 )
            value.M_CullingPlaneCount                       = GetInt32(new IntPtr(p + 0x0D0)); // 0245A2474960 0xD0 M_CullingPlaneCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CullingMask                             = GetUInt32(new IntPtr(p + 0x0D4)); // 0245A2474980 0xD4 M_CullingMask               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_SceneMask                               = GetUInt64(new IntPtr(p + 0x0D8)); // 0245A24749A0 0xD8 M_SceneMask                 ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_ViewID                                  = GetUInt64(new IntPtr(p + 0x0E0)); // 0245A24749C0 0xE0 M_ViewID                    ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_LayerFarCullDistances                   = (<m_LayerFarCullDistances>e__FixedBuffer)GetInt32(new IntPtr(p + 0x0E8)); // 0245A2474A00 0xE8 M_LayerFarCullDistances     ( 000186737560 ModelEnumType <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer <m_LayerFarCullDistances>e__FixedBuffer Int32 )
            value.M_LayerCull                               = GetInt32(new IntPtr(p + 0x168)); // 0245A2474A20 0x168 M_LayerCull                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CullingMatrix                           = (Matrix4x4)GetInt32(new IntPtr(p + 0x16C)); // 0245A2474A40 0x16C M_CullingMatrix             ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_Origin                                  = (Vector3)GetInt32(new IntPtr(p + 0x1AC)); // 0245A2474A60 0x1AC M_Origin                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_ShadowDistance                          = GetSingle(new IntPtr(p + 0x1B8)); // 0245A2474A80 0x1B8 M_ShadowDistance            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ShadowNearPlaneOffset                   = GetSingle(new IntPtr(p + 0x1BC)); // 0245A2474AA0 0x1BC M_ShadowNearPlaneOffset     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CullingOptions                          = (CullingOptions)GetInt32(new IntPtr(p + 0x1C0)); // 0245A2474AC0 0x1C0 M_CullingOptions            ( 000186664F50 ModelEnumType CullingOptions CullingOptions CullingOptions Int32 )
            value.M_ReflectionProbeSortingCriteria          = (ReflectionProbeSortingCriteria)GetInt32(new IntPtr(p + 0x1C4)); // 0245A2474AE0 0x1C4 M_ReflectionProbeSortingCriteria ( 000186638710 ModelEnumType ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria ReflectionProbeSortingCriteria Int32 )
            value.M_CameraProperties                        = (CameraProperties)GetInt32(new IntPtr(p + 0x1C8)); // 0245A2474B00 0x1C8 M_CameraProperties          ( 000186537B80 ModelEnumType CameraProperties CameraProperties CameraProperties Int32 )
            value.M_AccurateOcclusionThreshold              = GetSingle(new IntPtr(p + 0x5A8)); // 0245A2474B20 0x5A8 M_AccurateOcclusionThreshold ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MaximumPortalCullingJobs                = GetInt32(new IntPtr(p + 0x5AC)); // 0245A2474B40 0x5AC M_MaximumPortalCullingJobs  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_StereoViewMatrix                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x5B0)); // 0245A2474B60 0x5B0 M_StereoViewMatrix          ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_StereoProjectionMatrix                  = (Matrix4x4)GetInt32(new IntPtr(p + 0x5F0)); // 0245A2474B80 0x5F0 M_StereoProjectionMatrix    ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_StereoSeparationDistance                = GetSingle(new IntPtr(p + 0x630)); // 0245A2474BA0 0x630 M_StereoSeparationDistance  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_maximumVisibleLights                    = GetInt32(new IntPtr(p + 0x634)); // 0245A2474BC0 0x634 M_maximumVisibleLights      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ConservativeEnclosingSphere             = GetBool(new IntPtr(p + 0x638)); // 0245A2474BE0 0x638 M_ConservativeEnclosingSphere ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_NumIterationsEnclosingSphere            = GetInt32(new IntPtr(p + 0x63C)); // 0245A2474C00 0x63C M_NumIterationsEnclosingSphere ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
