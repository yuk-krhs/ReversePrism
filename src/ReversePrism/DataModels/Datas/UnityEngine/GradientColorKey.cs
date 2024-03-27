using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 Time                                     000186666050 ModelPrimitiveType float float float Single
    public partial class GradientColorKey
    {
        public Color                                    Color                                   { get; set; }
        public float                                    Time                                    { get; set; }

        public static GradientColorKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GradientColorKey();

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270023B3AB0 0x10 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Time                                      = GetSingle(new IntPtr(p + 0x020)); // 0270023B3AD0 0x20 Time                        ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
