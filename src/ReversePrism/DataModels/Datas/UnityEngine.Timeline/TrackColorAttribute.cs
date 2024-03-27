using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Color                                  0001865AA8E0 ModelEnumType Color Color Color Int32
    public partial class TrackColorAttribute
    {
        public Color                                    M_Color                                 { get; set; }

        public static TrackColorAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackColorAttribute();

            value.M_Color                                   = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270DB24C328 0x10 M_Color                     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
