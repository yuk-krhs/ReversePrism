using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 024 Rotate                                   000186666050 ModelPrimitiveType float float float Single
    // 028 Edge0                                    000186666050 ModelPrimitiveType float float float Single
    // 02C Edge1                                    000186666050 ModelPrimitiveType float float float Single
    public partial class ParaffinBehaviour
    {
        public bool                                     Enable                                  { get; set; }
        public Color                                    Color                                   { get; set; }
        public float                                    Rotate                                  { get; set; }
        public float                                    Edge0                                   { get; set; }
        public float                                    Edge1                                   { get; set; }

        public static ParaffinBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParaffinBehaviour();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270D50757F8 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 0270D5075818 0x14 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Rotate                                    = GetSingle(new IntPtr(p + 0x024)); // 0270D5075838 0x24 Rotate                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Edge0                                     = GetSingle(new IntPtr(p + 0x028)); // 0270D5075858 0x28 Edge0                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Edge1                                     = GetSingle(new IntPtr(p + 0x02C)); // 0270D5075878 0x2C Edge1                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
