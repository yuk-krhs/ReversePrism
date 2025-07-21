using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ca                                       ModelEnumType Color Color Color Int32
    // 020 Cb                                       ModelEnumType Color Color Color Int32
    public partial class Color2 : DataModel
    {
        public Color                                    Ca                                      { get; set; }
        public Color                                    Cb                                      { get; set; }

        public static Color2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Color2() { Pointer= p0 };

            value.Ca                                        = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 Ca                          ( ModelEnumType Color Color Color Int32 )
            value.Cb                                        = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 Cb                          ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
