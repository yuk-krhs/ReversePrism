using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        ModelEnumType float2 float2 float2 Int32
    // 018 B                                        ModelEnumType float2 float2 float2 Int32
    // 020 Index                                    ModelPrimitiveType int int int Int32
    public partial class UEncroachingSegment : DataModel
    {
        public float2                                   A                                       { get; set; }
        public float2                                   B                                       { get; set; }
        public int                                      Index                                   { get; set; }

        public static UEncroachingSegment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UEncroachingSegment() { Pointer= p0 };

            value.A                                         = (float2)GetInt32(new IntPtr(p + 0x010)); // 0x10 A                           ( ModelEnumType float2 float2 float2 Int32 )
            value.B                                         = (float2)GetInt32(new IntPtr(p + 0x018)); // 0x18 B                           ( ModelEnumType float2 float2 float2 Int32 )
            value.Index                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Index                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
