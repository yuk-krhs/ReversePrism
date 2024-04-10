using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    public partial class TextStateInfo : DataModel
    {
        public Color                                    Color                                   { get; set; }

        public static TextStateInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextStateInfo() { Pointer= p0 };

            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x010)); // 02466B0A7660 0x10 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
