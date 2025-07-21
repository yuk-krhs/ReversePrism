using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Result                                   ModelEnumType ResultCode ResultCode ResultCode Int32
    // 020 IsManaged                                ModelPrimitiveType bool bool bool Bool
    // 024 MeshType                                 ModelEnumType MeshType MeshType MeshType Int32
    // 028 IsBoneCloth                              ModelPrimitiveType bool bool bool Bool
    // 030 referenceIndices                         ExSimpleNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 038 attributes                               ExSimpleNativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 040 localPositions                           ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 048 localNormals                             ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 050 localTangents                            ExSimpleNativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 058 uv                                       ExSimpleNativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 060 boneWeights                              ExSimpleNativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 068 triangles                                ExSimpleNativeArray`1<int3> IL2CPP_TYPE_GENERICINST
    // 070 lines                                    ExSimpleNativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 078 CenterTransformIndex                     ModelPrimitiveType int int int Int32
    // 07C InitLocalToWorld                         ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0BC InitWorldToLocal                         ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0FC InitRotation                             ModelEnumType quaternion quaternion quaternion Int32
    // 10C InitInverseRotation                      ModelEnumType quaternion quaternion quaternion Int32
    // 11C InitScale                                ModelEnumType float3 float3 float3 Int32
    // 128 SkinRootIndex                            ModelPrimitiveType int int int Int32
    // 130 skinBoneTransformIndices                 ExSimpleNativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 138 skinBoneBindPoses                        ExSimpleNativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 140 TransformData                            ModelClassType TransformData TransformData TransformData Pointer
    // 148 boundingBox                              NativeReference`1<AABB> IL2CPP_TYPE_GENERICINST
    // 158 averageVertexDistance                    NativeReference`1<float> IL2CPP_TYPE_GENERICINST
    // 168 maxVertexDistance                        NativeReference`1<float> IL2CPP_TYPE_GENERICINST
    // 178 MergeChunk                               ModelEnumType DataChunk DataChunk DataChunk Int32
    // 180 joinIndices                              NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 190 vertexToTriangles                        NativeArray`1<FixedList32Bytes`1<uint>> IL2CPP_TYPE_GENERICINST
    // 1A0 vertexToVertexIndexArray                 NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 1B0 vertexToVertexDataArray                  NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 1C0 edges                                    NativeArray`1<int2> IL2CPP_TYPE_GENERICINST
    // 000 EdgeFlag_Cut                             sbyte IL2CPP_TYPE_U1
    // 1D0 edgeFlags                                NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 1E0 edgeToTriangles                          NativeParallelMultiHashMap`2<int2, ushort> IL2CPP_TYPE_GENERICINST
    // 1F0 vertexBindPosePositions                  NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 200 vertexBindPoseRotations                  NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 210 vertexToTransformRotations               NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 220 vertexDepths                             NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 230 vertexRootIndices                        NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 240 vertexParentIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 250 vertexChildIndexArray                    NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 260 vertexChildDataArray                     NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 270 vertexLocalPositions                     NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 280 vertexLocalRotations                     NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 290 normalAdjustmentRotations                NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 000 BaseLineFlag_IncludeLine                 sbyte IL2CPP_TYPE_U1
    // 2A0 baseLineFlags                            NativeArray`1<ExBitFlag8> IL2CPP_TYPE_GENERICINST
    // 2B0 baseLineStartDataIndices                 NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 2C0 baseLineDataCounts                       NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 2D0 baseLineData                             NativeArray`1<ushort> IL2CPP_TYPE_GENERICINST
    // 2E0 CustomSkinningBoneIndices                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 2E8 CenterFixedList                          ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 2F0 localCenterPosition                      NativeReference`1<float3> IL2CPP_TYPE_GENERICINST
    // 300 MappingProxyMesh                         ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer
    // 308 CenterWorldPosition                      ModelEnumType float3 float3 float3 Int32
    // 314 CenterWorldRotation                      ModelEnumType quaternion quaternion quaternion Int32
    // 324 CenterWorldScale                         ModelEnumType float3 float3 float3 Int32
    // 330 ToProxyMatrix                            ModelEnumType float4x4 float4x4 float4x4 Int32
    // 370 ToProxyRotation                          ModelEnumType quaternion quaternion quaternion Int32
    // 380 MappingId                                ModelPrimitiveType int int int Int32
    public partial class VirtualMesh : DataModel
    {
        public string                                   Name                                    { get; set; }
        public ResultCode                               Result                                  { get; set; }
        public bool                                     IsManaged                               { get; set; }
        public MeshType                                 MeshType                                { get; set; }
        public bool                                     IsBoneCloth                             { get; set; }
        public int                                      CenterTransformIndex                    { get; set; }
        public float4x4                                 InitLocalToWorld                        { get; set; }
        public float4x4                                 InitWorldToLocal                        { get; set; }
        public quaternion                               InitRotation                            { get; set; }
        public quaternion                               InitInverseRotation                     { get; set; }
        public float3                                   InitScale                               { get; set; }
        public int                                      SkinRootIndex                           { get; set; }
        public TransformData?                           TransformData                           { get; set; }
        public DataChunk                                MergeChunk                              { get; set; }
        public List<int>?                               CustomSkinningBoneIndices               { get; set; }
        public List<ushort>?                            CenterFixedList                         { get; set; }
        public VirtualMesh?                             MappingProxyMesh                        { get; set; }
        public float3                                   CenterWorldPosition                     { get; set; }
        public quaternion                               CenterWorldRotation                     { get; set; }
        public float3                                   CenterWorldScale                        { get; set; }
        public float4x4                                 ToProxyMatrix                           { get; set; }
        public quaternion                               ToProxyRotation                         { get; set; }
        public int                                      MappingId                               { get; set; }

        public static VirtualMesh? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMesh() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Result                                    = (ResultCode)GetInt32(new IntPtr(p + 0x018)); // 0x18 Result                      ( ModelEnumType ResultCode ResultCode ResultCode Int32 )
            value.IsManaged                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsManaged                   ( ModelPrimitiveType bool bool bool Bool )
            value.MeshType                                  = (MeshType)GetInt32(new IntPtr(p + 0x024)); // 0x24 MeshType                    ( ModelEnumType MeshType MeshType MeshType Int32 )
            value.IsBoneCloth                               = GetBool(new IntPtr(p + 0x028)); // 0x28 IsBoneCloth                 ( ModelPrimitiveType bool bool bool Bool )
            value.CenterTransformIndex                      = GetInt32(new IntPtr(p + 0x078)); // 0x78 CenterTransformIndex        ( ModelPrimitiveType int int int Int32 )
            value.InitLocalToWorld                          = (float4x4)GetInt32(new IntPtr(p + 0x07C)); // 0x7C InitLocalToWorld            ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.InitWorldToLocal                          = (float4x4)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC InitWorldToLocal            ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.InitRotation                              = (quaternion)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC InitRotation                ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.InitInverseRotation                       = (quaternion)GetInt32(new IntPtr(p + 0x10C)); // 0x10C InitInverseRotation         ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.InitScale                                 = (float3)GetInt32(new IntPtr(p + 0x11C)); // 0x11C InitScale                   ( ModelEnumType float3 float3 float3 Int32 )
            value.SkinRootIndex                             = GetInt32(new IntPtr(p + 0x128)); // 0x128 SkinRootIndex               ( ModelPrimitiveType int int int Int32 )
            value.TransformData                             = GetObject<TransformData>(new IntPtr(p + 0x140), ReversePrism.DataModels.TransformData.FromPointer); // 0x140 TransformData               ( ModelClassType TransformData TransformData TransformData Pointer )
            value.MergeChunk                                = (DataChunk)GetInt32(new IntPtr(p + 0x178)); // 0x178 MergeChunk                  ( ModelEnumType DataChunk DataChunk DataChunk Int32 )
            value.CustomSkinningBoneIndices                 = GetInt32List(new IntPtr(p + 0x2E0)); // 0x2E0 CustomSkinningBoneIndices   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CenterFixedList                           = GetUInt16List(new IntPtr(p + 0x2E8)); // 0x2E8 CenterFixedList             ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.MappingProxyMesh                          = GetObject<VirtualMesh>(new IntPtr(p + 0x300), ReversePrism.DataModels.VirtualMesh.FromPointer); // 0x300 MappingProxyMesh            ( ModelClassType VirtualMesh VirtualMesh VirtualMesh Pointer )
            value.CenterWorldPosition                       = (float3)GetInt32(new IntPtr(p + 0x308)); // 0x308 CenterWorldPosition         ( ModelEnumType float3 float3 float3 Int32 )
            value.CenterWorldRotation                       = (quaternion)GetInt32(new IntPtr(p + 0x314)); // 0x314 CenterWorldRotation         ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.CenterWorldScale                          = (float3)GetInt32(new IntPtr(p + 0x324)); // 0x324 CenterWorldScale            ( ModelEnumType float3 float3 float3 Int32 )
            value.ToProxyMatrix                             = (float4x4)GetInt32(new IntPtr(p + 0x330)); // 0x330 ToProxyMatrix               ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.ToProxyRotation                           = (quaternion)GetInt32(new IntPtr(p + 0x370)); // 0x370 ToProxyRotation             ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.MappingId                                 = GetInt32(new IntPtr(p + 0x380)); // 0x380 MappingId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
