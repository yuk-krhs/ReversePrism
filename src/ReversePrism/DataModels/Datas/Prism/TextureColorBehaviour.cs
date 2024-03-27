using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Intensity                                000186666050 ModelPrimitiveType float float float Single
    // 014 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class TextureColorBehaviour
    {
        public float                                    Intensity                               { get; set; }
        public Color                                    Color                                   { get; set; }

        public static TextureColorBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureColorBehaviour();

            value.Intensity                                 = GetSingle(new IntPtr(p + 0x010)); // 0270D4E00238 0x10 Intensity                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 0270D4E00258 0x14 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
