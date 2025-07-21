using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 PropertyBlock                            ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 030 PassIndexDBuffer                         ModelPrimitiveType int int int Int32
    // 034 PassIndexEmissive                        ModelPrimitiveType int int int Int32
    // 038 PassIndexScreenSpace                     ModelPrimitiveType int int int Int32
    // 03C PassIndexGBuffer                         ModelPrimitiveType int int int Int32
    // 040 DrawOrder                                ModelPrimitiveType int int int Int32
    // 044 IsCreated                                ModelPrimitiveType bool bool bool Bool
    // 048 decalToWorlds                            NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 058 normalToWorlds                           NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 068 sizeOffsets                              NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 078 drawDistances                            NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 088 angleFades                               NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 098 uvScaleBias                              NativeArray`1<float4> IL2CPP_TYPE_GENERICINST
    // 0A8 layerMasks                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0B8 sceneLayerMasks                          NativeArray`1<ulong> IL2CPP_TYPE_GENERICINST
    // 0C8 fadeFactors                              NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0D8 boundingSpheres                          NativeArray`1<BoundingSphere> IL2CPP_TYPE_GENERICINST
    // 0E8 scaleModes                               NativeArray`1<DecalScaleMode> IL2CPP_TYPE_GENERICINST
    // 0F8 renderingLayerMasks                      NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 108 positions                                NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 118 rotation                                 NativeArray`1<quaternion> IL2CPP_TYPE_GENERICINST
    // 128 scales                                   NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 138 dirty                                    NativeArray`1<bool> IL2CPP_TYPE_GENERICINST
    // 148 BoundingSphereArray                      ModelEnumListType BoundingSphere[] BoundingSphere[] List<BoundingSphere> Pointer
    public partial class DecalCachedChunk : DataModel
    {
        public MaterialPropertyBlock?                   PropertyBlock                           { get; set; }
        public int                                      PassIndexDBuffer                        { get; set; }
        public int                                      PassIndexEmissive                       { get; set; }
        public int                                      PassIndexScreenSpace                    { get; set; }
        public int                                      PassIndexGBuffer                        { get; set; }
        public int                                      DrawOrder                               { get; set; }
        public bool                                     IsCreated                               { get; set; }
        public List<BoundingSphere>?                    BoundingSphereArray                     { get; set; }

        public static DecalCachedChunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalCachedChunk() { Pointer= p0 };

            value.PropertyBlock                             = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x028), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x28 PropertyBlock               ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.PassIndexDBuffer                          = GetInt32(new IntPtr(p + 0x030)); // 0x30 PassIndexDBuffer            ( ModelPrimitiveType int int int Int32 )
            value.PassIndexEmissive                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 PassIndexEmissive           ( ModelPrimitiveType int int int Int32 )
            value.PassIndexScreenSpace                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 PassIndexScreenSpace        ( ModelPrimitiveType int int int Int32 )
            value.PassIndexGBuffer                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C PassIndexGBuffer            ( ModelPrimitiveType int int int Int32 )
            value.DrawOrder                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 DrawOrder                   ( ModelPrimitiveType int int int Int32 )
            value.IsCreated                                 = GetBool(new IntPtr(p + 0x044)); // 0x44 IsCreated                   ( ModelPrimitiveType bool bool bool Bool )
            value.BoundingSphereArray                       = GetEnumList<BoundingSphere>(new IntPtr(p + 0x148)); // 0x148 BoundingSphereArray         ( ModelEnumListType BoundingSphere[] BoundingSphere[] List<BoundingSphere> Pointer )

            return value;
        }
    }
}
