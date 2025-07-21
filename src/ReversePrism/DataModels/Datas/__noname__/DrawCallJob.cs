using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 decalToWorlds                            NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 020 normalToWorlds                           NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 030 sizeOffsets                              NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 040 drawDistances                            NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 050 angleFades                               NativeArray`1<float2> IL2CPP_TYPE_GENERICINST
    // 060 uvScaleBiases                            NativeArray`1<float4> IL2CPP_TYPE_GENERICINST
    // 070 layerMasks                               NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 080 sceneLayerMasks                          NativeArray`1<ulong> IL2CPP_TYPE_GENERICINST
    // 090 fadeFactors                              NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 0A0 boundingSpheres                          NativeArray`1<BoundingSphere> IL2CPP_TYPE_GENERICINST
    // 0B0 renderingLayerMasks                      NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0C0 CameraPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0D0 SceneCullingMask                         ModelPrimitiveType ulong ulong ulong UInt64
    // 0D8 CullingMask                              ModelPrimitiveType int int int Int32
    // 0E0 visibleDecalIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 0F0 VisibleDecalCount                        ModelPrimitiveType int int int Int32
    // 0F4 MaxDrawDistance                          ModelPrimitiveType float float float Single
    // 0F8 decalToWorldsDraw                        NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 108 normalToDecalsDraw                       NativeArray`1<float4x4> IL2CPP_TYPE_GENERICINST
    // 118 renderingLayerMasksDraw                  NativeArray`1<float> IL2CPP_TYPE_GENERICINST
    // 128 subCalls                                 NativeArray`1<DecalSubDrawCall> IL2CPP_TYPE_GENERICINST
    // 138 subCallCount                             NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class DrawCallJob : DataModel
    {
        public Vector3                                  CameraPosition                          { get; set; }
        public ulong                                    SceneCullingMask                        { get; set; }
        public int                                      CullingMask                             { get; set; }
        public int                                      VisibleDecalCount                       { get; set; }
        public float                                    MaxDrawDistance                         { get; set; }

        public static DrawCallJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawCallJob() { Pointer= p0 };

            value.CameraPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 CameraPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SceneCullingMask                          = GetUInt64(new IntPtr(p + 0x0D0)); // 0xD0 SceneCullingMask            ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CullingMask                               = GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 CullingMask                 ( ModelPrimitiveType int int int Int32 )
            value.VisibleDecalCount                         = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 VisibleDecalCount           ( ModelPrimitiveType int int int Int32 )
            value.MaxDrawDistance                           = GetSingle(new IntPtr(p + 0x0F4)); // 0xF4 MaxDrawDistance             ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
