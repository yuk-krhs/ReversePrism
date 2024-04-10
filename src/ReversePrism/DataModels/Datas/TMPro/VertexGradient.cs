using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TopLeft                                  0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 TopRight                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 BottomLeft                               0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 BottomRight                              0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class VertexGradient : DataModel
    {
        public Color                                    TopLeft                                 { get; set; }
        public Color                                    TopRight                                { get; set; }
        public Color                                    BottomLeft                              { get; set; }
        public Color                                    BottomRight                             { get; set; }

        public static VertexGradient? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VertexGradient() { Pointer= p0 };

            value.TopLeft                                   = (Color)GetInt32(new IntPtr(p + 0x010)); // 0245A3FA56B0 0x10 TopLeft                     ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TopRight                                  = (Color)GetInt32(new IntPtr(p + 0x020)); // 0245A3FA56D0 0x20 TopRight                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomLeft                                = (Color)GetInt32(new IntPtr(p + 0x030)); // 0245A3FA56F0 0x30 BottomLeft                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BottomRight                               = (Color)GetInt32(new IntPtr(p + 0x040)); // 0245A3FA5710 0x40 BottomRight                 ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
