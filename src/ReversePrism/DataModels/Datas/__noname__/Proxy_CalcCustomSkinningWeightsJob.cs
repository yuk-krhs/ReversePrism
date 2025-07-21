using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsBoneCloth                              ModelPrimitiveType bool bool bool Bool
    // 014 AngularAttenuation                       ModelPrimitiveType float float float Single
    // 018 DistanceReduction                        ModelPrimitiveType float float float Single
    // 01C DistancePow                              ModelPrimitiveType float float float Single
    // 020 attributes                               NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    // 030 localPositions                           NativeArray`1<float3> IL2CPP_TYPE_GENERICINST
    // 040 boneInfoList                             NativeList`1<SkinningBoneInfo> IL2CPP_TYPE_GENERICINST
    // 048 boneWeights                              NativeArray`1<VirtualMeshBoneWeight> IL2CPP_TYPE_GENERICINST
    public partial class Proxy_CalcCustomSkinningWeightsJob : DataModel
    {
        public bool                                     IsBoneCloth                             { get; set; }
        public float                                    AngularAttenuation                      { get; set; }
        public float                                    DistanceReduction                       { get; set; }
        public float                                    DistancePow                             { get; set; }

        public static Proxy_CalcCustomSkinningWeightsJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Proxy_CalcCustomSkinningWeightsJob() { Pointer= p0 };

            value.IsBoneCloth                               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsBoneCloth                 ( ModelPrimitiveType bool bool bool Bool )
            value.AngularAttenuation                        = GetSingle(new IntPtr(p + 0x014)); // 0x14 AngularAttenuation          ( ModelPrimitiveType float float float Single )
            value.DistanceReduction                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 DistanceReduction           ( ModelPrimitiveType float float float Single )
            value.DistancePow                               = GetSingle(new IntPtr(p + 0x01C)); // 0x1C DistancePow                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
