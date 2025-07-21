using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CameraPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 SceneCullingMask                         ModelPrimitiveType ulong ulong ulong UInt64
    // 040 CullingMask                              ModelPrimitiveType int int int Int32
    // 048 CullingGroups                            ModelClassType CullingGroup CullingGroup CullingGroup Pointer
    // 050 VisibleDecalIndexArray                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 visibleDecalIndices                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 068 VisibleDecalCount                        ModelPrimitiveType int int int Int32
    public partial class DecalCulledChunk : DataModel
    {
        public Vector3                                  CameraPosition                          { get; set; }
        public ulong                                    SceneCullingMask                        { get; set; }
        public int                                      CullingMask                             { get; set; }
        public CullingGroup?                            CullingGroups                           { get; set; }
        public List<int>?                               VisibleDecalIndexArray                  { get; set; }
        public int                                      VisibleDecalCount                       { get; set; }

        public static DecalCulledChunk? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalCulledChunk() { Pointer= p0 };

            value.CameraPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 CameraPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SceneCullingMask                          = GetUInt64(new IntPtr(p + 0x038)); // 0x38 SceneCullingMask            ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.CullingMask                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 CullingMask                 ( ModelPrimitiveType int int int Int32 )
            value.CullingGroups                             = GetObject<CullingGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CullingGroup.FromPointer); // 0x48 CullingGroups               ( ModelClassType CullingGroup CullingGroup CullingGroup Pointer )
            value.VisibleDecalIndexArray                    = GetInt32List(new IntPtr(p + 0x050)); // 0x50 VisibleDecalIndexArray      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.VisibleDecalCount                         = GetInt32(new IntPtr(p + 0x068)); // 0x68 VisibleDecalCount           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
