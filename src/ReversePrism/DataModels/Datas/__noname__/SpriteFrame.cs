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
    // 018 W                                        000186666050 ModelPrimitiveType float float float Single
    // 01C H                                        000186666050 ModelPrimitiveType float float float Single
    public partial class SpriteFrame : DataModel
    {
        public float                                    X                                       { get; set; }
        public float                                    Y                                       { get; set; }
        public float                                    W                                       { get; set; }
        public float                                    H                                       { get; set; }

        public static SpriteFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpriteFrame() { Pointer= p0 };

            value.X                                         = GetSingle(new IntPtr(p + 0x010)); // 02466A6CB160 0x10 X                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.Y                                         = GetSingle(new IntPtr(p + 0x014)); // 02466A6CB180 0x14 Y                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.W                                         = GetSingle(new IntPtr(p + 0x018)); // 02466A6CB1A0 0x18 W                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.H                                         = GetSingle(new IntPtr(p + 0x01C)); // 02466A6CB1C0 0x1C H                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
