using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vcnt                                     ModelPrimitiveType int int int Int32
    // 018 parentIndices                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 028 childMap                                 NativeParallelMultiHashMap`2<int, ushort> IL2CPP_TYPE_GENERICINST
    public partial class BaseLine_Bone_CreateBoneChildInfoJob : DataModel
    {
        public int                                      Vcnt                                    { get; set; }

        public static BaseLine_Bone_CreateBoneChildInfoJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseLine_Bone_CreateBoneChildInfoJob() { Pointer= p0 };

            value.Vcnt                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 Vcnt                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
