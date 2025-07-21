using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Buffer                                 IntPtr IL2CPP_TYPE_PTR
    // 018 M_Index                                  ModelPrimitiveType int int int Int32
    // 01C M_BucketIndex                            ModelPrimitiveType int int int Int32
    // 020 M_NextIndex                              ModelPrimitiveType int int int Int32
    public partial class UnsafeParallelHashMapDataEnumerator : DataModel
    {
        public int                                      M_Index                                 { get; set; }
        public int                                      M_BucketIndex                           { get; set; }
        public int                                      M_NextIndex                             { get; set; }

        public static UnsafeParallelHashMapDataEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnsafeParallelHashMapDataEnumerator() { Pointer= p0 };

            value.M_Index                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Index                     ( ModelPrimitiveType int int int Int32 )
            value.M_BucketIndex                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_BucketIndex               ( ModelPrimitiveType int int int Int32 )
            value.M_NextIndex                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_NextIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
