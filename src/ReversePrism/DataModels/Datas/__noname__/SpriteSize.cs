using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 W                                        000186666050 ModelPrimitiveType float float float Single
    // 014 H                                        000186666050 ModelPrimitiveType float float float Single
    public partial class SpriteSize
    {
        public float                                    W                                       { get; set; }
        public float                                    H                                       { get; set; }

        public static SpriteSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteSize();

            value.W                                         = GetSingle(new IntPtr(p + 0x010)); // 0270DA657A98 0x10 W                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.H                                         = GetSingle(new IntPtr(p + 0x014)); // 0270DA657AB8 0x14 H                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
