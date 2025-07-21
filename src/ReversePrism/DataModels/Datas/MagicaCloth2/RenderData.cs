using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReferenceCount                           ModelPrimitiveType int int int Int32
    // 018 useProcessSet                            HashSet`1<ClothProcess> IL2CPP_TYPE_GENERICINST
    // 020 IsSkipWriting                            ModelPrimitiveType bool bool bool Bool
    // 028 SetupData                                ModelClassType RenderSetupData RenderSetupData RenderSetupData Pointer
    // 030 PreBuildUniqueSerializeData              ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer
    // 038 OriginalMesh                             ModelClassType Mesh Mesh Mesh Pointer
    // 040 SkinnedMeshRendere                       ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 048 MeshFilter                               ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 050 TransformList                            ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    // 058 CustomMesh                               ModelClassType Mesh Mesh Mesh Pointer
    // 060 localPositions                           NativeArray`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 070 localNormals                             NativeArray`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 080 boneWeights                              NativeArray`1<BoneWeight> IL2CPP_TYPE_GENERICINST
    // 090 CenterBoneWeight                         ModelEnumType BoneWeight BoneWeight BoneWeight Int32
    // 000 Flag_UseCustomMesh                       int IL2CPP_TYPE_I4
    // 000 Flag_ChangePositionNormal                int IL2CPP_TYPE_I4
    // 000 Flag_ChangeBoneWeight                    int IL2CPP_TYPE_I4
    // 000 Flag_ModifyBoneWeight                    int IL2CPP_TYPE_I4
    // 0B0 Flag                                     ModelEnumType BitField32 BitField32 BitField32 Int32
    public partial class RenderData : DataModel
    {
        public int                                      ReferenceCount                          { get; set; }
        public bool                                     IsSkipWriting                           { get; set; }
        public RenderSetupData?                         SetupData                               { get; set; }
        public UniqueSerializationData?                 PreBuildUniqueSerializeData             { get; set; }
        public Mesh?                                    OriginalMesh                            { get; set; }
        public SkinnedMeshRenderer?                     SkinnedMeshRendere                      { get; set; }
        public MeshFilter?                              MeshFilter                              { get; set; }
        public List<Transform>?                         TransformList                           { get; set; }
        public Mesh?                                    CustomMesh                              { get; set; }
        public BoneWeight                               CenterBoneWeight                        { get; set; }
        public BitField32                               Flag                                    { get; set; }

        public static RenderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderData() { Pointer= p0 };

            value.ReferenceCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 ReferenceCount              ( ModelPrimitiveType int int int Int32 )
            value.IsSkipWriting                             = GetBool(new IntPtr(p + 0x020)); // 0x20 IsSkipWriting               ( ModelPrimitiveType bool bool bool Bool )
            value.SetupData                                 = GetObject<RenderSetupData>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderSetupData.FromPointer); // 0x28 SetupData                   ( ModelClassType RenderSetupData RenderSetupData RenderSetupData Pointer )
            value.PreBuildUniqueSerializeData               = GetObject<UniqueSerializationData>(new IntPtr(p + 0x030), ReversePrism.DataModels.UniqueSerializationData.FromPointer); // 0x30 PreBuildUniqueSerializeData ( ModelClassType UniqueSerializationData UniqueSerializationData UniqueSerializationData Pointer )
            value.OriginalMesh                              = GetObject<Mesh>(new IntPtr(p + 0x038), ReversePrism.DataModels.Mesh.FromPointer); // 0x38 OriginalMesh                ( ModelClassType Mesh Mesh Mesh Pointer )
            value.SkinnedMeshRendere                        = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x040), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 0x40 SkinnedMeshRendere          ( ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.MeshFilter                                = GetObject<MeshFilter>(new IntPtr(p + 0x048), ReversePrism.DataModels.MeshFilter.FromPointer); // 0x48 MeshFilter                  ( ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.TransformList                             = GetObjectList<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 TransformList               ( ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )
            value.CustomMesh                                = GetObject<Mesh>(new IntPtr(p + 0x058), ReversePrism.DataModels.Mesh.FromPointer); // 0x58 CustomMesh                  ( ModelClassType Mesh Mesh Mesh Pointer )
            value.CenterBoneWeight                          = (BoneWeight)GetInt32(new IntPtr(p + 0x090)); // 0x90 CenterBoneWeight            ( ModelEnumType BoneWeight BoneWeight BoneWeight Int32 )
            value.Flag                                      = (BitField32)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Flag                        ( ModelEnumType BitField32 BitField32 BitField32 Int32 )

            return value;
        }
    }
}
