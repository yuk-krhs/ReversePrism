using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 ColorMode                                ModelEnumType ColorGradientMode ColorGradientMode ColorGradientMode Int32
    // 01C TopLeft                                  ModelEnumType Color Color Color Int32
    // 02C TopRight                                 ModelEnumType Color Color Color Int32
    // 03C BottomLeft                               ModelEnumType Color Color Color Int32
    // 04C BottomRight                              ModelEnumType Color Color Color Int32
    // 000 k_DefaultColorMode                       ColorGradientMode IL2CPP_TYPE_VALUETYPE
    // 000 k_DefaultColor                           Color IL2CPP_TYPE_VALUETYPE
    public partial class TextColorGradient : DataModel
    {
        public ColorGradientMode                        ColorMode                               { get; set; }
        public Color                                    TopLeft                                 { get; set; }
        public Color                                    TopRight                                { get; set; }
        public Color                                    BottomLeft                              { get; set; }
        public Color                                    BottomRight                             { get; set; }

        public static TextColorGradient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextColorGradient() { Pointer= p0 };

            value.ColorMode                                 = (ColorGradientMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 ColorMode                   ( ModelEnumType ColorGradientMode ColorGradientMode ColorGradientMode Int32 )
            value.TopLeft                                   = (Color)GetInt32(new IntPtr(p + 0x01C)); // 0x1C TopLeft                     ( ModelEnumType Color Color Color Int32 )
            value.TopRight                                  = (Color)GetInt32(new IntPtr(p + 0x02C)); // 0x2C TopRight                    ( ModelEnumType Color Color Color Int32 )
            value.BottomLeft                                = (Color)GetInt32(new IntPtr(p + 0x03C)); // 0x3C BottomLeft                  ( ModelEnumType Color Color Color Int32 )
            value.BottomRight                               = (Color)GetInt32(new IntPtr(p + 0x04C)); // 0x4C BottomRight                 ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
