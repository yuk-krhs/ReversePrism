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
    public partial class Vector4
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    Z                                       { get; set; }
        public float                                    W                                       { get; set; }

        public static Vector4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector4();

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 0270044833D0 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 0270044833F0 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Z                                         = GetSingle(new IntPtr(p + 0x018)); // 027004483410 0x18 Z                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.W                                         = GetSingle(new IntPtr(p + 0x01C)); // 027004483430 0x1C W                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
