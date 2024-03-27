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
    // 01C W                                        000186666050 ModelPrimitiveType float float float Single
    // 000 zero                                     float4 IL2CPP_TYPE_VALUETYPE
    public partial class float4
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Z                                       { get; set; }
        public float                                    W                                       { get; set; }

        public static float4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new float4();

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 027001596670 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 027001596690 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Z                                         = GetSingle(new IntPtr(p + 0x018)); // 0270015966B0 0x18 Z                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.W                                         = GetSingle(new IntPtr(p + 0x01C)); // 0270015966D0 0x1C W                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
