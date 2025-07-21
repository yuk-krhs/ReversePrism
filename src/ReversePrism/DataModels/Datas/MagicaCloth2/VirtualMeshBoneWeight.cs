using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Weights                                  ModelEnumType float4 float4 float4 Int32
    // 020 BoneIndices                              ModelEnumType int4 int4 int4 Int32
    public partial class VirtualMeshBoneWeight : DataModel
    {
        public float4                                   Weights                                 { get; set; }
        public int4                                     BoneIndices                             { get; set; }

        public static VirtualMeshBoneWeight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualMeshBoneWeight() { Pointer= p0 };

            value.Weights                                   = (float4)GetInt32(new IntPtr(p + 0x010)); // 0x10 Weights                     ( ModelEnumType float4 float4 float4 Int32 )
            value.BoneIndices                               = (int4)GetInt32(new IntPtr(p + 0x020)); // 0x20 BoneIndices                 ( ModelEnumType int4 int4 int4 Int32 )

            return value;
        }
    }
}
