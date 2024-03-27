using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 R                                        000186666050 ModelPrimitiveType float float float Single
    // 014 G                                        000186666050 ModelPrimitiveType float float float Single
    // 018 B                                        000186666050 ModelPrimitiveType float float float Single
    // 01C A                                        000186666050 ModelPrimitiveType float float float Single
    public partial class Color
    {
        public float                                    R                                       { get; set; }
        public float                                    G                                       { get; set; }
        public float                                    B                                       { get; set; }
        public float                                    A                                       { get; set; }

        public static Color? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color();

            value.R                                         = GetSingle(new IntPtr(p + 0x010)); // 02700217ABD0 0x10 R                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.G                                         = GetSingle(new IntPtr(p + 0x014)); // 02700217ABF0 0x14 G                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.B                                         = GetSingle(new IntPtr(p + 0x018)); // 02700217AC10 0x18 B                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.A                                         = GetSingle(new IntPtr(p + 0x01C)); // 02700217AC30 0x1C A                           ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
