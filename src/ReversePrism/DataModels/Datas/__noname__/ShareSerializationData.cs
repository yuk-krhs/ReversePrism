using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 MeshType                                 ModelEnumType MeshType MeshType MeshType Int32
    // 01C IsBoneCloth                              ModelPrimitiveType bool bool bool Bool
    // 020 referenceIndices                         SerializationData<int> IL2CPP_TYPE_GENERICINST
    // 028 attributes                               SerializationData<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 030 localPositions                           SerializationData<float3> IL2CPP_TYPE_GENERICINST
    // 038 localNormals                             SerializationData<float3> IL2CPP_TYPE_GENERICINST
    // 040 localTangents                            SerializationData<float3> IL2CPP_TYPE_GENERICINST
    // 048 uv                                       SerializationData<float2> IL2CPP_TYPE_GENERICINST
    // 050 boneWeights                              SerializationData<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    // 058 triangles                                SerializationData<int3> IL2CPP_TYPE_GENERICINST
    // 060 lines                                    SerializationData<int2> IL2CPP_TYPE_GENERICINST
    // 068 CenterTransformIndex                     ModelPrimitiveType int int int Int32
    // 06C InitLocalToWorld                         ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0AC InitWorldToLocal                         ModelEnumType float4x4 float4x4 float4x4 Int32
    // 0EC InitRotation                             ModelEnumType quaternion quaternion quaternion Int32
    // 0FC InitInverseRotation                      ModelEnumType quaternion quaternion quaternion Int32
    // 10C InitScale                                ModelEnumType float3 float3 float3 Int32
    // 118 SkinRootIndex                            ModelPrimitiveType int int int Int32
    // 120 skinBoneTransformIndices                 SerializationData<int> IL2CPP_TYPE_GENERICINST
    // 128 skinBoneBindPoses                        SerializationData<float4x4> IL2CPP_TYPE_GENERICINST
    // 130 TransformData                            ModelClassType ShareSerializationData ShareSerializationData ShareSerializationData Pointer
    // 138 BoundingBox                              ModelEnumType AABB AABB AABB Int32
    // 150 AverageVertexDistance                    ModelPrimitiveType float float float Single
    // 154 MaxVertexDistance                        ModelPrimitiveType float float float Single
    // 158 VertexToTriangles                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 160 VertexToVertexIndexArray                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 168 VertexToVertexDataArray                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 170 Edges                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 178 EdgeFlags                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 180 EdgeToTrianglesKeys                      ModelEnumListType int2[] int2[] List<int2> Pointer
    // 188 EdgeToTrianglesValues                    ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 190 VertexBindPosePositions                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 198 VertexBindPoseRotations                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1A0 VertexToTransformRotations               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1A8 VertexDepths                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1B0 VertexRootIndices                        ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1B8 VertexParentIndices                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1C0 VertexChildIndexArray                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1C8 VertexChildDataArray                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1D0 VertexLocalPositions                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1D8 VertexLocalRotations                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1E0 NormalAdjustmentRotations                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1E8 BaseLineFlags                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1F0 BaseLineStartDataIndices                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 1F8 BaseLineDataCounts                       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 200 BaseLineData                             ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 208 CustomSkinningBoneIndices                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 210 CenterFixedList                          ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 218 LocalCenterPosition                      ModelEnumType float3 float3 float3 Int32
    // 224 CenterWorldPosition                      ModelEnumType float3 float3 float3 Int32
    // 230 CenterWorldRotation                      ModelEnumType quaternion quaternion quaternion Int32
    // 240 CenterWorldScale                         ModelEnumType float3 float3 float3 Int32
    // 24C ToProxyMatrix                            ModelEnumType float4x4 float4x4 float4x4 Int32
    // 28C ToProxyRotation                          ModelEnumType quaternion quaternion quaternion Int32
    public partial class ShareSerializationData : DataModel
    {
        public string                                   Name                                    { get; set; }
        public MeshType                                 MeshType                                { get; set; }
        public bool                                     IsBoneCloth                             { get; set; }
        public int                                      CenterTransformIndex                    { get; set; }
        public float4x4                                 InitLocalToWorld                        { get; set; }
        public float4x4                                 InitWorldToLocal                        { get; set; }
        public quaternion                               InitRotation                            { get; set; }
        public quaternion                               InitInverseRotation                     { get; set; }
        public float3                                   InitScale                               { get; set; }
        public int                                      SkinRootIndex                           { get; set; }
        public ShareSerializationData?                  TransformData                           { get; set; }
        public AABB                                     BoundingBox                             { get; set; }
        public float                                    AverageVertexDistance                   { get; set; }
        public float                                    MaxVertexDistance                       { get; set; }
        public List<sbyte>?                             VertexToTriangles                       { get; set; }
        public List<sbyte>?                             VertexToVertexIndexArray                { get; set; }
        public List<sbyte>?                             VertexToVertexDataArray                 { get; set; }
        public List<sbyte>?                             Edges                                   { get; set; }
        public List<sbyte>?                             EdgeFlags                               { get; set; }
        public List<int2>?                              EdgeToTrianglesKeys                     { get; set; }
        public List<ushort>?                            EdgeToTrianglesValues                   { get; set; }
        public List<sbyte>?                             VertexBindPosePositions                 { get; set; }
        public List<sbyte>?                             VertexBindPoseRotations                 { get; set; }
        public List<sbyte>?                             VertexToTransformRotations              { get; set; }
        public List<sbyte>?                             VertexDepths                            { get; set; }
        public List<sbyte>?                             VertexRootIndices                       { get; set; }
        public List<sbyte>?                             VertexParentIndices                     { get; set; }
        public List<sbyte>?                             VertexChildIndexArray                   { get; set; }
        public List<sbyte>?                             VertexChildDataArray                    { get; set; }
        public List<sbyte>?                             VertexLocalPositions                    { get; set; }
        public List<sbyte>?                             VertexLocalRotations                    { get; set; }
        public List<sbyte>?                             NormalAdjustmentRotations               { get; set; }
        public List<sbyte>?                             BaseLineFlags                           { get; set; }
        public List<sbyte>?                             BaseLineStartDataIndices                { get; set; }
        public List<sbyte>?                             BaseLineDataCounts                      { get; set; }
        public List<sbyte>?                             BaseLineData                            { get; set; }
        public List<int>?                               CustomSkinningBoneIndices               { get; set; }
        public List<ushort>?                            CenterFixedList                         { get; set; }
        public float3                                   LocalCenterPosition                     { get; set; }
        public float3                                   CenterWorldPosition                     { get; set; }
        public quaternion                               CenterWorldRotation                     { get; set; }
        public float3                                   CenterWorldScale                        { get; set; }
        public float4x4                                 ToProxyMatrix                           { get; set; }
        public quaternion                               ToProxyRotation                         { get; set; }

        public static ShareSerializationData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShareSerializationData() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.MeshType                                  = (MeshType)GetInt32(new IntPtr(p + 0x018)); // 0x18 MeshType                    ( ModelEnumType MeshType MeshType MeshType Int32 )
            value.IsBoneCloth                               = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsBoneCloth                 ( ModelPrimitiveType bool bool bool Bool )
            value.CenterTransformIndex                      = GetInt32(new IntPtr(p + 0x068)); // 0x68 CenterTransformIndex        ( ModelPrimitiveType int int int Int32 )
            value.InitLocalToWorld                          = (float4x4)GetInt32(new IntPtr(p + 0x06C)); // 0x6C InitLocalToWorld            ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.InitWorldToLocal                          = (float4x4)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC InitWorldToLocal            ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.InitRotation                              = (quaternion)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC InitRotation                ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.InitInverseRotation                       = (quaternion)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC InitInverseRotation         ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.InitScale                                 = (float3)GetInt32(new IntPtr(p + 0x10C)); // 0x10C InitScale                   ( ModelEnumType float3 float3 float3 Int32 )
            value.SkinRootIndex                             = GetInt32(new IntPtr(p + 0x118)); // 0x118 SkinRootIndex               ( ModelPrimitiveType int int int Int32 )
            value.TransformData                             = GetObject<ShareSerializationData>(new IntPtr(p + 0x130), ReversePrism.DataModels.ShareSerializationData.FromPointer); // 0x130 TransformData               ( ModelClassType ShareSerializationData ShareSerializationData ShareSerializationData Pointer )
            value.BoundingBox                               = (AABB)GetInt32(new IntPtr(p + 0x138)); // 0x138 BoundingBox                 ( ModelEnumType AABB AABB AABB Int32 )
            value.AverageVertexDistance                     = GetSingle(new IntPtr(p + 0x150)); // 0x150 AverageVertexDistance       ( ModelPrimitiveType float float float Single )
            value.MaxVertexDistance                         = GetSingle(new IntPtr(p + 0x154)); // 0x154 MaxVertexDistance           ( ModelPrimitiveType float float float Single )
            value.VertexToTriangles                         = GetSByteList(new IntPtr(p + 0x158)); // 0x158 VertexToTriangles           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexToVertexIndexArray                  = GetSByteList(new IntPtr(p + 0x160)); // 0x160 VertexToVertexIndexArray    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexToVertexDataArray                   = GetSByteList(new IntPtr(p + 0x168)); // 0x168 VertexToVertexDataArray     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Edges                                     = GetSByteList(new IntPtr(p + 0x170)); // 0x170 Edges                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.EdgeFlags                                 = GetSByteList(new IntPtr(p + 0x178)); // 0x178 EdgeFlags                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.EdgeToTrianglesKeys                       = GetEnumList<int2>(new IntPtr(p + 0x180)); // 0x180 EdgeToTrianglesKeys         ( ModelEnumListType int2[] int2[] List<int2> Pointer )
            value.EdgeToTrianglesValues                     = GetUInt16List(new IntPtr(p + 0x188)); // 0x188 EdgeToTrianglesValues       ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.VertexBindPosePositions                   = GetSByteList(new IntPtr(p + 0x190)); // 0x190 VertexBindPosePositions     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexBindPoseRotations                   = GetSByteList(new IntPtr(p + 0x198)); // 0x198 VertexBindPoseRotations     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexToTransformRotations                = GetSByteList(new IntPtr(p + 0x1A0)); // 0x1A0 VertexToTransformRotations  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexDepths                              = GetSByteList(new IntPtr(p + 0x1A8)); // 0x1A8 VertexDepths                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexRootIndices                         = GetSByteList(new IntPtr(p + 0x1B0)); // 0x1B0 VertexRootIndices           ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexParentIndices                       = GetSByteList(new IntPtr(p + 0x1B8)); // 0x1B8 VertexParentIndices         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexChildIndexArray                     = GetSByteList(new IntPtr(p + 0x1C0)); // 0x1C0 VertexChildIndexArray       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexChildDataArray                      = GetSByteList(new IntPtr(p + 0x1C8)); // 0x1C8 VertexChildDataArray        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexLocalPositions                      = GetSByteList(new IntPtr(p + 0x1D0)); // 0x1D0 VertexLocalPositions        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.VertexLocalRotations                      = GetSByteList(new IntPtr(p + 0x1D8)); // 0x1D8 VertexLocalRotations        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.NormalAdjustmentRotations                 = GetSByteList(new IntPtr(p + 0x1E0)); // 0x1E0 NormalAdjustmentRotations   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BaseLineFlags                             = GetSByteList(new IntPtr(p + 0x1E8)); // 0x1E8 BaseLineFlags               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BaseLineStartDataIndices                  = GetSByteList(new IntPtr(p + 0x1F0)); // 0x1F0 BaseLineStartDataIndices    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BaseLineDataCounts                        = GetSByteList(new IntPtr(p + 0x1F8)); // 0x1F8 BaseLineDataCounts          ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BaseLineData                              = GetSByteList(new IntPtr(p + 0x200)); // 0x200 BaseLineData                ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.CustomSkinningBoneIndices                 = GetInt32List(new IntPtr(p + 0x208)); // 0x208 CustomSkinningBoneIndices   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CenterFixedList                           = GetUInt16List(new IntPtr(p + 0x210)); // 0x210 CenterFixedList             ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.LocalCenterPosition                       = (float3)GetInt32(new IntPtr(p + 0x218)); // 0x218 LocalCenterPosition         ( ModelEnumType float3 float3 float3 Int32 )
            value.CenterWorldPosition                       = (float3)GetInt32(new IntPtr(p + 0x224)); // 0x224 CenterWorldPosition         ( ModelEnumType float3 float3 float3 Int32 )
            value.CenterWorldRotation                       = (quaternion)GetInt32(new IntPtr(p + 0x230)); // 0x230 CenterWorldRotation         ( ModelEnumType quaternion quaternion quaternion Int32 )
            value.CenterWorldScale                          = (float3)GetInt32(new IntPtr(p + 0x240)); // 0x240 CenterWorldScale            ( ModelEnumType float3 float3 float3 Int32 )
            value.ToProxyMatrix                             = (float4x4)GetInt32(new IntPtr(p + 0x24C)); // 0x24C ToProxyMatrix               ( ModelEnumType float4x4 float4x4 float4x4 Int32 )
            value.ToProxyRotation                           = (quaternion)GetInt32(new IntPtr(p + 0x28C)); // 0x28C ToProxyRotation             ( ModelEnumType quaternion quaternion quaternion Int32 )

            return value;
        }
    }
}
