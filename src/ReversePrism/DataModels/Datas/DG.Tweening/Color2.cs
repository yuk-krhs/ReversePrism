using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ca                                       0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 Cb                                       0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class Color2
    {
        public Color                                    Ca                                      { get; set; }
        public Color                                    Cb                                      { get; set; }

        public static Color2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color2();

            value.Ca                                        = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270DB05FB50 0x10 Ca                          ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.Cb                                        = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270DB05FB70 0x20 Cb                          ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
