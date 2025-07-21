using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartIndex                               ModelPrimitiveType int int int Int32
    // 014 CenterBoneWeight                         ModelEnumType BoneWeight BoneWeight BoneWeight Int32
    // 038 meshBoneWeights                          NativeArray`1<BoneWeight> IL2CPP_TYPE_GENERICINST
    // 048 mappingReferenceIndices                  NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 058 mappingAttributes                        NativeArray`1<VertexAttribute> IL2CPP_TYPE_GENERICINST
    public partial class UpdateBoneWeightJob2 : DataModel
    {
        public int                                      StartIndex                              { get; set; }
        public BoneWeight                               CenterBoneWeight                        { get; set; }

        public static UpdateBoneWeightJob2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpdateBoneWeightJob2() { Pointer= p0 };

            value.StartIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.CenterBoneWeight                          = (BoneWeight)GetInt32(new IntPtr(p + 0x014)); // 0x14 CenterBoneWeight            ( ModelEnumType BoneWeight BoneWeight BoneWeight Int32 )

            return value;
        }
    }
}
