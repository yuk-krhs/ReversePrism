using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 hierarchy                                <int> IL2CPP_TYPE_I
    // 018 Index                                    ModelPrimitiveType int int int Int32
    public partial class TransformAccess : DataModel
    {
        public int                                      Index                                   { get; set; }

        public static TransformAccess? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformAccess() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
