using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        000186666050 ModelPrimitiveType float float float Single
    // 014 Y                                        000186666050 ModelPrimitiveType float float float Single
    // 018 Z                                        000186666050 ModelPrimitiveType float float float Single
    // 000 zero                                     float3 IL2CPP_TYPE_VALUETYPE
    public partial class float3
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Z                                       { get; set; }

        public static float3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float3();

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 02700158CE00 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 02700158CE20 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Z                                         = GetSingle(new IntPtr(p + 0x018)); // 02700158CE40 0x18 Z                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
