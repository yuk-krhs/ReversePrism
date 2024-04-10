using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ColorMode                                0001865CFC80 ModelEnumType ColorMode ColorMode ColorMode Int32
    // 01C TopLeft                                  0001865AB0A0 ModelEnumType Color Color Color Int32
    // 02C TopRight                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 03C BottomLeft                               0001865AB0A0 ModelEnumType Color Color Color Int32
    // 04C BottomRight                              0001865AB0A0 ModelEnumType Color Color Color Int32
    // 000 k_DefaultColorMode                       ColorMode IL2CPP_TYPE_VALUETYPE
    // 000 k_DefaultColor                           Color IL2CPP_TYPE_VALUETYPE
    public partial class TMP_ColorGradient : DataModel
    {
        public ColorMode                                ColorMode                               { get; set; }
        public Color                                    TopLeft                                 { get; set; }
        public Color                                    TopRight                                { get; set; }
        public Color                                    BottomLeft                              { get; set; }
        public Color                                    BottomRight                             { get; set; }

        public static TMP_ColorGradient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_ColorGradient() { Pointer= p0 };

            value.ColorMode                                 = (ColorMode)GetInt32(new IntPtr(p + 0x018)); // 02466094BDB0 0x18 ColorMode                   ( 0001865CFC80 ModelEnumType ColorMode ColorMode ColorMode Int32 )
            value.TopLeft                                   = (Color)GetInt32(new IntPtr(p + 0x01C)); // 02466094BDD0 0x1C TopLeft                     ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TopRight                                  = (Color)GetInt32(new IntPtr(p + 0x02C)); // 02466094BDF0 0x2C TopRight                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomLeft                                = (Color)GetInt32(new IntPtr(p + 0x03C)); // 02466094BE10 0x3C BottomLeft                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomRight                               = (Color)GetInt32(new IntPtr(p + 0x04C)); // 02466094BE30 0x4C BottomRight                 ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
